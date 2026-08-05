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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F33EA0", Offset = "0x1F326A0", VA = "0x181F33EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FIPPFLGIAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2830440", Offset = "0x282EC40", VA = "0x182830440")]
	public static KPFGDODNFBO<CMNBACPDIDC<M>> NADJMCFJHFO<M>(this int EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E4F0", Offset = "0x1F2CCF0", VA = "0x181F2E4F0")]
	public static KPFGDODNFBO<IKHKKPLDKDK> KOCPGOJJGAK(this int EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<IKHKKPLDKDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2830440", Offset = "0x282EC40", VA = "0x182830440")]
	public static KPFGDODNFBO<CPDDEKGJHME<M>> GBOEHICNNGF<M>(this int EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CPDDEKGJHME<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CMNBACPDIDC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IEPHOACFOMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NDLDOELFLPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class IKHKKPLDKDK
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FOLPKKPBDGL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NBMIMDJDBKJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GAKIJCNAEGM
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
public static class CKNFKOHDEPB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LLLILDKGMNP<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr LJGDFLKDFMH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
		public LLLILDKGMNP(IntPtr LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41626D0", Offset = "0x4160ED0", VA = "0x1841626D0")]
		public int EHHNDHAPNMD(TDeps DNJOEPEBEMJ, TContext MPOPMIPMGJI, TCompileState DAOECAKDOHM, [In] JADAHCHJIGA<byte> IGJMPGDNAKF, int PDAGNIIPACO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28AF610", Offset = "0x28ADE10", VA = "0x1828AF610")]
	public static void FFLNGHMDCHB<TDeps, TContext, TCompileState>(TDeps DNJOEPEBEMJ, TContext MPOPMIPMGJI, TCompileState DAOECAKDOHM, [In] JADAHCHJIGA<byte> HENJKGGJKEF, JADAHCHJIGA<byte> GKHIBBDMADM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HAAHGNHFJNK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? DAILDACOBPH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HOFLKKJFFOP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FJGCHPMBJIH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BOINCHPJDJN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GMBNPDIFEAF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? ICHIIHHLDGE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MBGKDMGGKNK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NGCBPPEGPDE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MEHECJNNKPF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JEIIIPAEBAO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GOGHGGKKGMC, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? LEHGLPLMOEP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GIINPCPJAHM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NKMFNMMOALJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NKKCMGMMGJO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BEMBKIBKLLI, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EBFJBMPNDHA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? APNJKLNCGMO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OFFMCKICKEA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JAJCKLEDHAI, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? IPIKJJFDOKE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MIOFMMOBJLJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? APBHPOAFCOH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BCKHALCFALJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BJFEFDIKGNC, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GPIDOAPJNOM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HOJDKPJDKFD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? IJNIKBHGLCN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AOCOCJFINKA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PEEHNKFCBIL, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NGLDDPECFMA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PGAIJILGCPJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PCCELKPACNG, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KOCDCEBCNPK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EBFFKGEKHBE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? CFHFDHACPBM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NOIELMPHNFN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PHPLADMCIBP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? DCEMMGJIKKM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OAGNEPGNMFF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PBMFEGNHBKB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NKAODICIGMD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JPKHCPBFJCD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NDAOHMGKHLK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JDOLBDFDMGK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FPFCNGBFAPC, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FFHFINNNJHJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KOMIKEHHIAJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? CIAPKOBMBHB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PICPFMFFENJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FHCGPJBNJGN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OKMNNDJIHIB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AIKOAHPHEEF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NBKLPHDPABH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OAOMEONPJBA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HBOBOKBELCH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KGMNFMKJOOD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AMJHHCDFKFJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KAOHHJCBOPB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MLNNKHOFJOD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? COGFEFIMAIB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? LPEFJPNIGHI, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BIBAFIKNNOI, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? CGJHAGKBNIB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KBAEAIJNHOM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? COAPAMGLACO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JCPAINLJGPB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JBBFFBDCGLJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? ABFNNALIOBD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? DDNAMAHHIPA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AJKEOODHENE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JGOAKPADICL, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OFOBCAEKFON, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? LONHIKDNGPM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OFGJJNKLOGH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OCLNLLNNNPN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? APCOAGJEEEJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NNKOLJODILA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FCGLMJIFCBF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FGDIEFACMNL, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HELPFIMEPFF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FDCIKPEFFCB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JMIMOCEIABM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HNBOLALOFCD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BEBANPMKMGL, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? NJCLAEAIDCE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KNINAHIENHH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EKDHBLPKHGH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AFMNAIAGBDE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FNOOOBJKCBI, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JBABAIIBAPN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MEPFFOEACKG, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HCDMKMOGBPN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PNCPOIBBANH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? AHBBDACFNHH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EBFKCDHALCA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KHCDJIAIILH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BNAHBFAODEJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MOHDEFCGPAE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JCCEELONHGE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JJCPHDHMNDP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? DKHECPHBOKE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HFBINOKIDLO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KGFOPEBKFML, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MBLMFNNHLOD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? OJCPDBBCAKF, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? DEAKJEOLJEJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FPBPCJDJEJP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EPHACCKJOMJ, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? BJFBKDLLCBC, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EKKPAONFPNE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? ELHIJLCFKAB, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PHNIBPCNICP, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? CPPPIBDEGEK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GPJPPODFFJE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? FEGAEGENFOH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EMJIOKIPGMK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MMADCHPFFGD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? PADHBDHPABE, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KEDIFJELCKL, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GEGANGOALCA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? HIOIJIMGEHH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GDMFINMLMOO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EAFCDIMENGO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? JJIJLODECHM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KHGEFPGDNBO, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? MCHALDAPMEK, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? ODGCONCLEOD, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GOFNOFBALAN, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GOHLOBDDONH, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? KIIEEMOOLBM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? EJPKPECDKEM, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? GIGDOMHPPEA, [Optional] LLLILDKGMNP<TContext, TDeps, TCompileState>? CHKNMADMEEM) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DDB0", Offset = "0x1F2C5B0", VA = "0x181F2DDB0")]
	private static int KFHPCFPJKKJ([In] JADAHCHJIGA<byte> KGKGNFIBJEB, JADAHCHJIGA<byte> MBIIHBIIKOG, int CKMEAPHLBGJ, int POAAACAIHKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CPIDAAAIACG
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int KEKHNPAFNMB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28B2F10", Offset = "0x28B1710", VA = "0x1828B2F10")]
	public static KPFGDODNFBO<CMNBACPDIDC<T>> JGHOMIBEFNO<T>([In] this JADAHCHJIGA<byte> EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28B2F70", Offset = "0x28B1770", VA = "0x1828B2F70")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<T>>> KOPOEJGAEMJ<T>(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CMNBACPDIDC<T>>? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E200", Offset = "0x1F2CA00", VA = "0x181F2E200")]
	public static KPFGDODNFBO<CMNBACPDIDC<LAMKMBLFJAO>> LJDLMPNIELA(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<LAMKMBLFJAO>? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<LAMKMBLFJAO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DF30", Offset = "0x1F2C730", VA = "0x181F2DF30")]
	public static KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>> CMPBNDKLAEM(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] float? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E020", Offset = "0x1F2C820", VA = "0x181F2E020")]
	public static KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>> GBHFMAEMKEN(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E3D0", Offset = "0x1F2CBD0", VA = "0x181F2E3D0")]
	public static KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>> NOHHJJHBGMC(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<IFKEIGMBLOF>? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E100", Offset = "0x1F2C900", VA = "0x181F2E100")]
	public static KPFGDODNFBO<CMNBACPDIDC<NBMIMDJDBKJ>> HHPPMNNGFCE(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] byte? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<NBMIMDJDBKJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DE50", Offset = "0x1F2C650", VA = "0x181F2DE50")]
	public static KPFGDODNFBO<CMNBACPDIDC<IKHKKPLDKDK>> AJIEHBNPBMG(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<IKHKKPLDKDK>? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IKHKKPLDKDK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2CAE0", VA = "0x181F2E2E0")]
	public static KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> MMAOJDHBNFA(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] GAKIJCNAEGM? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28B2E50", Offset = "0x28B1650", VA = "0x1828B2E50")]
	public static KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<T>>> IOOBKHJJMCO<T>(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<T>>? IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D840", Offset = "0x1F2C040", VA = "0x181F2D840")]
	public static void FFNJHKHNHBK(this JADAHCHJIGA<byte> EGJINJKGIAK, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>> NCJGJDNJBMM, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28B2E40", Offset = "0x28B1640", VA = "0x1828B2E40")]
	public static void CLHEMOCIFNC<T>(this JADAHCHJIGA<byte> EGJINJKGIAK, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<T>>> PDAGNIIPACO, KPFGDODNFBO<CMNBACPDIDC<T>> IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28B2E40", Offset = "0x28B1640", VA = "0x1828B2E40")]
	public static void NJJCMMDOPHM<T>(this JADAHCHJIGA<byte> EGJINJKGIAK, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<T>>> DJKDHHDGIJK, KPFGDODNFBO<CPDDEKGJHME<T>> IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ALIPBHEOBEF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D9E0", Offset = "0x1F2C1E0", VA = "0x181F2D9E0")]
	public static AFFMEBCPHON DLMLJFHHJPO([In] this ReadOnlySpan<byte> GHFEJDPMJDG, int DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D940", Offset = "0x1F2C140", VA = "0x181F2D940")]
	public static AFFMEBCPHON DLMLJFHHJPO([In] this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x314C6F0", Offset = "0x314AEF0", VA = "0x18314C6F0")]
	public static AFFMEBCPHON DLMLJFHHJPO<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x314C840", Offset = "0x314B040", VA = "0x18314C840")]
	public static AFFMEBCPHON DLMLJFHHJPO<M>([In] this OAMAGIMFLCD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x314C380", Offset = "0x314AB80", VA = "0x18314C380")]
	public static AFFMEBCPHON DLMLJFHHJPO<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x314C4C0", Offset = "0x314ACC0", VA = "0x18314C4C0")]
	public static AFFMEBCPHON DLMLJFHHJPO<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x314C9A0", Offset = "0x314B1A0", VA = "0x18314C9A0")]
	public static AFFMEBCPHON DLMLJFHHJPO<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D9E0", Offset = "0x1F2C1E0", VA = "0x181F2D9E0")]
	public static int EMKIANBHDGP([In] this ReadOnlySpan<byte> GHFEJDPMJDG, int DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D830", Offset = "0x1F2C030", VA = "0x181F2D830")]
	public static int EMKIANBHDGP([In] this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static int EMKIANBHDGP<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static int EMKIANBHDGP<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static int EMKIANBHDGP<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static int EMKIANBHDGP<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x314CAD0", Offset = "0x314B2D0", VA = "0x18314CAD0")]
	public static float LLIGPGDLMNK<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x314CAD0", Offset = "0x314B2D0", VA = "0x18314CAD0")]
	public static float LLIGPGDLMNK<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x314CAD0", Offset = "0x314B2D0", VA = "0x18314CAD0")]
	public static float LLIGPGDLMNK<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x314C350", Offset = "0x314AB50", VA = "0x18314C350")]
	public static byte BMFPLGBHMAM<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x314C4A0", Offset = "0x314ACA0", VA = "0x18314C4A0")]
	public static byte BMFPLGBHMAM<M>([In] this OAMAGIMFLCD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x314C380", Offset = "0x314AB80", VA = "0x18314C380")]
	public static byte BMFPLGBHMAM<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x314C4C0", Offset = "0x314ACC0", VA = "0x18314C4C0")]
	public static byte BMFPLGBHMAM<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x314C3E0", Offset = "0x314ABE0", VA = "0x18314C3E0")]
	public static byte BMFPLGBHMAM<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D830", Offset = "0x1F2C030", VA = "0x181F2D830")]
	public static GAKIJCNAEGM EDOAIDLDIPG([In] this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE)
	{
		return default(GAKIJCNAEGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static GAKIJCNAEGM EDOAIDLDIPG<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(GAKIJCNAEGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x314CC60", Offset = "0x314B460", VA = "0x18314CC60")]
	public static KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> PMHEAOBFHGN<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x314CBF0", Offset = "0x314B3F0", VA = "0x18314CBF0")]
	public static KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> PMHEAOBFHGN<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x314CCD0", Offset = "0x314B4D0", VA = "0x18314CCD0")]
	public static KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> PMHEAOBFHGN<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x314CA60", Offset = "0x314B260", VA = "0x18314CA60")]
	public static KPFGDODNFBO<CPDDEKGJHME<IPLNPIMDNNN>> HKKFKNICPNO<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<CPDDEKGJHME<IPLNPIMDNNN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x314C680", Offset = "0x314AE80", VA = "0x18314C680")]
	public static KPFGDODNFBO<IKHKKPLDKDK> DKDKBKAEMMC<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<IKHKKPLDKDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x314C5A0", Offset = "0x314ADA0", VA = "0x18314C5A0")]
	public static KPFGDODNFBO<IKHKKPLDKDK> DKDKBKAEMMC<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<IKHKKPLDKDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x314C610", Offset = "0x314AE10", VA = "0x18314C610")]
	public static KPFGDODNFBO<IKHKKPLDKDK> DKDKBKAEMMC<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<IKHKKPLDKDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x314CB80", Offset = "0x314B380", VA = "0x18314CB80")]
	public static KPFGDODNFBO<LAMKMBLFJAO> MCIDODPNIGN<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<LAMKMBLFJAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x314CB10", Offset = "0x314B310", VA = "0x18314CB10")]
	public static KPFGDODNFBO<LAMKMBLFJAO> MCIDODPNIGN<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<LAMKMBLFJAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x314C530", Offset = "0x314AD30", VA = "0x18314C530")]
	public static KPFGDODNFBO<IFKEIGMBLOF> BPLCBCMKAOM<M>(this DLDHEKEFPNA<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE)
	{
		return default(KPFGDODNFBO<IFKEIGMBLOF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CAEKEIGGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DCF0", Offset = "0x1F2C4F0", VA = "0x181F2DCF0")]
	public static void PJHPJKAKDBA(this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE, AFFMEBCPHON IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DC80", Offset = "0x1F2C480", VA = "0x181F2DC80")]
	public static void PJHPJKAKDBA(this byte[] GHFEJDPMJDG, int DPKBONFELAE, AFFMEBCPHON IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DC00", Offset = "0x1F2C400", VA = "0x181F2DC00")]
	public static void PJHPJKAKDBA([In] this Span<byte> GHFEJDPMJDG, int DPKBONFELAE, AFFMEBCPHON IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x289A2E0", Offset = "0x2898AE0", VA = "0x18289A2E0")]
	public static void PJHPJKAKDBA<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, AFFMEBCPHON IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x289A140", Offset = "0x2898940", VA = "0x18289A140")]
	public static void PJHPJKAKDBA<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, AFFMEBCPHON IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D840", Offset = "0x1F2C040", VA = "0x181F2D840")]
	public static void FFNJHKHNHBK(this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DA50", Offset = "0x1F2C250", VA = "0x181F2DA50")]
	public static void FFNJHKHNHBK(this byte[] GHFEJDPMJDG, int DPKBONFELAE, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DAD0", Offset = "0x1F2C2D0", VA = "0x181F2DAD0")]
	public static void FFNJHKHNHBK([In] this Span<byte> GHFEJDPMJDG, int DPKBONFELAE, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2899F20", Offset = "0x2898720", VA = "0x182899F20")]
	public static void FFNJHKHNHBK<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2899F80", Offset = "0x2898780", VA = "0x182899F80")]
	public static void FFNJHKHNHBK<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DBC0", Offset = "0x1F2C3C0", VA = "0x181F2DBC0")]
	public static void KJLNPLIMIAJ(this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE, float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x289A080", Offset = "0x2898880", VA = "0x18289A080")]
	public static void KJLNPLIMIAJ<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x289A0E0", Offset = "0x28988E0", VA = "0x18289A0E0")]
	public static void KJLNPLIMIAJ<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DB50", Offset = "0x1F2C350", VA = "0x181F2DB50")]
	public static void FNPEJIMCKDF(this JADAHCHJIGA<byte> GHFEJDPMJDG, int DPKBONFELAE, byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x289A030", Offset = "0x2898830", VA = "0x18289A030")]
	public static void FNPEJIMCKDF<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2899FE0", Offset = "0x28987E0", VA = "0x182899FE0")]
	public static void FNPEJIMCKDF<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28311B0", Offset = "0x282F9B0", VA = "0x1828311B0")]
	public static void CLHEMOCIFNC<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28311B0", Offset = "0x282F9B0", VA = "0x1828311B0")]
	public static void CLHEMOCIFNC<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28311B0", Offset = "0x282F9B0", VA = "0x1828311B0")]
	public static void ENLBJOIBNPD<M>(this CCPKKOHIOOB<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, KPFGDODNFBO<IKHKKPLDKDK> IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28311B0", Offset = "0x282F9B0", VA = "0x1828311B0")]
	public static void ENLBJOIBNPD<M>([In] this IPJLFCGKLDD<M, byte> GHFEJDPMJDG, KPFGDODNFBO<M> DPKBONFELAE, KPFGDODNFBO<IKHKKPLDKDK> IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JIGPABNPJEE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F860", Offset = "0x1F2E060", VA = "0x181F2F860")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) EKPCEDIEENA(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F30F40", Offset = "0x1F2F740", VA = "0x181F30F40")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) IFJEOCIIBGE(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1F2FC60", Offset = "0x1F2E460", VA = "0x181F2FC60")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) FBEJOMPEEHO(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1F33950", Offset = "0x1F32150", VA = "0x181F33950")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) PBAJNPAMMJN(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F323B0", Offset = "0x1F30BB0", VA = "0x181F323B0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) KOHOMDODBNP(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F30BE0", Offset = "0x1F2F3E0", VA = "0x181F30BE0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) HOJPAMKJLMP(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F9E0", Offset = "0x1F2E1E0", VA = "0x181F2F9E0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) ENAJOHJOIMI(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F2EA90", Offset = "0x1F2D290", VA = "0x181F2EA90")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BCKAIKLMDNL(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F2EE50", Offset = "0x1F2D650", VA = "0x181F2EE50")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BNHPDOOKDFO(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F30600", Offset = "0x1F2EE00", VA = "0x181F30600")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>) HABKDAEBIDM(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? IPHHABIKCHD, [Optional] KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? KOGACMEMKFC)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F311B0", Offset = "0x1F2F9B0", VA = "0x181F311B0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>) IJNIBKMMDBH(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? IPHHABIKCHD, [Optional] KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? KOGACMEMKFC)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F32000", Offset = "0x1F30800", VA = "0x181F32000")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>) KEHGECEKFFI(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? IPHHABIKCHD, [Optional] KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? KOGACMEMKFC)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F32110", Offset = "0x1F30910", VA = "0x181F32110")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>) KIHFLLBEMKK(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? IPHHABIKCHD, [Optional] KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? KOGACMEMKFC)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F32D40", Offset = "0x1F31540", VA = "0x181F32D40")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<LAMKMBLFJAO>>) NANOIINGBOC(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? PLPIDPCGJDE, [Optional] KPFGDODNFBO<LAMKMBLFJAO>? CPDLACEKNJL)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<LAMKMBLFJAO>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2FED0", Offset = "0x1F2E6D0", VA = "0x181F2FED0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<LAMKMBLFJAO>>>) FKKPLMDFBKD(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? PLPIDPCGJDE, [Optional] KPFGDODNFBO<CPDDEKGJHME<LAMKMBLFJAO>>? CPDLACEKNJL)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<LAMKMBLFJAO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F31E60", Offset = "0x1F30660", VA = "0x181F31E60")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<IKHKKPLDKDK>>) KBOBDFAGOPA(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? PLPIDPCGJDE, [Optional] KPFGDODNFBO<IKHKKPLDKDK>? CPDLACEKNJL)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<IKHKKPLDKDK>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F303E0", Offset = "0x1F2EBE0", VA = "0x181F303E0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IKHKKPLDKDK>>>) GNFJCIBBGEI(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? PLPIDPCGJDE, [Optional] KPFGDODNFBO<CPDDEKGJHME<IKHKKPLDKDK>>? CPDLACEKNJL)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IKHKKPLDKDK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2AE94F0", Offset = "0x2AE7CF0", VA = "0x182AE94F0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>) NEBMNMGKFNI<TMarker>(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<IFKEIGMBLOF>? CPDLACEKNJL, [Optional][In] ReadOnlySpan<byte> MLKNGAFFKGE)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F33000", Offset = "0x1F31800", VA = "0x181F33000")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) NKDCOHMECEJ(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGKGNFIBJEB, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? MBIIHBIIKOG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F30AD0", Offset = "0x1F2F2D0", VA = "0x181F30AD0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) HKHBGFKJPLF(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGKGNFIBJEB, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? MBIIHBIIKOG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2AE96F0", Offset = "0x2AE7EF0", VA = "0x182AE96F0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>) NNGCOJKHAGO<TMarker>(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<TMarker>>? MBIIHBIIKOG, [Optional] int? GGKCGCGFHKJ, [Optional][In] ReadOnlySpan<byte> KGKGNFIBJEB)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2AE93A0", Offset = "0x2AE7BA0", VA = "0x182AE93A0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>) KMPPPKKJHAA<TMarker>(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<TMarker>>? KGKGNFIBJEB, [Optional] KPFGDODNFBO<CPDDEKGJHME<TMarker>>? MBIIHBIIKOG, [Optional] int? GGKCGCGFHKJ)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<TMarker>>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F30950", Offset = "0x1F2F150", VA = "0x181F30950")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) HHGHHPHHIJE(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F2FD80", Offset = "0x1F2E580", VA = "0x181F2FD80")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) FCPOPLAKNLN(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F30D00", Offset = "0x1F2F500", VA = "0x181F30D00")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) HPFKBDMNNCM(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F327D0", Offset = "0x1F30FD0", VA = "0x181F327D0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) LJFGMBKGPCE(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F2ED00", Offset = "0x1F2D500", VA = "0x181F2ED00")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BMPFKCBANKJ(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1F312D0", Offset = "0x1F2FAD0", VA = "0x181F312D0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) IMLJMMIEOEN(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E680", Offset = "0x1F2CE80", VA = "0x181F2E680")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) AMOPFAPFDHE(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F2FFE0", Offset = "0x1F2E7E0", VA = "0x181F2FFE0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) FPODHDMPLFE(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F333F0", Offset = "0x1F31BF0", VA = "0x181F333F0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) OHEMJALFGLF(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F260", Offset = "0x1F2DA60", VA = "0x181F2F260")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>) DPDOEAPCJLN(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? IJFLIPAHDAF)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E910", Offset = "0x1F2D110", VA = "0x181F2E910")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BCEIMGFDAOM(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F30130", Offset = "0x1F2E930", VA = "0x181F30130")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) GIIIAJFMAHA(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1F31570", Offset = "0x1F2FD70", VA = "0x181F31570")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JELHAEIDDHL(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1F33290", Offset = "0x1F31A90", VA = "0x181F33290")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) OEPMPKAAKCA(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F33AB0", Offset = "0x1F322B0", VA = "0x181F33AB0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) PFBAJCJAFJO(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F30710", Offset = "0x1F2EF10", VA = "0x181F30710")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) HBAPABDGIAH(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F313F0", Offset = "0x1F2FBF0", VA = "0x181F313F0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) IONLFBHNEEH(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F33670", Offset = "0x1F31E70", VA = "0x181F33670")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) OKFIOONNODI(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E7E0", Offset = "0x1F2CFE0", VA = "0x181F2E7E0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BCBAGEIIMOF(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F31D00", Offset = "0x1F30500", VA = "0x181F31D00")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JPHOJONMJPF(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F31BB0", Offset = "0x1F303B0", VA = "0x181F31BB0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JPBIDNDKGIP(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F30E20", Offset = "0x1F2F620", VA = "0x181F30E20")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) IBGMELLKPEJ(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F337D0", Offset = "0x1F31FD0", VA = "0x181F337D0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) OLOMGCCCHAC(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F32930", Offset = "0x1F31130", VA = "0x181F32930")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) MALMHOIAHAB(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F31A80", Offset = "0x1F30280", VA = "0x181F31A80")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JOILLFFEGEP(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F460", Offset = "0x1F2DC60", VA = "0x181F2F460")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) EFCMBFIICKO(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F5C0", Offset = "0x1F2DDC0", VA = "0x181F2F5C0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) EJDAFGPPBGI(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F30830", Offset = "0x1F2F030", VA = "0x181F30830")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) HFAGKFEMGFN(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F32230", Offset = "0x1F30A30", VA = "0x181F32230")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) KMNFPBNLHKH(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F32A90", Offset = "0x1F31290", VA = "0x181F32A90")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) MANNKJKECGJ(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F31800", Offset = "0x1F30000", VA = "0x181F31800")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JLKOGAHIIKF(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F33130", Offset = "0x1F31930", VA = "0x181F33130")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) ODEPGCHPBIP(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F710", Offset = "0x1F2DF10", VA = "0x181F2F710")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) EKKPGCENEJE(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F2EF70", Offset = "0x1F2D770", VA = "0x181F2EF70")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) CBHPEFJOGLD(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1F33D20", Offset = "0x1F32520", VA = "0x181F33D20")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) POELIIBCCBM(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1F32500", Offset = "0x1F30D00", VA = "0x181F32500")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) LAGMOCAHLCN(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F32EE0", Offset = "0x1F316E0", VA = "0x181F32EE0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) NAOABOPAIBG(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E520", Offset = "0x1F2CD20", VA = "0x181F2E520")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) ADAFLABODLO(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F110", Offset = "0x1F2D910", VA = "0x181F2F110")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) DDGGBFELDLK(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F2EBE0", Offset = "0x1F2D3E0", VA = "0x181F2EBE0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) BMPDDFNBKOA(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F350", Offset = "0x1F2DB50", VA = "0x181F2F350")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) EEAPMACNKDK(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] int? KIKBENIKJJF, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1F304F0", Offset = "0x1F2ECF0", VA = "0x181F304F0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) GNIKLLHDMIA(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KIKBENIKJJF, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F090", Offset = "0x1F2D890", VA = "0x181F2F090")]
	public static KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> CKLMKKBMJEJ(this JADAHCHJIGA<byte> EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F32650", Offset = "0x1F30E50", VA = "0x181F32650")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) LGFBGKCDELO(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F30290", Offset = "0x1F2EA90", VA = "0x181F30290")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) GJHNMLBJMKN(this JADAHCHJIGA<byte> EGJINJKGIAK, float KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IEPHOACFOMF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F31090", Offset = "0x1F2F890", VA = "0x181F31090")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>) IIIBOPPLGKP(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<IEPHOACFOMF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IEPHOACFOMF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F316A0", Offset = "0x1F2FEA0", VA = "0x181F316A0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JJBIJOICKNM(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F32BF0", Offset = "0x1F313F0", VA = "0x181F32BF0")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) NADCCKECKEO(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F2FB40", Offset = "0x1F2E340", VA = "0x181F2FB40")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) EOIFFNDKOJF(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F33510", Offset = "0x1F31D10", VA = "0x181F33510")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) OHMBDODFIPI(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F31930", Offset = "0x1F30130", VA = "0x181F31930")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) JNLCBPKDMKN(this JADAHCHJIGA<byte> EGJINJKGIAK, int KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F33C00", Offset = "0x1F32400", VA = "0x181F33C00")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>) PIAOCCMGFAB(this JADAHCHJIGA<byte> EGJINJKGIAK, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? KGMLOMMNCLH, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? AFJBDIDNCMM, [Optional] KPFGDODNFBO<CPDDEKGJHME<NDLDOELFLPF>>? OONIGNAAHFG)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<NDLDOELFLPF>>>));
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
