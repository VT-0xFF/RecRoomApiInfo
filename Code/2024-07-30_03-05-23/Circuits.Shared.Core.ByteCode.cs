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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEE900", Offset = "0x1FECF00", VA = "0x181FEE900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ECDKFKJLFAB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x292F1C0", Offset = "0x292D7C0", VA = "0x18292F1C0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<M>> ADDIDCOJGBL<M>(this int HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDED0", Offset = "0x1FEC4D0", VA = "0x181FEDED0")]
	public static CGBGMGFBCKF<IMGLHGEIFKP> HAILBOBLAHI(this int HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<IMGLHGEIFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x292F1C0", Offset = "0x292D7C0", VA = "0x18292F1C0")]
	public static CGBGMGFBCKF<IBENENKEOAE<M>> LKGDNIBNBBE<M>(this int HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<IBENENKEOAE<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BCJLFHBLKEN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BGADNLKADOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BEANOHAOBEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class IMGLHGEIFKP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GFKIGLAKHAM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class LBDDGLKACKP
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BPJJGMJDHDL
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
public static class ABBDAIJFCKL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OCPBNMNONOJ<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr HCHBBIIKJDJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
		public OCPBNMNONOJ(IntPtr AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x46C1D80", Offset = "0x46C0380", VA = "0x1846C1D80")]
		public int DKJHOBNJMII(TDeps BPGHBBHBELB, TContext ACIFLMKOFOE, TCompileState JHKHJGNDMPM, [In] DKMINHFJCNM<byte> JDFBKBKINEB, int DBOAPJCFJOC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x322E7F0", Offset = "0x322CDF0", VA = "0x18322E7F0")]
	public static void PJEKDKLHGLC<TDeps, TContext, TCompileState>(TDeps BPGHBBHBELB, TContext ACIFLMKOFOE, TCompileState JHKHJGNDMPM, [In] DKMINHFJCNM<byte> LPLBEGEDIDD, DKMINHFJCNM<byte> DODGFDBBKAG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BKIBGDBMONI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? PGDPLHEOEEC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FKEGLGBPMKP, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FBDJFEJCKEC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GPAALOPNJIE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KHOLLKKMLJL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? INKPNGLEKJB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ABLBBLKNBNI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HKEHGBPMJKC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ABCMMPOANEO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CKIAKOMBKIG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CNAIOLDFPEL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HJBENDOCDOL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MHOPJEHJFNE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EGKEPEJANEJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JLIHNJGGBEG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JDPIADCAFAB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LOFBPFKGENN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BFIGBMFMNPK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AMDNBPEKKJK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AHFCDOAOLOJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NHGJOBLNJJD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MBEAJHKFICC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AAFPHPAJNIA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IPGOMNJPIDL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DALKHAPCMOJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IJFMLMBNKGE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AGKLPMGDAGP, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IIPNJILFKHI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FOCCDFKINLB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HCBBDHEBGMO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FEPHNKMOLMK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AHKIDMJAKCB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MMGPCAJIOKB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CPAKCPJNDMG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DJNAJOODOJJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BIIDGONPDLE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HCKMFGDIMEE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FJNHKIIGDAH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MBIIKKELAOK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HMLDHKAMJAF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EBEPGGFEIJC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BDPNJNJCEAJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CNJOHEMGDHC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DNBPEGCAOGO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JGFADLIIDGD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GPBJBJACOAI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? APCDAPLKNOE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NCGIGAPCMHI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KLGKEAHABMN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HAEEFAOPING, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? OHGFLHHMBNA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GIGKBHHHGNN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AHAOKNMOKDE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GLPAGDNNEKA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CCOFLPOACFP, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IDJNKLMFPNC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MECGHCALEIK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GIPJMOMAIPO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CJKCEOOEBJD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KMIMGBHPAGF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? OOLGBEGPHPA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LEDKBEKACEH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IIEIEDDMBDL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EKGFGNGAJIO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JDAILFPKIJH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HHBKAKFIPIB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ABAIKIFPPAH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KJODLDNMJKF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DHBOOAHBAEG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BMCDGGGPOKE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CMGDNDBDPFA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NEOJCNHMCEE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ICDKPAJKNKB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ELJJPEEBNBD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BMLDAMACNLG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LPBHEDHPFLI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KFHHFIEPPOG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? PHNGLFIBFBJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NMFIOLKMAEK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HFPIEMFMLGL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AEOMLDLJLFM, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BIDPEHPNGGC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ANJAIAABKFE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JAACJPBJGLM, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EJHDCEPJFAK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KOJNDHDJGIE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FJODAHGENHJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KAOMALMDHMI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? AIOAHNBAHGI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NIPFJFHDABD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HIFOCFEEPLG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GGEPBAEJJJJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? OJKHNCMKABH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JKFPKEINPCD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? PGEJAKCLGDA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JJABJJEIFGE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LGHIBNNLELE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EALFOHLKKPP, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IJFNIPAHJDO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DNCAMPMLFAA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LBMHBOBBLBJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? PKGDIAJCHAN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NCIAKBIAKBG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ELECBAHLGMC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IKEONABLHGK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NGPNDHFFFNK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? PDMEICNODGP, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JOACICOFPGB, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CDBJBMKIKME, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EIEANFEGABH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ECIIJMEBHGJ, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NMJKCOGPFIO, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? LNICFKDLDHN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? KDEHCPEDFMF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? IBIIJALJMFA, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FLKOPFDEPCE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DNAJPIDCHML, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? NBLNCAKEFEF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? HMLDIHFBEEN, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MJDBAJIKPBD, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JEGKCHNPLNC, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? OKDACLPOGAH, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MJFMLNMGGKM, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? GLIGMODHLOK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? FMACHJPPCEL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? DDPKLJPPFGK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ICLAAFGPOHE, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? MKGFDDLPFKK, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? CCFCCDCEMMI, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? JDCMFPNEDJF, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? EOAAJLPGFGL, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? OIEHPDFOBBG, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? BCGNHIFHNND, [Optional] OCPBNMNONOJ<TContext, TDeps, TCompileState>? ALJCEDPNILM) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDD20", Offset = "0x1FEC320", VA = "0x181FEDD20")]
	private static int CGMJFJKJDPE([In] DKMINHFJCNM<byte> HHNPHHDBIPA, DKMINHFJCNM<byte> AKJLINGBOGD, int IJNJPAGKLKM, int BMKFLHFENBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HNJHNNKDJPP
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int KDHIDBGBOIN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6910", Offset = "0x2BB4F10", VA = "0x182BB6910")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<T>> HJBJDMNMAJD<T>([In] this DKMINHFJCNM<byte> HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6970", Offset = "0x2BB4F70", VA = "0x182BB6970")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<T>>> KBJPHOAOBOB<T>(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<T>>? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE350", Offset = "0x1FEC950", VA = "0x181FEE350")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<OAJKANAHJEC>> GPKOAAOEAIM(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<OAJKANAHJEC>? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<OAJKANAHJEC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE260", Offset = "0x1FEC860", VA = "0x181FEE260")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>> CFGJGMPKDOD(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] float? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE610", Offset = "0x1FECC10", VA = "0x181FEE610")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>> KNMHJKBIOKH(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE530", Offset = "0x1FECB30", VA = "0x181FEE530")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>> KDCOGJFCICI(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<JGEDDHMBOAG>? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE430", Offset = "0x1FECA30", VA = "0x181FEE430")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<LBDDGLKACKP>> JLDFPNCGAKH(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] byte? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<LBDDGLKACKP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE7E0", Offset = "0x1FECDE0", VA = "0x181FEE7E0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<IMGLHGEIFKP>> MHEBMPDDGBB(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IMGLHGEIFKP>? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<IMGLHGEIFKP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE6F0", Offset = "0x1FECCF0", VA = "0x181FEE6F0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> LICHNCFAKPE(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] BPJJGMJDHDL? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6850", Offset = "0x2BB4E50", VA = "0x182BB6850")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<T>>> DNJMCLMMFOL<T>(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<T>>? DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDC20", Offset = "0x1FEC220", VA = "0x181FEDC20")]
	public static void IBNEEMKKKPK(this DKMINHFJCNM<byte> HLIDMKMINHN, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>> FLCGHAFLIBO, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6840", Offset = "0x2BB4E40", VA = "0x182BB6840")]
	public static void BJNEPBKPBKK<T>(this DKMINHFJCNM<byte> HLIDMKMINHN, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<T>>> DBOAPJCFJOC, CGBGMGFBCKF<BCJLFHBLKEN<T>> DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6840", Offset = "0x2BB4E40", VA = "0x182BB6840")]
	public static void EHIONCBMHJH<T>(this DKMINHFJCNM<byte> HLIDMKMINHN, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<T>>> FOODJNGEOJH, CGBGMGFBCKF<IBENENKEOAE<T>> DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BHBDINMIJJJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDE60", Offset = "0x1FEC460", VA = "0x181FEDE60")]
	public static DLDLNHCGMKC IJOFIJMFONB([In] this ReadOnlySpan<byte> LKFNEINGOFE, int APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDDC0", Offset = "0x1FEC3C0", VA = "0x181FEDDC0")]
	public static DLDLNHCGMKC IJOFIJMFONB([In] this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x29318B0", Offset = "0x292FEB0", VA = "0x1829318B0")]
	public static DLDLNHCGMKC IJOFIJMFONB<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2931690", Offset = "0x292FC90", VA = "0x182931690")]
	public static DLDLNHCGMKC IJOFIJMFONB<M>([In] this OPILNIFCEBO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29314B0", Offset = "0x292FAB0", VA = "0x1829314B0")]
	public static DLDLNHCGMKC IJOFIJMFONB<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29315D0", Offset = "0x292FBD0", VA = "0x1829315D0")]
	public static DLDLNHCGMKC IJOFIJMFONB<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29317F0", Offset = "0x292FDF0", VA = "0x1829317F0")]
	public static DLDLNHCGMKC IJOFIJMFONB<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDE60", Offset = "0x1FEC460", VA = "0x181FEDE60")]
	public static int OLDLHLPMJKK([In] this ReadOnlySpan<byte> LKFNEINGOFE, int APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDC10", Offset = "0x1FEC210", VA = "0x181FEDC10")]
	public static int OLDLHLPMJKK([In] this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static int OLDLHLPMJKK<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static int OLDLHLPMJKK<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static int OLDLHLPMJKK<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static int OLDLHLPMJKK<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2931400", Offset = "0x292FA00", VA = "0x182931400")]
	public static float BLEFKBDHIFN<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2931400", Offset = "0x292FA00", VA = "0x182931400")]
	public static float BLEFKBDHIFN<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2931400", Offset = "0x292FA00", VA = "0x182931400")]
	public static float BLEFKBDHIFN<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2931640", Offset = "0x292FC40", VA = "0x182931640")]
	public static byte EJFGPCENAEO<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2931670", Offset = "0x292FC70", VA = "0x182931670")]
	public static byte EJFGPCENAEO<M>([In] this OPILNIFCEBO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29314B0", Offset = "0x292FAB0", VA = "0x1829314B0")]
	public static byte EJFGPCENAEO<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29315D0", Offset = "0x292FBD0", VA = "0x1829315D0")]
	public static byte EJFGPCENAEO<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2931510", Offset = "0x292FB10", VA = "0x182931510")]
	public static byte EJFGPCENAEO<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDC10", Offset = "0x1FEC210", VA = "0x181FEDC10")]
	public static BPJJGMJDHDL HJJNIBHLPPG([In] this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC)
	{
		return default(BPJJGMJDHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static BPJJGMJDHDL HJJNIBHLPPG<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(BPJJGMJDHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2931390", Offset = "0x292F990", VA = "0x182931390")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> BGBAAMNNHNJ<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29312B0", Offset = "0x292F8B0", VA = "0x1829312B0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> BGBAAMNNHNJ<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2931320", Offset = "0x292F920", VA = "0x182931320")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> BGBAAMNNHNJ<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2931C30", Offset = "0x2930230", VA = "0x182931C30")]
	public static CGBGMGFBCKF<IBENENKEOAE<DAINKMIDKHH>> NIHPFCCIPNC<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<IBENENKEOAE<DAINKMIDKHH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2931AE0", Offset = "0x29300E0", VA = "0x182931AE0")]
	public static CGBGMGFBCKF<IMGLHGEIFKP> LIPKKLNDPPC<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<IMGLHGEIFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2931A70", Offset = "0x2930070", VA = "0x182931A70")]
	public static CGBGMGFBCKF<IMGLHGEIFKP> LIPKKLNDPPC<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<IMGLHGEIFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2931A00", Offset = "0x2930000", VA = "0x182931A00")]
	public static CGBGMGFBCKF<IMGLHGEIFKP> LIPKKLNDPPC<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<IMGLHGEIFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2931B50", Offset = "0x2930150", VA = "0x182931B50")]
	public static CGBGMGFBCKF<OAJKANAHJEC> NGPBAGJAJHM<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<OAJKANAHJEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2931BC0", Offset = "0x29301C0", VA = "0x182931BC0")]
	public static CGBGMGFBCKF<OAJKANAHJEC> NGPBAGJAJHM<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<OAJKANAHJEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2931440", Offset = "0x292FA40", VA = "0x182931440")]
	public static CGBGMGFBCKF<JGEDDHMBOAG> CCBABJOONLC<M>(this OEMHKMDMOFO<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC)
	{
		return default(CGBGMGFBCKF<JGEDDHMBOAG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ENLDEOFKMBE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE0B0", Offset = "0x1FEC6B0", VA = "0x181FEE0B0")]
	public static void PPFGPFDDKJJ(this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC, DLDLNHCGMKC DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE170", Offset = "0x1FEC770", VA = "0x181FEE170")]
	public static void PPFGPFDDKJJ(this byte[] LKFNEINGOFE, int APCNIONLEEC, DLDLNHCGMKC DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE1E0", Offset = "0x1FEC7E0", VA = "0x181FEE1E0")]
	public static void PPFGPFDDKJJ([In] this Span<byte> LKFNEINGOFE, int APCNIONLEEC, DLDLNHCGMKC DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BFB0", Offset = "0x2A3A5B0", VA = "0x182A3BFB0")]
	public static void PPFGPFDDKJJ<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, DLDLNHCGMKC DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C150", Offset = "0x2A3A750", VA = "0x182A3C150")]
	public static void PPFGPFDDKJJ<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, DLDLNHCGMKC DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDC20", Offset = "0x1FEC220", VA = "0x181FEDC20")]
	public static void IBNEEMKKKPK(this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF70", Offset = "0x1FEC570", VA = "0x181FEDF70")]
	public static void IBNEEMKKKPK(this byte[] LKFNEINGOFE, int APCNIONLEEC, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDFF0", Offset = "0x1FEC5F0", VA = "0x181FEDFF0")]
	public static void IBNEEMKKKPK([In] this Span<byte> LKFNEINGOFE, int APCNIONLEEC, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BE30", Offset = "0x2A3A430", VA = "0x182A3BE30")]
	public static void IBNEEMKKKPK<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BE90", Offset = "0x2A3A490", VA = "0x182A3BE90")]
	public static void IBNEEMKKKPK<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE070", Offset = "0x1FEC670", VA = "0x181FEE070")]
	public static void JMDIEKDHGIO(this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC, float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BF50", Offset = "0x2A3A550", VA = "0x182A3BF50")]
	public static void JMDIEKDHGIO<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BEF0", Offset = "0x2A3A4F0", VA = "0x182A3BEF0")]
	public static void JMDIEKDHGIO<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF00", Offset = "0x1FEC500", VA = "0x181FEDF00")]
	public static void ENPFDHOKLCI(this DKMINHFJCNM<byte> LKFNEINGOFE, int APCNIONLEEC, byte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BDE0", Offset = "0x2A3A3E0", VA = "0x182A3BDE0")]
	public static void ENPFDHOKLCI<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, byte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD90", Offset = "0x2A3A390", VA = "0x182A3BD90")]
	public static void ENPFDHOKLCI<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, byte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD60", Offset = "0x2A3A360", VA = "0x182A3BD60")]
	public static void BJNEPBKPBKK<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD60", Offset = "0x2A3A360", VA = "0x182A3BD60")]
	public static void BJNEPBKPBKK<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD60", Offset = "0x2A3A360", VA = "0x182A3BD60")]
	public static void COOLMMBEJEA<M>(this GBHAABHCALK<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, CGBGMGFBCKF<IMGLHGEIFKP> DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD60", Offset = "0x2A3A360", VA = "0x182A3BD60")]
	public static void COOLMMBEJEA<M>([In] this DNKDMDAADBF<M, byte> LKFNEINGOFE, CGBGMGFBCKF<M> APCNIONLEEC, CGBGMGFBCKF<IMGLHGEIFKP> DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OEBHMGLIPIJ
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3BE0", Offset = "0x1FF21E0", VA = "0x181FF3BE0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) PEAEGKBFCBI(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1780", Offset = "0x1FEFD80", VA = "0x181FF1780")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) HAPIFJFDKMJ(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0F90", Offset = "0x1FEF590", VA = "0x181FF0F90")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) FPMPIELIJLK(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1390", Offset = "0x1FEF990", VA = "0x181FF1390")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) GKDBCMAHMHO(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF220", Offset = "0x1FED820", VA = "0x181FEF220")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) BIOGKEPGLPC(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FF40B0", Offset = "0x1FF26B0", VA = "0x181FF40B0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) PKNFCJNJFBC(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1BB0", Offset = "0x1FF01B0", VA = "0x181FF1BB0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) HIBPGBOJKFO(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3540", Offset = "0x1FF1B40", VA = "0x181FF3540")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) NABONLDCJPH(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3420", Offset = "0x1FF1A20", VA = "0x181FF3420")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) MPJCPOIJMOI(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0C10", Offset = "0x1FEF210", VA = "0x181FF0C10")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>) FHKLNGEALEB(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? DMNGPNKHPKF, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? BOEHEAPFOPD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1F80", Offset = "0x1FF0580", VA = "0x181FF1F80")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>) HKHGODIPPLI(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? DMNGPNKHPKF, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? BOEHEAPFOPD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0730", Offset = "0x1FEED30", VA = "0x181FF0730")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>) EMLCJCGDJFF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? DMNGPNKHPKF, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? BOEHEAPFOPD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2330", Offset = "0x1FF0930", VA = "0x181FF2330")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>) IPJDPAHKNEN(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? DMNGPNKHPKF, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? BOEHEAPFOPD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0340", Offset = "0x1FEE940", VA = "0x181FF0340")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<OAJKANAHJEC>>) EBOCENNMHNF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? MMCBIMOPEOH, [Optional] CGBGMGFBCKF<OAJKANAHJEC>? ILHEMCJEFIG)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<OAJKANAHJEC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFA80", Offset = "0x1FEE080", VA = "0x181FEFA80")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<OAJKANAHJEC>>>) CMJMFMHNGEN(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? MMCBIMOPEOH, [Optional] CGBGMGFBCKF<IBENENKEOAE<OAJKANAHJEC>>? ILHEMCJEFIG)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<OAJKANAHJEC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF4F0", Offset = "0x1FEDAF0", VA = "0x181FEF4F0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IMGLHGEIFKP>>) CGJAHFFNGFF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? MMCBIMOPEOH, [Optional] CGBGMGFBCKF<IMGLHGEIFKP>? ILHEMCJEFIG)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IMGLHGEIFKP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3D60", Offset = "0x1FF2360", VA = "0x181FF3D60")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<IMGLHGEIFKP>>>) PECOJNPMMMN(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? MMCBIMOPEOH, [Optional] CGBGMGFBCKF<IBENENKEOAE<IMGLHGEIFKP>>? ILHEMCJEFIG)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<IMGLHGEIFKP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5120", Offset = "0x2CF3720", VA = "0x182CF5120")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>) JGFLNEILNAL<TMarker>(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<JGEDDHMBOAG>? ILHEMCJEFIG, [Optional][In] ReadOnlySpan<byte> MMDLBEBNCGC)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEBC0", Offset = "0x1FED1C0", VA = "0x181FEEBC0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) AIBHPJPABGF(this DKMINHFJCNM<byte> HLIDMKMINHN, int HHNPHHDBIPA, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? AKJLINGBOGD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF7F0", Offset = "0x1FEDDF0", VA = "0x181FEF7F0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) CHIEJKDJJNE(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? HHNPHHDBIPA, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? AKJLINGBOGD)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5320", Offset = "0x2CF3920", VA = "0x182CF5320")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>) KPKEBFDKKMP<TMarker>(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<TMarker>>? AKJLINGBOGD, [Optional] int? LPKLLJKOBNO, [Optional][In] ReadOnlySpan<byte> HHNPHHDBIPA)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4FD0", Offset = "0x2CF35D0", VA = "0x182CF4FD0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>) IEDOHHEBHDN<TMarker>(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<TMarker>>? HHNPHHDBIPA, [Optional] CGBGMGFBCKF<IBENENKEOAE<TMarker>>? AKJLINGBOGD, [Optional] int? LPKLLJKOBNO)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<TMarker>>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF370", Offset = "0x1FED970", VA = "0x181FEF370")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) CBENIAAMAGN(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3860", Offset = "0x1FF1E60", VA = "0x181FF3860")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) OCLNNFDAHKC(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEAA0", Offset = "0x1FED0A0", VA = "0x181FEEAA0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) AGGJLAPNJFM(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEE10", Offset = "0x1FED410", VA = "0x181FEEE10")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) APLAGHCLNFL(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEF70", Offset = "0x1FED570", VA = "0x181FEEF70")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) BDKPMCPOPOH(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEECF0", Offset = "0x1FED2F0", VA = "0x181FEECF0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) AKOMOGFCHLF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF31A0", Offset = "0x1FF17A0", VA = "0x181FF31A0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) MHOFOCBPOFL(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFCF0", Offset = "0x1FEE2F0", VA = "0x181FEFCF0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) CPBDGFILOOK(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3F90", Offset = "0x1FF2590", VA = "0x181FF3F90")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) PJNIIADPPDA(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1D10", Offset = "0x1FF0310", VA = "0x181FF1D10")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>) HJFMNHPPLFF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? ILGDNGBOFNL)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2450", Offset = "0x1FF0A50", VA = "0x181FF2450")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) IPPAJIPPDCD(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFF90", Offset = "0x1FEE590", VA = "0x181FEFF90")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) DCBFNDMFGPK(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FF20A0", Offset = "0x1FF06A0", VA = "0x181FF20A0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) IANLCGJBPBO(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2B20", Offset = "0x1FF1120", VA = "0x181FF2B20")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) LBEHNNEJIKP(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0AC0", Offset = "0x1FEF0C0", VA = "0x181FF0AC0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) FELNNFPAIGM(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE980", Offset = "0x1FECF80", VA = "0x181FEE980")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) AEHNINMEJCN(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF900", Offset = "0x1FEDF00", VA = "0x181FEF900")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) CHJMLDNJPHL(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FF29C0", Offset = "0x1FF0FC0", VA = "0x181FF29C0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) KPIGDCGJECP(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0600", Offset = "0x1FEEC00", VA = "0x181FF0600")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) EIKJENCIKDD(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF690", Offset = "0x1FEDC90", VA = "0x181FEF690")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) CGPAPDCAGEJ(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3050", Offset = "0x1FF1650", VA = "0x181FF3050")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) MFGGGPMJKAA(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0D20", Offset = "0x1FEF320", VA = "0x181FF0D20")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) FNCIJGJILDF(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF10B0", Offset = "0x1FEF6B0", VA = "0x181FF10B0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) GHLDCNLIPCE(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF0C0", Offset = "0x1FED6C0", VA = "0x181FEF0C0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) BIIEMIDGGIG(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF00F0", Offset = "0x1FEE6F0", VA = "0x181FF00F0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) DHNHJLOMMLB(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1230", Offset = "0x1FEF830", VA = "0x181FF1230")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) GIOBMPIAOOI(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2F00", Offset = "0x1FF1500", VA = "0x181FF2F00")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) MBCDBJLJLKA(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3E70", Offset = "0x1FF2470", VA = "0x181FF3E70")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) PFINABNIODH(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1E00", Offset = "0x1FF0400", VA = "0x181FF1E00")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) HJNNHFJGINB(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FF21D0", Offset = "0x1FF07D0", VA = "0x181FF21D0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) IBFCAEMABFA(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FF41D0", Offset = "0x1FF27D0", VA = "0x181FF41D0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) PMMDPJMCLGA(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0960", Offset = "0x1FEEF60", VA = "0x181FF0960")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) FAJOKNKHILK(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FF25D0", Offset = "0x1FF0BD0", VA = "0x181FF25D0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) JLFLHLCMABP(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3300", Offset = "0x1FF1900", VA = "0x181FF3300")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) MNCOBFMBIGB(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1A30", Offset = "0x1FF0030", VA = "0x181FF1A30")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) HHJJMFFAJOP(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2870", Offset = "0x1FF0E70", VA = "0x181FF2870")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) KLHAMIAJFLA(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3AC0", Offset = "0x1FF20C0", VA = "0x181FF3AC0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) OKHGLDEFNMN(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2DA0", Offset = "0x1FF13A0", VA = "0x181FF2DA0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) LMCIDNBEGNH(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFE40", Offset = "0x1FEE440", VA = "0x181FEFE40")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) DAABLLHPPDL(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0840", Offset = "0x1FEEE40", VA = "0x181FF0840")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) ENCAGIJBDFI(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1670", Offset = "0x1FEFC70", VA = "0x181FF1670")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) GOKJBNPFOPH(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] int? BOIMGGMNHAE, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF39B0", Offset = "0x1FF1FB0", VA = "0x181FF39B0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) OJKBABFNBAM(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? BOIMGGMNHAE, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF37E0", Offset = "0x1FF1DE0", VA = "0x181FF37E0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> NOAEIFJOKPK(this DKMINHFJCNM<byte> HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FF14F0", Offset = "0x1FEFAF0", VA = "0x181FF14F0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) GOFNMOEEODJ(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3690", Offset = "0x1FF1C90", VA = "0x181FF3690")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) NAEACDPDLPK(this DKMINHFJCNM<byte> HLIDMKMINHN, float ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BGADNLKADOB>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0220", Offset = "0x1FEE820", VA = "0x181FF0220")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>) DLGAGFPFMMH(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BGADNLKADOB>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BGADNLKADOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FF18D0", Offset = "0x1FEFED0", VA = "0x181FF18D0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) HGKODKMDLML(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2720", Offset = "0x1FF0D20", VA = "0x181FF2720")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) KFEPHDGGFIK(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2C80", Offset = "0x1FF1280", VA = "0x181FF2C80")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) LJKDDINEOHG(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFB90", Offset = "0x1FEE190", VA = "0x181FEFB90")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) COIFKNGAEOI(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0E40", Offset = "0x1FEF440", VA = "0x181FF0E40")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) FNHIBKPJLNA(this DKMINHFJCNM<byte> HLIDMKMINHN, int ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FF04E0", Offset = "0x1FEEAE0", VA = "0x181FF04E0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>) EEKNGPNLIFA(this DKMINHFJCNM<byte> HLIDMKMINHN, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ELPAIKNHOIP, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? ANCDOEMAKKO, [Optional] CGBGMGFBCKF<IBENENKEOAE<BEANOHAOBEL>>? OMKLNMEHNOE)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<BEANOHAOBEL>>>));
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
