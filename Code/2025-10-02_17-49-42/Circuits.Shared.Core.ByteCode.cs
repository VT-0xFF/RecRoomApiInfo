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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B4C750", Offset = "0x2B4B150", VA = "0x182B4C750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BKPGNFNLMJP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32D3210", Offset = "0x32D1C10", VA = "0x1832D3210")]
	public static HOHDPLDONAJ<OHDHECABCNC<M>> GPFDFCOGEDB<M>(this int DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BCA0", Offset = "0x2B4A6A0", VA = "0x182B4BCA0")]
	public static HOHDPLDONAJ<EAOCDNABPDC> HCJEOPHFOCA(this int DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<EAOCDNABPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32D3210", Offset = "0x32D1C10", VA = "0x1832D3210")]
	public static HOHDPLDONAJ<HINCLKNGOJL<M>> GDLEKBPFIPM<M>(this int DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<HINCLKNGOJL<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OHDHECABCNC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CGFMOCFEGGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FKCNILDEBHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EAOCDNABPDC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LLCGKPILIDN
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JLLKOFCDMGK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum EPHOCGOAHBL
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
public static class OIJLDNFPINO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct JAAEAOIAEHA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr OKDHLAPLDHP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
		public JAAEAOIAEHA(IntPtr FDMAPEJEBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55219A0", Offset = "0x55203A0", VA = "0x1855219A0")]
		public int KDMGDDCNHFD(TDeps KPEJCAGFLDG, TContext GFENHEKLPCC, TCompileState LDIENBHCMIP, [In] DBIBICKBIIJ<byte> ALKNPHLKEIJ, int KBIFHFKADKF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B810", Offset = "0x3F4A210", VA = "0x183F4B810")]
	public static void MBDHAGKNBBI<TDeps, TContext, TCompileState>(TDeps KPEJCAGFLDG, TContext GFENHEKLPCC, TCompileState LDIENBHCMIP, [In] DBIBICKBIIJ<byte> CBOGHEIIFMH, DBIBICKBIIJ<byte> LFDPNFNOACP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? AJJOLOMEOCH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JNBBCKFDMIM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KJHLCBFLNPA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EEKGALMGHJJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LEFEBKPHDAA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JBJHMGBCDOB, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DMFHONCODAK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KJHFDGKAEGG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? NCJEMAGKKDB, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JHDNCMGHBNJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KKAIHJNDNML, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PMKLBKBOBKA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IDMHLHLAFJD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IOLJKCLPDJJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? AJPHINIGMKK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EJJGPBPHHGF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MFKOIGNLOPL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CALMLDDHBDB, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? GDMFCBPOABJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KDLHJGFLNMD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LPIAJCEMMNJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OGJLCOMLJJD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LJEIBDJELBN, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EOHFHCLGILC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DEKCIIGFLJB, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? BJHGMABMLII, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KCENKFKOHAP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EKODCIJLEIK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FCBGGIKKHJE, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KCIHBEFNAKH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DANBGIPBPOK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? GMFLFMDLNLF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KBGCMIBJNBE, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JDCICENACBG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JHLEFGIPBPM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OBLACKEDKPC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ODBMHNIIBNK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DILEACPIFHC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? NLBDNHHJAFP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? GIMAMCOLBAA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MAMLELGOLMA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? NEKAMHPBALC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KFABCEHEOKC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OKDIIFAKKFH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JFEBNIFLHGL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KAFCJNFDIBA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FCMEMBMNAAA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EGPMAHLDJCK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PIBCDKJIGEE, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FNPGBPLGECJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FKBGINGKBMO, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KHNJDEHEFEC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LAMEAGBEDDC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CJBPMAPIJIO, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DNLFNMFLALK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ALHJAEJBMLG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MJJFEDLGKAH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DIOEIPNAGPF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DKIHECKMFOO, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JIDOPHMAGOF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PMDKKCFABLC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DOBINBBJLPP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? HEFDDMNFABH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MPJNEKEBOPI, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LFBIBAIJNBH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JGNAKFEMEIJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IAPMMHJJOLJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ABMOOCEMCOK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DDEHNMEPAJA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CKDCMMCEMAE, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IAPLMNIOPJO, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? BJFDKADNKOM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IIOGHHCCLKP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? AKNDLBDFKFM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? NPCPKFHJOMP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CPFNCCALCCP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OBJDCIEJKKF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PKNJBLLNNJL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JLMOKJGIDFM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KMAKMNAEEJG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? AKBFLNMPNJM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ONOFHOEEIBL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? HFHODGAFBJD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CMHMNENFEPG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CAGGBCIKINA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PFPMEDKMANK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OCCLPNNLHAO, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? GBEEJPHHOMJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FKENINOIELH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? AGACIJGMNNF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EOLPCAGFHNK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KBLDJLNEIDN, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JMKFENJGHML, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? BMCFHJIKGLM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CGHODJGNMJI, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ADAFGFMJKOP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IEDJPLIOJBG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MHCNCJLKDJN, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LGFFKBDDCDL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LCLFBPGPNHD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JNMHLEOHOOL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LDEOHDCDDIG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FMIDEKNGPNH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IJNLKPPHKEI, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? ICLFGAGCLAA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? HADJICIAOFD, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PDKCONOONGP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? GHKJCLKJCKL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MEIEKAAKCCJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EAHJJMCPKLG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JJJAKMFMNDA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FENGKPMCGOI, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IICJJHDALCB, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FKAKJKKJKOG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? FIMGAKFONBP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DMFHBEHNBBP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? OFLHAINGHNJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JPPNIHPKCBL, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EFPMHJNEEAK, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IEOHHJJOCAH, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? LCCDKJAKJLE, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JOMGAINLIIJ, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? CEAFDMDAFID, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? EAOBGJAIBIP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IPDBMPHJFCN, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? KCDIKJLENIM, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PPPIHPHNIKC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DOCPAHEBFBA, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? BOLJGJFMPPC, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? DCGNMFIOHMP, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? PBIGNLPKDLF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? IFIPNDABJGF, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MDBCFCGNLOG, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? MAOJBANJEDI, [Optional] JAAEAOIAEHA<TContext, TDeps, TCompileState>? JJPJPAJLHMJ) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C7D0", Offset = "0x2B4B1D0", VA = "0x182B4C7D0")]
	private static int MMBEHAGOEKG([In] DBIBICKBIIJ<byte> EILINOAEIMG, DBIBICKBIIJ<byte> KAHHEMPAJEL, int NPCHJIPLCII, int MHMCOJIKNCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEAPOKCAEEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int OMEIFBOJFIB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D630", Offset = "0x3E6C030", VA = "0x183E6D630")]
	public static HOHDPLDONAJ<OHDHECABCNC<T>> DCBDHCCFOIJ<T>([In] this DBIBICKBIIJ<byte> DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D680", Offset = "0x3E6C080", VA = "0x183E6D680")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<T>>> LGCGALNPIAP<T>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<OHDHECABCNC<T>>? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C010", Offset = "0x2B4AA10", VA = "0x182B4C010")]
	public static HOHDPLDONAJ<OHDHECABCNC<EIMNPDILGCO>> OAGHCCIGOFB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<EIMNPDILGCO>? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<EIMNPDILGCO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BF40", Offset = "0x2B4A940", VA = "0x182B4BF40")]
	public static HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>> MNCIDBNOPCP(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] float? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BCD0", Offset = "0x2B4A6D0", VA = "0x182B4BCD0")]
	public static HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>> CLFOHFHLBKJ(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BDA0", Offset = "0x2B4A7A0", VA = "0x182B4BDA0")]
	public static HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>> GGGMAPBGNCO(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<BKCLJJAMDCD>? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C1B0", Offset = "0x2B4ABB0", VA = "0x182B4C1B0")]
	public static HOHDPLDONAJ<OHDHECABCNC<JLLKOFCDMGK>> PKLJEGOIGJO(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] byte? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<JLLKOFCDMGK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C0E0", Offset = "0x2B4AAE0", VA = "0x182B4C0E0")]
	public static HOHDPLDONAJ<OHDHECABCNC<EAOCDNABPDC>> OPJHFCEPHAD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<EAOCDNABPDC>? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<EAOCDNABPDC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BE70", Offset = "0x2B4A870", VA = "0x182B4BE70")]
	public static HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> LNIACDDGIHA(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] EPHOCGOAHBL? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D730", Offset = "0x3E6C130", VA = "0x183E6D730")]
	public static HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<T>>> LNJGLAACFOD<T>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<T>>? KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BBB0", Offset = "0x2B4A5B0", VA = "0x182B4BBB0")]
	public static void IOKMGNIPBEF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>> DMPFNADELGD, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D620", Offset = "0x3E6C020", VA = "0x183E6D620")]
	public static void HEIDJCIJPDM<T>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<T>>> KBIFHFKADKF, HOHDPLDONAJ<OHDHECABCNC<T>> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D620", Offset = "0x3E6C020", VA = "0x183E6D620")]
	public static void ANJNOFKFLFN<T>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<T>>> AMFCBHKNAIM, HOHDPLDONAJ<HINCLKNGOJL<T>> KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MGAKEMCIKJE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C640", Offset = "0x2B4B040", VA = "0x182B4C640")]
	public static OMBMBLOABPD AFLGGNJFFNC([In] this ReadOnlySpan<byte> BNICMFHPCJC, int MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C6B0", Offset = "0x2B4B0B0", VA = "0x182B4C6B0")]
	public static OMBMBLOABPD AFLGGNJFFNC([In] this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C040", Offset = "0x3E9AA40", VA = "0x183E9C040")]
	public static OMBMBLOABPD AFLGGNJFFNC<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BF30", Offset = "0x3E9A930", VA = "0x183E9BF30")]
	public static OMBMBLOABPD AFLGGNJFFNC<M>([In] this MGCIDHDNFIK<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C1A0", Offset = "0x3E9ABA0", VA = "0x183E9C1A0")]
	public static OMBMBLOABPD AFLGGNJFFNC<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C140", Offset = "0x3E9AB40", VA = "0x183E9C140")]
	public static OMBMBLOABPD AFLGGNJFFNC<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BEC0", Offset = "0x3E9A8C0", VA = "0x183E9BEC0")]
	public static OMBMBLOABPD AFLGGNJFFNC<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C640", Offset = "0x2B4B040", VA = "0x182B4C640")]
	public static int PGOJNKAKBNI([In] this ReadOnlySpan<byte> BNICMFHPCJC, int MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BC90", Offset = "0x2B4A690", VA = "0x182B4BC90")]
	public static int PGOJNKAKBNI([In] this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32D3200", Offset = "0x32D1C00", VA = "0x1832D3200")]
	public static int PGOJNKAKBNI<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32D3200", Offset = "0x32D1C00", VA = "0x1832D3200")]
	public static int PGOJNKAKBNI<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32D3200", Offset = "0x32D1C00", VA = "0x1832D3200")]
	public static int PGOJNKAKBNI<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32D3200", Offset = "0x32D1C00", VA = "0x1832D3200")]
	public static int PGOJNKAKBNI<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C3D0", Offset = "0x3E9ADD0", VA = "0x183E9C3D0")]
	public static float NECFILLPPID<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C3D0", Offset = "0x3E9ADD0", VA = "0x183E9C3D0")]
	public static float NECFILLPPID<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C3D0", Offset = "0x3E9ADD0", VA = "0x183E9C3D0")]
	public static float NECFILLPPID<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C1F0", Offset = "0x3E9ABF0", VA = "0x183E9C1F0")]
	public static byte DOOAMJJJHDD<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C290", Offset = "0x3E9AC90", VA = "0x183E9C290")]
	public static byte DOOAMJJJHDD<M>([In] this MGCIDHDNFIK<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C1A0", Offset = "0x3E9ABA0", VA = "0x183E9C1A0")]
	public static byte DOOAMJJJHDD<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C140", Offset = "0x3E9AB40", VA = "0x183E9C140")]
	public static byte DOOAMJJJHDD<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C220", Offset = "0x3E9AC20", VA = "0x183E9C220")]
	public static byte DOOAMJJJHDD<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BC90", Offset = "0x2B4A690", VA = "0x182B4BC90")]
	public static EPHOCGOAHBL MCHMCAEEHLE([In] this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL)
	{
		return default(EPHOCGOAHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x32D3200", Offset = "0x32D1C00", VA = "0x1832D3200")]
	public static EPHOCGOAHBL MCHMCAEEHLE<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(EPHOCGOAHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C570", Offset = "0x3E9AF70", VA = "0x183E9C570")]
	public static HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> PGKFHJBJOOI<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C510", Offset = "0x3E9AF10", VA = "0x183E9C510")]
	public static HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> PGKFHJBJOOI<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C5D0", Offset = "0x3E9AFD0", VA = "0x183E9C5D0")]
	public static HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> PGKFHJBJOOI<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C370", Offset = "0x3E9AD70", VA = "0x183E9C370")]
	public static HOHDPLDONAJ<HINCLKNGOJL<EBPBDIDCDHC>> JMLBJHPHEJB<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<HINCLKNGOJL<EBPBDIDCDHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C4B0", Offset = "0x3E9AEB0", VA = "0x183E9C4B0")]
	public static HOHDPLDONAJ<EAOCDNABPDC> OIDGOAHGBGB<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<EAOCDNABPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C450", Offset = "0x3E9AE50", VA = "0x183E9C450")]
	public static HOHDPLDONAJ<EAOCDNABPDC> OIDGOAHGBGB<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<EAOCDNABPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C3F0", Offset = "0x3E9ADF0", VA = "0x183E9C3F0")]
	public static HOHDPLDONAJ<EAOCDNABPDC> OIDGOAHGBGB<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<EAOCDNABPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C2B0", Offset = "0x3E9ACB0", VA = "0x183E9C2B0")]
	public static HOHDPLDONAJ<EIMNPDILGCO> JLOBEMIODGE<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<EIMNPDILGCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C310", Offset = "0x3E9AD10", VA = "0x183E9C310")]
	public static HOHDPLDONAJ<EIMNPDILGCO> JLOBEMIODGE<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<EIMNPDILGCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BE60", Offset = "0x3E9A860", VA = "0x183E9BE60")]
	public static HOHDPLDONAJ<BKCLJJAMDCD> AEIGMLOMINI<M>(this KGNGOLAIAHD<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL)
	{
		return default(HOHDPLDONAJ<BKCLJJAMDCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MCNNAPAKHGM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C2E0", Offset = "0x2B4ACE0", VA = "0x182B4C2E0")]
	public static void HDIDLFKPJPH(this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL, OMBMBLOABPD KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C420", Offset = "0x2B4AE20", VA = "0x182B4C420")]
	public static void HDIDLFKPJPH(this byte[] BNICMFHPCJC, int MDKBLKNBANL, OMBMBLOABPD KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C3A0", Offset = "0x2B4ADA0", VA = "0x182B4C3A0")]
	public static void HDIDLFKPJPH([In] this Span<byte> BNICMFHPCJC, int MDKBLKNBANL, OMBMBLOABPD KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E95180", Offset = "0x3E93B80", VA = "0x183E95180")]
	public static void HDIDLFKPJPH<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, OMBMBLOABPD KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E95090", Offset = "0x3E93A90", VA = "0x183E95090")]
	public static void HDIDLFKPJPH<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, OMBMBLOABPD KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BBB0", Offset = "0x2B4A5B0", VA = "0x182B4BBB0")]
	public static void IOKMGNIPBEF(this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C510", Offset = "0x2B4AF10", VA = "0x182B4C510")]
	public static void IOKMGNIPBEF(this byte[] BNICMFHPCJC, int MDKBLKNBANL, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C490", Offset = "0x2B4AE90", VA = "0x182B4C490")]
	public static void IOKMGNIPBEF([In] this Span<byte> BNICMFHPCJC, int MDKBLKNBANL, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E952C0", Offset = "0x3E93CC0", VA = "0x183E952C0")]
	public static void IOKMGNIPBEF<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E95270", Offset = "0x3E93C70", VA = "0x183E95270")]
	public static void IOKMGNIPBEF<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C600", Offset = "0x2B4B000", VA = "0x182B4C600")]
	public static void PMMJCHCIEOH(this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E95360", Offset = "0x3E93D60", VA = "0x183E95360")]
	public static void PMMJCHCIEOH<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E953B0", Offset = "0x3E93DB0", VA = "0x183E953B0")]
	public static void PMMJCHCIEOH<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C590", Offset = "0x2B4AF90", VA = "0x182B4C590")]
	public static void OBHHCHNLDCC(this DBIBICKBIIJ<byte> BNICMFHPCJC, int MDKBLKNBANL, byte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E95310", Offset = "0x3E93D10", VA = "0x183E95310")]
	public static void OBHHCHNLDCC<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, byte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E95340", Offset = "0x3E93D40", VA = "0x183E95340")]
	public static void OBHHCHNLDCC<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, byte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32D2A00", Offset = "0x32D1400", VA = "0x1832D2A00")]
	public static void HEIDJCIJPDM<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32D2A00", Offset = "0x32D1400", VA = "0x1832D2A00")]
	public static void HEIDJCIJPDM<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32D2A00", Offset = "0x32D1400", VA = "0x1832D2A00")]
	public static void FPAMKHBIPOP<M>(this BBGMECFCALI<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, HOHDPLDONAJ<EAOCDNABPDC> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32D2A00", Offset = "0x32D1400", VA = "0x1832D2A00")]
	public static void FPAMKHBIPOP<M>([In] this HCFGMOHCBNM<M, byte> BNICMFHPCJC, HOHDPLDONAJ<M> MDKBLKNBANL, HOHDPLDONAJ<EAOCDNABPDC> KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OIKHJNCOOAK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F300", Offset = "0x2B4DD00", VA = "0x182B4F300")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) EPIPKBFFGKO(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B520A0", Offset = "0x2B50AA0", VA = "0x182B520A0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) PHLFAECNOKL(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B504A0", Offset = "0x2B4EEA0", VA = "0x182B504A0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) JBBAEJJBPDJ(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B501F0", Offset = "0x2B4EBF0", VA = "0x182B501F0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) IPDMBOMHPLF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B517D0", Offset = "0x2B501D0", VA = "0x182B517D0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) NLAPPEDBPKC(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D370", Offset = "0x2B4BD70", VA = "0x182B4D370")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BOMOMAJNJNI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FC70", Offset = "0x2B4E670", VA = "0x182B4FC70")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) HFPAAALEODF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CD60", Offset = "0x2B4B760", VA = "0x182B4CD60")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BABJKKGDJIC(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E900", Offset = "0x2B4D300", VA = "0x182B4E900")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DJIPDFFJCAF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FB60", Offset = "0x2B4E560", VA = "0x182B4FB60")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>) GPEOKOKIPFL(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? KMAFNKGMDCF, [Optional] HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? ELNINCKCOEA)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DC80", Offset = "0x2B4C680", VA = "0x182B4DC80")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>) CPFBPICKPFP(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? KMAFNKGMDCF, [Optional] HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? ELNINCKCOEA)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DF00", Offset = "0x2B4C900", VA = "0x182B4DF00")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>) DBFNLIKFGPN(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? KMAFNKGMDCF, [Optional] HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? ELNINCKCOEA)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B51400", Offset = "0x2B4FE00", VA = "0x182B51400")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>) MPMLLPEOGBC(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? KMAFNKGMDCF, [Optional] HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? ELNINCKCOEA)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B50C80", Offset = "0x2B4F680", VA = "0x182B50C80")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<EIMNPDILGCO>>) LCPNBADLPNI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? MNLDLLIFPFD, [Optional] HOHDPLDONAJ<EIMNPDILGCO>? DHFPPCMKNFO)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<EIMNPDILGCO>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B50B70", Offset = "0x2B4F570", VA = "0x182B50B70")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EIMNPDILGCO>>>) LCMICFAMOKH(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? MNLDLLIFPFD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<EIMNPDILGCO>>? DHFPPCMKNFO)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EIMNPDILGCO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D5E0", Offset = "0x2B4BFE0", VA = "0x182B4D5E0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<EAOCDNABPDC>>) CFPLCHMAMHM(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? MNLDLLIFPFD, [Optional] HOHDPLDONAJ<EAOCDNABPDC>? DHFPPCMKNFO)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<EAOCDNABPDC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F5E0", Offset = "0x2B4DFE0", VA = "0x182B4F5E0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EAOCDNABPDC>>>) FLBLHNFAAEJ(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? MNLDLLIFPFD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<EAOCDNABPDC>>? DHFPPCMKNFO)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EAOCDNABPDC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3F4DBC0", Offset = "0x3F4C5C0", VA = "0x183F4DBC0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>) LHLKBPEPFBK<TMarker>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<BKCLJJAMDCD>? DHFPPCMKNFO, [Optional][In] ReadOnlySpan<byte> BLPDDGCLNPE)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D8D0", Offset = "0x2B4C2D0", VA = "0x182B4D8D0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) CLABIIPLEIA(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int EILINOAEIMG, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? KAHHEMPAJEL)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D140", Offset = "0x2B4BB40", VA = "0x182B4D140")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BMKDEMLKKAB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? EILINOAEIMG, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? KAHHEMPAJEL)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3F4D8C0", Offset = "0x3F4C2C0", VA = "0x183F4D8C0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>) DICKAIDCFLH<TMarker>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<TMarker>>? KAHHEMPAJEL, [Optional] int? BCAJFCGHDKI, [Optional][In] ReadOnlySpan<byte> EILINOAEIMG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3F4DAA0", Offset = "0x3F4C4A0", VA = "0x183F4DAA0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>) HLNNAFOEIBK<TMarker>(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<TMarker>>? EILINOAEIMG, [Optional] HOHDPLDONAJ<HINCLKNGOJL<TMarker>>? KAHHEMPAJEL, [Optional] int? BCAJFCGHDKI)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<TMarker>>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B51920", Offset = "0x2B50320", VA = "0x182B51920")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) NNIDMPKCHAI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B51AA0", Offset = "0x2B504A0", VA = "0x182B51AA0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) OACPGMBAPLI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B51BF0", Offset = "0x2B505F0", VA = "0x182B51BF0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) OGNOFKMELJD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B51D10", Offset = "0x2B50710", VA = "0x182B51D10")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) OJNOCNOPNJH(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DB30", Offset = "0x2B4C530", VA = "0x182B4DB30")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) COBNPBNKECC(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B511C0", Offset = "0x2B4FBC0", VA = "0x182B511C0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) MABPFBGNCDF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FF30", Offset = "0x2B4E930", VA = "0x182B4FF30")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) HIDDDNOKPMF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E570", Offset = "0x2B4CF70", VA = "0x182B4E570")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DGMCNFAIFLK(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B50F80", Offset = "0x2B4F980", VA = "0x182B50F80")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) LFMJDNJJMAD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F210", Offset = "0x2B4DC10", VA = "0x182B4F210")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>) EPHLHCHFHOF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? AALPIGGPGBL)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EDC0", Offset = "0x2B4D7C0", VA = "0x182B4EDC0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) EEAIACDODEM(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B50E20", Offset = "0x2B4F820", VA = "0x182B50E20")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) LDCKGPMPCGP(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E7D0", Offset = "0x2B4D1D0", VA = "0x182B4E7D0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DIIGNDDIKOG(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E010", Offset = "0x2B4CA10", VA = "0x182B4E010")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DCHEFMIHKDJ(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D780", Offset = "0x2B4C180", VA = "0x182B4D780")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) CGGDABKNCHD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EA20", Offset = "0x2B4D420", VA = "0x182B4EA20")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DNCMFNHGMEF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EF40", Offset = "0x2B4D940", VA = "0x182B4EF40")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) EGLFANEHHFI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2B50090", Offset = "0x2B4EA90", VA = "0x182B50090")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) IOIDDADJBHG(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E170", Offset = "0x2B4CB70", VA = "0x182B4E170")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DECBHJIGECE(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FDD0", Offset = "0x2B4E7D0", VA = "0x182B4FDD0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) HGINLAMIIOI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B50350", Offset = "0x2B4ED50", VA = "0x182B50350")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) IPHMGENMMIC(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D250", Offset = "0x2B4BC50", VA = "0x182B4D250")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BNHPJDMADCO(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B509F0", Offset = "0x2B4F3F0", VA = "0x182B509F0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) KOHMOEMOMPB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CFE0", Offset = "0x2B4B9E0", VA = "0x182B4CFE0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BJHDBODEJJG(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CEB0", Offset = "0x2B4B8B0", VA = "0x182B4CEB0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) BDFDGIDKKDD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B50740", Offset = "0x2B4F140", VA = "0x182B50740")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) KHAFACCIGPP(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E420", Offset = "0x2B4CE20", VA = "0x182B4E420")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DFDEMNLPIME(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CC40", Offset = "0x2B4B640", VA = "0x182B4CC40")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) ANIELJECACD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E2A0", Offset = "0x2B4CCA0", VA = "0x182B4E2A0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DELKIILHAPK(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C870", Offset = "0x2B4B270", VA = "0x182B4C870")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) AKGCFEHKJIN(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DA00", Offset = "0x2B4C400", VA = "0x182B4DA00")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) CLLEIIGBEIF(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DDA0", Offset = "0x2B4C7A0", VA = "0x182B4DDA0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) CPOMOAMHILB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F0C0", Offset = "0x2B4DAC0", VA = "0x182B4F0C0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) EICFLGBAEML(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B51F80", Offset = "0x2B50980", VA = "0x182B51F80")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) PDNBCEFGOBK(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F6F0", Offset = "0x2B4E0F0", VA = "0x182B4F6F0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) FNIMLNLMFNI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B508A0", Offset = "0x2B4F2A0", VA = "0x182B508A0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) KMPOALFHFFG(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CB20", Offset = "0x2B4B520", VA = "0x182B4CB20")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) AMMGNLMPIAA(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B51670", Offset = "0x2B50070", VA = "0x182B51670")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) NKKMCFMFKNJ(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B51520", Offset = "0x2B4FF20", VA = "0x182B51520")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) NFEOKLCIBPD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B510A0", Offset = "0x2B4FAA0", VA = "0x182B510A0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) LPLFMFAFOAO(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B51E70", Offset = "0x2B50870", VA = "0x182B51E70")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) PDADNFHMMEE(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] int? DGCOLEFNGKD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E6C0", Offset = "0x2B4D0C0", VA = "0x182B4E6C0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DHKFHKMPEEG(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? DGCOLEFNGKD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F870", Offset = "0x2B4E270", VA = "0x182B4F870")]
	public static HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> GCHAIJFKDFK(this DBIBICKBIIJ<byte> DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B505C0", Offset = "0x2B4EFC0", VA = "0x182B505C0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) JBMFEJJFBIN(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FA10", Offset = "0x2B4E410", VA = "0x182B4FA10")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) GLMEPPCLBAB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, float FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<CGFMOCFEGGM>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F8F0", Offset = "0x2B4E2F0", VA = "0x182B4F8F0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>) GEMGCLPBGCE(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<CGFMOCFEGGM>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<CGFMOCFEGGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EC60", Offset = "0x2B4D660", VA = "0x182B4EC60")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) ECMPOJHJOJA(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C9D0", Offset = "0x2B4B3D0", VA = "0x182B4C9D0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) AKNCHOFMMIL(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EB40", Offset = "0x2B4D540", VA = "0x182B4EB40")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) DNKHPFCAIBK(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F480", Offset = "0x2B4DE80", VA = "0x182B4F480")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) FABCCMKJCPD(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D490", Offset = "0x2B4BE90", VA = "0x182B4D490")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) CENACFBGLEI(this DBIBICKBIIJ<byte> DKGBCFDLMOI, int FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B512E0", Offset = "0x2B4FCE0", VA = "0x182B512E0")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>) MCMIKAPMKHB(this DBIBICKBIIJ<byte> DKGBCFDLMOI, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? FGHDIGDIKHD, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? GGJNNAMGOLA, [Optional] HOHDPLDONAJ<HINCLKNGOJL<FKCNILDEBHK>>? HKPHLMNNEOG)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<FKCNILDEBHK>>>));
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
