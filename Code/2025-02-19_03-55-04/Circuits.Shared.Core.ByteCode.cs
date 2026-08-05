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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2535B90", Offset = "0x2534790", VA = "0x182535B90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AKELGBGAIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30EA910", Offset = "0x30E9510", VA = "0x1830EA910")]
	public static ENBGACDEBPI<GGAFINAEHPA<M>> OEOCODFBLLF<M>(this int DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x252F630", Offset = "0x252E230", VA = "0x18252F630")]
	public static ENBGACDEBPI<APPBJBEGGDM> LNJHFHABKLM(this int DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<APPBJBEGGDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30EA910", Offset = "0x30E9510", VA = "0x1830EA910")]
	public static ENBGACDEBPI<FFOBBLBAKLA<M>> EHBCAOBAKAA<M>(this int DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<FFOBBLBAKLA<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GGAFINAEHPA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FIDGNHIADCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DCHNPJGMAPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class APPBJBEGGDM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JGCKKAOPKLM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FNIEDCHDNNF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OAGMKCGEOHB
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
public static class KCMKGHMODNB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct DBKCNHHEBAC<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KKNEOBDIJPA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
		public DBKCNHHEBAC(IntPtr FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62F1CF0", Offset = "0x62F08F0", VA = "0x1862F1CF0")]
		public int AOKANKCOAFH(TDeps CJMMHNIMOJB, TContext EKINCLIIKLE, TCompileState PNLNPPEIKNP, [In] OACMJNHPIGJ<byte> PFKGDFIHPGJ, int INIPHPCGJHP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34328B0", Offset = "0x34314B0", VA = "0x1834328B0")]
	public static void HFNBLCEJPOD<TDeps, TContext, TCompileState>(TDeps CJMMHNIMOJB, TContext EKINCLIIKLE, TCompileState PNLNPPEIKNP, [In] OACMJNHPIGJ<byte> DOKNOOHODJA, OACMJNHPIGJ<byte> EPANNKDLNJP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CDGDGPDBHOO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KHKPCFHHDFJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BAMMBKKABBL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JCBFKPOKBGO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JNPJKBAKIFP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AJPDPCOGDJC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CCEABMGIFDC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NMFCBCLFPGG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MCPNKMOLPJO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EKADNCFJDJP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JPEEKCLEFDL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BFNGBCIDAJN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BALPAMFICPE, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PKMIBMHPJAN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LNPAILKDCDK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DAFGACHPIFK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DNMCCKMILLL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? IKAHJELIHCM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MHMLHFPNMFA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? ONFPCCLIBAM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EEELCPBKHEK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MAKDFJOIEHH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? ONDGGMELCJB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? IOAOINBJEDM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HLFKONHJEOA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CKEBOAHGPMF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BHAKEJLLCKC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DDBEICMCMBI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PDAPMLEHLEJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MGECMMFLGCF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BHNLCOJJNNC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PNGEPLBLDHC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DJCOEOLBCGA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PBJDGELFBLK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HAHNEDJOAJI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HKOAIEFPKLD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? ILKBGKKLNIJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NIKJIEPJMOK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HMABFHCOKJA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EJMDALJJJMC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BMOFJPGPDPO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HDOBFJEAADM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CNNCHIPHKJO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KNIBOEEBHLN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AIIGFFPDGMM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NBNKMAJMAKG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NGPPCDFOIDH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BHHDPGKCBNF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? FMIFHOHBLKF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DHNMLOENNMI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GCFHJKACBFJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HAFPHOMFNDA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CINFGLEMMDO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DMDNPPJENNN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KIOJCMDMCGN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? IKPGIKGPJBF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? OANKFOPIMNB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? FLJDLOLPFKJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GEEKCKHAGKK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DHBHDDGHOEI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GOEFNFPKMNJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? OOLCGNBPJGF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PKFAILKHPKK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HLFEANDODGC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CBJLDBLNMOA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GCPMCANHMDI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NKDKLJKIKMI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GDJGJMMAEEE, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MMMGLLPNNDH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DLNBKHCEFMK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? ICPIGOGLIOI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? FDJDINNJNFD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CGLAHDKLKIN, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MLJHFBPGHKO, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JPFDPKPEMLP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AFHIIEFJNGK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NGMLPCGOKJJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GFNKNHJFBFC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? IOODCAKDGLP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? FKMCNOBDMJP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HKNAAKMEFDB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MBEPELEDDIJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? APJNKMJCKFD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JKHLAHJCMAD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HALGFGMJFHH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? PCJNFEFCHAB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AILKEBHDADP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GGIKHAPIICL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BAPBCKEJFLD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CINKOEBPHIA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LANDCOOEKKF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? INMNNKJPNFD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LHGBAMAGBDE, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LEFADPNOMGM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GIABAMHPFHG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KOGNJAGPNHI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BCJEJJAIMND, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NHJCPJINDEP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? OMAAPNIALFG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EBKKIHFFCOA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BDPPDGOLDKK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? POLGBFLJOOB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JBGLLOMNJAM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AHJKFJGHFOM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EOJKPOLFONB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? MINFCENODCF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AIFHAEBHAIJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EBGIEBOEFPC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? NHEFILIIBGI, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KOENMNJFIJA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? HNCEHMCJOND, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EILEHCGJGJM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JHHLOEAMCMG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? FGFOOCPMIDB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JEANOPKBAOC, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EIPGHIBEDKK, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EGPAFPBDMKM, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KPKOBBOGFCJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BCKJBHPPPGJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LEFHNBEHAOD, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EMOEDIIGAFF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? IFFGOLCHGKF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BMDIPMHDAMB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AGKJCFDECDH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KGFENIDABFB, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? EELDCFJHHOA, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? BBJKOAOODLL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? ELHDEEDFEKH, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? JCNJHGCELLF, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? AGMCLODEONJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? GEMDFKKCIGP, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? KNAMMJPILAL, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? DAFAEBPGNKG, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? LJEMCIIPJMJ, [Optional] DBKCNHHEBAC<TContext, TDeps, TCompileState>? CACEDKBANNE) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25350F0", Offset = "0x2533CF0", VA = "0x1825350F0")]
	private static int JFBEDHICMEM([In] OACMJNHPIGJ<byte> POLACNBCNMG, OACMJNHPIGJ<byte> LDFAIJKGKCP, int BICIFKAHIKL, int EBDKDADIOBA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MPNILGFGICC
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int CJIOKGNLCIM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x347B180", Offset = "0x3479D80", VA = "0x18347B180")]
	public static ENBGACDEBPI<GGAFINAEHPA<T>> EJFACNKGDND<T>([In] this OACMJNHPIGJ<byte> DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x347B0C0", Offset = "0x3479CC0", VA = "0x18347B0C0")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<T>>> DBHKCPODONM<T>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<GGAFINAEHPA<T>>? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2535610", Offset = "0x2534210", VA = "0x182535610")]
	public static ENBGACDEBPI<GGAFINAEHPA<MHPCJABLLBH>> OPCEAMFBLHG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<MHPCJABLLBH>? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<MHPCJABLLBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2535440", Offset = "0x2534040", VA = "0x182535440")]
	public static ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>> IMGEHLHLIEP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] float? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2535530", Offset = "0x2534130", VA = "0x182535530")]
	public static ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>> OPBBEKHLPMH(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2535360", Offset = "0x2533F60", VA = "0x182535360")]
	public static ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>> GABLFPPPHGM(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<MFILLNOKJPM>? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25356F0", Offset = "0x25342F0", VA = "0x1825356F0")]
	public static ENBGACDEBPI<GGAFINAEHPA<FNIEDCHDNNF>> POOFLOCCMBC(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] byte? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<FNIEDCHDNNF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2535280", Offset = "0x2533E80", VA = "0x182535280")]
	public static ENBGACDEBPI<GGAFINAEHPA<APPBJBEGGDM>> FEINOAOGBPB(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<APPBJBEGGDM>? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<APPBJBEGGDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2535190", Offset = "0x2533D90", VA = "0x182535190")]
	public static ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> EPOODCCPEPA(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] OAGMKCGEOHB? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x347B1F0", Offset = "0x3479DF0", VA = "0x18347B1F0")]
	public static ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<T>>> OKNBDIEOHLE<T>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<T>>? MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x252F5F0", Offset = "0x252E1F0", VA = "0x18252F5F0")]
	public static void MANAMHMJBFF(this OACMJNHPIGJ<byte> DKGDAEBOJKO, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>> NBBGLIIKIIP, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x347B1E0", Offset = "0x3479DE0", VA = "0x18347B1E0")]
	public static void LFDONILMIHO<T>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<T>>> INIPHPCGJHP, ENBGACDEBPI<GGAFINAEHPA<T>> MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x347B1E0", Offset = "0x3479DE0", VA = "0x18347B1E0")]
	public static void MCHEALMNLBD<T>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<T>>> PEHLHHBCCGF, ENBGACDEBPI<FFOBBLBAKLA<T>> MPDLOLIOGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BKLIIFAFEEL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2534FE0", Offset = "0x2533BE0", VA = "0x182534FE0")]
	public static GJKMACPKIMD LCLJMANDFFL([In] this ReadOnlySpan<byte> FOLLKKLPOMJ, int OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2535050", Offset = "0x2533C50", VA = "0x182535050")]
	public static GJKMACPKIMD LCLJMANDFFL([In] this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x31075D0", Offset = "0x31061D0", VA = "0x1831075D0")]
	public static GJKMACPKIMD LCLJMANDFFL<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3107470", Offset = "0x3106070", VA = "0x183107470")]
	public static GJKMACPKIMD LCLJMANDFFL<M>([In] this INJBIGHCIMN<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3107180", Offset = "0x3105D80", VA = "0x183107180")]
	public static GJKMACPKIMD LCLJMANDFFL<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3107110", Offset = "0x3105D10", VA = "0x183107110")]
	public static GJKMACPKIMD LCLJMANDFFL<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3107720", Offset = "0x3106320", VA = "0x183107720")]
	public static GJKMACPKIMD LCLJMANDFFL<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2534FE0", Offset = "0x2533BE0", VA = "0x182534FE0")]
	public static int MIMAONHJAJD([In] this ReadOnlySpan<byte> FOLLKKLPOMJ, int OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x252F520", Offset = "0x252E120", VA = "0x18252F520")]
	public static int MIMAONHJAJD([In] this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31077E0", Offset = "0x31063E0", VA = "0x1831077E0")]
	public static int MIMAONHJAJD<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x31077E0", Offset = "0x31063E0", VA = "0x1831077E0")]
	public static int MIMAONHJAJD<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31077E0", Offset = "0x31063E0", VA = "0x1831077E0")]
	public static int MIMAONHJAJD<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31077E0", Offset = "0x31063E0", VA = "0x1831077E0")]
	public static int MIMAONHJAJD<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3107430", Offset = "0x3106030", VA = "0x183107430")]
	public static float JMDGDPEEKOI<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3107430", Offset = "0x3106030", VA = "0x183107430")]
	public static float JMDGDPEEKOI<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3107430", Offset = "0x3106030", VA = "0x183107430")]
	public static float JMDGDPEEKOI<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3107020", Offset = "0x3105C20", VA = "0x183107020")]
	public static byte FBAMBJOIEOJ<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31071E0", Offset = "0x3105DE0", VA = "0x1831071E0")]
	public static byte FBAMBJOIEOJ<M>([In] this INJBIGHCIMN<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3107180", Offset = "0x3105D80", VA = "0x183107180")]
	public static byte FBAMBJOIEOJ<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3107110", Offset = "0x3105D10", VA = "0x183107110")]
	public static byte FBAMBJOIEOJ<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3107050", Offset = "0x3105C50", VA = "0x183107050")]
	public static byte FBAMBJOIEOJ<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x252F520", Offset = "0x252E120", VA = "0x18252F520")]
	public static OAGMKCGEOHB NDBFAGDHNGH([In] this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE)
	{
		return default(OAGMKCGEOHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31077E0", Offset = "0x31063E0", VA = "0x1831077E0")]
	public static OAGMKCGEOHB NDBFAGDHNGH<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(OAGMKCGEOHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3107270", Offset = "0x3105E70", VA = "0x183107270")]
	public static ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> FKHJIHLPNMC<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31072E0", Offset = "0x3105EE0", VA = "0x1831072E0")]
	public static ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> FKHJIHLPNMC<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3107350", Offset = "0x3105F50", VA = "0x183107350")]
	public static ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> FKHJIHLPNMC<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3107200", Offset = "0x3105E00", VA = "0x183107200")]
	public static ENBGACDEBPI<FFOBBLBAKLA<MCIANNAFDDF>> FJLPFCLBEPB<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<FFOBBLBAKLA<MCIANNAFDDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3106ED0", Offset = "0x3105AD0", VA = "0x183106ED0")]
	public static ENBGACDEBPI<APPBJBEGGDM> BGONADHNLCJ<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<APPBJBEGGDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3106F40", Offset = "0x3105B40", VA = "0x183106F40")]
	public static ENBGACDEBPI<APPBJBEGGDM> BGONADHNLCJ<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<APPBJBEGGDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3106FB0", Offset = "0x3105BB0", VA = "0x183106FB0")]
	public static ENBGACDEBPI<APPBJBEGGDM> BGONADHNLCJ<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<APPBJBEGGDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3106DF0", Offset = "0x31059F0", VA = "0x183106DF0")]
	public static ENBGACDEBPI<MHPCJABLLBH> AFPODEKLFGJ<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<MHPCJABLLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3106E60", Offset = "0x3105A60", VA = "0x183106E60")]
	public static ENBGACDEBPI<MHPCJABLLBH> AFPODEKLFGJ<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<MHPCJABLLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31073C0", Offset = "0x3105FC0", VA = "0x1831073C0")]
	public static ENBGACDEBPI<MFILLNOKJPM> GIAJNGNONEP<M>(this EMOAAMIFIJJ<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE)
	{
		return default(ENBGACDEBPI<MFILLNOKJPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NHJKBMJFGDM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25359D0", Offset = "0x25345D0", VA = "0x1825359D0")]
	public static void GHDCEPPCIMC(this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, GJKMACPKIMD MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2535960", Offset = "0x2534560", VA = "0x182535960")]
	public static void GHDCEPPCIMC(this byte[] FOLLKKLPOMJ, int OLHKKFMKCPE, GJKMACPKIMD MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25358E0", Offset = "0x25344E0", VA = "0x1825358E0")]
	public static void GHDCEPPCIMC([In] this Span<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, GJKMACPKIMD MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34DFEB0", Offset = "0x34DEAB0", VA = "0x1834DFEB0")]
	public static void GHDCEPPCIMC<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, GJKMACPKIMD MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34E0050", Offset = "0x34DEC50", VA = "0x1834E0050")]
	public static void GHDCEPPCIMC<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, GJKMACPKIMD MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x252F5F0", Offset = "0x252E1F0", VA = "0x18252F5F0")]
	public static void MANAMHMJBFF(this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2535A90", Offset = "0x2534690", VA = "0x182535A90")]
	public static void MANAMHMJBFF(this byte[] FOLLKKLPOMJ, int OLHKKFMKCPE, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2535B10", Offset = "0x2534710", VA = "0x182535B10")]
	public static void MANAMHMJBFF([In] this Span<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34E01F0", Offset = "0x34DEDF0", VA = "0x1834E01F0")]
	public static void MANAMHMJBFF<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34E0250", Offset = "0x34DEE50", VA = "0x1834E0250")]
	public static void MANAMHMJBFF<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2535830", Offset = "0x2534430", VA = "0x182535830")]
	public static void AGPOJAGCFCF(this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34DFD50", Offset = "0x34DE950", VA = "0x1834DFD50")]
	public static void AGPOJAGCFCF<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34DFDB0", Offset = "0x34DE9B0", VA = "0x1834DFDB0")]
	public static void AGPOJAGCFCF<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2535870", Offset = "0x2534470", VA = "0x182535870")]
	public static void DJDDNNMNIPH(this OACMJNHPIGJ<byte> FOLLKKLPOMJ, int OLHKKFMKCPE, byte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34DFE60", Offset = "0x34DEA60", VA = "0x1834DFE60")]
	public static void DJDDNNMNIPH<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, byte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34DFE10", Offset = "0x34DEA10", VA = "0x1834DFE10")]
	public static void DJDDNNMNIPH<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, byte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3169750", Offset = "0x3168350", VA = "0x183169750")]
	public static void LFDONILMIHO<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3169750", Offset = "0x3168350", VA = "0x183169750")]
	public static void LFDONILMIHO<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3169750", Offset = "0x3168350", VA = "0x183169750")]
	public static void MGILNKMPKKL<M>(this HKEHJPOMAJA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, ENBGACDEBPI<APPBJBEGGDM> MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3169750", Offset = "0x3168350", VA = "0x183169750")]
	public static void MGILNKMPKKL<M>([In] this JIIAGNOANKA<M, byte> FOLLKKLPOMJ, ENBGACDEBPI<M> OLHKKFMKCPE, ENBGACDEBPI<APPBJBEGGDM> MPDLOLIOGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ALBLJHEOHLO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2531D40", Offset = "0x2530940", VA = "0x182531D40")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) FBKHHPEEFGH(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2532790", Offset = "0x2531390", VA = "0x182532790")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) GFOPIEPBNKA(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25314A0", Offset = "0x25300A0", VA = "0x1825314A0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) DKCPOIMNMDL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2531BE0", Offset = "0x25307E0", VA = "0x182531BE0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) FBJFBFABEPK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2530660", Offset = "0x252F260", VA = "0x182530660")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) BMLKLEDBCFN(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25315C0", Offset = "0x25301C0", VA = "0x1825315C0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) ECKPEBMENLI(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2532100", Offset = "0x2530D00", VA = "0x182532100")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) FFCHNNCJKHJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25301C0", Offset = "0x252EDC0", VA = "0x1825301C0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) BFIIGMGCBKJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2532A40", Offset = "0x2531640", VA = "0x182532A40")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) GPKBKKFADHK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2530310", Offset = "0x252EF10", VA = "0x182530310")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>) BGHOGDKHINK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? MPDLOLIOGJL, [Optional] ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? LDCOHLCNMBH)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2530420", Offset = "0x252F020", VA = "0x182530420")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>) BILEOGAGJCP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? MPDLOLIOGJL, [Optional] ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? LDCOHLCNMBH)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2531390", Offset = "0x252FF90", VA = "0x182531390")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>) DIJHNHPOEOE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? MPDLOLIOGJL, [Optional] ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? LDCOHLCNMBH)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2533F00", Offset = "0x2532B00", VA = "0x182533F00")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>) KMPDNLOPBFJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? MPDLOLIOGJL, [Optional] ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? LDCOHLCNMBH)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2532260", Offset = "0x2530E60", VA = "0x182532260")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<MHPCJABLLBH>>) FJBCPONCDIB(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? IMDKJCAMONF, [Optional] ENBGACDEBPI<MHPCJABLLBH>? ONHFNCNDFHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<MHPCJABLLBH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2531280", Offset = "0x252FE80", VA = "0x182531280")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MHPCJABLLBH>>>) DHMHNCDFAJL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? IMDKJCAMONF, [Optional] ENBGACDEBPI<FFOBBLBAKLA<MHPCJABLLBH>>? ONHFNCNDFHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MHPCJABLLBH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2532CC0", Offset = "0x25318C0", VA = "0x182532CC0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<APPBJBEGGDM>>) HFOJJHHFIND(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? IMDKJCAMONF, [Optional] ENBGACDEBPI<APPBJBEGGDM>? ONHFNCNDFHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<APPBJBEGGDM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25332B0", Offset = "0x2531EB0", VA = "0x1825332B0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<APPBJBEGGDM>>>) INGJFKFIOJE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? IMDKJCAMONF, [Optional] ENBGACDEBPI<FFOBBLBAKLA<APPBJBEGGDM>>? ONHFNCNDFHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<APPBJBEGGDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AC34E0", Offset = "0x3AC20E0", VA = "0x183AC34E0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>) BNNELJNGJCA<TMarker>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<MFILLNOKJPM>? ONHFNCNDFHG, [Optional][In] ReadOnlySpan<byte> LLDJIJICLJF)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2531AB0", Offset = "0x25306B0", VA = "0x182531AB0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) EMLOHMCGPGG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int POLACNBCNMG, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? LDFAIJKGKCP)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2530E00", Offset = "0x252FA00", VA = "0x182530E00")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CGJPADBADHK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? POLACNBCNMG, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? LDFAIJKGKCP)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3830", Offset = "0x3AC2430", VA = "0x183AC3830")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>) GLEJANCNCMG<TMarker>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<TMarker>>? LDFAIJKGKCP, [Optional] int? FJJGAGKDECJ, [Optional][In] ReadOnlySpan<byte> POLACNBCNMG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3AC36E0", Offset = "0x3AC22E0", VA = "0x183AC36E0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>) EKHIHJAKDGD<TMarker>(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<TMarker>>? POLACNBCNMG, [Optional] ENBGACDEBPI<FFOBBLBAKLA<TMarker>>? LDFAIJKGKCP, [Optional] int? FJJGAGKDECJ)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<TMarker>>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25333C0", Offset = "0x2531FC0", VA = "0x1825333C0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) IPMPKAFPNNG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25335C0", Offset = "0x25321C0", VA = "0x1825335C0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) JGCEFAMEBEP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2531030", Offset = "0x252FC30", VA = "0x182531030")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) CKDOHGPHAOL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2530A20", Offset = "0x252F620", VA = "0x182530A20")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CCODBNEJMAK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2534410", Offset = "0x2533010", VA = "0x182534410")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) MBFHODJCBDC(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x252F770", Offset = "0x252E370", VA = "0x18252F770")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) ABCLMEMKJKP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2532B60", Offset = "0x2531760", VA = "0x182532B60")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) HDPPKHKHPAA(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2531FB0", Offset = "0x2530BB0", VA = "0x182531FB0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) FCJGBHINFNJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25339A0", Offset = "0x25325A0", VA = "0x1825339A0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) KFKBFOKGIBG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2531EC0", Offset = "0x2530AC0", VA = "0x182531EC0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>) FBMBGBEDOKH(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? OCHJAMBAGOA)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x252FB20", Offset = "0x252E720", VA = "0x18252FB20")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) APKJAAIJHKL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2533840", Offset = "0x2532440", VA = "0x182533840")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) KDCGDADIJCD(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2531150", Offset = "0x252FD50", VA = "0x182531150")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) DCIEOKBDIAI(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2531800", Offset = "0x2530400", VA = "0x182531800")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) EFJMEBJJFMC(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2532E60", Offset = "0x2531A60", VA = "0x182532E60")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) HGMOOBEHLKP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2530540", Offset = "0x252F140", VA = "0x182530540")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) BJECGJENEFP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2534560", Offset = "0x2533160", VA = "0x182534560")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) OBLAKHHFFDO(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25346E0", Offset = "0x25332E0", VA = "0x1825346E0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) OCIGEANHOKG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x252F9F0", Offset = "0x252E5F0", VA = "0x18252F9F0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) AOCOHKBNBOF(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2533C20", Offset = "0x2532820", VA = "0x182533C20")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) KKDHPGFDAHK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2534020", Offset = "0x2532C20", VA = "0x182534020")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) LGJCIIFNODE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25316E0", Offset = "0x25302E0", VA = "0x1825316E0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) EECONAPFGLK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2532FB0", Offset = "0x2531BB0", VA = "0x182532FB0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) HOBEPELLLEL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25307B0", Offset = "0x252F3B0", VA = "0x1825307B0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CAHCKHLGCNG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2530B80", Offset = "0x252F780", VA = "0x182530B80")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CEMOBJDIMGF(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25328E0", Offset = "0x25314E0", VA = "0x1825328E0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) GOAIDEGBMCJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2534BD0", Offset = "0x25337D0", VA = "0x182534BD0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) PDEGLGIHBNC(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2534840", Offset = "0x2533440", VA = "0x182534840")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) OCLGDMEPAGE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2533130", Offset = "0x2531D30", VA = "0x182533130")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) IMKPOKHAIOP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2533AC0", Offset = "0x25326C0", VA = "0x182533AC0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) KJAMLNLNECG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2533710", Offset = "0x2532310", VA = "0x182533710")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) KBLOJDJOKFJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2534D20", Offset = "0x2533920", VA = "0x182534D20")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) PFKCKBDLOEL(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x252FDC0", Offset = "0x252E9C0", VA = "0x18252FDC0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) BAOBDOMMJHF(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2532400", Offset = "0x2531000", VA = "0x182532400")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) FLGKANNDHFO(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2533D80", Offset = "0x2532980", VA = "0x182533D80")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) KMFLGNEHADM(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2530CB0", Offset = "0x252F8B0", VA = "0x182530CB0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) CGBIIJEJPIA(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x25342F0", Offset = "0x2532EF0", VA = "0x1825342F0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) LPCKOCGEJPM(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x252F890", Offset = "0x252E490", VA = "0x18252F890")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) ANODANKADGB(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2534960", Offset = "0x2533560", VA = "0x182534960")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) ONHGHPKLNBK(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2530F10", Offset = "0x252FB10", VA = "0x182530F10")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CIPGDCFBDIC(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2530910", Offset = "0x252F510", VA = "0x182530910")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) CBIIAAIIPEJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] int? CIDGHPGIAPG, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x252F660", Offset = "0x252E260", VA = "0x18252F660")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) AAIJIEPEEMF(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? CIDGHPGIAPG, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2533540", Offset = "0x2532140", VA = "0x182533540")]
	public static ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> JDMBLHOKKLF(this OACMJNHPIGJ<byte> DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2534170", Offset = "0x2532D70", VA = "0x182534170")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) LHDBNMGFIHP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x252FF10", Offset = "0x252EB10", VA = "0x18252FF10")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) BCFAEKLGGKD(this OACMJNHPIGJ<byte> DKGDAEBOJKO, float NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FIDGNHIADCJ>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x252FCA0", Offset = "0x252E8A0", VA = "0x18252FCA0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>) BALLPDBDINE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<FIDGNHIADCJ>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<FIDGNHIADCJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2530060", Offset = "0x252EC60", VA = "0x182530060")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) BEPBALKCJEH(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2532640", Offset = "0x2531240", VA = "0x182532640")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) GBHHOHINJGE(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2534AB0", Offset = "0x25336B0", VA = "0x182534AB0")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) PBCDGJENIOG(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2534E80", Offset = "0x2533A80", VA = "0x182534E80")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) PPHCDDGCEKH(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2531960", Offset = "0x2530560", VA = "0x182531960")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) EFNKPHDLPCJ(this OACMJNHPIGJ<byte> DKGDAEBOJKO, int NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2532520", Offset = "0x2531120", VA = "0x182532520")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>) FNNKFFPKILP(this OACMJNHPIGJ<byte> DKGDAEBOJKO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? NFOAEGAEIHO, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? KHFMJJLPPNM, [Optional] ENBGACDEBPI<FFOBBLBAKLA<DCHNPJGMAPI>>? FIMILAMCBHG)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<DCHNPJGMAPI>>>));
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
