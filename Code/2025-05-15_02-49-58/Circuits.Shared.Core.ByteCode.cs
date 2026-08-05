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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x278CD50", Offset = "0x278B350", VA = "0x18278CD50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KNLGPPDLFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3857070", Offset = "0x3855670", VA = "0x183857070")]
	public static EDBALDILLBK<BFODHMAPOAP<M>> CNNBANBCCPG<M>(this int OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x278CD20", Offset = "0x278B320", VA = "0x18278CD20")]
	public static EDBALDILLBK<PGHHJNEDGCL> EPHMEFFAEDN(this int OCACDKEJIIB)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3857070", Offset = "0x3855670", VA = "0x183857070")]
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
		[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
		public FABGBKJMKMC(IntPtr HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4967F40", Offset = "0x4966540", VA = "0x184967F40")]
		public int CIBKKMOJDEC(TDeps MMCKJCAOGBM, TContext BHEAPBGPMHH, TCompileState PCHICAJOMOM, [In] AKAJMPNFKFH<byte> KMEJHCIEDPB, int CKKJKHJHBHK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x385D0A0", Offset = "0x385B6A0", VA = "0x18385D0A0")]
	public static void NPLBLKMMFID<TDeps, TContext, TCompileState>(TDeps MMCKJCAOGBM, TContext BHEAPBGPMHH, TCompileState PCHICAJOMOM, [In] AKAJMPNFKFH<byte> BKDFGNBNBFO, AKAJMPNFKFH<byte> IPCHPBOCNIM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ELIBNPMODAO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GKMCFCEEDNF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PGCPNNKHDCL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JDDMMIAMBOP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LHFOOPFBPMK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DFHOEKKCPJM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LEMHJJKIAEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HKHNNECBBEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LLIPGAAEMMO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HJKKCJGCACI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDOPAGAGJGJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NKBJJNLBHLL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NPLPJJDHHKA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ILMGKLPCDEG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LDGNIJJHAPL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CPNDMDEHJHJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DEHIFLNGKLD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PDAIFPBKOMK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KMBBMDHHDCJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IMDCNEEKGNH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DKFMPLCILBG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHAMGFFPDDB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KBMKLJDLJPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IEMCGBELFLC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IBLBBLBHNPN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NOMAHLFEJNA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ABLPEDOONFM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PLHLDBFABGA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NPEALECLIHN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MEEDCMPHFPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ELDPPLLJOIK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNLIODFLINP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PDNOCGKMLDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BFLCMIBBEMA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GEAOIPPAGCN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NCFNHEAMJPI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKLGNMMBJNK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IGDIMBMBDCN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HMDODFNHHDM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LBFPGJAKKDD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNIGDLNOMMH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IAFOKOGFBMM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PHBDIBNIOBJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NDNLJFEMJPN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DHJAJDBMFMC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KPKEJNDMNMH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NHEDEPGJKOG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KNPBCFEPAHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MLJFNALAFBP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MJMMPHAGGBE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GEMPAEBEFEE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DJGJPJAFLGJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NNGMAAIMLDG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OMAOJOINMPF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HGDLJCKNOFF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ADCOHLLOFKF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CBLONGCHPCA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NKDJBKNCCKO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PPLDCHDAMMM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LFKAGFKNIGM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OOPHPNNHACO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IFBJBEKFAKA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDCEAINHBKD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FPPHEDAGOGI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HIGMDMIGAHL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JNGLBGCFBJF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DMOFJKEFOIH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MCMDIIEDDHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFAFJFINPCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IEKAHHKBMMJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BAFJHPMGKBP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ICBOCLGPAAF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? AFMLFALLPHN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFHHNIGPKCD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LHFBANGALCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MKPCFPCBNEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KBHLEIMMNGC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PEGGLGKDCOD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FCKHDOAMGHA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JILGCCIDDEC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GDEIBAGOMHI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LIAJIPEBJGG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DIJAFCCPODM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BMJCPAAIFDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LEMDDBCKAED, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MDNIEFECOOC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LGEAJONJMPL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NCNEKKAGMEM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OKLKMOBEJJB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JPEDHLDNGEL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? KKAFJCMBDND, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHNLFLBOMDH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EJGPICLLHFD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EDMACFGFEGD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BLHEPKPJKGC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ICMHPBGABFP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NJNMDODIEKK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? GPGGHPJCBEP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? PBDDADNIDHM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CMDAHAOEPHA, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HBNIIEGOINH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EPIBFBBFDFD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MFHGIBEDGHC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MOADAHPALAH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? MIIGKFGJKIF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CHMPFGHBOGO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? IFINAPMEELE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BGOHEGNBDCE, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LCBPKJBDOBL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CNKAPBJFKGD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HAEEPPNJJGG, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FKODONCFGBJ, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FICJJIJNFFN, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FMJGCGJDDJC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JILFDFFLNEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? OKNEDCEDNEM, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FKJALLPIIDL, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DHJBNAGFPKD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HOJEDELLEDO, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HNPJNJLGPJI, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HFLMOGHHHBC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NDMFALJDBOK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? HFMOCOHMLOC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKLHLFLGMNP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? LIFCLGMLIEK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CMFECOIGOOH, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? ADDCLBCGBJK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? BKEDEOJMCDD, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? EKDDCBADFFP, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? CAALMMIIMPC, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? DIALCCINHDK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? JEIDOICDKCK, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? FHJIBKFBFLF, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? NONNOAOOMJB, [Optional] FABGBKJMKMC<TContext, TDeps, TCompileState>? AIJBDHDOKJN) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x278CB70", Offset = "0x278B170", VA = "0x18278CB70")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FB87D0", Offset = "0x3FB6DD0", VA = "0x183FB87D0")]
	public static EDBALDILLBK<BFODHMAPOAP<T>> PPCACBPBOMJ<T>([In] this AKAJMPNFKFH<byte> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FB8640", Offset = "0x3FB6C40", VA = "0x183FB8640")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>> BEKNODOICJB<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<BFODHMAPOAP<T>>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27870D0", Offset = "0x27856D0", VA = "0x1827870D0")]
	public static EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>> NCEOPHLKGNG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<FCFMNFHIFNB>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2786B50", Offset = "0x2785150", VA = "0x182786B50")]
	public static EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>> ABPDPPLLJIA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] float? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2786D40", Offset = "0x2785340", VA = "0x182786D40")]
	public static EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>> CPJFLDJMFJH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2786F00", Offset = "0x2785500", VA = "0x182786F00")]
	public static EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>> HPDILBEGEFK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<GEIFHGDBEKD>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2786C40", Offset = "0x2785240", VA = "0x182786C40")]
	public static EDBALDILLBK<BFODHMAPOAP<JMDCDIHMBGM>> BGBANBIBONC(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] byte? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<JMDCDIHMBGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2786E20", Offset = "0x2785420", VA = "0x182786E20")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>> EKECFDIHGLJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<PGHHJNEDGCL>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2786FE0", Offset = "0x27855E0", VA = "0x182786FE0")]
	public static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> JKOPCPPFPOI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] DJFOIOECMMP? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FB8710", Offset = "0x3FB6D10", VA = "0x183FB8710")]
	public static EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>> OPCJOGMLJLE<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<T>>? OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2786A50", Offset = "0x2785050", VA = "0x182786A50")]
	public static void CBEEIEEAHGP(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>> AMMNJFIOKDA, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FB8700", Offset = "0x3FB6D00", VA = "0x183FB8700")]
	public static void NBPAFPIDHHB<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<T>>> CKKJKHJHBHK, EDBALDILLBK<BFODHMAPOAP<T>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FB8700", Offset = "0x3FB6D00", VA = "0x183FB8700")]
	public static void GBLIJJLMGLL<T>(this AKAJMPNFKFH<byte> OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<T>>> MIIJKBPCMMK, EDBALDILLBK<AJNOBLLAKEF<T>> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FHAEEPCKBKP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x278CC10", Offset = "0x278B210", VA = "0x18278CC10")]
	public static CDFNCNEGFME IIEMHCFLEGA([In] this ReadOnlySpan<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x278CC80", Offset = "0x278B280", VA = "0x18278CC80")]
	public static CDFNCNEGFME IIEMHCFLEGA([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38609C0", Offset = "0x385EFC0", VA = "0x1838609C0")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3860BD0", Offset = "0x385F1D0", VA = "0x183860BD0")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>([In] this KKJANHMOJPK<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38608C0", Offset = "0x385EEC0", VA = "0x1838608C0")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3860850", Offset = "0x385EE50", VA = "0x183860850")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3860B10", Offset = "0x385F110", VA = "0x183860B10")]
	public static CDFNCNEGFME IIEMHCFLEGA<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x278CC10", Offset = "0x278B210", VA = "0x18278CC10")]
	public static int NCMCEKJLIMN([In] this ReadOnlySpan<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2786A40", Offset = "0x2785040", VA = "0x182786A40")]
	public static int NCMCEKJLIMN([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3860D70", Offset = "0x385F370", VA = "0x183860D70")]
	public static int NCMCEKJLIMN<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3860D70", Offset = "0x385F370", VA = "0x183860D70")]
	public static int NCMCEKJLIMN<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3860D70", Offset = "0x385F370", VA = "0x183860D70")]
	public static int NCMCEKJLIMN<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3860D70", Offset = "0x385F370", VA = "0x183860D70")]
	public static int NCMCEKJLIMN<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3860D30", Offset = "0x385F330", VA = "0x183860D30")]
	public static float JFLBJPBELHO<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3860D30", Offset = "0x385F330", VA = "0x183860D30")]
	public static float JFLBJPBELHO<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3860D30", Offset = "0x385F330", VA = "0x183860D30")]
	public static float JFLBJPBELHO<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3860920", Offset = "0x385EF20", VA = "0x183860920")]
	public static byte HAFHCOGFMLF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3860830", Offset = "0x385EE30", VA = "0x183860830")]
	public static byte HAFHCOGFMLF<M>([In] this KKJANHMOJPK<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38608C0", Offset = "0x385EEC0", VA = "0x1838608C0")]
	public static byte HAFHCOGFMLF<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3860850", Offset = "0x385EE50", VA = "0x183860850")]
	public static byte HAFHCOGFMLF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3860770", Offset = "0x385ED70", VA = "0x183860770")]
	public static byte HAFHCOGFMLF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2786A40", Offset = "0x2785040", VA = "0x182786A40")]
	public static DJFOIOECMMP MAEDBOHAMDE([In] this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM)
	{
		return default(DJFOIOECMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3860D70", Offset = "0x385F370", VA = "0x183860D70")]
	public static DJFOIOECMMP MAEDBOHAMDE<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(DJFOIOECMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3860690", Offset = "0x385EC90", VA = "0x183860690")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38605B0", Offset = "0x385EBB0", VA = "0x1838605B0")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3860620", Offset = "0x385EC20", VA = "0x183860620")]
	public static EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBIBFKPOKLC<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3860700", Offset = "0x385ED00", VA = "0x183860700")]
	public static EDBALDILLBK<AJNOBLLAKEF<PGHLNDOLJNP>> GBGFLCJMJAH<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<AJNOBLLAKEF<PGHLNDOLJNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38604D0", Offset = "0x385EAD0", VA = "0x1838604D0")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3860460", Offset = "0x385EA60", VA = "0x183860460")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3860540", Offset = "0x385EB40", VA = "0x183860540")]
	public static EDBALDILLBK<PGHHJNEDGCL> AGCNOOMNJNF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<PGHHJNEDGCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3860E10", Offset = "0x385F410", VA = "0x183860E10")]
	public static EDBALDILLBK<FCFMNFHIFNB> OAFPBOJDEAF<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<FCFMNFHIFNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3860DA0", Offset = "0x385F3A0", VA = "0x183860DA0")]
	public static EDBALDILLBK<FCFMNFHIFNB> OAFPBOJDEAF<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<FCFMNFHIFNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3860950", Offset = "0x385EF50", VA = "0x183860950")]
	public static EDBALDILLBK<GEIFHGDBEKD> HHBFACCEMJD<M>(this KOLDGJODODL<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM)
	{
		return default(EDBALDILLBK<GEIFHGDBEKD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PCABEGGIIAO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x278CF40", Offset = "0x278B540", VA = "0x18278CF40")]
	public static void HPNJFEMFPNH(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x278CED0", Offset = "0x278B4D0", VA = "0x18278CED0")]
	public static void HPNJFEMFPNH(this byte[] ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x278D000", Offset = "0x278B600", VA = "0x18278D000")]
	public static void HPNJFEMFPNH([In] this Span<byte> ACDPPDBEDDM, int OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A084A0", Offset = "0x3A06AA0", VA = "0x183A084A0")]
	public static void HPNJFEMFPNH<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A08300", Offset = "0x3A06900", VA = "0x183A08300")]
	public static void HPNJFEMFPNH<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, CDFNCNEGFME OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2786A50", Offset = "0x2785050", VA = "0x182786A50")]
	public static void CBEEIEEAHGP(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x278CDD0", Offset = "0x278B3D0", VA = "0x18278CDD0")]
	public static void CBEEIEEAHGP(this byte[] ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x278CE50", Offset = "0x278B450", VA = "0x18278CE50")]
	public static void CBEEIEEAHGP([In] this Span<byte> ACDPPDBEDDM, int OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A08240", Offset = "0x3A06840", VA = "0x183A08240")]
	public static void CBEEIEEAHGP<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A082A0", Offset = "0x3A068A0", VA = "0x183A082A0")]
	public static void CBEEIEEAHGP<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x278D0F0", Offset = "0x278B6F0", VA = "0x18278D0F0")]
	public static void MADEEEBEDOM(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A08740", Offset = "0x3A06D40", VA = "0x183A08740")]
	public static void MADEEEBEDOM<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A086E0", Offset = "0x3A06CE0", VA = "0x183A086E0")]
	public static void MADEEEBEDOM<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x278D080", Offset = "0x278B680", VA = "0x18278D080")]
	public static void JJMFBAHABIC(this AKAJMPNFKFH<byte> ACDPPDBEDDM, int OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A08690", Offset = "0x3A06C90", VA = "0x183A08690")]
	public static void JJMFBAHABIC<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A08640", Offset = "0x3A06C40", VA = "0x183A08640")]
	public static void JJMFBAHABIC<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3863C00", Offset = "0x3862200", VA = "0x183863C00")]
	public static void NBPAFPIDHHB<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3863C00", Offset = "0x3862200", VA = "0x183863C00")]
	public static void NBPAFPIDHHB<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3863C00", Offset = "0x3862200", VA = "0x183863C00")]
	public static void GIMGLKJICBL<M>(this DAABAMGFIFM<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<PGHHJNEDGCL> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3863C00", Offset = "0x3862200", VA = "0x183863C00")]
	public static void GIMGLKJICBL<M>([In] this NPFHGGEEJIP<M, byte> ACDPPDBEDDM, EDBALDILLBK<M> OAHKGLFKJGM, EDBALDILLBK<PGHHJNEDGCL> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DGFOMNICMII
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x278B7D0", Offset = "0x2789DD0", VA = "0x18278B7D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) NJBPIJECPME(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2787B80", Offset = "0x2786180", VA = "0x182787B80")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) CADIGFCLABF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2789200", Offset = "0x2787800", VA = "0x182789200")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) HGOOMLFEBBB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x278BAA0", Offset = "0x278A0A0", VA = "0x18278BAA0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OIDIOLBJHGE(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x278BC00", Offset = "0x278A200", VA = "0x18278BC00")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OJKJFJAFOGN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2787430", Offset = "0x2785A30", VA = "0x182787430")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BBKANPLOEBN(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x278A190", Offset = "0x2788790", VA = "0x18278A190")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JEELNFLECJC(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2789B70", Offset = "0x2788170", VA = "0x182789B70")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IKMOJPHNGMG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2787820", Offset = "0x2785E20", VA = "0x182787820")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BLLBOMHMAJO(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x278C280", Offset = "0x278A880", VA = "0x18278C280")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) ONHPPIMACOM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x278B400", Offset = "0x2789A00", VA = "0x18278B400")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) MHKKJLNJAGM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2789660", Offset = "0x2787C60", VA = "0x182789660")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) IBELKHPOGEL(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2787310", Offset = "0x2785910", VA = "0x182787310")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) BABFJIMMDHC(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? OHLIHBDBKCE, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? NNAOJMAOBFC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x278A410", Offset = "0x2788A10", VA = "0x18278A410")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>) KEHCAKJFKDA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<FCFMNFHIFNB>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<FCFMNFHIFNB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2788250", Offset = "0x2786850", VA = "0x182788250")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<FCFMNFHIFNB>>>) DLKEBGJAMED(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<AJNOBLLAKEF<FCFMNFHIFNB>>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<FCFMNFHIFNB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2787550", Offset = "0x2785B50", VA = "0x182787550")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>) BGECGFKCIPH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<PGHHJNEDGCL>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<PGHHJNEDGCL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2788140", Offset = "0x2786740", VA = "0x182788140")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHHJNEDGCL>>>) CNHDJPOADKB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? FBNGBFIFDOO, [Optional] EDBALDILLBK<AJNOBLLAKEF<PGHHJNEDGCL>>? NPLDOOBBCLG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHHJNEDGCL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36B3A60", Offset = "0x36B2060", VA = "0x1836B3A60")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>) CHALPHKCBOJ<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<GEIFHGDBEKD>? NPLDOOBBCLG, [Optional][In] ReadOnlySpan<byte> APDBNIMCPID)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x278C8C0", Offset = "0x278AEC0", VA = "0x18278C8C0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PLHGNFGGNGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? FMDPDNGNNPP)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2788030", Offset = "0x2786630", VA = "0x182788030")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CKJHAPIPOHA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? FMDPDNGNNPP)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x36B3C60", Offset = "0x36B2260", VA = "0x1836B3C60")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>) GHEJGCNADCI<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? FMDPDNGNNPP, [Optional] int? CFNMLMNHCMF, [Optional][In] ReadOnlySpan<byte> EKBPMBFJFCG)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36B3E50", Offset = "0x36B2450", VA = "0x1836B3E50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>) GKCIOEDKAIM<TMarker>(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? EKBPMBFJFCG, [Optional] EDBALDILLBK<AJNOBLLAKEF<TMarker>>? FMDPDNGNNPP, [Optional] int? CFNMLMNHCMF)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<TMarker>>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2788A20", Offset = "0x2787020", VA = "0x182788A20")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FMOCEBFDJIK(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x278B520", Offset = "0x2789B20", VA = "0x18278B520")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) MOOHMCAANOO(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x278A890", Offset = "0x2788E90", VA = "0x18278A890")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) KJGJNGAPOBK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x278A730", Offset = "0x2788D30", VA = "0x18278A730")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) KIBJNCILKLN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x278B950", Offset = "0x2789F50", VA = "0x18278B950")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) NJECKNPIGDN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x278AB00", Offset = "0x2789100", VA = "0x18278AB00")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LDCPLCPMHOG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x278BFD0", Offset = "0x278A5D0", VA = "0x18278BFD0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMDEELIKCDM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x278B150", Offset = "0x2789750", VA = "0x18278B150")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MEFLGMNGJGE(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x278BD50", Offset = "0x278A350", VA = "0x18278BD50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OLKJLFJCILI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2787F40", Offset = "0x2786540", VA = "0x182787F40")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>) CJIJIFAEGGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? JBPLKINOHAD)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2788BA0", Offset = "0x27871A0", VA = "0x182788BA0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GCHPJHOGILC(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x278C760", Offset = "0x278AD60", VA = "0x18278C760")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PJJEPFCJNDF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27890D0", Offset = "0x27876D0", VA = "0x1827890D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HCKJJAICGHB(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2789320", Offset = "0x2787920", VA = "0x182789320")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HLMECNPKOIG(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2788360", Offset = "0x2786960", VA = "0x182788360")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) DPAENGOBONO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x278A2F0", Offset = "0x27888F0", VA = "0x18278A2F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JLMBHBMFHBK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x278AC20", Offset = "0x2789220", VA = "0x18278AC20")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LHPLPNEIPLN(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2787DE0", Offset = "0x27863E0", VA = "0x182787DE0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CGBBDLCCCPA(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27876F0", Offset = "0x2785CF0", VA = "0x1827876F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BKHMFJNKDFE(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x278ADA0", Offset = "0x27893A0", VA = "0x18278ADA0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LMCNMFBNGAO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27884B0", Offset = "0x2786AB0", VA = "0x1827884B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) ECBAIOFPFIL(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x278B030", Offset = "0x2789630", VA = "0x18278B030")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MDMBDIDNLII(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x278A5B0", Offset = "0x2788BB0", VA = "0x18278A5B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) KGMGBNFMDLJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2789480", Offset = "0x2787A80", VA = "0x182789480")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) HNIOHDOKGJO(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2788D20", Offset = "0x2787320", VA = "0x182788D20")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GFDMNDAAMNG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x278BE70", Offset = "0x278A470", VA = "0x18278BE70")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMCMAGEEBLA(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2788600", Offset = "0x2786C00", VA = "0x182788600")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) EPBPLCPDKDN(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x278A070", Offset = "0x2788670", VA = "0x18278A070")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JAODJLMEHPI(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x278C9F0", Offset = "0x278AFF0", VA = "0x18278C9F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) POFEHAMLOEA(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x278C390", Offset = "0x278A990", VA = "0x18278C390")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OPJOOMJMEFH(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x278AF00", Offset = "0x2789500", VA = "0x18278AF00")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MCGGNHJJBKK(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x278B670", Offset = "0x2789C70", VA = "0x18278B670")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) NGEMGCBLKEK(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x278C130", Offset = "0x278A730", VA = "0x18278C130")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) OMLDBIGFFED(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x278C640", Offset = "0x278AC40", VA = "0x18278C640")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PJEAJDPAPMA(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2788750", Offset = "0x2786D50", VA = "0x182788750")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FIIHDJDNNJF(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2789E10", Offset = "0x2788410", VA = "0x182789E10")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) IOPNIFLEGFP(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2788E50", Offset = "0x2787450", VA = "0x182788E50")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) GFLLIOOPIHF(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2788F70", Offset = "0x2787570", VA = "0x182788F70")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) GMBLNLMNIPA(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x278A9B0", Offset = "0x2788FB0", VA = "0x18278A9B0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) LBEENILBNNO(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2787940", Offset = "0x2785F40", VA = "0x182787940")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) BPFPIDGHMJH(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2787CD0", Offset = "0x27862D0", VA = "0x182787CD0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) CALGEKIIDIO(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] int? NFCCJNKBDBH, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2789F60", Offset = "0x2788560", VA = "0x182789F60")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) JAKMHEFHFCM(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? NFCCJNKBDBH, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27895E0", Offset = "0x2787BE0", VA = "0x1827895E0")]
	public static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> IAPCPDDAHII(this AKAJMPNFKFH<byte> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27899F0", Offset = "0x2787FF0", VA = "0x1827899F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) IJJIKNPEPFG(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27888D0", Offset = "0x2786ED0", VA = "0x1827888D0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) FIJPJIMKFDH(this AKAJMPNFKFH<byte> OCACDKEJIIB, float HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<KHBKIKOIDAE>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27871F0", Offset = "0x27857F0", VA = "0x1827871F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>) AOILEMAHJHN(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<KHBKIKOIDAE>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<KHBKIKOIDAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2789890", Offset = "0x2787E90", VA = "0x182789890")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IJJIGMGALDM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x278C4F0", Offset = "0x278AAF0", VA = "0x18278C4F0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) PCHKNDKGDAL(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2789770", Offset = "0x2787D70", VA = "0x182789770")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) IIENDLPDAGG(this AKAJMPNFKFH<byte> OCACDKEJIIB, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x278B2A0", Offset = "0x27898A0", VA = "0x18278B2A0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) MFPHLPLGCFM(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2789CC0", Offset = "0x27882C0", VA = "0x182789CC0")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>) INGCOHFKHOJ(this AKAJMPNFKFH<byte> OCACDKEJIIB, int HLHEEENKHNP, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? GHJJIFJECEA, [Optional] EDBALDILLBK<AJNOBLLAKEF<AKDOAODMDCG>>? HECJDLLPJOC)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<AKDOAODMDCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2787A60", Offset = "0x2786060", VA = "0x182787A60")]
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
