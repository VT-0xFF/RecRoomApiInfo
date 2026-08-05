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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EB3210", Offset = "0x1EB2410", VA = "0x181EB3210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PMAFNKCGHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<M>> GGNJFGOHJPK<M>(this int CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3290", Offset = "0x1EB2490", VA = "0x181EB3290")]
	public static MKMFEDEKPBJ<DNGCEOAHOHC> DCLBCEIKKAO(this int CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<DNGCEOAHOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static MKMFEDEKPBJ<GDHHLLMGLNP<M>> ICKMEILNABH<M>(this int CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<GDHHLLMGLNP<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MMBGBHNCAIG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EKPFNHOOBGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HGIELDKKFBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DNGCEOAHOHC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class ALBILBKKDDL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MHHHOBJONCE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum AMHBOCHBPPG
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
public static class NKPNGLIANIM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KPMCOHNHECM<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KFFKCHCFKNG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
		public KPMCOHNHECM(IntPtr FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0510", Offset = "0x3ECF710", VA = "0x183ED0510")]
		public int IPKFGEDDFJP(TDeps LPEICIFHPLM, TContext ILEBKFMPDJP, TCompileState LFLJMGEFAGM, [In] CEHBIJEANKB<byte> IGNAHEGNJBC, int KOIEKHBJLOJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8690", Offset = "0x2AC7890", VA = "0x182AC8690")]
	public static void KFMEJFOHPAK<TDeps, TContext, TCompileState>(TDeps LPEICIFHPLM, TContext ILEBKFMPDJP, TCompileState LFLJMGEFAGM, [In] CEHBIJEANKB<byte> BPNJMGOBGFB, CEHBIJEANKB<byte> ILBNFIGADHG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AFNNKGDENEB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LHIHDFKHNFD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BCEPKMMPCBK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FDOHLFLDFNK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PLFPNIJGIFO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NBALDBNCFEI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ALBCEMPPNPP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GBHCDEHJIAC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PPNNALOJLND, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FAALADAFKHF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FCCJKHCADIH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LPPNGMDMJFO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? OFPKOFFJNMB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KJFDFDLOAFK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HJBLCLOLJOF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GGDLLDPGLCP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JDDAGFLFBDO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HCGADFJMCMB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MCMGFGIMOIK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LKHMGBMHMIL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LEGFENMDABB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KLBPEFODLKK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GMHADFCOEFC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HNOFGNEHJIP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IKLOIFBIKLN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FINOKJKNMAI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LPGEMDKAHGG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IGAGBGFLMNI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CFPOMKMGFCE, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LEIGKNNFLHK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MFMGNPFGMGK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LDMGHHMJANN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AHJJBLHDIMN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? DDKKAIBCPJM, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IDICDKJFPKL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MNAJAALGBJD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NCPNAMEJFJK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CJEPJPNLEMO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MONGAANEGDG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EOBFEBOENLJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ECEPLBNDALP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BCEFBHBMAJL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GKFODGOMOBI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JIDCHLKAMLO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JHBDELIMAFJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LHMPBBAANLA, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BDGHFLNFEAH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MCPOPHNPHDE, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NMFPNLONOJK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PEKBOLIOKGL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ABAECAMNFGO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CJGNDKMECID, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JJHIBIEDDDD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ENPAIKMLNEJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JHBOCMCGCCF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GHDCBIHNLOH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EFDKMLPMJJP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? DOEGNLGIBKN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? DKCPLIBMMBN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? DDKHDKECNEM, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HLFMKGGICHF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GBDKFAOBOEE, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BCPPKBNCEFG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CHLOKODEAML, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ABDGLCMJIMP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KCHFPABOBPC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LEHBPBADCMB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BOABGBMPHFK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CKNMHHFBKKA, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MFDLFNEIBDB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JGAIBHIBBCE, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NHHBCBANFCD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PJNEOAAGNNH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MKBGIDNEFIK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CLANBDLIEIO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PKLJIMNEBBG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BPCNLCFKDBC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NELCBGFGMIC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EALHBOAAHHK, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LDLBIDFGBPH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LJPJAKGACFL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BEDHHAHLCIN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HHDJIJKCLDO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AGCECIPFOHH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GIEKLMLFGCC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? OFEIPFLNBDG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FKKLIPFDMGD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NHAIJEFOGEN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MGINILENIJM, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PDPPOLHPEIP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IMGNJAAGILC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HKFAOCGFDBD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NPHACKIDFDL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PCNEHNFBLBJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IAJMHCDPPNH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KLPOLGCEIHJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EDEALDDMALG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GIPPLHJANBI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MOFIDKNMEAH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NNIMBLMICGO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NCNAMADKCNI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? NNODNILFBFC, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? IBDLPOJEIIH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FMAFKMDABPF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? CCFPOOCKCFE, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LFBIAKOICAG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EGFLCGEEFNI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LIMJKIIFOIJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JENKDAEFBOJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ECGGJJGAJNP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MHNCFABDCNI, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AMIELPHKELB, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JLECECOHDKM, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HMKGBFJPGMJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PKCPMCLBPKN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PAGPDOGFFFM, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PMLECKKKNFF, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? EEOAJANKMNJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BIJNFDPPHIA, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ALCNLPKHBNA, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KADBMODKOMP, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? ONBLMCCIGOH, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? DFLAPFFNCIO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AHIEHEIMPHD, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? JOCKKIBKGAO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? HNMLINNOGFA, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? LABOIPDHLFO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KAGKPCIJCEN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? PKFKECKHENJ, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? KBPMANPKFCN, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? MLOODEKAIKG, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? FFJBMLEJNAL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? BBAGDMMBFPO, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? GGBMOAFOICL, [Optional] KPMCOHNHECM<TContext, TDeps, TCompileState>? AFIGHGMGPFP) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3170", Offset = "0x1EB2370", VA = "0x181EB3170")]
	private static int AGAPBMFAHKK([In] CEHBIJEANKB<byte> CMOEDDFMDJD, CEHBIJEANKB<byte> GIDMHIMFIHF, int IFNAKMJKBID, int BIFLOKBJAPK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MINJJCFCILL
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int LHJMONKLEOD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B240", Offset = "0x2A6A440", VA = "0x182A6B240")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<T>> LIMJGNHMJMJ<T>([In] this CEHBIJEANKB<byte> CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B180", Offset = "0x2A6A380", VA = "0x182A6B180")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<T>>> JCLMKHDDMAL<T>(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<T>>? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2C50", Offset = "0x1EB1E50", VA = "0x181EB2C50")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<DOIFECCPIOP>> EPNEKJCMMBL(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<DOIFECCPIOP>? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<DOIFECCPIOP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3060", Offset = "0x1EB2260", VA = "0x181EB3060")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>> NJDOAEFGLKJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] float? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2D20", Offset = "0x1EB1F20", VA = "0x181EB2D20")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>> FNMPGFBGEDE(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2F90", Offset = "0x1EB2190", VA = "0x181EB2F90")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<PHPNPCJOCOE>> MAFFLBBBEKP(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<PHPNPCJOCOE>? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<PHPNPCJOCOE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2B60", Offset = "0x1EB1D60", VA = "0x181EB2B60")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<MHHHOBJONCE>> DLPBGIIOKCC(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] byte? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<MHHHOBJONCE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2EC0", Offset = "0x1EB20C0", VA = "0x181EB2EC0")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<DNGCEOAHOHC>> KGDIOOHHGKN(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<DNGCEOAHOHC>? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<DNGCEOAHOHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2DF0", Offset = "0x1EB1FF0", VA = "0x181EB2DF0")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>> KEJKOIHMBLC(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] AMHBOCHBPPG? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B290", Offset = "0x2A6A490", VA = "0x182A6B290")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<T>>> PIPNIOOJLDB<T>(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<T>>? HLCKBKFCMPI)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1EB26B0", Offset = "0x1EB18B0", VA = "0x181EB26B0")]
	public static void HNILBGILCMF(this CEHBIJEANKB<byte> CJKIBFNGPNM, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>> JOIEDDKPIHA, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B170", Offset = "0x2A6A370", VA = "0x182A6B170")]
	public static void EHJDOADKGNE<T>(this CEHBIJEANKB<byte> CJKIBFNGPNM, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<T>>> KOIEKHBJLOJ, MKMFEDEKPBJ<MMBGBHNCAIG<T>> HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B170", Offset = "0x2A6A370", VA = "0x182A6B170")]
	public static void BGGAKHHIHFH<T>(this CEHBIJEANKB<byte> CJKIBFNGPNM, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<T>>> IJGMGEGLGGP, MKMFEDEKPBJ<GDHHLLMGLNP<T>> HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ALNCHBGEKOB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB26F0", Offset = "0x1EB18F0", VA = "0x181EB26F0")]
	public static PIHPPAPLCME OKHONDJLGBB([In] this ReadOnlySpan<byte> PGPEJDBBJED, int OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2760", Offset = "0x1EB1960", VA = "0x181EB2760")]
	public static PIHPPAPLCME OKHONDJLGBB([In] this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD96B0", Offset = "0x2FD88B0", VA = "0x182FD96B0")]
	public static PIHPPAPLCME OKHONDJLGBB<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9830", Offset = "0x2FD8A30", VA = "0x182FD9830")]
	public static PIHPPAPLCME OKHONDJLGBB<M>([In] this AADIONFDIAI<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9640", Offset = "0x2FD8840", VA = "0x182FD9640")]
	public static PIHPPAPLCME OKHONDJLGBB<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9540", Offset = "0x2FD8740", VA = "0x182FD9540")]
	public static PIHPPAPLCME OKHONDJLGBB<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FD97C0", Offset = "0x2FD89C0", VA = "0x182FD97C0")]
	public static PIHPPAPLCME OKHONDJLGBB<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1EB26F0", Offset = "0x1EB18F0", VA = "0x181EB26F0")]
	public static int KMMFFJNINMB([In] this ReadOnlySpan<byte> PGPEJDBBJED, int OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2540", Offset = "0x1EB1740", VA = "0x181EB2540")]
	public static int KMMFFJNINMB([In] this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static int KMMFFJNINMB<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static int KMMFFJNINMB<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static int KMMFFJNINMB<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static int KMMFFJNINMB<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9160", Offset = "0x2FD8360", VA = "0x182FD9160")]
	public static float BIKDEDPNMMK<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9160", Offset = "0x2FD8360", VA = "0x182FD9160")]
	public static float BIKDEDPNMMK<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9160", Offset = "0x2FD8360", VA = "0x182FD9160")]
	public static float BIKDEDPNMMK<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD95A0", Offset = "0x2FD87A0", VA = "0x182FD95A0")]
	public static byte LHHBKJAKPGG<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9690", Offset = "0x2FD8890", VA = "0x182FD9690")]
	public static byte LHHBKJAKPGG<M>([In] this AADIONFDIAI<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9640", Offset = "0x2FD8840", VA = "0x182FD9640")]
	public static byte LHHBKJAKPGG<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9540", Offset = "0x2FD8740", VA = "0x182FD9540")]
	public static byte LHHBKJAKPGG<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD95D0", Offset = "0x2FD87D0", VA = "0x182FD95D0")]
	public static byte LHHBKJAKPGG<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2540", Offset = "0x1EB1740", VA = "0x181EB2540")]
	public static AMHBOCHBPPG GBMAOCMKBDK([In] this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG)
	{
		return default(AMHBOCHBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static AMHBOCHBPPG GBMAOCMKBDK<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(AMHBOCHBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9420", Offset = "0x2FD8620", VA = "0x182FD9420")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>> KFLHBGIGMMH<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9480", Offset = "0x2FD8680", VA = "0x182FD9480")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>> KFLHBGIGMMH<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FD93C0", Offset = "0x2FD85C0", VA = "0x182FD93C0")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>> KFLHBGIGMMH<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2FD94E0", Offset = "0x2FD86E0", VA = "0x182FD94E0")]
	public static MKMFEDEKPBJ<GDHHLLMGLNP<MGLJAMGGPMJ>> LEDHCKKLGKP<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<GDHHLLMGLNP<MGLJAMGGPMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2FD91E0", Offset = "0x2FD83E0", VA = "0x182FD91E0")]
	public static MKMFEDEKPBJ<DNGCEOAHOHC> CNOBHBNIGHO<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<DNGCEOAHOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9180", Offset = "0x2FD8380", VA = "0x182FD9180")]
	public static MKMFEDEKPBJ<DNGCEOAHOHC> CNOBHBNIGHO<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<DNGCEOAHOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9240", Offset = "0x2FD8440", VA = "0x182FD9240")]
	public static MKMFEDEKPBJ<DNGCEOAHOHC> CNOBHBNIGHO<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<DNGCEOAHOHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9300", Offset = "0x2FD8500", VA = "0x182FD9300")]
	public static MKMFEDEKPBJ<DOIFECCPIOP> EKLIMMBNBLF<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<DOIFECCPIOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2FD92A0", Offset = "0x2FD84A0", VA = "0x182FD92A0")]
	public static MKMFEDEKPBJ<DOIFECCPIOP> EKLIMMBNBLF<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<DOIFECCPIOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9360", Offset = "0x2FD8560", VA = "0x182FD9360")]
	public static MKMFEDEKPBJ<PHPNPCJOCOE> JBOOMIDNJFG<M>(this NOGOGJJGMED<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG)
	{
		return default(MKMFEDEKPBJ<PHPNPCJOCOE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HCFBHMGAFEA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2880", Offset = "0x1EB1A80", VA = "0x181EB2880")]
	public static void EFOEBFBGEME(this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG, PIHPPAPLCME HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2940", Offset = "0x1EB1B40", VA = "0x181EB2940")]
	public static void EFOEBFBGEME(this byte[] PGPEJDBBJED, int OGAJAFJJDGG, PIHPPAPLCME HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2800", Offset = "0x1EB1A00", VA = "0x181EB2800")]
	public static void EFOEBFBGEME([In] this Span<byte> PGPEJDBBJED, int OGAJAFJJDGG, PIHPPAPLCME HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29AD5A0", Offset = "0x29AC7A0", VA = "0x1829AD5A0")]
	public static void EFOEBFBGEME<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, PIHPPAPLCME HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29AD690", Offset = "0x29AC890", VA = "0x1829AD690")]
	public static void EFOEBFBGEME<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, PIHPPAPLCME HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1EB26B0", Offset = "0x1EB18B0", VA = "0x181EB26B0")]
	public static void HNILBGILCMF(this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1EB29B0", Offset = "0x1EB1BB0", VA = "0x181EB29B0")]
	public static void HNILBGILCMF(this byte[] PGPEJDBBJED, int OGAJAFJJDGG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2A30", Offset = "0x1EB1C30", VA = "0x181EB2A30")]
	public static void HNILBGILCMF([In] this Span<byte> PGPEJDBBJED, int OGAJAFJJDGG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29AD790", Offset = "0x29AC990", VA = "0x1829AD790")]
	public static void HNILBGILCMF<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29AD7E0", Offset = "0x29AC9E0", VA = "0x1829AD7E0")]
	public static void HNILBGILCMF<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2B20", Offset = "0x1EB1D20", VA = "0x181EB2B20")]
	public static void OMAHAHFKELF(this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29AD890", Offset = "0x29ACA90", VA = "0x1829AD890")]
	public static void OMAHAHFKELF<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29AD8E0", Offset = "0x29ACAE0", VA = "0x1829AD8E0")]
	public static void OMAHAHFKELF<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2AB0", Offset = "0x1EB1CB0", VA = "0x181EB2AB0")]
	public static void NHOFNGPNIDF(this CEHBIJEANKB<byte> PGPEJDBBJED, int OGAJAFJJDGG, byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29AD830", Offset = "0x29ACA30", VA = "0x1829AD830")]
	public static void NHOFNGPNIDF<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29AD860", Offset = "0x29ACA60", VA = "0x1829AD860")]
	public static void NHOFNGPNIDF<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29AD780", Offset = "0x29AC980", VA = "0x1829AD780")]
	public static void EHJDOADKGNE<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>> HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29AD780", Offset = "0x29AC980", VA = "0x1829AD780")]
	public static void EHJDOADKGNE<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, MKMFEDEKPBJ<MMBGBHNCAIG<MGLJAMGGPMJ>> HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29AD780", Offset = "0x29AC980", VA = "0x1829AD780")]
	public static void NFNEJFHMDBJ<M>(this PLMMFEMJMLP<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, MKMFEDEKPBJ<DNGCEOAHOHC> HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29AD780", Offset = "0x29AC980", VA = "0x1829AD780")]
	public static void NFNEJFHMDBJ<M>([In] this BJFDOKELEMF<M, byte> PGPEJDBBJED, MKMFEDEKPBJ<M> OGAJAFJJDGG, MKMFEDEKPBJ<DNGCEOAHOHC> HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PPJECHFJBDC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7EE0", Offset = "0x1EB70E0", VA = "0x181EB7EE0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) NKJBOFNAJME(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3700", Offset = "0x1EB2900", VA = "0x181EB3700")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) APPNECABFGK(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3440", Offset = "0x1EB2640", VA = "0x181EB3440")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) AFNKPGGAENG(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1EB70D0", Offset = "0x1EB62D0", VA = "0x181EB70D0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LKLCCNKEHML(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7730", Offset = "0x1EB6930", VA = "0x181EB7730")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) MGGCHKKHJPG(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1EB55C0", Offset = "0x1EB47C0", VA = "0x181EB55C0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) FDEJHIIFKEE(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5A10", Offset = "0x1EB4C10", VA = "0x181EB5A10")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) HAJGKDHOLFJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6CF0", Offset = "0x1EB5EF0", VA = "0x181EB6CF0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LADBDNDBGOP(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6960", Offset = "0x1EB5B60", VA = "0x181EB6960")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) KJOMKNAMPBF(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4A30", Offset = "0x1EB3C30", VA = "0x181EB4A30")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>) DNOJAGOOKAM(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? HLCKBKFCMPI, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>? BIJAJOMCIBM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1EB66E0", Offset = "0x1EB58E0", VA = "0x181EB66E0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>) KCJEIACFBKP(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? HLCKBKFCMPI, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>? BIJAJOMCIBM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7B20", Offset = "0x1EB6D20", VA = "0x181EB7B20")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>) MKNCFOHGAKA(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? HLCKBKFCMPI, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>? BIJAJOMCIBM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5E10", Offset = "0x1EB5010", VA = "0x181EB5E10")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>) HMHGOJMFPOE(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? HLCKBKFCMPI, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>? BIJAJOMCIBM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3BE0", Offset = "0x1EB2DE0", VA = "0x181EB3BE0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<DOIFECCPIOP>>) BNKMFCMCAOH(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? DCGHNBDABPD, [Optional] MKMFEDEKPBJ<DOIFECCPIOP>? IKBJCBBBOIM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<DOIFECCPIOP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4920", Offset = "0x1EB3B20", VA = "0x181EB4920")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<DOIFECCPIOP>>>) DLOFDBBNICN(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? DCGHNBDABPD, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<DOIFECCPIOP>>? IKBJCBBBOIM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<DOIFECCPIOP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3560", Offset = "0x1EB2760", VA = "0x181EB3560")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<DNGCEOAHOHC>>) ANBHLFJLGLL(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? DCGHNBDABPD, [Optional] MKMFEDEKPBJ<DNGCEOAHOHC>? IKBJCBBBOIM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<DNGCEOAHOHC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB39B0", Offset = "0x1EB2BB0", VA = "0x181EB39B0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<DNGCEOAHOHC>>>) BJIKKMAJNJH(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? DCGHNBDABPD, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<DNGCEOAHOHC>>? IKBJCBBBOIM)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<DNGCEOAHOHC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CAC0", Offset = "0x2B1BCC0", VA = "0x182B1CAC0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<PHPNPCJOCOE>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<TMarker>>) MDKGFACKKFE<TMarker>(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<PHPNPCJOCOE>? IKBJCBBBOIM, [Optional][In] ReadOnlySpan<byte> JLJKEBMIIPF)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<PHPNPCJOCOE>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4B40", Offset = "0x1EB3D40", VA = "0x181EB4B40")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) DNPLLMINBKG(this CEHBIJEANKB<byte> CJKIBFNGPNM, int CMOEDDFMDJD, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? GIDMHIMFIHF)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6450", Offset = "0x1EB5650", VA = "0x181EB6450")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) JDFPGEDDLDF(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? CMOEDDFMDJD, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? GIDMHIMFIHF)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B1C7C0", Offset = "0x2B1B9C0", VA = "0x182B1C7C0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<TMarker>>) BHCHLOADAOI<TMarker>(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<TMarker>>? GIDMHIMFIHF, [Optional] int? AGHIAPEPFJE, [Optional][In] ReadOnlySpan<byte> CMOEDDFMDJD)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B1C9A0", Offset = "0x2B1BBA0", VA = "0x182B1C9A0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>) GAMBMEEMBEC<TMarker>(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<TMarker>>? CMOEDDFMDJD, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<TMarker>>? GIDMHIMFIHF, [Optional] int? AGHIAPEPFJE)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<TMarker>>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6560", Offset = "0x1EB5760", VA = "0x181EB6560")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) KABNGEEGJOF(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1EB51D0", Offset = "0x1EB43D0", VA = "0x181EB51D0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) EMDOMNCMLBI(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4800", Offset = "0x1EB3A00", VA = "0x181EB4800")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) DGFHHFFGKIF(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6080", Offset = "0x1EB5280", VA = "0x181EB6080")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) IPNCABBILOO(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7C30", Offset = "0x1EB6E30", VA = "0x181EB7C30")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) MPEKGPOCEOL(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB50B0", Offset = "0x1EB42B0", VA = "0x181EB50B0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) EKNNGCBHOOH(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8AE0", Offset = "0x1EB7CE0", VA = "0x181EB8AE0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) PMPFKFPCGGO(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8700", Offset = "0x1EB7900", VA = "0x181EB8700")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) OOIKFACIDMA(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB56E0", Offset = "0x1EB48E0", VA = "0x181EB56E0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) FNHFIEAPJEJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5920", Offset = "0x1EB4B20", VA = "0x181EB5920")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>) GMKHLCAEHOE(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>? IKJBJKOPKLB)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<MMBGBHNCAIG<ALBILBKKDDL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB42B0", Offset = "0x1EB34B0", VA = "0x181EB42B0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CKOJJPGKBEL(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1EB75D0", Offset = "0x1EB67D0", VA = "0x181EB75D0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) MFBKCLEAOMB(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1EB46D0", Offset = "0x1EB38D0", VA = "0x181EB46D0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) DFMMGFBLJCJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6800", Offset = "0x1EB5A00", VA = "0x181EB6800")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) KDPMNKPCJNI(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7230", Offset = "0x1EB6430", VA = "0x181EB7230")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LMOFLIIBOFO(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3EE0", Offset = "0x1EB30E0", VA = "0x181EB3EE0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CDLJJMHLLME(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4430", Offset = "0x1EB3630", VA = "0x181EB4430")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CLHGADHPLGO(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7D80", Offset = "0x1EB6F80", VA = "0x181EB7D80")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) NHEJNEBOMKO(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8310", Offset = "0x1EB7510", VA = "0x181EB8310")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) ODFDBOLLMLP(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6F70", Offset = "0x1EB6170", VA = "0x181EB6F70")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LCJDNMIIMCF(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1EB61E0", Offset = "0x1EB53E0", VA = "0x181EB61E0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) JBHLAHPHPBD(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6A80", Offset = "0x1EB5C80", VA = "0x181EB6A80")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) KLFDBGJPFCN(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB32C0", Offset = "0x1EB24C0", VA = "0x181EB32C0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) ACAHKFNDAOJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8440", Offset = "0x1EB7640", VA = "0x181EB8440")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) OHHNDNBFEIN(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB74A0", Offset = "0x1EB66A0", VA = "0x181EB74A0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LPFGJBNJFAL(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4000", Offset = "0x1EB3200", VA = "0x181EB4000")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CGFDELHPKNN(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5B70", Offset = "0x1EB4D70", VA = "0x181EB5B70")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) HICDMLFDLLJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7A00", Offset = "0x1EB6C00", VA = "0x181EB7A00")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) MJNOEDFIEBC(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8850", Offset = "0x1EB7A50", VA = "0x181EB8850")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) PCNHLEHAGDK(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3850", Offset = "0x1EB2A50", VA = "0x181EB3850")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) BGACKCANDML(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6E40", Offset = "0x1EB6040", VA = "0x181EB6E40")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LCIBDKIFIML(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3D80", Offset = "0x1EB2F80", VA = "0x181EB3D80")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CBGCEIPEKKP(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4C70", Offset = "0x1EB3E70", VA = "0x181EB4C70")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) DPKANHGFGGJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5320", Offset = "0x1EB4520", VA = "0x181EB5320")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) EOEDDAFEHPO(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5440", Offset = "0x1EB4640", VA = "0x181EB5440")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) EOMNGJHAEPN(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1EB81C0", Offset = "0x1EB73C0", VA = "0x181EB81C0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) OAIJGOGDPCI(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5800", Offset = "0x1EB4A00", VA = "0x181EB5800")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) GHMMCHMNPIK(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4DC0", Offset = "0x1EB3FC0", VA = "0x181EB4DC0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) EBLAPNEOOHC(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4160", Offset = "0x1EB3360", VA = "0x181EB4160")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) CJCFCHDFING(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7380", Offset = "0x1EB6580", VA = "0x181EB7380")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) LPAIPHJLFHB(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB89D0", Offset = "0x1EB7BD0", VA = "0x181EB89D0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) PEJBGHDCIMB(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] int? JHGAELILJOA, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB4F20", Offset = "0x1EB4120", VA = "0x181EB4F20")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) EDIDMBJNGKF(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JHGAELILJOA, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5030", Offset = "0x1EB4230", VA = "0x181EB5030")]
	public static MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>> EEAJDNDACDA(this CEHBIJEANKB<byte> CJKIBFNGPNM)
	{
		return default(MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7880", Offset = "0x1EB6A80", VA = "0x181EB7880")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) MHEFGAEBHLM(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, float OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6BA0", Offset = "0x1EB5DA0", VA = "0x181EB6BA0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) KOHHHNPELCO(this CEHBIJEANKB<byte> CJKIBFNGPNM, float KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<EKPFNHOOBGK>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6330", Offset = "0x1EB5530", VA = "0x181EB6330")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>) JCOHDNIOBIM(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<EKPFNHOOBGK>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<EKPFNHOOBGK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8060", Offset = "0x1EB7260", VA = "0x181EB8060")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) NOEFPPPBEFK(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5F30", Offset = "0x1EB5130", VA = "0x181EB5F30")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) HOBOJDJDHPP(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1EB45B0", Offset = "0x1EB37B0", VA = "0x181EB45B0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) COECILIMAAI(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1EB85A0", Offset = "0x1EB77A0", VA = "0x181EB85A0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) OLFHINKAHPF(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, int OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5CC0", Offset = "0x1EB4EC0", VA = "0x181EB5CC0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) HLBEIPICCBK(this CEHBIJEANKB<byte> CJKIBFNGPNM, int KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<HGIELDKKFBJ>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3AC0", Offset = "0x1EB2CC0", VA = "0x181EB3AC0")]
	public static (MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>) BMOHLOFDPHJ(this CEHBIJEANKB<byte> CJKIBFNGPNM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? KNPEILCEKGM, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? OMGEENCMFCP, [Optional] MKMFEDEKPBJ<GDHHLLMGLNP<HGIELDKKFBJ>>? JGHOPJNHEAP)
	{
		return default((MKMFEDEKPBJ<MMBGBHNCAIG<ALBILBKKDDL>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>, MKMFEDEKPBJ<MMBGBHNCAIG<GDHHLLMGLNP<HGIELDKKFBJ>>>));
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
