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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FCE150", Offset = "0x1FCCD50", VA = "0x181FCE150")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BKGNHKCKKEE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28F5F70", Offset = "0x28F4B70", VA = "0x1828F5F70")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<M>> HMAPCCLNBAG<M>(this int ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7D00", Offset = "0x1FC6900", VA = "0x181FC7D00")]
	public static JCIKKDEFAFO<BGLFKEALHMM> HPEOJDOFDPD(this int ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<BGLFKEALHMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28F5F70", Offset = "0x28F4B70", VA = "0x1828F5F70")]
	public static JCIKKDEFAFO<DKNAMEIKMHD<M>> EJKIMNGFBAB<M>(this int ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<DKNAMEIKMHD<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CBKKBBEDBLD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DFIJNLBNPMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CEBNLENGEOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BGLFKEALHMM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CHMHJEBDLEO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FJBOIPDOCAM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BJNKLFIFCOO
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
public static class EFKLMBIMJJJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MBMFMCDLIGC<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr AEDCKMEIINL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
		public MBMFMCDLIGC(IntPtr JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x446E110", Offset = "0x446CD10", VA = "0x18446E110")]
		public int HEONFGBJNMF(TDeps EIDBKEEIBKK, TContext KKOKJDBNFON, TCompileState FAHLNPKGHIM, [In] JFDANJHACCB<byte> PNLIOBCLHBK, int HJCFKINBOFA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29B1D00", Offset = "0x29B0900", VA = "0x1829B1D00")]
	public static void OEHPBPAGEPO<TDeps, TContext, TCompileState>(TDeps EIDBKEEIBKK, TContext KKOKJDBNFON, TCompileState FAHLNPKGHIM, [In] JFDANJHACCB<byte> DLIDODLFELM, JFDANJHACCB<byte> KIMNDMJKFPE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CCDHANILAPE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? AJMJECMOMII, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? FHGKNKOEGGI, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ACDCEGBMBIH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DBOPCENBAGL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CBAEDDJNGKF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? FJIBENLHGKD, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HFKCJPFDAHH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LOBJMOOMNDH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JHCAPOFNBMC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EJNMBANOJMA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LIBMJEEFGLJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GGLEMPOKMNM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DMCMHKLHPMG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? AALMHEMIFEE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CBNMHJPFFMG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EDDIMBKAIIC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LIADBLPLJIP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CIFOIKKHEMN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? KNPHNBNBNFK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MDJCODILBED, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? POEFEIEEMEI, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PJHGBBDLOEM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JCNJGMBFKJL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? KNFJHJEGBON, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NPECBADECJA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GHJAJJNHGEI, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IPFGIEDALBJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? KDPCJJDBOHK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BJFEAIPDLIJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IHMLMNDFMLO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BKJNHOLAKIK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IKFIMBOPEHF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JHMHLAGNJIA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MANPEPIBJNE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DPFKCJJEKIL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PHOGJCIBABN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ONHJPLHFCDK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GHJEBIADOKP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IOODPGOFIHK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NCNEKECFNNM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IDLECGMEJBP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CFOHMOGDJMC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DNIHBGMJKKH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? KONINLAMLEJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LPEDIMDCEIK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? AJEPBMJPNLN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BHEPCGDOIFL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LGJOAJNDLHH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MCBMECFNBKP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JDGNNHNIMCJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? AENPNKJGCEH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LAOBMGEOIPM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JECONHNEBNG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IKBJLMJIJON, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NGOKDGNHOHA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MAMONNEHNJP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LCNAGAIPDPM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? APADMEHACEG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PELDAFHKCIL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GLBANDBBBFK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? FAMBMHCKDJE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ILJOPPIBEHJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HJMLFGNIGJF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DPPMJJGIBMO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LCFDHMAFLAA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NAEIHJNMKIA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LLOOEJDENPH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ADGBGPCAAHK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LGBBHGBNING, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GFGJELBLAON, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JKEMCMBBBOI, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ACGNHINFFLK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ACNKDNBCKIF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DJNMPJMHMGE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? OGEOIPNMDBB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DFCHNFONMAP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? KMBPANLMKDM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MDFOPGJDFAA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IKNAICNGOKO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? FDLLLHCDAGH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LKCIPLFEPPB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CIHPNLNBMDL, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JCOCJLBAELE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LOFAKBAJGMH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CAEPJAJHLEP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PGDMKOINOIO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JNJOMPIMLDC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GFELJOCOCEC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HJAJHCPOOJD, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BFLIIMBLLPF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PPHJHAHDFGM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? POFJGONAHIH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CKEBJBMAGNP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DCOKDKDGPFG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MHBLADLGPCA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HFHCMMGBMGM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LFNGMHIHMME, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EDEBKKEAJEC, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CMPEDEENKMH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LGLAJFMNLCH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CJOMAENNPPF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BNJLCAONMHM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NJCGGDIMOIN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MLKDJECMLPH, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NIDGPOCAHOD, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EKMONOJEBCE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HEDKNBLNLGE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JDMKIDGCNMN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IHKHEFCNHOO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MNOIKGJNLEJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? NHLODKCGBBB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? OGGDFECAJEA, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? ABNCMFIGGJM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EMPMHBJOBPP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? CNGMBKJPPEN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? LGDDNKNJIBB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? AHLFECGJDHK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IDPDCKFLEPP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? IJGCKPHCAIF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DBGLCODGPHJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? PBIBCBINHNK, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JAPLLFFNCKE, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HIPOGIBNKHB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? GBIFJADGBBF, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JFJCJHNOBLN, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? MKBPCIAKHPB, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? EKOMMDACOJJ, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? HHIHHODKFKM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JMJBGOCMCIO, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BMDDMMJAEBP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? JLJHOEKLOLG, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? FHICPHCHHDP, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? BJLHEMMCCMM, [Optional] MBMFMCDLIGC<TContext, TDeps, TCompileState>? DBJLIBDNJPP) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7D30", Offset = "0x1FC6930", VA = "0x181FC7D30")]
	private static int LLHKJJOFMAH([In] JFDANJHACCB<byte> LHEHPOLGBPN, JFDANJHACCB<byte> BIAIEKINDGJ, int CNNPCLMHBKN, int LLHINFJPPOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IAONHPKFCPF
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int BNJFDGBKPME;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B68050", Offset = "0x2B66C50", VA = "0x182B68050")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<T>> IPLMPINJLBP<T>([In] this JFDANJHACCB<byte> ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B680B0", Offset = "0x2B66CB0", VA = "0x182B680B0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<T>>> KJOMLLAJKKF<T>(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<T>>? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC80A0", Offset = "0x1FC6CA0", VA = "0x181FC80A0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<LLMICBBDFED>> JALFHGFLJAJ(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<LLMICBBDFED>? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<LLMICBBDFED>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8340", Offset = "0x1FC6F40", VA = "0x181FC8340")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>> OIHIFLEKHNI(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] float? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8180", Offset = "0x1FC6D80", VA = "0x181FC8180")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>> JGDCJPKLGBP(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8260", Offset = "0x1FC6E60", VA = "0x181FC8260")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>> NBKAIEFHHME(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<OHFLOCDKCBK>? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7EB0", Offset = "0x1FC6AB0", VA = "0x181FC7EB0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<FJBOIPDOCAM>> AKNHGOOCPKO(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] byte? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<FJBOIPDOCAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7DD0", Offset = "0x1FC69D0", VA = "0x181FC7DD0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<BGLFKEALHMM>> AEPFDFCAGBE(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<BGLFKEALHMM>? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<BGLFKEALHMM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7FB0", Offset = "0x1FC6BB0", VA = "0x181FC7FB0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> HFJLIMBBMFF(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] BJNKLFIFCOO? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F90", Offset = "0x2B66B90", VA = "0x182B67F90")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<T>>> ENKPKNAELCD<T>(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<T>>? IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7BB0", Offset = "0x1FC67B0", VA = "0x181FC7BB0")]
	public static void LIEADNNEDHJ(this JFDANJHACCB<byte> ENEDBNLKLJL, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>> CBKHNJIBFAH, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F80", Offset = "0x2B66B80", VA = "0x182B67F80")]
	public static void CAJKCIMPKBK<T>(this JFDANJHACCB<byte> ENEDBNLKLJL, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<T>>> HJCFKINBOFA, JCIKKDEFAFO<CBKKBBEDBLD<T>> IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F80", Offset = "0x2B66B80", VA = "0x182B67F80")]
	public static void CFACLOKPFJN<T>(this JFDANJHACCB<byte> ENEDBNLKLJL, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<T>>> AJBFKJBICHI, JCIKKDEFAFO<DKNAMEIKMHD<T>> IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AOECIHDEDMD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7C90", Offset = "0x1FC6890", VA = "0x181FC7C90")]
	public static OBHAAEALFBF LOFBKGFKLPB([In] this ReadOnlySpan<byte> GABEBEKDBIP, int OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7BF0", Offset = "0x1FC67F0", VA = "0x181FC7BF0")]
	public static OBHAAEALFBF LOFBKGFKLPB([In] this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3202780", Offset = "0x3201380", VA = "0x183202780")]
	public static OBHAAEALFBF LOFBKGFKLPB<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3202570", Offset = "0x3201170", VA = "0x183202570")]
	public static OBHAAEALFBF LOFBKGFKLPB<M>([In] this HBFMMOMHGCI<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3202250", Offset = "0x3200E50", VA = "0x183202250")]
	public static OBHAAEALFBF LOFBKGFKLPB<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32020F0", Offset = "0x3200CF0", VA = "0x1832020F0")]
	public static OBHAAEALFBF LOFBKGFKLPB<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32026C0", Offset = "0x32012C0", VA = "0x1832026C0")]
	public static OBHAAEALFBF LOFBKGFKLPB<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7C90", Offset = "0x1FC6890", VA = "0x181FC7C90")]
	public static int ODNOEAKFIMG([In] this ReadOnlySpan<byte> GABEBEKDBIP, int OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7AE0", Offset = "0x1FC66E0", VA = "0x181FC7AE0")]
	public static int ODNOEAKFIMG([In] this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static int ODNOEAKFIMG<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static int ODNOEAKFIMG<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static int ODNOEAKFIMG<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static int ODNOEAKFIMG<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3201F60", Offset = "0x3200B60", VA = "0x183201F60")]
	public static float AFEGKPPDHNE<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3201F60", Offset = "0x3200B60", VA = "0x183201F60")]
	public static float AFEGKPPDHNE<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3201F60", Offset = "0x3200B60", VA = "0x183201F60")]
	public static float AFEGKPPDHNE<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3202160", Offset = "0x3200D60", VA = "0x183202160")]
	public static byte EFHCIBLAFAL<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32022B0", Offset = "0x3200EB0", VA = "0x1832022B0")]
	public static byte EFHCIBLAFAL<M>([In] this HBFMMOMHGCI<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3202250", Offset = "0x3200E50", VA = "0x183202250")]
	public static byte EFHCIBLAFAL<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32020F0", Offset = "0x3200CF0", VA = "0x1832020F0")]
	public static byte EFHCIBLAFAL<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3202190", Offset = "0x3200D90", VA = "0x183202190")]
	public static byte EFHCIBLAFAL<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7AE0", Offset = "0x1FC66E0", VA = "0x181FC7AE0")]
	public static BJNKLFIFCOO GFCEHHECEOI([In] this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG)
	{
		return default(BJNKLFIFCOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static BJNKLFIFCOO GFCEHHECEOI<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(BJNKLFIFCOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3202080", Offset = "0x3200C80", VA = "0x183202080")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> DOJMIOOODGD<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3202010", Offset = "0x3200C10", VA = "0x183202010")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> DOJMIOOODGD<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3201FA0", Offset = "0x3200BA0", VA = "0x183201FA0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> DOJMIOOODGD<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32028D0", Offset = "0x32014D0", VA = "0x1832028D0")]
	public static JCIKKDEFAFO<DKNAMEIKMHD<OPFCLJJOIHA>> PDIJJDAOCFL<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<DKNAMEIKMHD<OPFCLJJOIHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3202500", Offset = "0x3201100", VA = "0x183202500")]
	public static JCIKKDEFAFO<BGLFKEALHMM> LAIAMOEOPGH<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<BGLFKEALHMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3202420", Offset = "0x3201020", VA = "0x183202420")]
	public static JCIKKDEFAFO<BGLFKEALHMM> LAIAMOEOPGH<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<BGLFKEALHMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3202490", Offset = "0x3201090", VA = "0x183202490")]
	public static JCIKKDEFAFO<BGLFKEALHMM> LAIAMOEOPGH<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<BGLFKEALHMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3202340", Offset = "0x3200F40", VA = "0x183202340")]
	public static JCIKKDEFAFO<LLMICBBDFED> GGCEMBMHDJA<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<LLMICBBDFED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32023B0", Offset = "0x3200FB0", VA = "0x1832023B0")]
	public static JCIKKDEFAFO<LLMICBBDFED> GGCEMBMHDJA<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<LLMICBBDFED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32022D0", Offset = "0x3200ED0", VA = "0x1832022D0")]
	public static JCIKKDEFAFO<OHFLOCDKCBK> FCCMHIKMKON<M>(this LDMIEKANPMO<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG)
	{
		return default(JCIKKDEFAFO<OHFLOCDKCBK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JHCJPPFILPG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDDF0", Offset = "0x1FCC9F0", VA = "0x181FCDDF0")]
	public static void AMIEEAHEHEL(this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG, OBHAAEALFBF IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDEB0", Offset = "0x1FCCAB0", VA = "0x181FCDEB0")]
	public static void AMIEEAHEHEL(this byte[] GABEBEKDBIP, int OCLHDMKBGBG, OBHAAEALFBF IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDF20", Offset = "0x1FCCB20", VA = "0x181FCDF20")]
	public static void AMIEEAHEHEL([In] this Span<byte> GABEBEKDBIP, int OCLHDMKBGBG, OBHAAEALFBF IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D740", Offset = "0x2B9C340", VA = "0x182B9D740")]
	public static void AMIEEAHEHEL<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, OBHAAEALFBF IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D5B0", Offset = "0x2B9C1B0", VA = "0x182B9D5B0")]
	public static void AMIEEAHEHEL<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, OBHAAEALFBF IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7BB0", Offset = "0x1FC67B0", VA = "0x181FC7BB0")]
	public static void LIEADNNEDHJ(this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE0D0", Offset = "0x1FCCCD0", VA = "0x181FCE0D0")]
	public static void LIEADNNEDHJ(this byte[] GABEBEKDBIP, int OCLHDMKBGBG, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE050", Offset = "0x1FCCC50", VA = "0x181FCE050")]
	public static void LIEADNNEDHJ([In] this Span<byte> GABEBEKDBIP, int OCLHDMKBGBG, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DA90", Offset = "0x2B9C690", VA = "0x182B9DA90")]
	public static void LIEADNNEDHJ<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DA30", Offset = "0x2B9C630", VA = "0x182B9DA30")]
	public static void LIEADNNEDHJ<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE010", Offset = "0x1FCCC10", VA = "0x181FCE010")]
	public static void HHBFKFAMEJM(this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG, float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D9D0", Offset = "0x2B9C5D0", VA = "0x182B9D9D0")]
	public static void HHBFKFAMEJM<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D970", Offset = "0x2B9C570", VA = "0x182B9D970")]
	public static void HHBFKFAMEJM<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDFA0", Offset = "0x1FCCBA0", VA = "0x181FCDFA0")]
	public static void FGGKIIHJAMD(this JFDANJHACCB<byte> GABEBEKDBIP, int OCLHDMKBGBG, byte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D8D0", Offset = "0x2B9C4D0", VA = "0x182B9D8D0")]
	public static void FGGKIIHJAMD<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, byte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D920", Offset = "0x2B9C520", VA = "0x182B9D920")]
	public static void FGGKIIHJAMD<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, byte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29E1580", Offset = "0x29E0180", VA = "0x1829E1580")]
	public static void CAJKCIMPKBK<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29E1580", Offset = "0x29E0180", VA = "0x1829E1580")]
	public static void CAJKCIMPKBK<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29E1580", Offset = "0x29E0180", VA = "0x1829E1580")]
	public static void LJHCCKOMCHB<M>(this PAOCMADHIKK<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, JCIKKDEFAFO<BGLFKEALHMM> IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29E1580", Offset = "0x29E0180", VA = "0x1829E1580")]
	public static void LJHCCKOMCHB<M>([In] this GJNABCCILOL<M, byte> GABEBEKDBIP, JCIKKDEFAFO<M> OCLHDMKBGBG, JCIKKDEFAFO<BGLFKEALHMM> IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JBBEJEPBLNH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9030", Offset = "0x1FC7C30", VA = "0x181FC9030")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) BHMMBLLCGOF(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9E60", Offset = "0x1FC8A60", VA = "0x181FC9E60")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) DLKBHGBLCPK(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD630", Offset = "0x1FCC230", VA = "0x181FCD630")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) PDNCHCDKLAG(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8AD0", Offset = "0x1FC76D0", VA = "0x181FC8AD0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) AIADBFEFOEH(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB920", Offset = "0x1FCA520", VA = "0x181FCB920")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) JEIOBJECLIF(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCDA0", Offset = "0x1FCB9A0", VA = "0x181FCCDA0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) MOHFLAIJGGD(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9940", Offset = "0x1FC8540", VA = "0x181FC9940")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) DJIFEBPEDLP(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9D10", Offset = "0x1FC8910", VA = "0x181FC9D10")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) DLFNLGLIIFD(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEF0", Offset = "0x1FC9AF0", VA = "0x181FCAEF0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) GMKMAIHEGCN(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FC92D0", Offset = "0x1FC7ED0", VA = "0x181FC92D0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>) BMLLHCDHKEI(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? IIPLJLPCLBC, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? OJABJBKIGNP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB010", Offset = "0x1FC9C10", VA = "0x181FCB010")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>) GOMGBCABNHC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? IIPLJLPCLBC, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? OJABJBKIGNP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC7F0", Offset = "0x1FCB3F0", VA = "0x181FCC7F0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>) LMMCBNLHIGD(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? IIPLJLPCLBC, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? OJABJBKIGNP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCADD0", Offset = "0x1FC99D0", VA = "0x181FCADD0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>) GJDFMMHMJOC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? IIPLJLPCLBC, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? OJABJBKIGNP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDC50", Offset = "0x1FCC850", VA = "0x181FCDC50")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<LLMICBBDFED>>) PMDMPOLGFDC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? EGJDPALHPPC, [Optional] JCIKKDEFAFO<LLMICBBDFED>? FKJLAAGOMNG)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<LLMICBBDFED>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA9E0", Offset = "0x1FC95E0", VA = "0x181FCA9E0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<LLMICBBDFED>>>) FOMLKIJEIGG(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? EGJDPALHPPC, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<LLMICBBDFED>>? FKJLAAGOMNG)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<LLMICBBDFED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8700", Offset = "0x1FC7300", VA = "0x181FC8700")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<BGLFKEALHMM>>) AGCIMKAFLIN(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? EGJDPALHPPC, [Optional] JCIKKDEFAFO<BGLFKEALHMM>? FKJLAAGOMNG)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<BGLFKEALHMM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCB70", Offset = "0x1FCB770", VA = "0x181FCCB70")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<BGLFKEALHMM>>>) MKDCGCNAPIC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? EGJDPALHPPC, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<BGLFKEALHMM>>? FKJLAAGOMNG)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<BGLFKEALHMM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B989B0", Offset = "0x2B975B0", VA = "0x182B989B0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>) BHGHEGBPGLP<TMarker>(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<OHFLOCDKCBK>? FKJLAAGOMNG, [Optional][In] ReadOnlySpan<byte> JGFKFMMOAJO)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC560", Offset = "0x1FCB160", VA = "0x181FCC560")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) LHJMOBHDNLJ(this JFDANJHACCB<byte> ENEDBNLKLJL, int LHEHPOLGBPN, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? BIAIEKINDGJ)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FC89C0", Offset = "0x1FC75C0", VA = "0x181FC89C0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) AHGNEHJBNDC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? LHEHPOLGBPN, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? BIAIEKINDGJ)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B98D00", Offset = "0x2B97900", VA = "0x182B98D00")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>) OHFNGHGLIAL<TMarker>(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<TMarker>>? BIAIEKINDGJ, [Optional] int? INGCLKPLIOP, [Optional][In] ReadOnlySpan<byte> LHEHPOLGBPN)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B98BB0", Offset = "0x2B977B0", VA = "0x182B98BB0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>) NEOEDLLKJPM<TMarker>(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<TMarker>>? LHEHPOLGBPN, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<TMarker>>? BIAIEKINDGJ, [Optional] int? INGCLKPLIOP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<TMarker>>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9540", Offset = "0x1FC8140", VA = "0x181FC9540")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) CFGHJCAIMFL(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9FB0", Offset = "0x1FC8BB0", VA = "0x181FC9FB0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) DPAGACALDAN(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA3A0", Offset = "0x1FC8FA0", VA = "0x181FCA3A0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) EHLLENFKBON(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBE70", Offset = "0x1FCAA70", VA = "0x181FCBE70")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) KDADAEMMNJE(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB3E0", Offset = "0x1FC9FE0", VA = "0x181FCB3E0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) IIGLFEDEKMD(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC88A0", Offset = "0x1FC74A0", VA = "0x181FC88A0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) AHAABBAONGP(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAAF0", Offset = "0x1FC96F0", VA = "0x181FCAAF0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) GAJIDJJIHME(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB130", Offset = "0x1FC9D30", VA = "0x181FCB130")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) HCDGJGFMFHJ(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA7B0", Offset = "0x1FC93B0", VA = "0x181FCA7B0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) FGLBDNJGFFL(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9C20", Offset = "0x1FC8820", VA = "0x181FC9C20")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>) DKHKJGIHIJE(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? EMGCLKCDMEO)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBCF0", Offset = "0x1FCA8F0", VA = "0x181FCBCF0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) KAICJFBFBPA(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FC96C0", Offset = "0x1FC82C0", VA = "0x181FC96C0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) DAELGHHEPKP(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBA70", Offset = "0x1FCA670", VA = "0x181FCBA70")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) JMEHDCBEJHB(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB280", Offset = "0x1FC9E80", VA = "0x181FCB280")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) HHCGMDCAGCJ(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCEC0", Offset = "0x1FCBAC0", VA = "0x181FCCEC0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) MPOCGLOHJBO(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA540", Offset = "0x1FC9140", VA = "0x181FCA540")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) ENMDOKAOFOL(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC280", Offset = "0x1FCAE80", VA = "0x181FCC280")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) KMKIOFKBNDJ(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FC85A0", Offset = "0x1FC71A0", VA = "0x181FC85A0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) AELCIGIMIBH(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD750", Offset = "0x1FCC350", VA = "0x181FCD750")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) PFNEEDLEEKG(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FC93E0", Offset = "0x1FC7FE0", VA = "0x181FC93E0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) CCICONKHLND(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB7D0", Offset = "0x1FCA3D0", VA = "0x181FCB7D0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) IOALNEBJELB(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCC80", Offset = "0x1FCB880", VA = "0x181FCCC80")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) MNLCKFNGOEK(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAC50", Offset = "0x1FC9850", VA = "0x181FCAC50")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) GEEGJDAIPPB(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD010", Offset = "0x1FCBC10", VA = "0x181FCD010")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) NAKFMAHBCFH(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8470", Offset = "0x1FC7070", VA = "0x181FC8470")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) AAAKPKMNGMI(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC690", Offset = "0x1FCB290", VA = "0x181FCC690")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) LIJMLLENIEP(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD880", Offset = "0x1FCC480", VA = "0x181FCD880")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) PIJCLPJHBNC(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB6B0", Offset = "0x1FCA2B0", VA = "0x181FCB6B0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) ILPLNFIAGKC(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9AA0", Offset = "0x1FC86A0", VA = "0x181FC9AA0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) DKAIGDEHOCB(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC120", Offset = "0x1FCAD20", VA = "0x181FCC120")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) KLPMOJLODHF(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDB20", Offset = "0x1FCC720", VA = "0x181FCDB20")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) PKJCMELPOHE(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD4D0", Offset = "0x1FCC0D0", VA = "0x181FCD4D0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) PCMECNEFIEH(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBBA0", Offset = "0x1FCA7A0", VA = "0x181FCBBA0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) JONOAJHONND(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD290", Offset = "0x1FCBE90", VA = "0x181FCD290")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) NJHDKKJAGFO(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB530", Offset = "0x1FCA130", VA = "0x181FCB530")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) IKGCBIJGKCL(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD9D0", Offset = "0x1FCC5D0", VA = "0x181FCD9D0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) PKIFMOHGDDO(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8F10", Offset = "0x1FC7B10", VA = "0x181FC8F10")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) BGFGNAPKODE(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC400", Offset = "0x1FCB000", VA = "0x181FCC400")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) LGCKCBMBCDP(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA660", Offset = "0x1FC9260", VA = "0x181FCA660")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) FFEDKAHFPBA(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC91B0", Offset = "0x1FC7DB0", VA = "0x181FC91B0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) BLMFHBAADCH(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCA60", Offset = "0x1FCB660", VA = "0x181FCCA60")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) MECGBEAPOPJ(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] int? KIFCFGGDFLM, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA8D0", Offset = "0x1FC94D0", VA = "0x181FCA8D0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) FLLFOMOPNKM(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? KIFCFGGDFLM, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA4C0", Offset = "0x1FC90C0", VA = "0x181FCA4C0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> EJLMLOOEBCA(this JFDANJHACCB<byte> ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8C30", Offset = "0x1FC7830", VA = "0x181FC8C30")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) BCECLICCBJL(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA250", Offset = "0x1FC8E50", VA = "0x181FCA250")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) EHCCJCJOOJB(this JFDANJHACCB<byte> ENEDBNLKLJL, float EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DFIJNLBNPMB>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD3B0", Offset = "0x1FCBFB0", VA = "0x181FCD3B0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>) ONOIMHCPJBJ(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<DFIJNLBNPMB>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<DFIJNLBNPMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC900", Offset = "0x1FCB500", VA = "0x181FCC900")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) MAEOMMKMCHB(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA100", Offset = "0x1FC8D00", VA = "0x181FCA100")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) ECNENGBJFIM(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD170", Offset = "0x1FCBD70", VA = "0x181FCD170")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) NDNKIOHHFCP(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8DB0", Offset = "0x1FC79B0", VA = "0x181FC8DB0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) BEIJNIMMJNJ(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBFD0", Offset = "0x1FCABD0", VA = "0x181FCBFD0")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) KEHHAKPDKNP(this JFDANJHACCB<byte> ENEDBNLKLJL, int EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9820", Offset = "0x1FC8420", VA = "0x181FC9820")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>) DCMHOENKPOP(this JFDANJHACCB<byte> ENEDBNLKLJL, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? EIMAMGODFEG, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? PMIMEIKCDGB, [Optional] JCIKKDEFAFO<DKNAMEIKMHD<CEBNLENGEOG>>? NOLBJCLDPHP)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<CEBNLENGEOG>>>));
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
