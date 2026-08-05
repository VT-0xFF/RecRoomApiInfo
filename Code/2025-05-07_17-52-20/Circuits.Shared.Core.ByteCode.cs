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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x278BF00", Offset = "0x278AF00", VA = "0x18278BF00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KNLGPPDLFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3838760", Offset = "0x3837760", VA = "0x183838760")]
	public static EDBALDILLBK<BFODHMAPOAP<M>> CNNBANBCCPG<M>(this int OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x278BED0", Offset = "0x278AED0", VA = "0x18278BED0")]
	public static EDBALDILLBK<PGHHJNEDGCL> EPHMEFFAEDN(this int OCACDKEJIIB)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3838760", Offset = "0x3837760", VA = "0x183838760")]
	public static EDBALDILLBK<AJNOBLLAKEF<M>> GJDLHHACICL<M>(this int OCACDKEJIIB)
	{
		return default(EDBALDILLBK<AJNOBLLAKEF<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BFODHMAPOAP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KHBKIKOIDAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AKDOAODMDCG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PGHHJNEDGCL
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FNLIENCGJGF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JMDCDIHMBGM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DJFOIOECMMP
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
public static class FGBMHLLPLNI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FABGBKJMKMC<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr PCAAKKAJNLP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
		public FABGBKJMKMC(IntPtr HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4928150", Offset = "0x4927150", VA = "0x184928150")]
		public int CIBKKMOJDEC(TDeps MMCKJCAOGBM, TContext BHEAPBGPMHH, TCompileState PCHICAJOMOM, [In] AKAJMPNFKFH<byte> KMEJHCIEDPB, int CKKJKHJHBHK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x383E760", Offset = "0x383D760", VA = "0x18383E760")]
	public static void NPLBLKMMFID<TDeps, TContext, TCompileState>(TDeps MMCKJCAOGBM, TContext BHEAPBGPMHH, TCompileState PCHICAJOMOM, [In] AKAJMPNFKFH<byte> BKDFGNBNBFO, AKAJMPNFKFH<byte> IPCHPBOCNIM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ELIBNPMODAO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GKMCFCEEDNF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PGCPNNKHDCL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JDDMMIAMBOP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LHFOOPFBPMK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DFHOEKKCPJM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LEMHJJKIAEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HKHNNECBBEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LLIPGAAEMMO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HJKKCJGCACI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDOPAGAGJGJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NKBJJNLBHLL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NPLPJJDHHKA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ILMGKLPCDEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LDGNIJJHAPL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CPNDMDEHJHJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DEHIFLNGKLD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PDAIFPBKOMK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KMBBMDHHDCJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IMDCNEEKGNH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DKFMPLCILBG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHAMGFFPDDB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KBMKLJDLJPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IEMCGBELFLC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IBLBBLBHNPN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NOMAHLFEJNA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ABLPEDOONFM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PLHLDBFABGA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NPEALECLIHN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MEEDCMPHFPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ELDPPLLJOIK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNLIODFLINP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PDNOCGKMLDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BFLCMIBBEMA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GEAOIPPAGCN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NCFNHEAMJPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKLGNMMBJNK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IGDIMBMBDCN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HMDODFNHHDM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LBFPGJAKKDD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNIGDLNOMMH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IAFOKOGFBMM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PHBDIBNIOBJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NDNLJFEMJPN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DHJAJDBMFMC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KPKEJNDMNMH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NHEDEPGJKOG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNPBCFEPAHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MLJFNALAFBP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MJMMPHAGGBE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GEMPAEBEFEE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DJGJPJAFLGJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NNGMAAIMLDG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OMAOJOINMPF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HGDLJCKNOFF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ADCOHLLOFKF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CBLONGCHPCA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NKDJBKNCCKO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PPLDCHDAMMM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LFKAGFKNIGM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OOPHPNNHACO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IFBJBEKFAKA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDCEAINHBKD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FPPHEDAGOGI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HIGMDMIGAHL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JNGLBGCFBJF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DMOFJKEFOIH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MCMDIIEDDHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFAFJFINPCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IEKAHHKBMMJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BAFJHPMGKBP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ICBOCLGPAAF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? AFMLFALLPHN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFHHNIGPKCD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LHFBANGALCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MKPCFPCBNEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KBHLEIMMNGC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PEGGLGKDCOD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FCKHDOAMGHA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JILGCCIDDEC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GDEIBAGOMHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LIAJIPEBJGG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DIJAFCCPODM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BMJCPAAIFDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LEMDDBCKAED, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MDNIEFECOOC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LGEAJONJMPL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NCNEKKAGMEM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OKLKMOBEJJB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JPEDHLDNGEL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KKAFJCMBDND, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHNLFLBOMDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EJGPICLLHFD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDMACFGFEGD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BLHEPKPJKGC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ICMHPBGABFP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NJNMDODIEKK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GPGGHPJCBEP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PBDDADNIDHM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CMDAHAOEPHA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HBNIIEGOINH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EPIBFBBFDFD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFHGIBEDGHC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MOADAHPALAH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MIIGKFGJKIF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHMPFGHBOGO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IFINAPMEELE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BGOHEGNBDCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LCBPKJBDOBL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CNKAPBJFKGD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HAEEPPNJJGG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FKODONCFGBJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FICJJIJNFFN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FMJGCGJDDJC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JILFDFFLNEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OKNEDCEDNEM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FKJALLPIIDL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DHJBNAGFPKD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HOJEDELLEDO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HNPJNJLGPJI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HFLMOGHHHBC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NDMFALJDBOK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HFMOCOHMLOC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKLHLFLGMNP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LIFCLGMLIEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CMFECOIGOOH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ADDCLBCGBJK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BKEDEOJMCDD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKDDCBADFFP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CAALMMIIMPC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DIALCCINHDK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JEIDOICDKCK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FHJIBKFBFLF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NONNOAOOMJB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? AIJBDHDOKJN) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x278BD20", Offset = "0x278AD20", VA = "0x18278BD20")]
	private static int OIPCFIJJMAA([In] AKAJMPNFKFH<byte> EKBPMBFJFCG, AKAJMPNFKFH<byte> FMDPDNGNNPP, int IPAELMFFKOA, int JAALIADHHOC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AAGCHHCPIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int KOCOIHOEMFG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F619D0", Offset = "0x3F609D0", VA = "0x183F619D0")]
	public static EDBALDILLBK<BFODHMAPOAP<T>> PPCACBPBOMJ<T>([In] this AKAJMPNFKFH<byte> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F61840", Offset = "0x3F60840", VA = "0x183F61840")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>> BEKNODOICJB<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<BFODHMAPOAP<T>>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2786280", Offset = "0x2785280", VA = "0x182786280")]
	public static EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>> NCEOPHLKGNG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<FCFMNFHIFNB>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2785D00", Offset = "0x2784D00", VA = "0x182785D00")]
	public static EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>> ABPDPPLLJIA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] float? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2785EF0", Offset = "0x2784EF0", VA = "0x182785EF0")]
	public static EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>> CPJFLDJMFJH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27860B0", Offset = "0x27850B0", VA = "0x1827860B0")]
	public static EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>> HPDILBEGEFK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<GEIFHGDBEKD>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2785DF0", Offset = "0x2784DF0", VA = "0x182785DF0")]
	public static EDBALDILLBK<BFODHMAPOAP<JMDCDIHMBGM>> BGBANBIBONC(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] byte? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<JMDCDIHMBGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2785FD0", Offset = "0x2784FD0", VA = "0x182785FD0")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>> EKECFDIHGLJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<PGHHJNEDGCL>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2786190", Offset = "0x2785190", VA = "0x182786190")]
	public static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> JKOPCPPFPOI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] DJFOIOECMMP? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F61910", Offset = "0x3F60910", VA = "0x183F61910")]
	public static EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>> OPCJOGMLJLE<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<T>>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2785C00", Offset = "0x2784C00", VA = "0x182785C00")]
	public static void CBEEIEEAHGP(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>> AMMNJFIOKDA, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F61900", Offset = "0x3F60900", VA = "0x183F61900")]
	public static void NBPAFPIDHHB<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>> CKKJKHJHBHK, EDBALDILLBK<BFODHMAPOAP<T>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F61900", Offset = "0x3F60900", VA = "0x183F61900")]
	public static void GBLIJJLMGLL<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>> MIIJKBPCMMK, EDBALDILLBK<AJNOBLLAKEF<T>> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FHAEEPCKBKP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x278BDC0", Offset = "0x278ADC0", VA = "0x18278BDC0")]
	public static CDFNCNEGFME IIEMHCFLEGA([In] this ReadOnlySpan<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x278BE30", Offset = "0x278AE30", VA = "0x18278BE30")]
	public static CDFNCNEGFME IIEMHCFLEGA([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3842080", Offset = "0x3841080", VA = "0x183842080")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3842290", Offset = "0x3841290", VA = "0x183842290")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>([In] this KKJANHMOJPK<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3841F80", Offset = "0x3840F80", VA = "0x183841F80")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3841F10", Offset = "0x3840F10", VA = "0x183841F10")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38421D0", Offset = "0x38411D0", VA = "0x1838421D0")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x278BDC0", Offset = "0x278ADC0", VA = "0x18278BDC0")]
	public static int NCMCEKJLIMN([In] this ReadOnlySpan<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2785BF0", Offset = "0x2784BF0", VA = "0x182785BF0")]
	public static int NCMCEKJLIMN([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3842430", Offset = "0x3841430", VA = "0x183842430")]
	public static int NCMCEKJLIMN<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3842430", Offset = "0x3841430", VA = "0x183842430")]
	public static int NCMCEKJLIMN<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3842430", Offset = "0x3841430", VA = "0x183842430")]
	public static int NCMCEKJLIMN<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3842430", Offset = "0x3841430", VA = "0x183842430")]
	public static int NCMCEKJLIMN<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38423F0", Offset = "0x38413F0", VA = "0x1838423F0")]
	public static float JFLBJPBELHO<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38423F0", Offset = "0x38413F0", VA = "0x1838423F0")]
	public static float JFLBJPBELHO<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38423F0", Offset = "0x38413F0", VA = "0x1838423F0")]
	public static float JFLBJPBELHO<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3841FE0", Offset = "0x3840FE0", VA = "0x183841FE0")]
	public static byte HAFHCOGFMLF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3841EF0", Offset = "0x3840EF0", VA = "0x183841EF0")]
	public static byte HAFHCOGFMLF<M>([In] this KKJANHMOJPK<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3841F80", Offset = "0x3840F80", VA = "0x183841F80")]
	public static byte HAFHCOGFMLF<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3841F10", Offset = "0x3840F10", VA = "0x183841F10")]
	public static byte HAFHCOGFMLF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3841E30", Offset = "0x3840E30", VA = "0x183841E30")]
	public static byte HAFHCOGFMLF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2785BF0", Offset = "0x2784BF0", VA = "0x182785BF0")]
	public static DJFOIOECMMP MAEDBOHAMDE([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(DJFOIOECMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3842430", Offset = "0x3841430", VA = "0x183842430")]
	public static DJFOIOECMMP MAEDBOHAMDE<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(DJFOIOECMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3841D50", Offset = "0x3840D50", VA = "0x183841D50")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3841C70", Offset = "0x3840C70", VA = "0x183841C70")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3841CE0", Offset = "0x3840CE0", VA = "0x183841CE0")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3841DC0", Offset = "0x3840DC0", VA = "0x183841DC0")]
	public static EDBALDILLBK<AJNOBLLAKEF<PGHLNDOLJNP>> GBGFLCJMJAH<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<AJNOBLLAKEF<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3841B90", Offset = "0x3840B90", VA = "0x183841B90")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3841B20", Offset = "0x3840B20", VA = "0x183841B20")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3841C00", Offset = "0x3840C00", VA = "0x183841C00")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38424D0", Offset = "0x38414D0", VA = "0x1838424D0")]
	public static EDBALDILLBK<FCFMNFHIFNB> OAFPBOJDEAF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<FCFMNFHIFNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3842460", Offset = "0x3841460", VA = "0x183842460")]
	public static EDBALDILLBK<FCFMNFHIFNB> OAFPBOJDEAF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<FCFMNFHIFNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3842010", Offset = "0x3841010", VA = "0x183842010")]
	public static EDBALDILLBK<GEIFHGDBEKD> HHBFACCEMJD<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<GEIFHGDBEKD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PCABEGGIIAO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x278C0F0", Offset = "0x278B0F0", VA = "0x18278C0F0")]
	public static void HPNJFEMFPNH(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x278C080", Offset = "0x278B080", VA = "0x18278C080")]
	public static void HPNJFEMFPNH(this byte[] ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x278C1B0", Offset = "0x278B1B0", VA = "0x18278C1B0")]
	public static void HPNJFEMFPNH([In] this Span<byte> ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39EB950", Offset = "0x39EA950", VA = "0x1839EB950")]
	public static void HPNJFEMFPNH<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39EB7B0", Offset = "0x39EA7B0", VA = "0x1839EB7B0")]
	public static void HPNJFEMFPNH<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2785C00", Offset = "0x2784C00", VA = "0x182785C00")]
	public static void CBEEIEEAHGP(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x278BF80", Offset = "0x278AF80", VA = "0x18278BF80")]
	public static void CBEEIEEAHGP(this byte[] ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x278C000", Offset = "0x278B000", VA = "0x18278C000")]
	public static void CBEEIEEAHGP([In] this Span<byte> ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39EB6F0", Offset = "0x39EA6F0", VA = "0x1839EB6F0")]
	public static void CBEEIEEAHGP<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39EB750", Offset = "0x39EA750", VA = "0x1839EB750")]
	public static void CBEEIEEAHGP<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x278C2A0", Offset = "0x278B2A0", VA = "0x18278C2A0")]
	public static void MADEEEBEDOM(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39EBBF0", Offset = "0x39EABF0", VA = "0x1839EBBF0")]
	public static void MADEEEBEDOM<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39EBB90", Offset = "0x39EAB90", VA = "0x1839EBB90")]
	public static void MADEEEBEDOM<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x278C230", Offset = "0x278B230", VA = "0x18278C230")]
	public static void JJMFBAHABIC(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39EBB40", Offset = "0x39EAB40", VA = "0x1839EBB40")]
	public static void JJMFBAHABIC<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39EBAF0", Offset = "0x39EAAF0", VA = "0x1839EBAF0")]
	public static void JJMFBAHABIC<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x38452F0", Offset = "0x38442F0", VA = "0x1838452F0")]
	public static void NBPAFPIDHHB<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x38452F0", Offset = "0x38442F0", VA = "0x1838452F0")]
	public static void NBPAFPIDHHB<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x38452F0", Offset = "0x38442F0", VA = "0x1838452F0")]
	public static void GIMGLKJICBL<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<PGHHJNEDGCL> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x38452F0", Offset = "0x38442F0", VA = "0x1838452F0")]
	public static void GIMGLKJICBL<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<PGHHJNEDGCL> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DGFOMNICMII
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x278A980", Offset = "0x2789980", VA = "0x18278A980")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) NJBPIJECPME(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2786D30", Offset = "0x2785D30", VA = "0x182786D30")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) CADIGFCLABF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27883B0", Offset = "0x27873B0", VA = "0x1827883B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) HGOOMLFEBBB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x278AC50", Offset = "0x2789C50", VA = "0x18278AC50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OIDIOLBJHGE(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x278ADB0", Offset = "0x2789DB0", VA = "0x18278ADB0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OJKJFJAFOGN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27865E0", Offset = "0x27855E0", VA = "0x1827865E0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BBKANPLOEBN(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2789340", Offset = "0x2788340", VA = "0x182789340")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JEELNFLECJC(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2788D20", Offset = "0x2787D20", VA = "0x182788D20")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IKMOJPHNGMG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27869D0", Offset = "0x27859D0", VA = "0x1827869D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BLLBOMHMAJO(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x278B430", Offset = "0x278A430", VA = "0x18278B430")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) ONHPPIMACOM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x278A5B0", Offset = "0x27895B0", VA = "0x18278A5B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) MHKKJLNJAGM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2788810", Offset = "0x2787810", VA = "0x182788810")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) IBELKHPOGEL(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27864C0", Offset = "0x27854C0", VA = "0x1827864C0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) BABFJIMMDHC(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27895C0", Offset = "0x27885C0", VA = "0x1827895C0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>) KEHCAKJFKDA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<FCFMNFHIFNB>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2787400", Offset = "0x2786400", VA = "0x182787400")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<FCFMNFHIFNB>>>) DLKEBGJAMED(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<AJNOBLLAKEF<FCFMNFHIFNB>>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<FCFMNFHIFNB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2786700", Offset = "0x2785700", VA = "0x182786700")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>) BGECGFKCIPH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<PGHHJNEDGCL>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27872F0", Offset = "0x27862F0", VA = "0x1827872F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHHJNEDGCL>>>) CNHDJPOADKB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<AJNOBLLAKEF<PGHHJNEDGCL>>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHHJNEDGCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3695A90", Offset = "0x3694A90", VA = "0x183695A90")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>) CHALPHKCBOJ<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<GEIFHGDBEKD>? NPLDOOBBCLG, [Optional][In] ReadOnlySpan<byte> APDBNIMCPID)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x278BA70", Offset = "0x278AA70", VA = "0x18278BA70")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PLHGNFGGNGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? FMDPDNGNNPP)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27871E0", Offset = "0x27861E0", VA = "0x1827871E0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CKJHAPIPOHA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? FMDPDNGNNPP)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3695C90", Offset = "0x3694C90", VA = "0x183695C90")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>) GHEJGCNADCI<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? FMDPDNGNNPP, [Optional] int? CFNMLMNHCMF, [Optional][In] ReadOnlySpan<byte> EKBPMBFJFCG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3695E80", Offset = "0x3694E80", VA = "0x183695E80")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>) GKCIOEDKAIM<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? FMDPDNGNNPP, [Optional] int? CFNMLMNHCMF)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2787BD0", Offset = "0x2786BD0", VA = "0x182787BD0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FMOCEBFDJIK(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x278A6D0", Offset = "0x27896D0", VA = "0x18278A6D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) MOOHMCAANOO(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2789A40", Offset = "0x2788A40", VA = "0x182789A40")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) KJGJNGAPOBK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27898E0", Offset = "0x27888E0", VA = "0x1827898E0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) KIBJNCILKLN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x278AB00", Offset = "0x2789B00", VA = "0x18278AB00")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) NJECKNPIGDN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2789CB0", Offset = "0x2788CB0", VA = "0x182789CB0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LDCPLCPMHOG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x278B180", Offset = "0x278A180", VA = "0x18278B180")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMDEELIKCDM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x278A300", Offset = "0x2789300", VA = "0x18278A300")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MEFLGMNGJGE(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x278AF00", Offset = "0x2789F00", VA = "0x18278AF00")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OLKJLFJCILI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27870F0", Offset = "0x27860F0", VA = "0x1827870F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) CJIJIFAEGGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? JBPLKINOHAD)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2787D50", Offset = "0x2786D50", VA = "0x182787D50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GCHPJHOGILC(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x278B910", Offset = "0x278A910", VA = "0x18278B910")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PJJEPFCJNDF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2788280", Offset = "0x2787280", VA = "0x182788280")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HCKJJAICGHB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27884D0", Offset = "0x27874D0", VA = "0x1827884D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HLMECNPKOIG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2787510", Offset = "0x2786510", VA = "0x182787510")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) DPAENGOBONO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27894A0", Offset = "0x27884A0", VA = "0x1827894A0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JLMBHBMFHBK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2789DD0", Offset = "0x2788DD0", VA = "0x182789DD0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LHPLPNEIPLN(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2786F90", Offset = "0x2785F90", VA = "0x182786F90")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CGBBDLCCCPA(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27868A0", Offset = "0x27858A0", VA = "0x1827868A0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BKHMFJNKDFE(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2789F50", Offset = "0x2788F50", VA = "0x182789F50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LMCNMFBNGAO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2787660", Offset = "0x2786660", VA = "0x182787660")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) ECBAIOFPFIL(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x278A1E0", Offset = "0x27891E0", VA = "0x18278A1E0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MDMBDIDNLII(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2789760", Offset = "0x2788760", VA = "0x182789760")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) KGMGBNFMDLJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2788630", Offset = "0x2787630", VA = "0x182788630")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HNIOHDOKGJO(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2787ED0", Offset = "0x2786ED0", VA = "0x182787ED0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GFDMNDAAMNG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x278B020", Offset = "0x278A020", VA = "0x18278B020")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMCMAGEEBLA(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27877B0", Offset = "0x27867B0", VA = "0x1827877B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) EPBPLCPDKDN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2789220", Offset = "0x2788220", VA = "0x182789220")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JAODJLMEHPI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x278BBA0", Offset = "0x278ABA0", VA = "0x18278BBA0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) POFEHAMLOEA(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x278B540", Offset = "0x278A540", VA = "0x18278B540")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OPJOOMJMEFH(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x278A0B0", Offset = "0x27890B0", VA = "0x18278A0B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MCGGNHJJBKK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x278A820", Offset = "0x2789820", VA = "0x18278A820")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) NGEMGCBLKEK(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x278B2E0", Offset = "0x278A2E0", VA = "0x18278B2E0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMLDBIGFFED(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x278B7F0", Offset = "0x278A7F0", VA = "0x18278B7F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PJEAJDPAPMA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2787900", Offset = "0x2786900", VA = "0x182787900")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FIIHDJDNNJF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2788FC0", Offset = "0x2787FC0", VA = "0x182788FC0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) IOPNIFLEGFP(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2788000", Offset = "0x2787000", VA = "0x182788000")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) GFLLIOOPIHF(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2788120", Offset = "0x2787120", VA = "0x182788120")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GMBLNLMNIPA(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2789B60", Offset = "0x2788B60", VA = "0x182789B60")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LBEENILBNNO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2786AF0", Offset = "0x2785AF0", VA = "0x182786AF0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BPFPIDGHMJH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2786E80", Offset = "0x2785E80", VA = "0x182786E80")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CALGEKIIDIO(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? NFCCJNKBDBH, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2789110", Offset = "0x2788110", VA = "0x182789110")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JAKMHEFHFCM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? NFCCJNKBDBH, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2788790", Offset = "0x2787790", VA = "0x182788790")]
	public static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> IAPCPDDAHII(this AKAJMPNFKFH<byte> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2788BA0", Offset = "0x2787BA0", VA = "0x182788BA0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) IJJIKNPEPFG(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2787A80", Offset = "0x2786A80", VA = "0x182787A80")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FIJPJIMKFDH(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27863A0", Offset = "0x27853A0", VA = "0x1827863A0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) AOILEMAHJHN(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2788A40", Offset = "0x2787A40", VA = "0x182788A40")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IJJIGMGALDM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x278B6A0", Offset = "0x278A6A0", VA = "0x18278B6A0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PCHKNDKGDAL(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2788920", Offset = "0x2787920", VA = "0x182788920")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IIENDLPDAGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x278A450", Offset = "0x2789450", VA = "0x18278A450")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MFPHLPLGCFM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2788E70", Offset = "0x2787E70", VA = "0x182788E70")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) INGCOHFKHOJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2786C10", Offset = "0x2785C10", VA = "0x182786C10")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CACJICCMDKJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
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
