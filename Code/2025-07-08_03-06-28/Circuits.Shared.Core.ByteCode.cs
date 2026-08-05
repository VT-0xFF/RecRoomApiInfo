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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BFD10", Offset = "0x29BEB10", VA = "0x1829BFD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCLJGEBPMMD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3936570", Offset = "0x3935370", VA = "0x183936570")]
	public static HBBCPCNIOON<JDDKNNOFDCE<M>> OBGKAHLIHBP<M>(this int FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29BF370", Offset = "0x29BE170", VA = "0x1829BF370")]
	public static HBBCPCNIOON<DNHAKBEOBHF> JJOBIFPMDCF(this int FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<DNHAKBEOBHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3936570", Offset = "0x3935370", VA = "0x183936570")]
	public static HBBCPCNIOON<NNNCHCBIJGL<M>> FAGPJDGKMAO<M>(this int FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<NNNCHCBIJGL<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JDDKNNOFDCE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CAIEKJCAHFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EJCLCGIGHHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DNHAKBEOBHF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class POGJONOCEFB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IMICGCEDFBF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum MOLCEHMKCID
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
public static class IFEPOBAJBDM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OGDAMIHFNAE<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr LCGHKMEBHNE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
		public OGDAMIHFNAE(IntPtr HJPGLGOFFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58577D0", Offset = "0x58565D0", VA = "0x1858577D0")]
		public int BOBFGEKALDJ(TDeps FEBHHEFFJMB, TContext JACKFIDBPJG, TCompileState KEKIAHEEDKM, [In] OJAIHBKPJPA<byte> EBNIOOKBOHL, int ILCFCFOGKMI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3620", Offset = "0x3BC2420", VA = "0x183BC3620")]
	public static void CEFNMIEPALL<TDeps, TContext, TCompileState>(TDeps FEBHHEFFJMB, TContext JACKFIDBPJG, TCompileState KEKIAHEEDKM, [In] OJAIHBKPJPA<byte> BPGLABIFFBC, OJAIHBKPJPA<byte> JJICFKFHGIF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MHEBMNHHJNH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JJMCCBAEANI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HJIKIMIEKLG, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CIFCINMEDNL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OJJOIDFKALJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EIKJCOAMJAD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? FIDDIFAGELD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HLGJGPBHOCB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PPDOCENBJCD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DGLOHIFLNNM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BLEABJCIDOI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NCLCKDCDALF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HDNHPDIHAMK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MBHMHEKHLFG, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MHJEMFJCENK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MOJAOHAFNAI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CAMPODNCILG, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? FDHGPICPJPL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EHFGHJHBLJP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LNCJPFMCLIC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PHNFJJOEAFN, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DOPEIAEFAPD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MNFBPAIGCJJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? KGEOGGKLAEI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MBBBAGHKHIL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OEHLOIGMCPC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PJGPJIICPHJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EAJLNBALPFC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ALDPJHOCOJH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GILKEOIECMG, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PKIDJLICBAD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NPNLGPHHING, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IGDHJBCLPIJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NHJKAILJCKB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OLAODFBAMGB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? FOHCJFIKOIH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CKIMHKFDOKJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JAACEEDBMNJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ALKCELFODBE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LMFKNLPCNDH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GJKJCKOHLFP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DMFNIBGHBLM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MCPMBKLLAIP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CGBBIHIILKE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GPLCKGLBGOK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BKNJBAGMKKM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ELCPPDGPNPD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MMHEOHCDPNL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OEAIJAGMGLH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IPPGGHDIDMO, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HBKNMOHFBMC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LLHEBFFGLEP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HELFHEPEOBN, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DNMELABPEKD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HDDMABJODJI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DFHEILCABAF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BHAGBPOCECK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LDEMADMHCKF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DHOMIKPBBPE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IONDBAIOLIB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DPCBMIAHLHE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DJJCBMDLGOK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MNDJOCKEGBL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OIPEMBIDEGP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CNOFBHHMHJB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? AMEKAAJPFHI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GCIOEEBNEGH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EDCAGJDJHOI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HFIPIINJIIK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DIEGCFCCBFD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OOLHEBOBELM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? KGAIDODFEIO, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IFNOIFGIHCP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? AHPKGNCICFA, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HCDFLKHBGAJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MBMIDLOEMEJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EOJKHMNHMDA, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CDGGDAHOHJB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? OKBEHBKEAHM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JDAKJIABNBL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HEHFIGJOEPM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MNDCFMGBPDK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LOJNOKJJMOL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MIICOIFFBIK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IFCAKAMFFAE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? AMLBIKJKMFO, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ONGNJOPFAJC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BDIIJOBAPNF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GHJICOLIIOJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PCOHELAJNKF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NBBAPCAFDIE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? AEFPNIPLCOD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JLIOIGAHLMD, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JPAOPAEAJHA, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HODHJABFAMM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BAOLLIPKKPH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? KNFPHPPAAHM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GBGCAHHNALC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JALNOHJHAPO, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BLMLMBMPCIF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HEDHJIKGELE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JLIJEBNEMIB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LHLHGGAICGM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CJNAJOFOALI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? GPMFMMOEEAJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? BJPODIGJOEL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JCKBGLMHBAL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CLENOKBJIOF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? KMMKKKJMNBI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LKIANNNFMPE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LPOMAAHJNDI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MOPFGHHOCNF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NJCOFGKFHLH, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ENFMNFFPHMA, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JBNBGPMDDMF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EOLFAOMFHDP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DMBADOAOALK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? IEKJKFNPMJE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PBLOAIKGGBM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CKFCCKFDPLE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? KBICOODOEDE, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? HKHPIJBLGFM, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? CGJENCAPKFP, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ANIJCHEIMOO, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? EILNAMHGDPI, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? DFGJJJDNHAL, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ILKIJOAHOOJ, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? NFGLNHIMECN, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PBKMKIILKDB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PNPCFHLHJCF, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? ALAGBMGGJGK, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? JKIMLJIBJMB, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? LKOBFLGMKEC, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? MHKIIHFGNML, [Optional] OGDAMIHFNAE<TContext, TDeps, TCompileState>? PHKDOJHAADA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29BF2D0", Offset = "0x29BE0D0", VA = "0x1829BF2D0")]
	private static int BBOAIEDLJML([In] OJAIHBKPJPA<byte> BDNOGLGKMMF, OJAIHBKPJPA<byte> BHIDIDEELPL, int DKBLEPBOJIC, int LJEIHABMGGI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NCGCCILAILA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int NCILNLMBNBJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D00330", Offset = "0x3CFF130", VA = "0x183D00330")]
	public static HBBCPCNIOON<JDDKNNOFDCE<T>> MCEKEIBMPIK<T>([In] this OJAIHBKPJPA<byte> FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D00380", Offset = "0x3CFF180", VA = "0x183D00380")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<T>>> PJJFLKGEIEF<T>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<JDDKNNOFDCE<T>>? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29BF490", Offset = "0x29BE290", VA = "0x1829BF490")]
	public static HBBCPCNIOON<JDDKNNOFDCE<GOOCMPIBMLE>> EPKEHONGOKI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<GOOCMPIBMLE>? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<GOOCMPIBMLE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x29BF700", Offset = "0x29BE500", VA = "0x1829BF700")]
	public static HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>> KAHLHOFMBDC(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] float? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29BF7D0", Offset = "0x29BE5D0", VA = "0x1829BF7D0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>> KKAIJAFGOPI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29BF630", Offset = "0x29BE430", VA = "0x1829BF630")]
	public static HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>> IOAIDEIPDHH(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<OLOEGFAPHEG>? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x29BF3A0", Offset = "0x29BE1A0", VA = "0x1829BF3A0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<IMICGCEDFBF>> CDHAECBNHOG(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] byte? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<IMICGCEDFBF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29BF8A0", Offset = "0x29BE6A0", VA = "0x1829BF8A0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<DNHAKBEOBHF>> OPMHAEJLLMJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<DNHAKBEOBHF>? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<DNHAKBEOBHF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29BF560", Offset = "0x29BE360", VA = "0x1829BF560")]
	public static HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> IGKJKCEJEFP(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] MOLCEHMKCID? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D00270", Offset = "0x3CFF070", VA = "0x183D00270")]
	public static HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<T>>> KACNFIIENDE<T>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<T>>? BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29B9860", Offset = "0x29B8660", VA = "0x1829B9860")]
	public static void OIMPPJNKIHH(this OJAIHBKPJPA<byte> FEOFEEGOGIO, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>> ILOECKNHFEF, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D00260", Offset = "0x3CFF060", VA = "0x183D00260")]
	public static void FFCODEEEMIF<T>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<T>>> ILCFCFOGKMI, HBBCPCNIOON<JDDKNNOFDCE<T>> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D00260", Offset = "0x3CFF060", VA = "0x183D00260")]
	public static void LICBMOFLGBD<T>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<T>>> LCHGMLILIIA, HBBCPCNIOON<NNNCHCBIJGL<T>> BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OMKBLHHMKDO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x29BFE30", Offset = "0x29BEC30", VA = "0x1829BFE30")]
	public static PDLHEEOINJI DGOONBLKEFC([In] this ReadOnlySpan<byte> JMAPKDPGDHP, int GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29BFD90", Offset = "0x29BEB90", VA = "0x1829BFD90")]
	public static PDLHEEOINJI DGOONBLKEFC([In] this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A730", Offset = "0x3D39530", VA = "0x183D3A730")]
	public static PDLHEEOINJI DGOONBLKEFC<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A840", Offset = "0x3D39640", VA = "0x183D3A840")]
	public static PDLHEEOINJI DGOONBLKEFC<M>([In] this EEHMBCMCCDF<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A950", Offset = "0x3D39750", VA = "0x183D3A950")]
	public static PDLHEEOINJI DGOONBLKEFC<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A6D0", Offset = "0x3D394D0", VA = "0x183D3A6D0")]
	public static PDLHEEOINJI DGOONBLKEFC<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A9A0", Offset = "0x3D397A0", VA = "0x183D3A9A0")]
	public static PDLHEEOINJI DGOONBLKEFC<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29BFE30", Offset = "0x29BEC30", VA = "0x1829BFE30")]
	public static int NLGKDCNKOBM([In] this ReadOnlySpan<byte> JMAPKDPGDHP, int GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29B9940", Offset = "0x29B8740", VA = "0x1829B9940")]
	public static int NLGKDCNKOBM([In] this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3934B30", Offset = "0x3933930", VA = "0x183934B30")]
	public static int NLGKDCNKOBM<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3934B30", Offset = "0x3933930", VA = "0x183934B30")]
	public static int NLGKDCNKOBM<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3934B30", Offset = "0x3933930", VA = "0x183934B30")]
	public static int NLGKDCNKOBM<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3934B30", Offset = "0x3933930", VA = "0x183934B30")]
	public static int NLGKDCNKOBM<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ABF0", Offset = "0x3D399F0", VA = "0x183D3ABF0")]
	public static float MMDLHNMGOAM<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ABF0", Offset = "0x3D399F0", VA = "0x183D3ABF0")]
	public static float MMDLHNMGOAM<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ABF0", Offset = "0x3D399F0", VA = "0x183D3ABF0")]
	public static float MMDLHNMGOAM<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AD60", Offset = "0x3D39B60", VA = "0x183D3AD60")]
	public static byte OJNLPJKECHK<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ACD0", Offset = "0x3D39AD0", VA = "0x183D3ACD0")]
	public static byte OJNLPJKECHK<M>([In] this EEHMBCMCCDF<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A950", Offset = "0x3D39750", VA = "0x183D3A950")]
	public static byte OJNLPJKECHK<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A6D0", Offset = "0x3D394D0", VA = "0x183D3A6D0")]
	public static byte OJNLPJKECHK<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ACF0", Offset = "0x3D39AF0", VA = "0x183D3ACF0")]
	public static byte OJNLPJKECHK<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29B9940", Offset = "0x29B8740", VA = "0x1829B9940")]
	public static MOLCEHMKCID EKGCBPDDALK([In] this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND)
	{
		return default(MOLCEHMKCID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3934B30", Offset = "0x3933930", VA = "0x183934B30")]
	public static MOLCEHMKCID EKGCBPDDALK<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(MOLCEHMKCID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AA70", Offset = "0x3D39870", VA = "0x183D3AA70")]
	public static HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> IFFFBCJIEDE<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AAD0", Offset = "0x3D398D0", VA = "0x183D3AAD0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> IFFFBCJIEDE<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AB30", Offset = "0x3D39930", VA = "0x183D3AB30")]
	public static HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> IFFFBCJIEDE<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AA10", Offset = "0x3D39810", VA = "0x183D3AA10")]
	public static HBBCPCNIOON<NNNCHCBIJGL<CMJJGMNNMIB>> GPGJGDGBJEN<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<NNNCHCBIJGL<CMJJGMNNMIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A670", Offset = "0x3D39470", VA = "0x183D3A670")]
	public static HBBCPCNIOON<DNHAKBEOBHF> BJKEAFAOLLF<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<DNHAKBEOBHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A5B0", Offset = "0x3D393B0", VA = "0x183D3A5B0")]
	public static HBBCPCNIOON<DNHAKBEOBHF> BJKEAFAOLLF<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<DNHAKBEOBHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A610", Offset = "0x3D39410", VA = "0x183D3A610")]
	public static HBBCPCNIOON<DNHAKBEOBHF> BJKEAFAOLLF<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<DNHAKBEOBHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AC10", Offset = "0x3D39A10", VA = "0x183D3AC10")]
	public static HBBCPCNIOON<GOOCMPIBMLE> OBHCJJHMHHM<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<GOOCMPIBMLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AC70", Offset = "0x3D39A70", VA = "0x183D3AC70")]
	public static HBBCPCNIOON<GOOCMPIBMLE> OBHCJJHMHHM<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<GOOCMPIBMLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AB90", Offset = "0x3D39990", VA = "0x183D3AB90")]
	public static HBBCPCNIOON<OLOEGFAPHEG> MKCNAELFJIK<M>(this IBOHFPGOOJJ<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND)
	{
		return default(HBBCPCNIOON<OLOEGFAPHEG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NDPOHDBPALD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29BFB10", Offset = "0x29BE910", VA = "0x1829BFB10")]
	public static void BAGDIEEPLDP(this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND, PDLHEEOINJI BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29BFAA0", Offset = "0x29BE8A0", VA = "0x1829BFAA0")]
	public static void BAGDIEEPLDP(this byte[] JMAPKDPGDHP, int GJENNMCNOND, PDLHEEOINJI BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29BFA20", Offset = "0x29BE820", VA = "0x1829BFA20")]
	public static void BAGDIEEPLDP([In] this Span<byte> JMAPKDPGDHP, int GJENNMCNOND, PDLHEEOINJI BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D009B0", Offset = "0x3CFF7B0", VA = "0x183D009B0")]
	public static void BAGDIEEPLDP<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, PDLHEEOINJI BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D00AA0", Offset = "0x3CFF8A0", VA = "0x183D00AA0")]
	public static void BAGDIEEPLDP<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, PDLHEEOINJI BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29B9860", Offset = "0x29B8660", VA = "0x1829B9860")]
	public static void OIMPPJNKIHH(this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29BFC90", Offset = "0x29BEA90", VA = "0x1829BFC90")]
	public static void OIMPPJNKIHH(this byte[] JMAPKDPGDHP, int GJENNMCNOND, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29BFC10", Offset = "0x29BEA10", VA = "0x1829BFC10")]
	public static void OIMPPJNKIHH([In] this Span<byte> JMAPKDPGDHP, int GJENNMCNOND, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D00C80", Offset = "0x3CFFA80", VA = "0x183D00C80")]
	public static void OIMPPJNKIHH<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D00C30", Offset = "0x3CFFA30", VA = "0x183D00C30")]
	public static void OIMPPJNKIHH<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29BFBD0", Offset = "0x29BE9D0", VA = "0x1829BFBD0")]
	public static void JMHIFHJBJJG(this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D00B90", Offset = "0x3CFF990", VA = "0x183D00B90")]
	public static void JMHIFHJBJJG<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D00BE0", Offset = "0x3CFF9E0", VA = "0x183D00BE0")]
	public static void JMHIFHJBJJG<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x29BF9B0", Offset = "0x29BE7B0", VA = "0x1829BF9B0")]
	public static void ANCIJLEHMFC(this OJAIHBKPJPA<byte> JMAPKDPGDHP, int GJENNMCNOND, byte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D00950", Offset = "0x3CFF750", VA = "0x183D00950")]
	public static void ANCIJLEHMFC<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, byte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D00980", Offset = "0x3CFF780", VA = "0x183D00980")]
	public static void ANCIJLEHMFC<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, byte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39360E0", Offset = "0x3934EE0", VA = "0x1839360E0")]
	public static void FFCODEEEMIF<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x39360E0", Offset = "0x3934EE0", VA = "0x1839360E0")]
	public static void FFCODEEEMIF<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x39360E0", Offset = "0x3934EE0", VA = "0x1839360E0")]
	public static void JACDBHLJCAO<M>(this NEDDAHKAHLH<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, HBBCPCNIOON<DNHAKBEOBHF> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39360E0", Offset = "0x3934EE0", VA = "0x1839360E0")]
	public static void JACDBHLJCAO<M>([In] this GKFIIGKMHKL<M, byte> JMAPKDPGDHP, HBBCPCNIOON<M> GJENNMCNOND, HBBCPCNIOON<DNHAKBEOBHF> BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HBGJNPNCFEH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29BB0D0", Offset = "0x29B9ED0", VA = "0x1829BB0D0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) EBPEGNPOJIB(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29BBEC0", Offset = "0x29BACC0", VA = "0x1829BBEC0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) GAJLAMDFIEL(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29BDBA0", Offset = "0x29BC9A0", VA = "0x1829BDBA0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) KPAEKELLKDM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29BE320", Offset = "0x29BD120", VA = "0x1829BE320")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) MDPOGKBADHN(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29BEAB0", Offset = "0x29BD8B0", VA = "0x1829BEAB0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) ONJPBALLJFF(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29BA620", Offset = "0x29B9420", VA = "0x1829BA620")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) CHCDOCBOPNC(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29BE7F0", Offset = "0x29BD5F0", VA = "0x1829BE7F0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) OFBKIDFJLAO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29BBD70", Offset = "0x29BAB70", VA = "0x1829BBD70")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) FOIAIMPMJFI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29BC830", Offset = "0x29BB630", VA = "0x1829BC830")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) ICMNOELFAHA(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29BC010", Offset = "0x29BAE10", VA = "0x1829BC010")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>) GCAAACEGMNB(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? BNECONOIKOE, [Optional] HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? HKGNJIJFLFE)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29BE480", Offset = "0x29BD280", VA = "0x1829BE480")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>) MOEDLLHEPMP(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BNECONOIKOE, [Optional] HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? HKGNJIJFLFE)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29BC120", Offset = "0x29BAF20", VA = "0x1829BC120")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>) GLDACLABBBN(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? BNECONOIKOE, [Optional] HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? HKGNJIJFLFE)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29BBC50", Offset = "0x29BAA50", VA = "0x1829BBC50")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>) FNLKJAAFNFO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BNECONOIKOE, [Optional] HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? HKGNJIJFLFE)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29BB9A0", Offset = "0x29BA7A0", VA = "0x1829BB9A0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<GOOCMPIBMLE>>) FJBJNPEACDE(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? PBIDOLNFLJC, [Optional] HBBCPCNIOON<GOOCMPIBMLE>? FAMNJGOAPBK)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<GOOCMPIBMLE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29BDE10", Offset = "0x29BCC10", VA = "0x1829BDE10")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<GOOCMPIBMLE>>>) LCMKPLLMMJH(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? PBIDOLNFLJC, [Optional] HBBCPCNIOON<NNNCHCBIJGL<GOOCMPIBMLE>>? FAMNJGOAPBK)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<GOOCMPIBMLE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29BA740", Offset = "0x29B9540", VA = "0x1829BA740")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<DNHAKBEOBHF>>) CHLPDPKIKDF(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? PBIDOLNFLJC, [Optional] HBBCPCNIOON<DNHAKBEOBHF>? FAMNJGOAPBK)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<DNHAKBEOBHF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29BD930", Offset = "0x29BC730", VA = "0x1829BD930")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<DNHAKBEOBHF>>>) KIFHFDMGOIK(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? PBIDOLNFLJC, [Optional] HBBCPCNIOON<NNNCHCBIJGL<DNHAKBEOBHF>>? FAMNJGOAPBK)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<DNHAKBEOBHF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B99200", Offset = "0x3B98000", VA = "0x183B99200")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>) PIOPEHHNCNI<TMarker>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<OLOEGFAPHEG>? FAMNJGOAPBK, [Optional][In] ReadOnlySpan<byte> BOIPFNOKGBJ)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29BED80", Offset = "0x29BDB80", VA = "0x1829BED80")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) OOMEIINLAIB(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int BDNOGLGKMMF, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BHIDIDEELPL)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29BB760", Offset = "0x29BA560", VA = "0x1829BB760")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) EMEIBDFHHGE(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BDNOGLGKMMF, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BHIDIDEELPL)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B99020", Offset = "0x3B97E20", VA = "0x183B99020")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>) DKHNAMAODEJ<TMarker>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<TMarker>>? BHIDIDEELPL, [Optional] int? DFCCCGNJINK, [Optional][In] ReadOnlySpan<byte> BDNOGLGKMMF)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3B993F0", Offset = "0x3B981F0", VA = "0x183B993F0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>) PLIKFLNODHN<TMarker>(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<TMarker>>? BDNOGLGKMMF, [Optional] HBBCPCNIOON<NNNCHCBIJGL<TMarker>>? BHIDIDEELPL, [Optional] int? DFCCCGNJINK)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<TMarker>>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29BB250", Offset = "0x29BA050", VA = "0x1829BB250")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) EGNDEFOMJIL(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29BCAB0", Offset = "0x29BB8B0", VA = "0x1829BCAB0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) INBAIKEMIML(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29BB3D0", Offset = "0x29BA1D0", VA = "0x1829BB3D0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) EKNPIIMFDHM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29BC650", Offset = "0x29BB450", VA = "0x1829BC650")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) HGCLMGANEGF(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29BAE20", Offset = "0x29B9C20", VA = "0x1829BAE20")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) DLDLNCDEMOG(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29BAD00", Offset = "0x29B9B00", VA = "0x1829BAD00")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) DJNKMNMIAPO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29BC230", Offset = "0x29BB030", VA = "0x1829BC230")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) GLIHKIELJMP(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29BB4F0", Offset = "0x29BA2F0", VA = "0x1829BB4F0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) ELHADGKEFEO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29B9E10", Offset = "0x29B8C10", VA = "0x1829B9E10")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) BGHINBCOPPG(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x29BE700", Offset = "0x29BD500", VA = "0x1829BE700")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>) NCPLBJEPOPK(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? LIHIGLNIPMD)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x29BAA60", Offset = "0x29B9860", VA = "0x1829BAA60")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) DCNDIHHGOMD(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x29BDA40", Offset = "0x29BC840", VA = "0x1829BDA40")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) KNMCKLFCHEO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x29BD6E0", Offset = "0x29BC4E0", VA = "0x1829BD6E0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) KBHONDOOOCJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x29BE070", Offset = "0x29BCE70", VA = "0x1829BE070")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) LJOBNCAMCGI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29BCED0", Offset = "0x29BBCD0", VA = "0x1829BCED0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JCMIJOHOEPK(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29B9CF0", Offset = "0x29B8AF0", VA = "0x1829B9CF0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) BGAECNIHJNB(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29B9F30", Offset = "0x29B8D30", VA = "0x1829B9F30")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) BKHCLHBEHHI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29BA360", Offset = "0x29B9160", VA = "0x1829BA360")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) CCIOGIMMBNI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29B9BC0", Offset = "0x29B89C0", VA = "0x1829B9BC0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) AIHFIBAFKPP(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x29BC390", Offset = "0x29BB190", VA = "0x1829BC390")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) GPEBIDHIGIB(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x29B9A70", Offset = "0x29B8870", VA = "0x1829B9A70")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) AHMCAICNFKA(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x29BD020", Offset = "0x29BBE20", VA = "0x1829BD020")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JDOOFALIBFM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x29BEC00", Offset = "0x29BDA00", VA = "0x1829BEC00")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) OOEIJPJCEPF(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x29BE5A0", Offset = "0x29BD3A0", VA = "0x1829BE5A0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) NAFDGEGIEJO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x29BD260", Offset = "0x29BC060", VA = "0x1829BD260")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JGPNCDLGNLK(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x29BE950", Offset = "0x29BD750", VA = "0x1829BE950")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) OLDLGFJDCOP(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x29BDF20", Offset = "0x29BCD20", VA = "0x1829BDF20")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) LDPPPNKFLIJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x29BD390", Offset = "0x29BC190", VA = "0x1829BD390")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JIPNHCNIEDJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x29BCD50", Offset = "0x29BBB50", VA = "0x1829BCD50")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) IPFFIDOMBEK(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x29BA4C0", Offset = "0x29B92C0", VA = "0x1829BA4C0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) CGOKIGPKCLN(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x29BB870", Offset = "0x29BA670", VA = "0x1829BB870")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) FDFMGJNJIJC(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x29BA0B0", Offset = "0x29B8EB0", VA = "0x1829BA0B0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) BOPGBCCODBH(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x29BE1D0", Offset = "0x29BCFD0", VA = "0x1829BE1D0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) LPDEFDMEBCI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x29BD5C0", Offset = "0x29BC3C0", VA = "0x1829BD5C0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JOBBCEIOOIM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x29BF000", Offset = "0x29BDE00", VA = "0x1829BF000")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) PGBPCDAJOAD(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x29BDCC0", Offset = "0x29BCAC0", VA = "0x1829BDCC0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) LBNGJAPNFML(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x29BB640", Offset = "0x29BA440", VA = "0x1829BB640")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) ELLNOIDJLBA(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29BC4F0", Offset = "0x29BB2F0", VA = "0x1829BC4F0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) GPGCFJLGEOM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x29BA210", Offset = "0x29B9010", VA = "0x1829BA210")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) CBDCICHEOPI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x29BABE0", Offset = "0x29B99E0", VA = "0x1829BABE0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) DDPCCIOOPBJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x29BBB40", Offset = "0x29BA940", VA = "0x1829BBB40")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) FNCCIHDPIKO(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] int? LLJPAPGBFNP, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x29BD4B0", Offset = "0x29BC2B0", VA = "0x1829BD4B0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JJLJLKNGDED(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? LLJPAPGBFNP, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x29BC7B0", Offset = "0x29BB5B0", VA = "0x1829BC7B0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> HJDODBPBBEG(this OJAIHBKPJPA<byte> FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x29BA8E0", Offset = "0x29B96E0", VA = "0x1829BA8E0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) CIJCAILLBID(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x29BEEB0", Offset = "0x29BDCB0", VA = "0x1829BEEB0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) PCDKDNBCOAJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, float MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<CAIEKJCAHFG>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x29BD810", Offset = "0x29BC610", VA = "0x1829BD810")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>) KGBFEGNNOHN(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<CAIEKJCAHFG>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CAIEKJCAHFG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29BC950", Offset = "0x29BB750", VA = "0x1829BC950")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) IKJHCGLICAI(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x29BF180", Offset = "0x29BDF80", VA = "0x1829BF180")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) POFAOACBJBJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x29B9950", Offset = "0x29B8750", VA = "0x1829B9950")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) ACHDGLBFIJH(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29BAF70", Offset = "0x29B9D70", VA = "0x1829BAF70")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) DLIGHIOJOMM(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x29BCC00", Offset = "0x29BBA00", VA = "0x1829BCC00")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) INIPOIJIJFG(this OJAIHBKPJPA<byte> FEOFEEGOGIO, int MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x29BD140", Offset = "0x29BBF40", VA = "0x1829BD140")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>) JGPKICKGGMJ(this OJAIHBKPJPA<byte> FEOFEEGOGIO, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? MKJOHHEOFOA, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBBEDOFING, [Optional] HBBCPCNIOON<NNNCHCBIJGL<EJCLCGIGHHB>>? BPBFBLMEHHH)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<EJCLCGIGHHB>>>));
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
