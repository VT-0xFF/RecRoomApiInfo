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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2228190", Offset = "0x2227590", VA = "0x182228190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCLBJNLOMIG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDD290", VA = "0x182BDDE90")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<M>> OKEKDAIGFGG<M>(this int MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2221F90", Offset = "0x2221390", VA = "0x182221F90")]
	public static FGLBFCBPBCD<HMLIDFJANJN> ALGOMCOJAJL(this int MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<HMLIDFJANJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDD290", VA = "0x182BDDE90")]
	public static FGLBFCBPBCD<AJBGMCAKAFC<M>> PILAFEPAJEC<M>(this int MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<AJBGMCAKAFC<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MFKEBFFAIOJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BFIDOFFBNHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NJOMBHMDOJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HMLIDFJANJN
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KOFGJDFDGPO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HIPLMLAMJLP
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BCBICGDDPFK
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
public static class GMNNPHNPKJJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LHGKDAJMDAF<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KECJEOHFKGE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
		public LHGKDAJMDAF(IntPtr GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x460BDB0", Offset = "0x460B1B0", VA = "0x18460BDB0")]
		public int JNFLGGLMFJH(TDeps ICFGLKCGHOG, TContext NGJELCHDMKO, TCompileState GOBLAKEDFJJ, [In] GCECACNENLC<byte> KFOBMMPNFED, int NNFDHNAHEAO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E6DCE0", Offset = "0x2E6D0E0", VA = "0x182E6DCE0")]
	public static void BEDCDJGFHOF<TDeps, TContext, TCompileState>(TDeps ICFGLKCGHOG, TContext NGJELCHDMKO, TCompileState GOBLAKEDFJJ, [In] GCECACNENLC<byte> IDOOFMLIBMI, GCECACNENLC<byte> KJEAJBLBOMF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IPGDGFGEALM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PNPBNHNDFKE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GLHEPONIILG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FKILFPEBOAC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GGGOEJCCNPK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FADPLDDDHFI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? INEMAJJACGP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LLMOOLCEEGE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HBCMDAKKCCM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EIMCPFKPMDC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EMAEEOIDEPJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IMGGPKGMMBM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GOLGOBHOBOL, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FEIFBALFKCL, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PIBMBMOMGIF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KFKIOLBFEPK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LHBAAODONJI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JCMLHLFEDNH, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JNHGIIPDLDI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? ILLOMAADMAN, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IGDJMJPECAM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? NLPCNJKABNG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HAOFEJKOPCB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? ICGDEBPKALB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FDOPJBCNIJA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FFLOCNEFBPL, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LIBMLPBHCIM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IIHGLHGAFLF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FIPGNLKENAJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DGLBJCAIHGB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CHCABOHPPBG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LHJJGBNNPGI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IECFPDFFGKE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BAEGDIOEHKM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KGONNPMLDFD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BGCGJLOIFIN, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? AGIBMFMBFML, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KBGAJMCKNEN, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HDGMCEOCLLH, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KBCDDCDCHEA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PAEIPHKJEHA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FDMDHMBCDFJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IHDNFLLBDGD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EFNPEJNBHII, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? OCLCKPDOFNA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JKPHFODGMLK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KJFAKAKKFEP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IAEBIFEJOBO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CBGBOPHCJBD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LMPOJMCELMJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CKFLFOAMIHB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KLECCMLDDBM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KMCNBLEKLGE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IIIENANDNMC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DMGBAGBCHBM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JIGFANJEJLL, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PPIKDLFNGJI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PHMALBMDHPH, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LNDFBKBKCNA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JJJKMBLGHKD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CCHLOHDJBDH, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MAGEJPDAAFP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CJLGJMFKDII, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MJIJGBOGPID, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GCIIECOOFOF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IAAMKPOIAMG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FDNAEKHLPND, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? OLFJIOJJGEJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BLKOFAIONMF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IKCLMKBOCPP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KAEAGEEDMON, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PLNPDMDHHGJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MFIMEKINGOO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MNMDIBDLAJG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EDMHAFHGFDB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? OLIHFDFFDKF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LEPOAEPJAKM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? INILCOPMBEI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CNFANJLHAOC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FJHONBCDPGD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LCFHMLEJEPN, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CFGIMHEFLMJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BLAOKPKGEKJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HCPLMJAPKMJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EEJEEHBKJAK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DHNIBCMDEMJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MGKHKIBAFDF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FCJIFOBCJMI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PBNEMAAHINC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JKFONEBEONO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CLOPNIONBGD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KKJJOHFPEOC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? OCKMIGGCJOP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? AHGGBAGLDCC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DKHHFHMHKCI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BDODMKOPPKJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PHFABHOBNGF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JGGAHLGHPAJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MFEPLNIGIGI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KKAHIAHGGFD, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JHJANEBLOGJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HFCDGHFABIC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EHDKAPMPFEE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PPCEFNKKICG, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KGNHGPIDFKI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LJMNKBDFMLO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KDEBIDACAAJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? IEKAOOJGNCK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DBGMILMHAFF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? DAECLHPNGHP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JMEEGALELLC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? JBFHJPGJDNM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KEJKLOMDJPM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LKHDLEJPHEK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GDLNBFANJFI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? EEKHBLDGJCN, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KJHJLFKFEHB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GIDNCBJBIIA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? ONBLPKKGDKJ, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? OGIDCBMPGMA, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? NFBCKFDGALC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GODHMOFBOIM, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? HLACBOMGAPI, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? NIFGBBLDOAK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GECJCNDJFKC, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? KPFECKDJEKK, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FGLHNKAPFEF, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? BBGPGNKONHH, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? PLENJEAHIKB, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? GDLEOBHGHBE, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MKMCONKDENP, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? FPOLNEBHEJO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? LOCLHLGBNMO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? CFFPNDCEOPO, [Optional] LHGKDAJMDAF<TContext, TDeps, TCompileState>? MFLBKKPHLNB) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22220D0", Offset = "0x22214D0", VA = "0x1822220D0")]
	private static int FCEJEBHMIAG([In] GCECACNENLC<byte> NCNPDGLPGME, GCECACNENLC<byte> CAPKHGDIEMA, int AKMLIMIBFHO, int MGEMHICLKEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HJBKKDIDNEI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int PHPDLHIEICG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E881A0", Offset = "0x2E875A0", VA = "0x182E881A0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<T>> HGIEHJCBBJP<T>([In] this GCECACNENLC<byte> MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E88200", Offset = "0x2E87600", VA = "0x182E88200")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<T>>> INOHLLMDLCC<T>(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<T>>? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22226F0", Offset = "0x2221AF0", VA = "0x1822226F0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<AJCNMBKOFNE>> OPMBLPBNKNA(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJCNMBKOFNE>? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<AJCNMBKOFNE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2222340", Offset = "0x2221740", VA = "0x182222340")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>> CADIDFICBKO(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] float? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2222610", Offset = "0x2221A10", VA = "0x182222610")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>> OCJNOFGMPNC(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2222430", Offset = "0x2221830", VA = "0x182222430")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>> CJCDJNPGFHE(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<KNHPKNCFPBE>? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2222510", Offset = "0x2221910", VA = "0x182222510")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<HIPLMLAMJLP>> JEJEGGGMBFO(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] byte? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<HIPLMLAMJLP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2222260", Offset = "0x2221660", VA = "0x182222260")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<HMLIDFJANJN>> BELNNIKCGHO(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<HMLIDFJANJN>? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<HMLIDFJANJN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2222170", Offset = "0x2221570", VA = "0x182222170")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> ALFCPEDLPKD(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] BCBICGDDPFK? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E882D0", Offset = "0x2E876D0", VA = "0x182E882D0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<T>>> OCKEKCOHCDC<T>(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<T>>? LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2221F50", Offset = "0x2221350", VA = "0x182221F50")]
	public static void MHCCODFFLFH(this GCECACNENLC<byte> MBGHIKEGJAA, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>> FKOCDCNFNNA, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E882C0", Offset = "0x2E876C0", VA = "0x182E882C0")]
	public static void NHOMCNEGGEJ<T>(this GCECACNENLC<byte> MBGHIKEGJAA, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<T>>> NNFDHNAHEAO, FGLBFCBPBCD<MFKEBFFAIOJ<T>> LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E882C0", Offset = "0x2E876C0", VA = "0x182E882C0")]
	public static void MDNMFCMDEBN<T>(this GCECACNENLC<byte> MBGHIKEGJAA, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<T>>> BGEDAOAHMPM, FGLBFCBPBCD<AJBGMCAKAFC<T>> LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FOBMLJFECMN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2222060", Offset = "0x2221460", VA = "0x182222060")]
	public static KCFDAINDPGI FCNHPPJNNFD([In] this ReadOnlySpan<byte> HFHEELJJDFM, int IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2221FC0", Offset = "0x22213C0", VA = "0x182221FC0")]
	public static KCFDAINDPGI FCNHPPJNNFD([In] this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C210", Offset = "0x2E5B610", VA = "0x182E5C210")]
	public static KCFDAINDPGI FCNHPPJNNFD<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C0B0", Offset = "0x2E5B4B0", VA = "0x182E5C0B0")]
	public static KCFDAINDPGI FCNHPPJNNFD<M>([In] this BOLEPNFEDDL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BE90", Offset = "0x2E5B290", VA = "0x182E5BE90")]
	public static KCFDAINDPGI FCNHPPJNNFD<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BD40", Offset = "0x2E5B140", VA = "0x182E5BD40")]
	public static KCFDAINDPGI FCNHPPJNNFD<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BFF0", Offset = "0x2E5B3F0", VA = "0x182E5BFF0")]
	public static KCFDAINDPGI FCNHPPJNNFD<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2222060", Offset = "0x2221460", VA = "0x182222060")]
	public static int OOBKHBDBNAB([In] this ReadOnlySpan<byte> HFHEELJJDFM, int IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2221E80", Offset = "0x2221280", VA = "0x182221E80")]
	public static int OOBKHBDBNAB([In] this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDBD0", Offset = "0x2BDCFD0", VA = "0x182BDDBD0")]
	public static int OOBKHBDBNAB<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDBD0", Offset = "0x2BDCFD0", VA = "0x182BDDBD0")]
	public static int OOBKHBDBNAB<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDBD0", Offset = "0x2BDCFD0", VA = "0x182BDDBD0")]
	public static int OOBKHBDBNAB<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDBD0", Offset = "0x2BDCFD0", VA = "0x182BDDBD0")]
	public static int OOBKHBDBNAB<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF40", Offset = "0x2E5B340", VA = "0x182E5BF40")]
	public static float CPGODNPGAOJ<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF40", Offset = "0x2E5B340", VA = "0x182E5BF40")]
	public static float CPGODNPGAOJ<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF40", Offset = "0x2E5B340", VA = "0x182E5BF40")]
	public static float CPGODNPGAOJ<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BD10", Offset = "0x2E5B110", VA = "0x182E5BD10")]
	public static byte BELMAIALOFF<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BE70", Offset = "0x2E5B270", VA = "0x182E5BE70")]
	public static byte BELMAIALOFF<M>([In] this BOLEPNFEDDL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BE90", Offset = "0x2E5B290", VA = "0x182E5BE90")]
	public static byte BELMAIALOFF<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BD40", Offset = "0x2E5B140", VA = "0x182E5BD40")]
	public static byte BELMAIALOFF<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BDB0", Offset = "0x2E5B1B0", VA = "0x182E5BDB0")]
	public static byte BELMAIALOFF<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2221E80", Offset = "0x2221280", VA = "0x182221E80")]
	public static BCBICGDDPFK POIEJLIDMNP([In] this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB)
	{
		return default(BCBICGDDPFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDBD0", Offset = "0x2BDCFD0", VA = "0x182BDDBD0")]
	public static BCBICGDDPFK POIEJLIDMNP<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(BCBICGDDPFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C4B0", Offset = "0x2E5B8B0", VA = "0x182E5C4B0")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIBIMOOGDKP<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C590", Offset = "0x2E5B990", VA = "0x182E5C590")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIBIMOOGDKP<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C520", Offset = "0x2E5B920", VA = "0x182E5C520")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIBIMOOGDKP<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF80", Offset = "0x2E5B380", VA = "0x182E5BF80")]
	public static FGLBFCBPBCD<AJBGMCAKAFC<OIGPANGPEIL>> EMHBLEBMKNI<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<AJBGMCAKAFC<OIGPANGPEIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C6E0", Offset = "0x2E5BAE0", VA = "0x182E5C6E0")]
	public static FGLBFCBPBCD<HMLIDFJANJN> PLJJDDAIOEN<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<HMLIDFJANJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C600", Offset = "0x2E5BA00", VA = "0x182E5C600")]
	public static FGLBFCBPBCD<HMLIDFJANJN> PLJJDDAIOEN<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<HMLIDFJANJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C670", Offset = "0x2E5BA70", VA = "0x182E5C670")]
	public static FGLBFCBPBCD<HMLIDFJANJN> PLJJDDAIOEN<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<HMLIDFJANJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C3D0", Offset = "0x2E5B7D0", VA = "0x182E5C3D0")]
	public static FGLBFCBPBCD<AJCNMBKOFNE> LBIKDBBLEEG<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<AJCNMBKOFNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C440", Offset = "0x2E5B840", VA = "0x182E5C440")]
	public static FGLBFCBPBCD<AJCNMBKOFNE> LBIKDBBLEEG<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<AJCNMBKOFNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C360", Offset = "0x2E5B760", VA = "0x182E5C360")]
	public static FGLBFCBPBCD<KNHPKNCFPBE> JMLEAALJOHD<M>(this FCMFIIGFAIL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB)
	{
		return default(FGLBFCBPBCD<KNHPKNCFPBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class POJADJOFHNG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2228280", Offset = "0x2227680", VA = "0x182228280")]
	public static void BDOOHPIDCOK(this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB, KCFDAINDPGI LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22283C0", Offset = "0x22277C0", VA = "0x1822283C0")]
	public static void BDOOHPIDCOK(this byte[] HFHEELJJDFM, int IKLMBMAPKMB, KCFDAINDPGI LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2228340", Offset = "0x2227740", VA = "0x182228340")]
	public static void BDOOHPIDCOK([In] this Span<byte> HFHEELJJDFM, int IKLMBMAPKMB, KCFDAINDPGI LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x301EDC0", Offset = "0x301E1C0", VA = "0x18301EDC0")]
	public static void BDOOHPIDCOK<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, KCFDAINDPGI LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x301EC20", Offset = "0x301E020", VA = "0x18301EC20")]
	public static void BDOOHPIDCOK<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, KCFDAINDPGI LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2221F50", Offset = "0x2221350", VA = "0x182221F50")]
	public static void MHCCODFFLFH(this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22284F0", Offset = "0x22278F0", VA = "0x1822284F0")]
	public static void MHCCODFFLFH(this byte[] HFHEELJJDFM, int IKLMBMAPKMB, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2228470", Offset = "0x2227870", VA = "0x182228470")]
	public static void MHCCODFFLFH([In] this Span<byte> HFHEELJJDFM, int IKLMBMAPKMB, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x301F080", Offset = "0x301E480", VA = "0x18301F080")]
	public static void MHCCODFFLFH<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x301F020", Offset = "0x301E420", VA = "0x18301F020")]
	public static void MHCCODFFLFH<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2228430", Offset = "0x2227830", VA = "0x182228430")]
	public static void HNFCCKPEGNM(this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB, float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x301EFC0", Offset = "0x301E3C0", VA = "0x18301EFC0")]
	public static void HNFCCKPEGNM<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x301EF60", Offset = "0x301E360", VA = "0x18301EF60")]
	public static void HNFCCKPEGNM<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2228210", Offset = "0x2227610", VA = "0x182228210")]
	public static void AKKEILNBJKL(this GCECACNENLC<byte> HFHEELJJDFM, int IKLMBMAPKMB, byte LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x301EBD0", Offset = "0x301DFD0", VA = "0x18301EBD0")]
	public static void AKKEILNBJKL<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, byte LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x301EB80", Offset = "0x301DF80", VA = "0x18301EB80")]
	public static void AKKEILNBJKL<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, byte LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED00", Offset = "0x2BDE100", VA = "0x182BDED00")]
	public static void NHOMCNEGGEJ<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED00", Offset = "0x2BDE100", VA = "0x182BDED00")]
	public static void NHOMCNEGGEJ<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, FGLBFCBPBCD<MFKEBFFAIOJ<OIGPANGPEIL>> LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED00", Offset = "0x2BDE100", VA = "0x182BDED00")]
	public static void HBJKPNMPMFK<M>(this OAPEIPDONBD<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, FGLBFCBPBCD<HMLIDFJANJN> LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED00", Offset = "0x2BDE100", VA = "0x182BDED00")]
	public static void HBJKPNMPMFK<M>([In] this FEEOHBDMIAL<M, byte> HFHEELJJDFM, FGLBFCBPBCD<M> IKLMBMAPKMB, FGLBFCBPBCD<HMLIDFJANJN> LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HMEKOBGKLHA
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2223B50", Offset = "0x2222F50", VA = "0x182223B50")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) ECCHPJDAHPF(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2225F10", Offset = "0x2225310", VA = "0x182225F10")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) KKNNFMEIKIC(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2226EF0", Offset = "0x22262F0", VA = "0x182226EF0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) NFODHIIFAPP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2224790", Offset = "0x2223B90", VA = "0x182224790")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) GIODBDIIDIN(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2227380", Offset = "0x2226780", VA = "0x182227380")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) OEPHJGBPHJJ(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2224E00", Offset = "0x2224200", VA = "0x182224E00")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) HJJKJMAOIPI(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2224F20", Offset = "0x2224320", VA = "0x182224F20")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) IFPNOCAFDFJ(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2225880", Offset = "0x2224C80", VA = "0x182225880")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) JMGLBLMJEFD(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22262A0", Offset = "0x22256A0", VA = "0x1822262A0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) LAAHAOBFNBD(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2226060", Offset = "0x2225460", VA = "0x182226060")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>) KNKAEJGGFCB(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? LIHHDPOHLDK, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? JIENJCEOCMG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2226DD0", Offset = "0x22261D0", VA = "0x182226DD0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>) NCLIKHPNAPJ(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LIHHDPOHLDK, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? JIENJCEOCMG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2227630", Offset = "0x2226A30", VA = "0x182227630")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>) OKAGBLEEBJH(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? LIHHDPOHLDK, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? JIENJCEOCMG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2224A10", Offset = "0x2223E10", VA = "0x182224A10")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>) GPGJKKPFDLP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LIHHDPOHLDK, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? JIENJCEOCMG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2223090", Offset = "0x2222490", VA = "0x182223090")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJCNMBKOFNE>>) BNPKOBDNCMB(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? BBKGNBHEDIG, [Optional] FGLBFCBPBCD<AJCNMBKOFNE>? HGNEAAOPDDM)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJCNMBKOFNE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2222A80", Offset = "0x2221E80", VA = "0x182222A80")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<AJCNMBKOFNE>>>) AHNFHHGAMMP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? BBKGNBHEDIG, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<AJCNMBKOFNE>>? HGNEAAOPDDM)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<AJCNMBKOFNE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2223E30", Offset = "0x2223230", VA = "0x182223E30")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<HMLIDFJANJN>>) EKFLNKAODMI(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? BBKGNBHEDIG, [Optional] FGLBFCBPBCD<HMLIDFJANJN>? HGNEAAOPDDM)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<HMLIDFJANJN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2224150", Offset = "0x2223550", VA = "0x182224150")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<HMLIDFJANJN>>>) EPNANHJHJLP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? BBKGNBHEDIG, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<HMLIDFJANJN>>? HGNEAAOPDDM)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<HMLIDFJANJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E891F0", Offset = "0x2E885F0", VA = "0x182E891F0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>) NLJNKNHHIIL<TMarker>(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<KNHPKNCFPBE>? HGNEAAOPDDM, [Optional][In] ReadOnlySpan<byte> MPMEGOKIEPF)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<KNHPKNCFPBE>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x22237C0", Offset = "0x2222BC0", VA = "0x1822237C0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) DFKIKMLDGBL(this GCECACNENLC<byte> MBGHIKEGJAA, int NCNPDGLPGME, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? CAPKHGDIEMA)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22238F0", Offset = "0x2222CF0", VA = "0x1822238F0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) DHAEEHOPMGM(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? NCNPDGLPGME, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? CAPKHGDIEMA)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E89000", Offset = "0x2E88400", VA = "0x182E89000")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>) HIEPLNNGGEE<TMarker>(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<TMarker>>? CAPKHGDIEMA, [Optional] int? MFKKELONDCC, [Optional][In] ReadOnlySpan<byte> NCNPDGLPGME)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E88EB0", Offset = "0x2E882B0", VA = "0x182E88EB0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>) GDMDGDOJGFK<TMarker>(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<TMarker>>? NCNPDGLPGME, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<TMarker>>? CAPKHGDIEMA, [Optional] int? MFKKELONDCC)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<TMarker>>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2227EB0", Offset = "0x22272B0", VA = "0x182227EB0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) PMDELCIGNBJ(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2222F40", Offset = "0x2222340", VA = "0x182222F40")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) BDKDJLDHKAB(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22232B0", Offset = "0x22226B0", VA = "0x1822232B0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) CLKLKGFHNCP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2227220", Offset = "0x2226620", VA = "0x182227220")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) ODLIFGJLNMI(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x22251E0", Offset = "0x22245E0", VA = "0x1822251E0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) IMDNJOKBEPN(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2227740", Offset = "0x2226B40", VA = "0x182227740")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) OOBONFKFOBM(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x22274D0", Offset = "0x22268D0", VA = "0x1822274D0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) OFCCJOCLCOE(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2223670", Offset = "0x2222A70", VA = "0x182223670")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) DEAMABFACKM(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22269F0", Offset = "0x2225DF0", VA = "0x1822269F0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) MHOBCGCHNDG(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2227130", Offset = "0x2226530", VA = "0x182227130")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>) OCEEOLJDPON(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>? FEGNCHGJCKG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<MFKEBFFAIOJ<KOFGJDFDGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2225700", Offset = "0x2224B00", VA = "0x182225700")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) JEJKNLANPJE(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2226C70", Offset = "0x2226070", VA = "0x182226C70")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) MLGCOBFLHLH(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2224660", Offset = "0x2223A60", VA = "0x182224660")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) GINPALDBNGF(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x22279C0", Offset = "0x2226DC0", VA = "0x1822279C0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) PDMFBBBEPIN(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2225DC0", Offset = "0x22251C0", VA = "0x182225DC0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) KIBMLMKPKNI(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2223550", Offset = "0x2222950", VA = "0x182223550")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) DEAEDEAELIG(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2223FD0", Offset = "0x22233D0", VA = "0x182223FD0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) EOEGMNEIOBJ(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2225080", Offset = "0x2224480", VA = "0x182225080")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) IGCCPJJKEJE(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2222E10", Offset = "0x2222210", VA = "0x182222E10")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) ALFDCGECKAI(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2228030", Offset = "0x2227430", VA = "0x182228030")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) PNPFMHKLGHE(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2223A00", Offset = "0x2222E00", VA = "0x182223A00")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) DINLEAEIPBL(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2222CF0", Offset = "0x22220F0", VA = "0x182222CF0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) ALAJIAIGKKH(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2224C80", Offset = "0x2224080", VA = "0x182224C80")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) HJDOOGHHKPK(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x22263C0", Offset = "0x22257C0", VA = "0x1822263C0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) LAHFAIJPCDD(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x22243E0", Offset = "0x22237E0", VA = "0x1822243E0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) FEHKPHNDOFO(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2223CD0", Offset = "0x22230D0", VA = "0x182223CD0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) EHCCECKJKAB(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2226780", Offset = "0x2225B80", VA = "0x182226780")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) MEINEILBHPB(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x22268D0", Offset = "0x2225CD0", VA = "0x1822268D0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) MFIHADMOKPD(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2224260", Offset = "0x2223660", VA = "0x182224260")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) FAOIENMAINF(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2226B10", Offset = "0x2225F10", VA = "0x182226B10")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) MJHPKONEALB(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2226170", Offset = "0x2225570", VA = "0x182226170")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) KOOLFGMCFBG(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2227860", Offset = "0x2226C60", VA = "0x182227860")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) OOIPDFHFKEK(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2224B30", Offset = "0x2223F30", VA = "0x182224B30")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) HIBFCOKNEGK(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2222960", Offset = "0x2221D60", VA = "0x182222960")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) AFFJCDLGAIA(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2225C40", Offset = "0x2225040", VA = "0x182225C40")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) KHHAHBHGKND(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2226630", Offset = "0x2225A30", VA = "0x182226630")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) LNIHGBEFBJJ(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2227010", Offset = "0x2226410", VA = "0x182227010")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) NLDICDDPKLP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2222B90", Offset = "0x2221F90", VA = "0x182222B90")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) AJEGOIHNKGG(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2222810", Offset = "0x2221C10", VA = "0x182222810")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) AEKGPGEFGII(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x22259D0", Offset = "0x2224DD0", VA = "0x1822259D0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) KCJODEAFCDM(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2226520", Offset = "0x2225920", VA = "0x182226520")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) LCFOPLBIHHC(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] int? ICLJGNCFMNB, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2225330", Offset = "0x2224730", VA = "0x182225330")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) IPNLHNOAMDP(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? ICLJGNCFMNB, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2223230", Offset = "0x2222630", VA = "0x182223230")]
	public static FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>> CFGFJMNNIIA(this GCECACNENLC<byte> MBGHIKEGJAA)
	{
		return default(FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x22233D0", Offset = "0x22227D0", VA = "0x1822233D0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) DDJNAPIBIOB(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, float LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2225AF0", Offset = "0x2224EF0", VA = "0x182225AF0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) KGLNBMMOBIO(this GCECACNENLC<byte> MBGHIKEGJAA, float HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<BFIDOFFBNHA>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2227C70", Offset = "0x2227070", VA = "0x182227C70")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>) PHDNEBKEECI(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<BFIDOFFBNHA>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<BFIDOFFBNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2225440", Offset = "0x2224840", VA = "0x182225440")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) JBAMBDDECPI(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2224510", Offset = "0x2223910", VA = "0x182224510")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) FFNDAFCPLFN(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2227D90", Offset = "0x2227190", VA = "0x182227D90")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) PLHDIHMPOBO(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22255A0", Offset = "0x22249A0", VA = "0x1822255A0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) JEJIFAALKIJ(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, int LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2227B20", Offset = "0x2226F20", VA = "0x182227B20")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) PEFGAGNALJO(this GCECACNENLC<byte> MBGHIKEGJAA, int HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<NJOMBHMDOJN>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x22248F0", Offset = "0x2223CF0", VA = "0x1822248F0")]
	public static (FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>) GOMNLHJBMBA(this GCECACNENLC<byte> MBGHIKEGJAA, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? HCFNCMBKLPD, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? LMLEOKOHLPN, [Optional] FGLBFCBPBCD<AJBGMCAKAFC<NJOMBHMDOJN>>? IKMEDDHNAEG)
	{
		return default((FGLBFCBPBCD<MFKEBFFAIOJ<KOFGJDFDGPO>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>, FGLBFCBPBCD<MFKEBFFAIOJ<AJBGMCAKAFC<NJOMBHMDOJN>>>));
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
