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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FDB6C0", Offset = "0x1FD9CC0", VA = "0x181FDB6C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CKJNLFGEDKF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2970930", Offset = "0x296EF30", VA = "0x182970930")]
	public static EJDMOINMPCI<ECJCCLAGCON<M>> EMIOLACOFIH<M>(this int ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5270", Offset = "0x1FD3870", VA = "0x181FD5270")]
	public static EJDMOINMPCI<OCJIFINKLKP> PIOJCIGDAMN(this int ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<OCJIFINKLKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2970930", Offset = "0x296EF30", VA = "0x182970930")]
	public static EJDMOINMPCI<KHLBCHFOACL<M>> HDOEGOIGAKF<M>(this int ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<KHLBCHFOACL<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ECJCCLAGCON<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NLDMAMCMAKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IMGOAHLFMAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OCJIFINKLKP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CGILJFKPHAP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KHJFKGOHGFN
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ECEFHEGGLNL
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
public static class FPDHKLPBEOL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LBBFIJEFPGN<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr FBBOLOGCAEG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
		public LBBFIJEFPGN(IntPtr ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x428F0B0", Offset = "0x428D6B0", VA = "0x18428F0B0")]
		public int DFDLGJKGLOI(TDeps MEELJJGMLGH, TContext AMHGNLFEGOH, TCompileState LLCILPEHNOH, [In] CDJBEBBGDPF<byte> FIMMHAKFIPI, int DOLBEAPCCEC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B5E120", Offset = "0x2B5C720", VA = "0x182B5E120")]
	public static void CNGDEGJPEOH<TDeps, TContext, TCompileState>(TDeps MEELJJGMLGH, TContext AMHGNLFEGOH, TCompileState LLCILPEHNOH, [In] CDJBEBBGDPF<byte> GCNEOPCLEMG, CDJBEBBGDPF<byte> CPCJODBALEJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LFJIJMIPIJK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NODECBBIOOJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NACIHIDOFMP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BMFMACCICHJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GKCFJNMBPAM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MAEHIKHFPAA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MEOBBBOACEP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? FLBPADFAGMF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KNDCPNMIEGK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BAJPLGOHJAK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EOPBEPCLAIA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PJNOAGKPEIL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NBKKHAMALIB, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? ALFOKLMLJCD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GMLPDEDBCCI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HJJHIENKGPA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JDIMMNDHBOM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NMENPNPNCOP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PCBJCDOIIIF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DPDDKKGLHFC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GBOGPMHGJKE, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MMGJEJMFDLO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DIOKBMGHADM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EMCCCGILHIG, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? IHDGFLIBNHO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EKCNLEEKIFJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JJFDNEOJNPL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? IGDDHPLGMNC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JJNPFJCAMFI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PGFGJEKAHBK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HGNNLELKCHO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LMLKAKDIHFI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KJNEMKGLFEL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PAOOAGEPKOL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NHOHNODEENK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? CNMGFHDNPED, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GCHCHHPJMAH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JPICENGIOIF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? CODHBAAPBKD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? FICCMEOCNFF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HLFOAEBOANK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LPHIDHAJMLD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MCAEGIMPGOP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PLBHAJIPIKD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NIPIBADCHEH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KGAMEDPHGKI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JFHNBCKCEBM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HPOFLPFAMBA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NNJMCKMFEIH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JKJMLJHEEDB, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KEFLHFGBHMI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MPADLIBDCKL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DBDAEAKMAJA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? FAKLICILMHC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DJMDKPELAIO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HHLOEHBOEAC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DIINFHBIECE, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JKCFOHOPBEF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EMJCJLHHIHB, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PIFCJNHEOFE, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DACFCCNIDKI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KKAPDGIIAJF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? ICMLIMHHCDK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KHNJJPPGLGL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OHOALHPMHPM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KKKJPEDHMJB, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DJFDAIJIOKP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JJFGBNAPAFN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KOFFDGKPMNG, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? IKEEJEGGOCK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OACPOPMIPAC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JFGAFDGGPAF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MPENFOFBJMN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PMHCNFPFEPA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? IEGHBJDFPDH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GNAKLGKPLFK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? ALOHAJPDFCL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JBLAGHGOHAN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NPNOKNHNCIF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LHHLBLPKIGM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AFFJKKFLOHG, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OBGPOJKNCOL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PABHPLEADPJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? ICAKCAIKNGK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? ICKAKBEFECP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HFBLMFHKLHC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BOJMINKOPMO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EJMMDIDCGNK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JDGOKDNFBDN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? IAPHIJJFHBE, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DAANOGNCCBO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HPOJANGIHLB, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JPPOFAJCJKD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LCCDKFMLAFC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BGGLGNGNPGK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HBAOIHPHDMO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? EDBKOGCFIEJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? CKNHAJFOIAF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KACPHAGKNAL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? MGIHIAKLOMK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AFKANHODAJM, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KCEBOGFFAEO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AGKAJPPJLGD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DECDKCELKLA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HNJPFGANLGI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NALLKGGLGNA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OLLHMKJCPFN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DAKFJNDOEJH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LHCMAAOBJBL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GNGOBIOKEGK, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OAJFCIAJPKC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KLNBFMPAHMI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OOMCJAOHNED, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? OKMGONEBLIG, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HBMHIENBGPF, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GKJOMNPGKDI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? HOELKBGMEFI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BLPEGJCHKLC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? LOOJNAOIGHL, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? NLCLCNMBFEP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? CBGIIGDICIC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AECHOHKIHPO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? PCOJKMHMEPE, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JFHBODNIFCJ, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GKEECBJAAAA, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? KKEPGJADDLC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BJABCKPJOAD, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? DKPIDAPBPBI, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JIBFENDLBGP, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? FOOGJOIOKNH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? GJHECLHHKMO, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AEHOMJBOPJC, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? AMHAKBAGJBH, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? BPEBFNPBBGN, [Optional] LBBFIJEFPGN<TContext, TDeps, TCompileState>? JIFLPLPFMGO) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5940", Offset = "0x1FD3F40", VA = "0x181FD5940")]
	private static int KMAJPLDKOCG([In] CDJBEBBGDPF<byte> ANJCAANKHOF, CDJBEBBGDPF<byte> NLDMHMGCOCL, int KKKICJLJANF, int FDDANCOAHOL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FKMEOKDKLDO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int HHNFGJNNGHE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B56730", Offset = "0x2B54D30", VA = "0x182B56730")]
	public static EJDMOINMPCI<ECJCCLAGCON<T>> EPMECKHLJKB<T>([In] this CDJBEBBGDPF<byte> ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B56860", Offset = "0x2B54E60", VA = "0x182B56860")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<T>>> NFMDKFKCFIK<T>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<ECJCCLAGCON<T>>? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5490", Offset = "0x1FD3A90", VA = "0x181FD5490")]
	public static EJDMOINMPCI<ECJCCLAGCON<LDEGJPGOKID>> DDMKCEFJEAM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<LDEGJPGOKID>? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<LDEGJPGOKID>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5650", Offset = "0x1FD3C50", VA = "0x181FD5650")]
	public static EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>> LMBHNAGFBKN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] float? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5820", Offset = "0x1FD3E20", VA = "0x181FD5820")]
	public static EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>> OCDEAOCNOOI(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5570", Offset = "0x1FD3B70", VA = "0x181FD5570")]
	public static EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>> JCBBCHGHEGF(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<EJLGKGMKJHL>? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FD52A0", Offset = "0x1FD38A0", VA = "0x181FD52A0")]
	public static EJDMOINMPCI<ECJCCLAGCON<KHJFKGOHGFN>> ABEPJMMEMCB(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] byte? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<KHJFKGOHGFN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5740", Offset = "0x1FD3D40", VA = "0x181FD5740")]
	public static EJDMOINMPCI<ECJCCLAGCON<OCJIFINKLKP>> MPAFMDFJNAH(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<OCJIFINKLKP>? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<OCJIFINKLKP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FD53A0", Offset = "0x1FD39A0", VA = "0x181FD53A0")]
	public static EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> AOOJOIIEJEI(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] ECEFHEGGLNL? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B567A0", Offset = "0x2B54DA0", VA = "0x182B567A0")]
	public static EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<T>>> GHKBOCAGCNH<T>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<T>>? FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5120", Offset = "0x1FD3720", VA = "0x181FD5120")]
	public static void ILJKHHHCHMA(this CDJBEBBGDPF<byte> ELMHNMGFNPC, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>> DBAJLALEEBK, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B56790", Offset = "0x2B54D90", VA = "0x182B56790")]
	public static void PPAKBOCICPE<T>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<T>>> DOLBEAPCCEC, EJDMOINMPCI<ECJCCLAGCON<T>> FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B56790", Offset = "0x2B54D90", VA = "0x182B56790")]
	public static void FNGFKAMLIJC<T>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<T>>> DEICMDGPFON, EJDMOINMPCI<KHLBCHFOACL<T>> FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BGHBFLFEEEE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5160", Offset = "0x1FD3760", VA = "0x181FD5160")]
	public static PEIEOFGIIME MOOAANKICLK([In] this ReadOnlySpan<byte> CNNPIMPOGKL, int JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD51D0", Offset = "0x1FD37D0", VA = "0x181FD51D0")]
	public static PEIEOFGIIME MOOAANKICLK([In] this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28FA530", Offset = "0x28F8B30", VA = "0x1828FA530")]
	public static PEIEOFGIIME MOOAANKICLK<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28FA740", Offset = "0x28F8D40", VA = "0x1828FA740")]
	public static PEIEOFGIIME MOOAANKICLK<M>([In] this PGIMPBDDGDA<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F60", Offset = "0x28F8560", VA = "0x1828F9F60")]
	public static PEIEOFGIIME MOOAANKICLK<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28FA0D0", Offset = "0x28F86D0", VA = "0x1828FA0D0")]
	public static PEIEOFGIIME MOOAANKICLK<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28FA680", Offset = "0x28F8C80", VA = "0x1828FA680")]
	public static PEIEOFGIIME MOOAANKICLK<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5160", Offset = "0x1FD3760", VA = "0x181FD5160")]
	public static int EBAIMNBEEKG([In] this ReadOnlySpan<byte> CNNPIMPOGKL, int JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4FB0", Offset = "0x1FD35B0", VA = "0x181FD4FB0")]
	public static int EBAIMNBEEKG([In] this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8530", VA = "0x1828F9F30")]
	public static int EBAIMNBEEKG<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8530", VA = "0x1828F9F30")]
	public static int EBAIMNBEEKG<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8530", VA = "0x1828F9F30")]
	public static int EBAIMNBEEKG<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8530", VA = "0x1828F9F30")]
	public static int EBAIMNBEEKG<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28F9EF0", Offset = "0x28F84F0", VA = "0x1828F9EF0")]
	public static float CFLLNOLDNHD<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x28F9EF0", Offset = "0x28F84F0", VA = "0x1828F9EF0")]
	public static float CFLLNOLDNHD<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x28F9EF0", Offset = "0x28F84F0", VA = "0x1828F9EF0")]
	public static float CFLLNOLDNHD<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x28F9FC0", Offset = "0x28F85C0", VA = "0x1828F9FC0")]
	public static byte EBBFLPAECAD<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28FA0B0", Offset = "0x28F86B0", VA = "0x1828FA0B0")]
	public static byte EBBFLPAECAD<M>([In] this PGIMPBDDGDA<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F60", Offset = "0x28F8560", VA = "0x1828F9F60")]
	public static byte EBBFLPAECAD<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28FA0D0", Offset = "0x28F86D0", VA = "0x1828FA0D0")]
	public static byte EBBFLPAECAD<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x28F9FF0", Offset = "0x28F85F0", VA = "0x1828F9FF0")]
	public static byte EBBFLPAECAD<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4FB0", Offset = "0x1FD35B0", VA = "0x181FD4FB0")]
	public static ECEFHEGGLNL LBJBEGEEEEG([In] this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE)
	{
		return default(ECEFHEGGLNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8530", VA = "0x1828F9F30")]
	public static ECEFHEGGLNL LBJBEGEEEEG<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(ECEFHEGGLNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28FA3E0", Offset = "0x28F89E0", VA = "0x1828FA3E0")]
	public static EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> MNOGIDIBOHE<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28FA4C0", Offset = "0x28F8AC0", VA = "0x1828FA4C0")]
	public static EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> MNOGIDIBOHE<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28FA450", Offset = "0x28F8A50", VA = "0x1828FA450")]
	public static EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> MNOGIDIBOHE<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x28F9E80", Offset = "0x28F8480", VA = "0x1828F9E80")]
	public static EJDMOINMPCI<KHLBCHFOACL<LHPDJMBFANM>> BFBIGKPAKCM<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<KHLBCHFOACL<LHPDJMBFANM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28FA140", Offset = "0x28F8740", VA = "0x1828FA140")]
	public static EJDMOINMPCI<OCJIFINKLKP> ELJLMJFPNND<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<OCJIFINKLKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28FA1B0", Offset = "0x28F87B0", VA = "0x1828FA1B0")]
	public static EJDMOINMPCI<OCJIFINKLKP> ELJLMJFPNND<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<OCJIFINKLKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28FA220", Offset = "0x28F8820", VA = "0x1828FA220")]
	public static EJDMOINMPCI<OCJIFINKLKP> ELJLMJFPNND<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<OCJIFINKLKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28FA370", Offset = "0x28F8970", VA = "0x1828FA370")]
	public static EJDMOINMPCI<LDEGJPGOKID> LNHLBJAHAHI<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<LDEGJPGOKID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28FA300", Offset = "0x28F8900", VA = "0x1828FA300")]
	public static EJDMOINMPCI<LDEGJPGOKID> LNHLBJAHAHI<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<LDEGJPGOKID>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28FA290", Offset = "0x28F8890", VA = "0x1828FA290")]
	public static EJDMOINMPCI<EJLGKGMKJHL> LKLJHMLFOCM<M>(this DPIEEPBOMLE<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE)
	{
		return default(EJDMOINMPCI<EJLGKGMKJHL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NNJNJHPBKFM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB450", Offset = "0x1FD9A50", VA = "0x181FDB450")]
	public static void EAAFPKPPAAP(this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE, PEIEOFGIIME FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB3E0", Offset = "0x1FD99E0", VA = "0x181FDB3E0")]
	public static void EAAFPKPPAAP(this byte[] CNNPIMPOGKL, int JNOIOMLBIAE, PEIEOFGIIME FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB360", Offset = "0x1FD9960", VA = "0x181FDB360")]
	public static void EAAFPKPPAAP([In] this Span<byte> CNNPIMPOGKL, int JNOIOMLBIAE, PEIEOFGIIME FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3040", Offset = "0x2CC1640", VA = "0x182CC3040")]
	public static void EAAFPKPPAAP<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, PEIEOFGIIME FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC31E0", Offset = "0x2CC17E0", VA = "0x182CC31E0")]
	public static void EAAFPKPPAAP<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, PEIEOFGIIME FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5120", Offset = "0x1FD3720", VA = "0x181FD5120")]
	public static void ILJKHHHCHMA(this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB600", Offset = "0x1FD9C00", VA = "0x181FDB600")]
	public static void ILJKHHHCHMA(this byte[] CNNPIMPOGKL, int JNOIOMLBIAE, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB580", Offset = "0x1FD9B80", VA = "0x181FDB580")]
	public static void ILJKHHHCHMA([In] this Span<byte> CNNPIMPOGKL, int JNOIOMLBIAE, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3480", Offset = "0x2CC1A80", VA = "0x182CC3480")]
	public static void ILJKHHHCHMA<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3420", Offset = "0x2CC1A20", VA = "0x182CC3420")]
	public static void ILJKHHHCHMA<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB680", Offset = "0x1FD9C80", VA = "0x181FDB680")]
	public static void MGCLFAEGPIE(this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CC34E0", Offset = "0x2CC1AE0", VA = "0x182CC34E0")]
	public static void MGCLFAEGPIE<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3540", Offset = "0x2CC1B40", VA = "0x182CC3540")]
	public static void MGCLFAEGPIE<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB510", Offset = "0x1FD9B10", VA = "0x181FDB510")]
	public static void IFDNCJMNODN(this CDJBEBBGDPF<byte> CNNPIMPOGKL, int JNOIOMLBIAE, byte FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3380", Offset = "0x2CC1980", VA = "0x182CC3380")]
	public static void IFDNCJMNODN<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, byte FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC33D0", Offset = "0x2CC19D0", VA = "0x182CC33D0")]
	public static void IFDNCJMNODN<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, byte FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29A33C0", Offset = "0x29A19C0", VA = "0x1829A33C0")]
	public static void PPAKBOCICPE<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29A33C0", Offset = "0x29A19C0", VA = "0x1829A33C0")]
	public static void PPAKBOCICPE<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29A33C0", Offset = "0x29A19C0", VA = "0x1829A33C0")]
	public static void LIMGICFJFDN<M>(this JCKMAGOBPCF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, EJDMOINMPCI<OCJIFINKLKP> FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29A33C0", Offset = "0x29A19C0", VA = "0x1829A33C0")]
	public static void LIMGICFJFDN<M>([In] this EMJPKJMGBFF<M, byte> CNNPIMPOGKL, EJDMOINMPCI<M> JNOIOMLBIAE, EJDMOINMPCI<OCJIFINKLKP> FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KMKBKLDJDNM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB080", Offset = "0x1FD9680", VA = "0x181FDB080")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) PHIOOECKHKG(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAF30", Offset = "0x1FD9530", VA = "0x181FDAF30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) PCIEMMBJAHP(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5B40", Offset = "0x1FD4140", VA = "0x181FD5B40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) BODDFPJNLKP(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FD90D0", Offset = "0x1FD76D0", VA = "0x181FD90D0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) KHPADEGPGGD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FDADE0", Offset = "0x1FD93E0", VA = "0x181FDADE0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) PCFOLHOPPEL(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FD77F0", Offset = "0x1FD5DF0", VA = "0x181FD77F0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) HNDEOAFMIFG(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9E30", Offset = "0x1FD8430", VA = "0x181FD9E30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NEGNCNKBFPJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8110", Offset = "0x1FD6710", VA = "0x181FD8110")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) INAEJHKDELE(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7FF0", Offset = "0x1FD65F0", VA = "0x181FD7FF0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) IDOIDJFFDNN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7910", Offset = "0x1FD5F10", VA = "0x181FD7910")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>) HNIOALLPIOC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? FEBGGALLBNN, [Optional] EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? JBJOJFCFICO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAC40", Offset = "0x1FD9240", VA = "0x181FDAC40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>) PAHKJAGJJMH(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? FEBGGALLBNN, [Optional] EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? JBJOJFCFICO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6200", Offset = "0x1FD4800", VA = "0x181FD6200")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>) DADLGHLIFBN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? FEBGGALLBNN, [Optional] EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? JBJOJFCFICO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD65E0", Offset = "0x1FD4BE0", VA = "0x181FD65E0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>) EGBHALCPOFD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? FEBGGALLBNN, [Optional] EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? JBJOJFCFICO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5D90", Offset = "0x1FD4390", VA = "0x181FD5D90")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<LDEGJPGOKID>>) CAAAFBBGPMO(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? HGFEKOICOHC, [Optional] EJDMOINMPCI<LDEGJPGOKID>? MMBIFBKCHGP)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<LDEGJPGOKID>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7310", Offset = "0x1FD5910", VA = "0x181FD7310")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LDEGJPGOKID>>>) GKLGJBDLIPC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? HGFEKOICOHC, [Optional] EJDMOINMPCI<KHLBCHFOACL<LDEGJPGOKID>>? MMBIFBKCHGP)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LDEGJPGOKID>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9740", Offset = "0x1FD7D40", VA = "0x181FD9740")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<OCJIFINKLKP>>) LMMNCEBIOHG(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? HGFEKOICOHC, [Optional] EJDMOINMPCI<OCJIFINKLKP>? MMBIFBKCHGP)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<OCJIFINKLKP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7C30", Offset = "0x1FD6230", VA = "0x181FD7C30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<OCJIFINKLKP>>>) IABCHGMGJFF(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? HGFEKOICOHC, [Optional] EJDMOINMPCI<KHLBCHFOACL<OCJIFINKLKP>>? MMBIFBKCHGP)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<OCJIFINKLKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E280", Offset = "0x2C0C880", VA = "0x182C0E280")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>) NGANCMNLMIJ<TMarker>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<EJLGKGMKJHL>? MMBIFBKCHGP, [Optional][In] ReadOnlySpan<byte> JHLEMCFOEMF)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8FA0", Offset = "0x1FD75A0", VA = "0x181FD8FA0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) KDNMBLGLAPC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int ANJCAANKHOF, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? NLDMHMGCOCL)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6AA0", Offset = "0x1FD50A0", VA = "0x181FD6AA0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) FIBNFLMLNFA(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? ANJCAANKHOF, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? NLDMHMGCOCL)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C0DF40", Offset = "0x2C0C540", VA = "0x182C0DF40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>) BNAODIMLNEM<TMarker>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<TMarker>>? NLDMHMGCOCL, [Optional] int? PPOFLGDKIBE, [Optional][In] ReadOnlySpan<byte> ANJCAANKHOF)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E130", Offset = "0x2C0C730", VA = "0x182C0E130")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>) DIMPNHMIGEI<TMarker>(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<TMarker>>? ANJCAANKHOF, [Optional] EJDMOINMPCI<KHLBCHFOACL<TMarker>>? NLDMHMGCOCL, [Optional] int? PPOFLGDKIBE)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<TMarker>>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6080", Offset = "0x1FD4680", VA = "0x181FD6080")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) CHCFJJGCNIG(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7420", Offset = "0x1FD5A20", VA = "0x181FD7420")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) GLDGFOAGAKF(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FD93B0", Offset = "0x1FD79B0", VA = "0x181FD93B0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) KOFMDLFCEJO(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FD98E0", Offset = "0x1FD7EE0", VA = "0x181FD98E0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) MOAFFEAIEAM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9B60", Offset = "0x1FD8160", VA = "0x181FD9B60")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NDNIJNLNNDC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6980", Offset = "0x1FD4F80", VA = "0x181FD6980")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) FEFBIIDKGHJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6820", Offset = "0x1FD4E20", VA = "0x181FD6820")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) EKJIAJGBMHM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA0E0", Offset = "0x1FD86E0", VA = "0x181FDA0E0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NKAPAEIGKKH(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8380", Offset = "0x1FD6980", VA = "0x181FD8380")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JBMIPCKLNAN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7A20", Offset = "0x1FD6020", VA = "0x181FD7A20")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>) HOAOLFBPEEN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? ANJANIDOIEF)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9230", Offset = "0x1FD7830", VA = "0x181FD9230")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) KLJDEKBKPGG(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA9C0", Offset = "0x1FD8FC0", VA = "0x181FDA9C0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) OJNKCNLFEHM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6D30", Offset = "0x1FD5330", VA = "0x181FD6D30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) FONBOGJACHN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8A30", Offset = "0x1FD7030", VA = "0x181FD8A30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JLIGEOGBFII(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FD70A0", Offset = "0x1FD56A0", VA = "0x181FD70A0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) GIBBBBMBBOF(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6700", Offset = "0x1FD4D00", VA = "0x181FD6700")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) EJOEDGHLDDE(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6BB0", Offset = "0x1FD51B0", VA = "0x181FD6BB0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) FLEICDIIBDL(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA480", Offset = "0x1FD8A80", VA = "0x181FDA480")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) OAFOJIADLII(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA350", Offset = "0x1FD8950", VA = "0x181FDA350")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NLMDPFHKIHA(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7E90", Offset = "0x1FD6490", VA = "0x181FD7E90")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) IBJNIOFFHML(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6310", Offset = "0x1FD4910", VA = "0x181FD6310")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) DHFPILLHNGC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAB20", Offset = "0x1FD9120", VA = "0x181FDAB20")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) OMJMHDKLGKD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8750", Offset = "0x1FD6D50", VA = "0x181FD8750")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JKHFBAPGMNJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB200", Offset = "0x1FD9800", VA = "0x181FDB200")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) PKDKOGHMOBK(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6F70", Offset = "0x1FD5570", VA = "0x181FD6F70")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) GEOBPOLPJKA(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD84A0", Offset = "0x1FD6AA0", VA = "0x181FD84A0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JGFMJDENPDC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8600", Offset = "0x1FD6C00", VA = "0x181FD8600")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JJBKIFKMEOM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9620", Offset = "0x1FD7C20", VA = "0x181FD9620")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) LFLPONMIKBJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9CB0", Offset = "0x1FD82B0", VA = "0x181FD9CB0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NEGMLFMNBGF(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8E40", Offset = "0x1FD7440", VA = "0x181FD8E40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) KAEFCPEHCJL(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5C60", Offset = "0x1FD4260", VA = "0x181FD5C60")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) BODKPPCJNGD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FD59E0", Offset = "0x1FD3FE0", VA = "0x181FD59E0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) BAOCBMPMPIA(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5F30", Offset = "0x1FD4530", VA = "0x181FD5F30")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) CCPKPENIOEB(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7B10", Offset = "0x1FD6110", VA = "0x181FD7B10")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) HPOEPMGICHB(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA6F0", Offset = "0x1FD8CF0", VA = "0x181FDA6F0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) OCFJFOFBKPJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FD94D0", Offset = "0x1FD7AD0", VA = "0x181FD94D0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) LCGMIDBECDN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA230", Offset = "0x1FD8830", VA = "0x181FDA230")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) NKJDKJKJJJD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8B90", Offset = "0x1FD7190", VA = "0x181FD8B90")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JLMGCNDEEKI(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9F90", Offset = "0x1FD8590", VA = "0x181FD9F90")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) NJJHFODHHAL(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD71F0", Offset = "0x1FD57F0", VA = "0x181FD71F0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) GIOGPGHHPAD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6E60", Offset = "0x1FD5460", VA = "0x181FD6E60")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) GEFFCKJHMBD(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] int? LFNACEIFILN, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA5E0", Offset = "0x1FD8BE0", VA = "0x181FDA5E0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) OBOAIPNBFGC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? LFNACEIFILN, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAD60", Offset = "0x1FD9360", VA = "0x181FDAD60")]
	public static EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> PBGLMFHPOLP(this CDJBEBBGDPF<byte> ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6460", Offset = "0x1FD4A60", VA = "0x181FD6460")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) EEPEOLCHBDN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8CF0", Offset = "0x1FD72F0", VA = "0x181FD8CF0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) KACBEAGPJMO(this CDJBEBBGDPF<byte> ELMHNMGFNPC, float BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<NLDMAMCMAKM>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FD76D0", Offset = "0x1FD5CD0", VA = "0x181FD76D0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>) GOIAFEPBFEJ(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<NLDMAMCMAKM>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<NLDMAMCMAKM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7570", Offset = "0x1FD5B70", VA = "0x181FD7570")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) GLICPNPIFBL(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA870", Offset = "0x1FD8E70", VA = "0x181FDA870")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) OGJKHHCBJKM(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8260", Offset = "0x1FD6860", VA = "0x181FD8260")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JBIBKKKBKKN(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FD88D0", Offset = "0x1FD6ED0", VA = "0x181FD88D0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) JLIFPFDPEEC(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7D40", Offset = "0x1FD6340", VA = "0x181FD7D40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) IBEMNHMENJE(this CDJBEBBGDPF<byte> ELMHNMGFNPC, int BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9A40", Offset = "0x1FD8040", VA = "0x181FD9A40")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>) MOALBLBOOMK(this CDJBEBBGDPF<byte> ELMHNMGFNPC, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? BHGMPFJEBGJ, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? GBHHIJKPLIB, [Optional] EJDMOINMPCI<KHLBCHFOACL<IMGOAHLFMAJ>>? IFBNIDIMOOO)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<IMGOAHLFMAJ>>>));
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
