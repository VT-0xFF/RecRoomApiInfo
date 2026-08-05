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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x2640850", Offset = "0x263FC50", VA = "0x182640850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EEHFAEAFHKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3439390", Offset = "0x3438790", VA = "0x183439390")]
	public static EECNAGIPCBM<AMGCLMOKHAB<M>> HGHMHNHBOLM<M>(this int CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2640710", Offset = "0x263FB10", VA = "0x182640710")]
	public static EECNAGIPCBM<FGGDFLMIIJC> CNFAGPCJBKJ(this int CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<FGGDFLMIIJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3439390", Offset = "0x3438790", VA = "0x183439390")]
	public static EECNAGIPCBM<GBMPBPGOJIG<M>> OLGCCHGCMON<M>(this int CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<GBMPBPGOJIG<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class AMGCLMOKHAB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HFGFLGOEJKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class OKPGGGJOGGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FGGDFLMIIJC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KNAAHPPNIJP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KFOCNHGKHLB
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JECAKLAACII
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
public static class ACAEFCMPIAG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IBOGBDGGNLA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr JHKDEKNHDAJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
		public IBOGBDGGNLA(IntPtr KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x49ACE90", Offset = "0x49AC290", VA = "0x1849ACE90")]
		public int BHNBAFNFKNN(TDeps EIHGNKDHDGF, TContext BGMFHIEECKK, TCompileState LDEPDFMJLLO, [In] EPPNKNJKIOI<byte> IOIFOMCJIME, int BCDCNENCNNI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D57240", Offset = "0x3D56640", VA = "0x183D57240")]
	public static void AJMMCAEKCLM<TDeps, TContext, TCompileState>(TDeps EIHGNKDHDGF, TContext BGMFHIEECKK, TCompileState LDEPDFMJLLO, [In] EPPNKNJKIOI<byte> OMGNAHHMJKB, EPPNKNJKIOI<byte> NNICNBBAJGJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KJMMCLHGAMC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BPCIPFPECOI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? EFPKHDDDCBG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? LGNGMNPKDGN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BKOHNGKJKNF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MDDNDPNFCFF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? OGPKEJDJEDD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IGHFDEIIHAO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AAAMPPHEJPH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GGGMIODMHPO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NLOHBKLGNOH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AEIDPEIGLAN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MBAELFDHIFI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IEDPJBKAEFA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GMKJIIIFKDG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MJHBDMPMHJD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? OFHMDIPFEDD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FAMNLAMCIIM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? PDPIPIAJGCL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AMIFHPEMOME, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MBCLENKOFLJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CMHMKLEIIIJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NHKOPMKJMLF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DAOGNICMKEA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MLINEPDBFOD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IANOECCOIIP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IMNFAMHEHKG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AOPBHGAFHKN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GNGLBFGIKHF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BKDBAAOCCBD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DNHMLLAGMOB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DGIFGOHEFMC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CNNCBANJDJB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? LBCGHPNKGKK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CGHFBIDLEBC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BIEPJOBPDFG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CMLNMIBNGJA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? OCNGJCEDOKO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DFNDIPOGHNG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MOACLADMMLN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BBDEKAMHGIK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FBFHAGPDHEB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? PPHEILDDFNL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HCKFCFJCCLK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? OFLELNAGNDO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KLFAEJFCDAB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AJFHLOADBCH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NAEDJHLCPOI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IAAKNFKMBPE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AEDGBMMOBEB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GNLBOJABCHI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CDJLINLJOMG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HLBEBJLLGNG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? APMECCGCCGC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JHOCDPEPKKK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MIIBNIAKLIO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HOIMEPMDKPE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DAJHHOPPAMP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JPEJGIBBIKD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? LDJDCDGFNKK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MJEMMIFLNOD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KMCJHKJFABB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KOCAGFCMJNH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? ICOAGEJOBPA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BOLOCDEPKHK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KEHMFMMPKKL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GHKNLDADLMG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JKPFCAGHGOI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CCEHFDMPPGP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? PLPFFGHGENM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AGNDGBBMGJN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CEPBDICALNO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JJMLDMOHOEA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HCKHAPKNLHB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BKMGLPKDLBE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MIDMDBHMHDE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JJLMCBOMHJA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DGPEABBNEDO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HHKGAKDCOPL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GEOFHCJICCP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IAELFGCPCPO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KAOLFLHAMGM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FGJKFAHGBDJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HNCPAOMCFNF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? PDBOMNODJLJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AAIAOBCKPFM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IBFLJHKIIJM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CHADNINCMFJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GEAFAGJOKID, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JCHLHELILLJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FMJNPLIDBCM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NJCEFPPDLKO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? LAHMLIIPCGH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HMOOAAIKBHF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MHOAGPEKALL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FELCGAJLAII, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NNCBJLECOHN, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BBKONJLIPMM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KCLINBFCFHL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? ACDBEHEGJNA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DJCIMIEKMPB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FMOCNEDPLEM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? PJCLKJCEIOD, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DHHHKKEIMKC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DBFNMLGNAOB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? LBDNLBFJLMI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BFGEDKPIFEO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? IFGOLGGHHFO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KCFIAMEBEAE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? BFHHBIIOIFM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NFNCIBFLHND, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? HIAPICCPLBL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? DLAFGHLPKDP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KBNAGNBOEPJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FIMNGIFCBDG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NJJMLJIJLBJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JPEGDLOGCDF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? EKGOEKJHIKI, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CGNBFMADIIJ, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? MJFBEMKBHKF, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CBKHLEOONOH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AEJKCPDGBOO, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? GBHHGOBJANC, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? ADCBCIBMJMG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CADNMNIPPJP, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? ELABFPNBFNH, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FGGCGIOKBJB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? JNIDJLLHLMM, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FPJNEGIFJBG, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? FOGNBOHFNNE, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? EBIGCECKGEB, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? AANPODOBGOK, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? KCALIEFNCAA, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? NADMHGPMBIL, [Optional] IBOGBDGGNLA<TContext, TDeps, TCompileState>? CBANIIBLDKN) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2640310", Offset = "0x263F710", VA = "0x182640310")]
	private static int CJMOAJFFEJE([In] EPPNKNJKIOI<byte> PBMDLFOECGG, EPPNKNJKIOI<byte> JAPINDHIFOD, int LLNIGMDIFON, int PPLOBPJCNII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OJEEDPBKOHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int EAJKNHABNNC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37CFCB0", Offset = "0x37CF0B0", VA = "0x1837CFCB0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<T>> BPHKHGMOHDK<T>([In] this EPPNKNJKIOI<byte> CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37CFDE0", Offset = "0x37CF1E0", VA = "0x1837CFDE0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<T>>> PBOENEKMICN<T>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<T>>? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2640E50", Offset = "0x2640250", VA = "0x182640E50")]
	public static EECNAGIPCBM<AMGCLMOKHAB<CIPOGONPJJK>> NNFPLKNBJIB(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<CIPOGONPJJK>? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<CIPOGONPJJK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2640D60", Offset = "0x2640160", VA = "0x182640D60")]
	public static EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>> MGKFAKNKDDD(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] float? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2640B90", Offset = "0x263FF90", VA = "0x182640B90")]
	public static EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>> LCJIGGOIMHH(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26409D0", Offset = "0x263FDD0", VA = "0x1826409D0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>> HHKKCCAMLDG(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<JFJBMCNMGML>? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26408D0", Offset = "0x263FCD0", VA = "0x1826408D0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<KFOCNHGKHLB>> CIMKJOPANEB(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] byte? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<KFOCNHGKHLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2640AB0", Offset = "0x263FEB0", VA = "0x182640AB0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<FGGDFLMIIJC>> IHKFECDPCEE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<FGGDFLMIIJC>? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<FGGDFLMIIJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2640C70", Offset = "0x2640070", VA = "0x182640C70")]
	public static EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> MBJDJBGBKOK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] JECAKLAACII? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37CFD20", Offset = "0x37CF120", VA = "0x1837CFD20")]
	public static EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<T>>> LMNGOKCHNNF<T>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<T>>? FIIKLGCIAGG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2640220", Offset = "0x263F620", VA = "0x182640220")]
	public static void IOGOCOAIADF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>> NLHAAKDEFGN, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37CFD10", Offset = "0x37CF110", VA = "0x1837CFD10")]
	public static void FPGNAGHHIOE<T>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<T>>> BCDCNENCNNI, EECNAGIPCBM<AMGCLMOKHAB<T>> FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37CFD10", Offset = "0x37CF110", VA = "0x1837CFD10")]
	public static void EOMAPDMOBIO<T>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<T>>> MKIAINOCIBA, EECNAGIPCBM<GBMPBPGOJIG<T>> FIIKLGCIAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HNNJGNEFEJI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2640740", Offset = "0x263FB40", VA = "0x182640740")]
	public static IOFJIGKIBJE MGOIMPDCNBJ([In] this ReadOnlySpan<byte> FIKLNMFCLIL, int ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26407B0", Offset = "0x263FBB0", VA = "0x1826407B0")]
	public static IOFJIGKIBJE MGOIMPDCNBJ([In] this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x363F1D0", Offset = "0x363E5D0", VA = "0x18363F1D0")]
	public static IOFJIGKIBJE MGOIMPDCNBJ<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x363EF40", Offset = "0x363E340", VA = "0x18363EF40")]
	public static IOFJIGKIBJE MGOIMPDCNBJ<M>([In] this BMJCAJHJMGB<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x363EEE0", Offset = "0x363E2E0", VA = "0x18363EEE0")]
	public static IOFJIGKIBJE MGOIMPDCNBJ<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x363F0A0", Offset = "0x363E4A0", VA = "0x18363F0A0")]
	public static IOFJIGKIBJE MGOIMPDCNBJ<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x363F110", Offset = "0x363E510", VA = "0x18363F110")]
	public static IOFJIGKIBJE MGOIMPDCNBJ<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2640740", Offset = "0x263FB40", VA = "0x182640740")]
	public static int GKIKIFHIDOG([In] this ReadOnlySpan<byte> FIKLNMFCLIL, int ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2640260", Offset = "0x263F660", VA = "0x182640260")]
	public static int GKIKIFHIDOG([In] this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35BDA40", Offset = "0x35BCE40", VA = "0x1835BDA40")]
	public static int GKIKIFHIDOG<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35BDA40", Offset = "0x35BCE40", VA = "0x1835BDA40")]
	public static int GKIKIFHIDOG<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35BDA40", Offset = "0x35BCE40", VA = "0x1835BDA40")]
	public static int GKIKIFHIDOG<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35BDA40", Offset = "0x35BCE40", VA = "0x1835BDA40")]
	public static int GKIKIFHIDOG<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x363EB90", Offset = "0x363DF90", VA = "0x18363EB90")]
	public static float EKCEIJLIBGK<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x363EB90", Offset = "0x363DF90", VA = "0x18363EB90")]
	public static float EKCEIJLIBGK<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x363EB90", Offset = "0x363DF90", VA = "0x18363EB90")]
	public static float EKCEIJLIBGK<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x363F3E0", Offset = "0x363E7E0", VA = "0x18363F3E0")]
	public static byte OFMHHJLAJOG<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x363F410", Offset = "0x363E810", VA = "0x18363F410")]
	public static byte OFMHHJLAJOG<M>([In] this BMJCAJHJMGB<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x363EEE0", Offset = "0x363E2E0", VA = "0x18363EEE0")]
	public static byte OFMHHJLAJOG<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x363F0A0", Offset = "0x363E4A0", VA = "0x18363F0A0")]
	public static byte OFMHHJLAJOG<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x363F320", Offset = "0x363E720", VA = "0x18363F320")]
	public static byte OFMHHJLAJOG<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2640260", Offset = "0x263F660", VA = "0x182640260")]
	public static JECAKLAACII AFLPMDOCJME([In] this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII)
	{
		return default(JECAKLAACII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35BDA40", Offset = "0x35BCE40", VA = "0x1835BDA40")]
	public static JECAKLAACII AFLPMDOCJME<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(JECAKLAACII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x363EBD0", Offset = "0x363DFD0", VA = "0x18363EBD0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EOKFGGOCDBC<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x363ECB0", Offset = "0x363E0B0", VA = "0x18363ECB0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EOKFGGOCDBC<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x363EC40", Offset = "0x363E040", VA = "0x18363EC40")]
	public static EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> EOKFGGOCDBC<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x363F430", Offset = "0x363E830", VA = "0x18363F430")]
	public static EECNAGIPCBM<GBMPBPGOJIG<AIBFMNHAJPD>> OKICLJPJGND<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<GBMPBPGOJIG<AIBFMNHAJPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x363ED20", Offset = "0x363E120", VA = "0x18363ED20")]
	public static EECNAGIPCBM<FGGDFLMIIJC> FEOLNIAOFPI<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<FGGDFLMIIJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x363ED90", Offset = "0x363E190", VA = "0x18363ED90")]
	public static EECNAGIPCBM<FGGDFLMIIJC> FEOLNIAOFPI<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<FGGDFLMIIJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x363EE00", Offset = "0x363E200", VA = "0x18363EE00")]
	public static EECNAGIPCBM<FGGDFLMIIJC> FEOLNIAOFPI<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<FGGDFLMIIJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x363EAB0", Offset = "0x363DEB0", VA = "0x18363EAB0")]
	public static EECNAGIPCBM<CIPOGONPJJK> BMLLNJHNFAL<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<CIPOGONPJJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x363EB20", Offset = "0x363DF20", VA = "0x18363EB20")]
	public static EECNAGIPCBM<CIPOGONPJJK> BMLLNJHNFAL<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<CIPOGONPJJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x363EE70", Offset = "0x363E270", VA = "0x18363EE70")]
	public static EECNAGIPCBM<JFJBMCNMGML> KBFBDMCABLK<M>(this ICNPICGMOCM<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII)
	{
		return default(EECNAGIPCBM<JFJBMCNMGML>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DAIJAHCGCFK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2640420", Offset = "0x263F820", VA = "0x182640420")]
	public static void HPOJFDCODFE(this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII, IOFJIGKIBJE FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2640560", Offset = "0x263F960", VA = "0x182640560")]
	public static void HPOJFDCODFE(this byte[] FIKLNMFCLIL, int ENIHAJKAFII, IOFJIGKIBJE FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26404E0", Offset = "0x263F8E0", VA = "0x1826404E0")]
	public static void HPOJFDCODFE([In] this Span<byte> FIKLNMFCLIL, int ENIHAJKAFII, IOFJIGKIBJE FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3401580", Offset = "0x3400980", VA = "0x183401580")]
	public static void HPOJFDCODFE<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, IOFJIGKIBJE FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34013E0", Offset = "0x34007E0", VA = "0x1834013E0")]
	public static void HPOJFDCODFE<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, IOFJIGKIBJE FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2640220", Offset = "0x263F620", VA = "0x182640220")]
	public static void IOGOCOAIADF(this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2640650", Offset = "0x263FA50", VA = "0x182640650")]
	public static void IOGOCOAIADF(this byte[] FIKLNMFCLIL, int ENIHAJKAFII, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26405D0", Offset = "0x263F9D0", VA = "0x1826405D0")]
	public static void IOGOCOAIADF([In] this Span<byte> FIKLNMFCLIL, int ENIHAJKAFII, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3401780", Offset = "0x3400B80", VA = "0x183401780")]
	public static void IOGOCOAIADF<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3401720", Offset = "0x3400B20", VA = "0x183401720")]
	public static void IOGOCOAIADF<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26406D0", Offset = "0x263FAD0", VA = "0x1826406D0")]
	public static void OBPAMJJHHMG(this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII, float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3401840", Offset = "0x3400C40", VA = "0x183401840")]
	public static void OBPAMJJHHMG<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34017E0", Offset = "0x3400BE0", VA = "0x1834017E0")]
	public static void OBPAMJJHHMG<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x26403B0", Offset = "0x263F7B0", VA = "0x1826403B0")]
	public static void ABONNJDGOGK(this EPPNKNJKIOI<byte> FIKLNMFCLIL, int ENIHAJKAFII, byte FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3401360", Offset = "0x3400760", VA = "0x183401360")]
	public static void ABONNJDGOGK<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, byte FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3401310", Offset = "0x3400710", VA = "0x183401310")]
	public static void ABONNJDGOGK<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, byte FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x34013B0", Offset = "0x34007B0", VA = "0x1834013B0")]
	public static void FPGNAGHHIOE<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34013B0", Offset = "0x34007B0", VA = "0x1834013B0")]
	public static void FPGNAGHHIOE<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, EECNAGIPCBM<AMGCLMOKHAB<AIBFMNHAJPD>> FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34013B0", Offset = "0x34007B0", VA = "0x1834013B0")]
	public static void MMEGFOAJCJI<M>(this FENCAGBAMDI<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, EECNAGIPCBM<FGGDFLMIIJC> FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34013B0", Offset = "0x34007B0", VA = "0x1834013B0")]
	public static void MMEGFOAJCJI<M>([In] this DPABJAJNCGF<M, byte> FIKLNMFCLIL, EECNAGIPCBM<M> ENIHAJKAFII, EECNAGIPCBM<FGGDFLMIIJC> FIIKLGCIAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ONJKCGCNAME
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26435C0", Offset = "0x26429C0", VA = "0x1826435C0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) HEFIKAKPGEP(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2641440", Offset = "0x2640840", VA = "0x182641440")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) BBCDKDJNBLC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26439E0", Offset = "0x2642DE0", VA = "0x1826439E0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) ICACOOJOKOK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2643DA0", Offset = "0x26431A0", VA = "0x182643DA0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) JGKIJHGIMEK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2644F40", Offset = "0x2644340", VA = "0x182644F40")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) MGNNNKALCHL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26467D0", Offset = "0x2645BD0", VA = "0x1826467D0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PPCMKCJLKBL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2646140", Offset = "0x2645540", VA = "0x182646140")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PFNKPDMOIML(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2642FC0", Offset = "0x26423C0", VA = "0x182642FC0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) GDMIPBGDDGK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2643200", Offset = "0x2642600", VA = "0x182643200")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) GGGNBMIAJEK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2641330", Offset = "0x2640730", VA = "0x182641330")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>) AOKLBDCMHDD(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? FIIKLGCIAGG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? GMHFLHLMAEL)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26434A0", Offset = "0x26428A0", VA = "0x1826434A0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>) HCBBKPBLJHN(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? FIIKLGCIAGG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? GMHFLHLMAEL)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26451B0", Offset = "0x26445B0", VA = "0x1826451B0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>) MIPCFIMFDLL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? FIIKLGCIAGG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? GMHFLHLMAEL)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26466B0", Offset = "0x2645AB0", VA = "0x1826466B0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>) POJCHMLEDCA(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? FIIKLGCIAGG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? GMHFLHLMAEL)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2642B40", Offset = "0x2641F40", VA = "0x182642B40")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<CIPOGONPJJK>>) FEICNHJPFAK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? PNFNAPKJEBG, [Optional] EECNAGIPCBM<CIPOGONPJJK>? HGCIPPLBBMM)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<CIPOGONPJJK>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2641E10", Offset = "0x2641210", VA = "0x182641E10")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<CIPOGONPJJK>>>) COKOOBOKGOG(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? PNFNAPKJEBG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<CIPOGONPJJK>>? HGCIPPLBBMM)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<CIPOGONPJJK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2642080", Offset = "0x2641480", VA = "0x182642080")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<FGGDFLMIIJC>>) DJAJHKCJBJO(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? PNFNAPKJEBG, [Optional] EECNAGIPCBM<FGGDFLMIIJC>? HGCIPPLBBMM)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<FGGDFLMIIJC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2641950", Offset = "0x2640D50", VA = "0x182641950")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<FGGDFLMIIJC>>>) BJFDLMKNPFA(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? PNFNAPKJEBG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<FGGDFLMIIJC>>? HGCIPPLBBMM)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<FGGDFLMIIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37D3480", Offset = "0x37D2880", VA = "0x1837D3480")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>) GLKFDFBJGHL<TMarker>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<JFJBMCNMGML>? HGCIPPLBBMM, [Optional][In] ReadOnlySpan<byte> AMHCLKHIFKH)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<JFJBMCNMGML>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2641CE0", Offset = "0x26410E0", VA = "0x182641CE0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) CKCPICFECKC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int PBMDLFOECGG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? JAPINDHIFOD)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2644650", Offset = "0x2643A50", VA = "0x182644650")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) KKGIGKNGLNO(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? PBMDLFOECGG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? JAPINDHIFOD)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37D37D0", Offset = "0x37D2BD0", VA = "0x1837D37D0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>) ODHHKGOAJID<TMarker>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<TMarker>>? JAPINDHIFOD, [Optional] int? EOKAMHLPIFK, [Optional][In] ReadOnlySpan<byte> PBMDLFOECGG)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37D3680", Offset = "0x37D2A80", VA = "0x1837D3680")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>) IOCGOEBKCHH<TMarker>(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<TMarker>>? PBMDLFOECGG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<TMarker>>? JAPINDHIFOD, [Optional] int? EOKAMHLPIFK)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<TMarker>>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2646400", Offset = "0x2645800", VA = "0x182646400")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) PKHPCGOPJFN(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2645760", Offset = "0x2644B60", VA = "0x182645760")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) OFDNAAJFPGJ(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2644290", Offset = "0x2643690", VA = "0x182644290")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) KEBHOLHLLHG(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2642CE0", Offset = "0x26420E0", VA = "0x182642CE0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) FHNFLJBCJOC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2643B00", Offset = "0x2642F00", VA = "0x182643B00")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) IIADKFCPACC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26448B0", Offset = "0x2643CB0", VA = "0x1826448B0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) LDMMAHGHOGG(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26454A0", Offset = "0x26448A0", VA = "0x1826454A0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) NDOBNNAIFLC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2644DF0", Offset = "0x26441F0", VA = "0x182644DF0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) MFOIKPBHDIP(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2645A10", Offset = "0x2644E10", VA = "0x182645A10")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) OGIFHENLJIL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2643110", Offset = "0x2642510", VA = "0x182643110")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>) GECLHDOOIBP(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>? DLJECCOKOKJ)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<AMGCLMOKHAB<KNAAHPPNIJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2642220", Offset = "0x2641620", VA = "0x182642220")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) EAHAHNAOFFK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2644B30", Offset = "0x2643F30", VA = "0x182644B30")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) LLFMEPEELDC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26424C0", Offset = "0x26418C0", VA = "0x1826424C0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) EDAPAMLABLJ(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26449D0", Offset = "0x2643DD0", VA = "0x1826449D0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) LEAILCBBHAC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641C90", VA = "0x182642890")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) EJKKJGAELGE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26423A0", Offset = "0x26417A0", VA = "0x1826423A0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) ECCCNMIPFHC(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2642E40", Offset = "0x2642240", VA = "0x182642E40")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) FIJCOIADIME(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2645600", Offset = "0x2644A00", VA = "0x182645600")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) NKKFOIGKCNK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2645EF0", Offset = "0x26452F0", VA = "0x182645EF0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PALGIBNIJMJ(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26462A0", Offset = "0x26456A0", VA = "0x1826462A0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PHDAKOAEJDF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26410C0", Offset = "0x26404C0", VA = "0x1826410C0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) AJLGBFILHKB(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2642770", Offset = "0x2641B70", VA = "0x182642770")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) EHECCPKOPIE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2643320", Offset = "0x2642720", VA = "0x182643320")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) GGKCJHHLGBK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26417F0", Offset = "0x2640BF0", VA = "0x1826417F0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) BIJCKJMNGIE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2644010", Offset = "0x2643410", VA = "0x182644010")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) JJNDIENKGCA(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2641A60", Offset = "0x2640E60", VA = "0x182641A60")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) CFPPGKNAGLP(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2644760", Offset = "0x2643B60", VA = "0x182644760")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) LCCGMPOLNHF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2645DD0", Offset = "0x26451D0", VA = "0x182645DD0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) ONMCKFGFKPK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26444D0", Offset = "0x26438D0", VA = "0x1826444D0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) KINPDGEOFNF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26429E0", Offset = "0x2641DE0", VA = "0x1826429E0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) EPECCLCKBNF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2646580", Offset = "0x2645980", VA = "0x182646580")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PMALKGBAELJ(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26458B0", Offset = "0x2644CB0", VA = "0x1826458B0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) OGBIJCINMKD(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2643740", Offset = "0x2642B40", VA = "0x182643740")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) HGLBAOMDMBA(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2646020", Offset = "0x2645420", VA = "0x182646020")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) PCOLOFAOMBM(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26425F0", Offset = "0x26419F0", VA = "0x1826425F0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) EHCDFHOHEPN(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2640F70", Offset = "0x2640370", VA = "0x182640F70")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) AEKOJPMCKNM(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2641210", Offset = "0x2640610", VA = "0x182641210")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) ANIGOJIFGCE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2645340", Offset = "0x2644740", VA = "0x182645340")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) NDIILGOACJK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2644140", Offset = "0x2643540", VA = "0x182644140")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) JMPKEIOEGBD(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2645090", Offset = "0x2644490", VA = "0x182645090")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) MGPBDONJFKE(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2643F00", Offset = "0x2643300", VA = "0x182643F00")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) JJMMADAHFFP(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] int? FIDLGKBCLMC, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2641590", Offset = "0x2640990", VA = "0x182641590")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) BDONOBIAMNA(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? FIDLGKBCLMC, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26452C0", Offset = "0x26446C0", VA = "0x1826452C0")]
	public static EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>> MLCEMAFPLGB(this EPPNKNJKIOI<byte> CAMFIHKHJNG)
	{
		return default(EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2645B30", Offset = "0x2644F30", VA = "0x182645B30")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) OIFJOGDPGPI(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, float BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2643C50", Offset = "0x2643050", VA = "0x182643C50")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) IPEHHKALOFK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, float AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<HFGFLGOEJKP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2645CB0", Offset = "0x26450B0", VA = "0x182645CB0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>) OMJFCONGJCF(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<HFGFLGOEJKP>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<HFGFLGOEJKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2644C90", Offset = "0x2644090", VA = "0x182644C90")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) MCHDEIGNAGL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2643890", Offset = "0x2642C90", VA = "0x182643890")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) HOIBCPJNBHH(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2641BC0", Offset = "0x2640FC0", VA = "0x182641BC0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) CKCCIJCJEKB(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2641F20", Offset = "0x2641320", VA = "0x182641F20")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) DDELLEHDDAK(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, int BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26416A0", Offset = "0x2640AA0", VA = "0x1826416A0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) BGNBKOPKOCL(this EPPNKNJKIOI<byte> CAMFIHKHJNG, int AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<OKPGGGJOGGB>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26443B0", Offset = "0x26437B0", VA = "0x1826443B0")]
	public static (EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>) KEPCBKBBOBI(this EPPNKNJKIOI<byte> CAMFIHKHJNG, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? AKAPFCIGAAM, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? BPDIMNMHBCA, [Optional] EECNAGIPCBM<GBMPBPGOJIG<OKPGGGJOGGB>>? MEEHJPHKEMN)
	{
		return default((EECNAGIPCBM<AMGCLMOKHAB<KNAAHPPNIJP>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>, EECNAGIPCBM<AMGCLMOKHAB<GBMPBPGOJIG<OKPGGGJOGGB>>>));
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
