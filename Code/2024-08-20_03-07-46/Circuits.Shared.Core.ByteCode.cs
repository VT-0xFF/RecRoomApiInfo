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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20002A0", Offset = "0x1FFF2A0", VA = "0x1820002A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MOFPNNAOOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28987B0", Offset = "0x28977B0", VA = "0x1828987B0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<M>> LFFFHPLBGKL<M>(this int KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2000270", Offset = "0x1FFF270", VA = "0x182000270")]
	public static BGKDPCAKPBJ<HDAPBNILEED> EHFJBLGBAFP(this int KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<HDAPBNILEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28987B0", Offset = "0x28977B0", VA = "0x1828987B0")]
	public static BGKDPCAKPBJ<KKPCOHNODPC<M>> DKDBPJFMMIB<M>(this int KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<KKPCOHNODPC<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class AOGIMHHCCDD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DBDGPKKENKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IDFFJOFDIGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HDAPBNILEED
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JNDEJCCNEEG
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HMNNNMBGMHL
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OMBOLECGMND
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
public static class JMIKAHOCDGL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct GHCLIABPFAG<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr HKOHEKBCCKM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
		public GHCLIABPFAG(IntPtr OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CC20", Offset = "0x3D6BC20", VA = "0x183D6CC20")]
		public int GHKHNOGELCE(TDeps HPGJLJLFPIH, TContext IBLIIOCCPPC, TCompileState POOOFNNEGFG, [In] PPKMBIHDAAO<byte> JGBIPJNDLBD, int LIPIFNEJJJL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CAD0", Offset = "0x2C3BAD0", VA = "0x182C3CAD0")]
	public static void KGCFONFHGGA<TDeps, TContext, TCompileState>(TDeps HPGJLJLFPIH, TContext IBLIIOCCPPC, TCompileState POOOFNNEGFG, [In] PPKMBIHDAAO<byte> DGKONIIGBBN, PPKMBIHDAAO<byte> JLGHKFICANE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KLAECALGJIC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NAJHHJGFLBB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OKNHOEEHAKI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MDPPGAKNKFA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NNNBMFAEACM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HOJJLGDHNNJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MPGBJGLELKO, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EDFKMJKHBIA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BLKIIBIAAEB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NBNCMJBMKPP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ADPCHHBHCDD, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KDLAOGBMCLH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BKMEIJPDDCJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IAMDJNNJLMH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FGJKBMIEABJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BKBDDOMPOCK, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HNKBBELMPKC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HDCJOHAOJLE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? PCIINCGFAEH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CDDHAALLBCL, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IGMCIJPKPLK, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JLBGNFCAOAF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HDNJAPPKFEE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HILHMFCEJGO, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FBPIBNCKAOC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EOJIDMDMFPJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EENCLBHMKAP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BMCKDNCGKBD, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EGHIEDCMLOF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DHLJBCBPBIH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MHCMJJEAIIJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DBGHBNOLIEO, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GNJBDEGAPGH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JJEAAIMHIMP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GAIHKAFHNHB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ADGBAGCBOLP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CCBCFADEDII, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IFGNFKOFENJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JHDIJMJHMMP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? LMILJGHNDOJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KNBNBJAFPEL, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? AGBIJCGPBHB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MFCGDOOHONC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BEJMPJEJCKC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OPOCEJCJPKD, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BKKMJJECNLE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NBNBPKHAEBN, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HCJIOLFHOOL, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FJNAOFLLHJE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ODNAFPELOED, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KDIJBEKCHKI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? LKJNCBIDOJG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NOIKPOLNDOH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EEOIDMBIBBP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EIPGEDNLMON, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? AOIELEPBHPC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MKAGHLGBHED, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BKAJNEJMDAA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FPEJFIPHMED, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GEMJDLGHGAA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? LNCBDFEIBAD, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OHEFBLJDHJL, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ELINAEMHAAI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? PAFBDFPJJHK, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JMBHDKOPMMH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OFHJHIJDJBI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IHEELJBMDNM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? PMIIKJMLNCA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FCPGHIMIDCP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DOLGFJMDGFE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JMJFIAFPIJB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KIDHLLPDMCH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? FFCAFKNMNJE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EOCNNGBHFIB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HOPBKCIOMJO, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HDPEHDOPOLI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GOAIBPDNEII, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ICONDDMIIME, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BOIPGCMHGBI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? PJCGELAIJKP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BEOCOJEJBFN, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IKKHODGNBHB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CHFOFMGIDNE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EEJCOGEEJKA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HFLLODAADMA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HOLAFBIIDGA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CIBPDALJENP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BIPHOOFGJGK, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NJNKKCLOIPG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GJHJIOCEPGG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JMCKCMHGBNB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OEOGCALNIPB, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? LFAKPNPACGP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OCFICABJJKA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CDDNOHPHLNA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CLIFCHBOGBO, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OLAOGPCDMBP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HEOHDJBLFHP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MODFFALCHHN, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ENGHIGPHPEL, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HKOHHKMANDG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IJLCHHNLPFG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CNCCKAMILPG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IFICJJLDAEC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OOAMLAECIFA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? GOLCPFPIEHE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NONPJMDDFLH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? AIBAGNDFKCF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? AKIECJAPJNM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DBMADIGFAGG, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HGAHLMFJLIF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NJJPNJAOFIF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? COMEJCHJOBP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DFMDFGMDOPM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BGHHCLIEKHA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CIIIOJJCBHK, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? DGHAHABKJAP, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? EPIKFDGEDHM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ILACPDHNLEE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? BOKFOMMOFGN, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CPEMFGHFHPE, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OMGJGBAOPMH, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? LHFFAHMJJNA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IIJFABHNLLI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? MLINAJOABAI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? HECPEMBMOCI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? KKNOGFOCOIF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? NPLMANHKKAD, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IGJJPGAJLGA, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JHBMNOCDJHC, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? OGDHBOLEDAJ, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? JPMJIJIENMF, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? CCDPICGGODM, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? IPNJJJEIKJI, [Optional] GHCLIABPFAG<TContext, TDeps, TCompileState>? ANKFGOOBHLK) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20001D0", Offset = "0x1FFF1D0", VA = "0x1820001D0")]
	private static int GFFBKHFHGOO([In] PPKMBIHDAAO<byte> GOCEFODHDBO, PPKMBIHDAAO<byte> FICFNKLGBCA, int KKONFBKDDLI, int DOPPKGNLPAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ELADPLLOLNH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int GGLDPKJIJBH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F5E0", Offset = "0x2A3E5E0", VA = "0x182A3F5E0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<T>> EOBHHJHJPBL<T>([In] this PPKMBIHDAAO<byte> KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F700", Offset = "0x2A3E700", VA = "0x182A3F700")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<T>>> PBBCDPNMKHJ<T>(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<T>>? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA1E0", Offset = "0x1FF91E0", VA = "0x181FFA1E0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AJJHAIFHNDG>> OOBACGDHPDL(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<AJJHAIFHNDG>? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AJJHAIFHNDG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9E30", Offset = "0x1FF8E30", VA = "0x181FF9E30")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>> BGKBONGPFKM(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] float? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9D50", Offset = "0x1FF8D50", VA = "0x181FF9D50")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>> AEKMEAKMMDI(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA2C0", Offset = "0x1FF92C0", VA = "0x181FFA2C0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>> PAHNBBHKOPI(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<CABCPBKFDEH>? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA000", Offset = "0x1FF9000", VA = "0x181FFA000")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<HMNNNMBGMHL>> JHBOFLKCGHN(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] byte? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<HMNNNMBGMHL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA100", Offset = "0x1FF9100", VA = "0x181FFA100")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<HDAPBNILEED>> MDMDFDEEHAE(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<HDAPBNILEED>? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<HDAPBNILEED>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9F10", Offset = "0x1FF8F10", VA = "0x181FF9F10")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> FKDPDMHHPLB(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] OMBOLECGMND? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F640", Offset = "0x2A3E640", VA = "0x182A3F640")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<T>>> MDDPNPJPEOC<T>(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<T>>? JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9C50", Offset = "0x1FF8C50", VA = "0x181FF9C50")]
	public static void AGLIMAMNMED(this PPKMBIHDAAO<byte> KALCJEIICGB, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>> MJBNCEDGLMG, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F5D0", Offset = "0x2A3E5D0", VA = "0x182A3F5D0")]
	public static void BOKCHNJJJDD<T>(this PPKMBIHDAAO<byte> KALCJEIICGB, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<T>>> LIPIFNEJJJL, BGKDPCAKPBJ<AOGIMHHCCDD<T>> JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F5D0", Offset = "0x2A3E5D0", VA = "0x182A3F5D0")]
	public static void PAEPJDAGAMF<T>(this PPKMBIHDAAO<byte> KALCJEIICGB, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<T>>> PFLPLBJJACK, BGKDPCAKPBJ<KKPCOHNODPC<T>> JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EMFLOEFAKAA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA3E0", Offset = "0x1FF93E0", VA = "0x181FFA3E0")]
	public static KMHLEJADADA PIIBHOCIBPB([In] this ReadOnlySpan<byte> KABOAHAAMFF, int JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA450", Offset = "0x1FF9450", VA = "0x181FFA450")]
	public static KMHLEJADADA PIIBHOCIBPB([In] this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A40420", Offset = "0x2A3F420", VA = "0x182A40420")]
	public static KMHLEJADADA PIIBHOCIBPB<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A40570", Offset = "0x2A3F570", VA = "0x182A40570")]
	public static KMHLEJADADA PIIBHOCIBPB<M>([In] this JAGHCMLILCK<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FEC0", Offset = "0x2A3EEC0", VA = "0x182A3FEC0")]
	public static KMHLEJADADA PIIBHOCIBPB<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FF50", Offset = "0x2A3EF50", VA = "0x182A3FF50")]
	public static KMHLEJADADA PIIBHOCIBPB<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2A406C0", Offset = "0x2A3F6C0", VA = "0x182A406C0")]
	public static KMHLEJADADA PIIBHOCIBPB<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA3E0", Offset = "0x1FF93E0", VA = "0x181FFA3E0")]
	public static int NADJEHFAMHJ([In] this ReadOnlySpan<byte> KABOAHAAMFF, int JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9BA0", Offset = "0x1FF8BA0", VA = "0x181FF9BA0")]
	public static int NADJEHFAMHJ([In] this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static int NADJEHFAMHJ<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static int NADJEHFAMHJ<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static int NADJEHFAMHJ<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static int NADJEHFAMHJ<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FDB0", Offset = "0x2A3EDB0", VA = "0x182A3FDB0")]
	public static float BKDEPLLPJCJ<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FDB0", Offset = "0x2A3EDB0", VA = "0x182A3FDB0")]
	public static float BKDEPLLPJCJ<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FDB0", Offset = "0x2A3EDB0", VA = "0x182A3FDB0")]
	public static float BKDEPLLPJCJ<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FF20", Offset = "0x2A3EF20", VA = "0x182A3FF20")]
	public static byte CLDHKEGOEKE<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FDF0", Offset = "0x2A3EDF0", VA = "0x182A3FDF0")]
	public static byte CLDHKEGOEKE<M>([In] this JAGHCMLILCK<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FEC0", Offset = "0x2A3EEC0", VA = "0x182A3FEC0")]
	public static byte CLDHKEGOEKE<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FF50", Offset = "0x2A3EF50", VA = "0x182A3FF50")]
	public static byte CLDHKEGOEKE<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FE10", Offset = "0x2A3EE10", VA = "0x182A3FE10")]
	public static byte CLDHKEGOEKE<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9BA0", Offset = "0x1FF8BA0", VA = "0x181FF9BA0")]
	public static OMBOLECGMND BHPFOCDEOHJ([In] this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB)
	{
		return default(OMBOLECGMND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static OMBOLECGMND BHPFOCDEOHJ<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(OMBOLECGMND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FFC0", Offset = "0x2A3EFC0", VA = "0x182A3FFC0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> DJNIJEDAPBO<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A40030", Offset = "0x2A3F030", VA = "0x182A40030")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> DJNIJEDAPBO<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A400A0", Offset = "0x2A3F0A0", VA = "0x182A400A0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> DJNIJEDAPBO<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A40340", Offset = "0x2A3F340", VA = "0x182A40340")]
	public static BGKDPCAKPBJ<KKPCOHNODPC<GDEICLOHDHO>> JPFKFIKFCMH<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<KKPCOHNODPC<GDEICLOHDHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A402D0", Offset = "0x2A3F2D0", VA = "0x182A402D0")]
	public static BGKDPCAKPBJ<HDAPBNILEED> JJENDJBGMKG<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<HDAPBNILEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A401F0", Offset = "0x2A3F1F0", VA = "0x182A401F0")]
	public static BGKDPCAKPBJ<HDAPBNILEED> JJENDJBGMKG<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<HDAPBNILEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A40260", Offset = "0x2A3F260", VA = "0x182A40260")]
	public static BGKDPCAKPBJ<HDAPBNILEED> JJENDJBGMKG<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<HDAPBNILEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A40180", Offset = "0x2A3F180", VA = "0x182A40180")]
	public static BGKDPCAKPBJ<AJJHAIFHNDG> GGOCDACOLDH<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<AJJHAIFHNDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A40110", Offset = "0x2A3F110", VA = "0x182A40110")]
	public static BGKDPCAKPBJ<AJJHAIFHNDG> GGOCDACOLDH<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<AJJHAIFHNDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A403B0", Offset = "0x2A3F3B0", VA = "0x182A403B0")]
	public static BGKDPCAKPBJ<CABCPBKFDEH> MELOMAPNCEB<M>(this CFDIOFGMMPB<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB)
	{
		return default(BGKDPCAKPBJ<CABCPBKFDEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ICJMHCCIFCI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFF70", Offset = "0x1FFEF70", VA = "0x181FFFF70")]
	public static void EKKGEHNKENB(this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB, KMHLEJADADA JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20000B0", Offset = "0x1FFF0B0", VA = "0x1820000B0")]
	public static void EKKGEHNKENB(this byte[] KABOAHAAMFF, int JPMKJCMAIBB, KMHLEJADADA JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2000030", Offset = "0x1FFF030", VA = "0x182000030")]
	public static void EKKGEHNKENB([In] this Span<byte> KABOAHAAMFF, int JPMKJCMAIBB, KMHLEJADADA JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5030", Offset = "0x2BD4030", VA = "0x182BD5030")]
	public static void EKKGEHNKENB<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, KMHLEJADADA JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4EA0", Offset = "0x2BD3EA0", VA = "0x182BD4EA0")]
	public static void EKKGEHNKENB<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, KMHLEJADADA JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9C50", Offset = "0x1FF8C50", VA = "0x181FF9C50")]
	public static void AGLIMAMNMED(this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFEF0", Offset = "0x1FFEEF0", VA = "0x181FFFEF0")]
	public static void AGLIMAMNMED(this byte[] KABOAHAAMFF, int JPMKJCMAIBB, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFE70", Offset = "0x1FFEE70", VA = "0x181FFFE70")]
	public static void AGLIMAMNMED([In] this Span<byte> KABOAHAAMFF, int JPMKJCMAIBB, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4DE0", Offset = "0x2BD3DE0", VA = "0x182BD4DE0")]
	public static void AGLIMAMNMED<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4E40", Offset = "0x2BD3E40", VA = "0x182BD4E40")]
	public static void AGLIMAMNMED<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2000120", Offset = "0x1FFF120", VA = "0x182000120")]
	public static void LEGPFABLIJC(this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5220", Offset = "0x2BD4220", VA = "0x182BD5220")]
	public static void LEGPFABLIJC<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BD51C0", Offset = "0x2BD41C0", VA = "0x182BD51C0")]
	public static void LEGPFABLIJC<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2000160", Offset = "0x1FFF160", VA = "0x182000160")]
	public static void ONGGKPBGFEM(this PPKMBIHDAAO<byte> KABOAHAAMFF, int JPMKJCMAIBB, byte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BD52D0", Offset = "0x2BD42D0", VA = "0x182BD52D0")]
	public static void ONGGKPBGFEM<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, byte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5280", Offset = "0x2BD4280", VA = "0x182BD5280")]
	public static void ONGGKPBGFEM<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, byte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29914F0", Offset = "0x29904F0", VA = "0x1829914F0")]
	public static void BOKCHNJJJDD<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29914F0", Offset = "0x29904F0", VA = "0x1829914F0")]
	public static void BOKCHNJJJDD<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29914F0", Offset = "0x29904F0", VA = "0x1829914F0")]
	public static void LGCDEPNAFLN<M>(this PKEPENJENKF<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, BGKDPCAKPBJ<HDAPBNILEED> JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29914F0", Offset = "0x29904F0", VA = "0x1829914F0")]
	public static void LGCDEPNAFLN<M>([In] this EOMFHNLIELJ<M, byte> KABOAHAAMFF, BGKDPCAKPBJ<M> JPMKJCMAIBB, BGKDPCAKPBJ<HDAPBNILEED> JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FJHHNEHPDPL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCE10", Offset = "0x1FFBE10", VA = "0x181FFCE10")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) HHEOGMANJPO(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF950", Offset = "0x1FFE950", VA = "0x181FFF950")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) PLHDHJGAEIN(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF6D0", Offset = "0x1FFE6D0", VA = "0x181FFF6D0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) PIOPBPKLGDM(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCBA0", Offset = "0x1FFBBA0", VA = "0x181FFCBA0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) GPFDCMCOMPA(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAF10", Offset = "0x1FF9F10", VA = "0x181FFAF10")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DCCJDEHAHBG(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE1D0", Offset = "0x1FFD1D0", VA = "0x181FFE1D0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) LJONKLBFADD(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFD10", Offset = "0x1FFED10", VA = "0x181FFFD10")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PONNBBIPAEM(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB1B0", Offset = "0x1FFA1B0", VA = "0x181FFB1B0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DDICELNKGDL(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD480", Offset = "0x1FFC480", VA = "0x181FFD480")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) JFJPEDFMLGF(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDF40", Offset = "0x1FFCF40", VA = "0x181FFDF40")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>) LGFBNALFLAH(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? JJCEIJMGOAB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? LKDDOGLMHDG)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE2F0", Offset = "0x1FFD2F0", VA = "0x181FFE2F0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>) LOKNGIKLPBJ(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? JJCEIJMGOAB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? LKDDOGLMHDG)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBF90", Offset = "0x1FFAF90", VA = "0x181FFBF90")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>) FABDDPMMFMB(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? JJCEIJMGOAB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? LKDDOGLMHDG)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE7B0", Offset = "0x1FFD7B0", VA = "0x181FFE7B0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>) MFNLOGLELFF(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? JJCEIJMGOAB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? LKDDOGLMHDG)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC830", Offset = "0x1FFB830", VA = "0x181FFC830")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AJJHAIFHNDG>>) GHDKMMAOLDB(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? MLLJKOFIIPN, [Optional] BGKDPCAKPBJ<AJJHAIFHNDG>? BOJOFOCMOIF)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<AJJHAIFHNDG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE6A0", Offset = "0x1FFD6A0", VA = "0x181FFE6A0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<AJJHAIFHNDG>>>) MFGBEBDGMCN(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? MLLJKOFIIPN, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<AJJHAIFHNDG>>? BOJOFOCMOIF)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<AJJHAIFHNDG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDC20", Offset = "0x1FFCC20", VA = "0x181FFDC20")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<HDAPBNILEED>>) LEIMHAAMCOK(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? MLLJKOFIIPN, [Optional] BGKDPCAKPBJ<HDAPBNILEED>? BOJOFOCMOIF)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<HDAPBNILEED>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD220", Offset = "0x1FFC220", VA = "0x181FFD220")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<HDAPBNILEED>>>) IEOICPDGIGM(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? MLLJKOFIIPN, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<HDAPBNILEED>>? BOJOFOCMOIF)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<HDAPBNILEED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2BA86B0", Offset = "0x2BA76B0", VA = "0x182BA86B0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>) IAFEBEEBMIJ<TMarker>(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<CABCPBKFDEH>? BOJOFOCMOIF, [Optional][In] ReadOnlySpan<byte> AHGAPHMJDIB)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEC80", Offset = "0x1FFDC80", VA = "0x181FFEC80")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) NJECOIFLICE(this PPKMBIHDAAO<byte> KALCJEIICGB, int GOCEFODHDBO, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? FICFNKLGBCA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB8F0", Offset = "0x1FFA8F0", VA = "0x181FFB8F0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DPHKCMNPDIJ(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GOCEFODHDBO, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? FICFNKLGBCA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2BA84C0", Offset = "0x2BA74C0", VA = "0x182BA84C0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>) FNPNLEHCDMF<TMarker>(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<TMarker>>? FICFNKLGBCA, [Optional] int? GHACOABIHDA, [Optional][In] ReadOnlySpan<byte> GOCEFODHDBO)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8370", Offset = "0x2BA7370", VA = "0x182BA8370")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>) BIMNNEFNNNN<TMarker>(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<TMarker>>? GOCEFODHDBO, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<TMarker>>? FICFNKLGBCA, [Optional] int? GHACOABIHDA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<TMarker>>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF550", Offset = "0x1FFE550", VA = "0x181FFF550")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) PIOHGFFFEAP(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCA50", Offset = "0x1FFBA50", VA = "0x181FFCA50")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) GMJNKICDHLK(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD9E0", Offset = "0x1FFC9E0", VA = "0x181FFD9E0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) KPBCPHNEHJN(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB660", Offset = "0x1FFA660", VA = "0x181FFB660")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DOGHANGMHHA(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAB50", Offset = "0x1FF9B50", VA = "0x181FFAB50")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) CCPDCGAMJNJ(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC2E0", Offset = "0x1FFB2E0", VA = "0x181FFC2E0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) GAPNKDIMPHO(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD5A0", Offset = "0x1FFC5A0", VA = "0x181FFD5A0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) KEGBEHFEIFN(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF060", Offset = "0x1FFE060", VA = "0x181FFF060")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PAGHHFMHAGC(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFADF0", Offset = "0x1FF9DF0", VA = "0x181FFADF0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) CMFKHFMKFOI(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF1B0", Offset = "0x1FFE1B0", VA = "0x181FFF1B0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>) PCJLECKDLKA(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? NGCNMIIABLD)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC6B0", Offset = "0x1FFB6B0", VA = "0x181FFC6B0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) GGAJAJFJFOE(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEB20", Offset = "0x1FFDB20", VA = "0x181FFEB20")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) NCNMAKJACFK(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE8D0", Offset = "0x1FFD8D0", VA = "0x181FFE8D0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) MHLKJGEIAEE(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBE30", Offset = "0x1FFAE30", VA = "0x181FFBE30")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) EPOHEEFFNGN(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF400", Offset = "0x1FFE400", VA = "0x181FFF400")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PFAEDOBONHB(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA780", Offset = "0x1FF9780", VA = "0x181FFA780")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) BAOFAFBIEMC(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDDC0", Offset = "0x1FFCDC0", VA = "0x181FFDDC0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) LFHMFNIDNCI(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEF00", Offset = "0x1FFDF00", VA = "0x181FFEF00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) ODAJCAMHILC(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA650", Offset = "0x1FF9650", VA = "0x181FFA650")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) AKIGMMCJJND(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD700", Offset = "0x1FFC700", VA = "0x181FFD700")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) KGBGOLJLKAD(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FFACA0", Offset = "0x1FF9CA0", VA = "0x181FFACA0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) CKLPAHDFEJG(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEA00", Offset = "0x1FFDA00", VA = "0x181FFEA00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) NCNEAHGLOHC(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD860", Offset = "0x1FFC860", VA = "0x181FFD860")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) KNAGABKMFJE(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF7F0", Offset = "0x1FFE7F0", VA = "0x181FFF7F0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PKPFFCKGLKP(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB7C0", Offset = "0x1FFA7C0", VA = "0x181FFB7C0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DOLDJGOGHOO(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC400", Offset = "0x1FFB400", VA = "0x181FFC400")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) GAPPKGMDHGI(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB060", Offset = "0x1FFA060", VA = "0x181FFB060")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DCKOEFELMEB(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB300", Offset = "0x1FFA300", VA = "0x181FFB300")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DJHFGGKLOGL(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB60", Offset = "0x1FFAB60", VA = "0x181FFBB60")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) ENOHGDOHFKP(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBA00", Offset = "0x1FFAA00", VA = "0x181FFBA00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) EEFPKOOAJPD(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCF90", Offset = "0x1FFBF90", VA = "0x181FFCF90")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) HJNLEBCKAAM(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF2A0", Offset = "0x1FFE2A0", VA = "0x181FFF2A0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PDAGDNCNAMA(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBCE0", Offset = "0x1FFACE0", VA = "0x181FFBCE0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) EONNOOAGLIC(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB540", Offset = "0x1FFA540", VA = "0x181FFB540")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DMHJKEDGHCN(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE050", Offset = "0x1FFD050", VA = "0x181FFE050")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) LIMKJOPFMDM(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEDB0", Offset = "0x1FFDDB0", VA = "0x181FFEDB0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) NJKIIHNGJJJ(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDB00", Offset = "0x1FFCB00", VA = "0x181FFDB00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) LBHNKJGEAKN(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD0C0", Offset = "0x1FFC0C0", VA = "0x181FFD0C0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) HJPLKEIBMCH(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAA00", Offset = "0x1FF9A00", VA = "0x181FFAA00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) BNFOCGLPDDO(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC1C0", Offset = "0x1FFB1C0", VA = "0x181FFC1C0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) FNBJAOFNDNB(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE410", Offset = "0x1FFD410", VA = "0x181FFE410")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) MDOLLJBCJFH(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] int? DOPIJKKNMJL, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCD00", Offset = "0x1FFBD00", VA = "0x181FFCD00")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) HAPAIELDAHJ(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? DOPIJKKNMJL, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC9D0", Offset = "0x1FFB9D0", VA = "0x181FFC9D0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> GMFBMKOFOLH(this PPKMBIHDAAO<byte> KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE520", Offset = "0x1FFD520", VA = "0x181FFE520")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) MEPGLOBONKH(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD330", Offset = "0x1FFC330", VA = "0x181FFD330")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) ILGCIOJEJGB(this PPKMBIHDAAO<byte> KALCJEIICGB, float HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<DBDGPKKENKP>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC0A0", Offset = "0x1FFB0A0", VA = "0x181FFC0A0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>) FDGOCKCALAH(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<DBDGPKKENKP>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<DBDGPKKENKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA4F0", Offset = "0x1FF94F0", VA = "0x181FFA4F0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) AGCJHJONEKM(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFBC0", Offset = "0x1FFEBC0", VA = "0x181FFFBC0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PMKMIOFLBEK(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFAA0", Offset = "0x1FFEAA0", VA = "0x181FFFAA0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) PMHNPFCFHME(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA8A0", Offset = "0x1FF98A0", VA = "0x181FFA8A0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) BECJPNDGANH(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC560", Offset = "0x1FFB560", VA = "0x181FFC560")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) GCEIJDMLKHK(this PPKMBIHDAAO<byte> KALCJEIICGB, int HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB420", Offset = "0x1FFA420", VA = "0x181FFB420")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>) DJJFCDMNFJC(this PPKMBIHDAAO<byte> KALCJEIICGB, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? HANNFMOCMEI, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? KEOGPFNFIGD, [Optional] BGKDPCAKPBJ<KKPCOHNODPC<IDFFJOFDIGH>>? GPJNHALFCOA)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<IDFFJOFDIGH>>>));
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
