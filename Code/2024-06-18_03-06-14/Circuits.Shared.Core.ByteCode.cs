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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F9D510", Offset = "0x1F9BF10", VA = "0x181F9D510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FNFDNEEGBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A69FE0", Offset = "0x2A689E0", VA = "0x182A69FE0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<M>> GJNGGFEFHAF<M>(this int BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F97310", Offset = "0x1F95D10", VA = "0x181F97310")]
	public static AEAOKLPMJLF<FDJGKMNJDKI> EOOJIHCFINP(this int BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<FDJGKMNJDKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A69FE0", Offset = "0x2A689E0", VA = "0x182A69FE0")]
	public static AEAOKLPMJLF<PNEAIIFMLDM<M>> MJMJANLNFCG<M>(this int BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<PNEAIIFMLDM<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MPIMPNCNAOI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BEOPNPDIICN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CHLIDABPDDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FDJGKMNJDKI
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BDKFFLBNIHO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BKPMNJDBNBB
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HHMBKFJGHOO
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
public static class NDFJHOJCJDD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OPPGMMEELED<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr FINLKJIMOCI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
		public OPPGMMEELED(IntPtr PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4626F80", Offset = "0x4625980", VA = "0x184626F80")]
		public int EDIAJIJOMBB(TDeps GMLBPALEECE, TContext KNJFLEFNAIO, TCompileState OJHEFGCKEAI, [In] KHFGELOKLHG<byte> CMALLBAECMJ, int LMJCPBMGFKO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C788C0", Offset = "0x2C772C0", VA = "0x182C788C0")]
	public static void DINHOPDAKEC<TDeps, TContext, TCompileState>(TDeps GMLBPALEECE, TContext KNJFLEFNAIO, TCompileState OJHEFGCKEAI, [In] KHFGELOKLHG<byte> NIEEFCBENGA, KHFGELOKLHG<byte> NHEFDJPJCPF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? FGFLAPDFFNA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JDMADDHBBOM, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JFMLDPFPPDF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? IJDBEHAOLBD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JNDJFHMDOHO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? AJKCJEDPPMF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LBCGIFFPBKL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HDKGKMJNKFO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HLCLALLLICO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CBGGEKKDOJP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ECFPLADBBLE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BCJEIHHAKFM, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NFHPHMPGKGA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KPCBEPBJPOE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ELJEFBGIGAE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OHNPAEKKEIP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KJOFOEIDGOK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OKNBKGLCFFK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MHCMAMFEPIP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KNJKLEAJDEJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GAIDAHMPAGH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EFABOBMGJKM, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? FCGKOFKAMKA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? PKOBHFKNOEI, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EKCKCKMPNJH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? DOKIJLALLED, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HPAPAJAMLMK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CDBPKKCCICI, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MNNENGHNBGO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? PDHCDFNMLIL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JGFNAHMBJEK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HCADNIDGNNG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KOJMKIDOFDG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ICPJLAFMILN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BINCIHFGNJM, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JHJKONBKNHO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MHEIKBJFGDC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BCBHLNBFNCB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HMKKKMAFDFK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CNLKDBPPCPE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LGLMNAHHOOP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ECKPLOLOPOO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CDNFLPCGBFP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CKIIPMHAPKJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BNGOBJAJFHJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GNKIAEJNKGG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HBOJOFJJBPC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? DAAOBJNJNKD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EDCFHKOAFNL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HONIMHJBOMN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ILDPCCBHHKJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LBFIIDCEHFG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MEHNGOKNOKE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? DGDAGAFAFFN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GIKGEOCLAJL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JDEHOKGJHOE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HJFKKLEGEGC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JCNDHMDDECN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NCIHCNHILAG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CAGKACJFHNL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LALGDKFKPAC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BFALEFPHBEE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HNJLFJHHHMP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? IDBJMDLOKMD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HKEJPMIBIOH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JEKNLGPDEMB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NAIELBPFIDO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GFEFJGDDJGN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NDOEKMCAJHC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GKOGFANFEIL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EHEDPFJPPLF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OBPMPDIKHBO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CHAAJPCCJFB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HNCOJJOEGHB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MJJBAAFKHIC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? PPHINJPECLE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JJJPABHPHJF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CFBGLEHGELI, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BBBAMEKJKIJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? IPKKCBPMCGO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JLFJBBICNMF, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EIFBLGFHFML, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LDBPEEDCPOO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JFBPOEIGNKE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GNJGEJGAKHK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CPDHHJKGBIA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NKNNPCKFFJN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EFDEEJPJMEB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ALKOOOOGNMD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MNBIKIALLEE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JJHKDKCFHPH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ACNDCPEDPPC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LMMDLCNDOPI, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KDHLAHEMFCN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? MJFEOAOKCPH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BCGGJGGEAFA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BNINMANODMC, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NHKMDMGJDOB, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HAFLPNGNGEO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? PHHGEJLHCFP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HAGAPJPBIND, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? GCPHGKLFAJH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JEEJPCEKHEP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OKDMCPGADCE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OCMAEEEGIJK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JNAOFOPLJIP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HJOHHIHGNBA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ADEPKJIFIIK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OALHPDICMID, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BLHEGKGHAKN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NEDEOLCPLNE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? OBOLAHOANEG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? AMEKMIOLNPD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? JMOEDLBCFCL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? FFIBOPDNLDE, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? ALPGMHCKEGN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KEHBJGKBJNO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CJDIKLOKPED, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? AHNLBKEKDCD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? FCEMIFMMIEL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HKGNNEGHAMH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EPJNODFLNDJ, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BLJHPIFANNL, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? BDEOCFCGKIN, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HCOIBEDBJIO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? IBNBBDCAMIA, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? CBJEDLONFLI, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? FHKFHGJDHFO, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? KKDLDJDLAMK, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HGADNIEMOHG, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? EHJJGDHGJDP, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? HIGHEFEHPHH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? LKJGNKACBMH, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? NJBNIMCPCGD, [Optional] OPPGMMEELED<TContext, TDeps, TCompileState>? DOLMCOKPDJK) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F97AF0", Offset = "0x1F964F0", VA = "0x181F97AF0")]
	private static int ICFHPDHGOKA([In] KHFGELOKLHG<byte> CLIKFJHOANF, KHFGELOKLHG<byte> IAJKDACGMME, int BPFHAJJBCKE, int OHELHAFFKFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KLDCNOBEGPG
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int AIOHFBPHMBG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBDE0", Offset = "0x2BBA7E0", VA = "0x182BBBDE0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<T>> FDOGODIIMMP<T>([In] this KHFGELOKLHG<byte> BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD20", Offset = "0x2BBA720", VA = "0x182BBBD20")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<T>>> DJKDNCEDKPG<T>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<T>>? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F97720", Offset = "0x1F96120", VA = "0x181F97720")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<PLOGIFEADJP>> INCGFGGDFCC(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PLOGIFEADJP>? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<PLOGIFEADJP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F978E0", Offset = "0x1F962E0", VA = "0x181F978E0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>> KPIMLHHFHMJ(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] float? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F97450", Offset = "0x1F95E50", VA = "0x181F97450")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>> AOLNAHCDJEG(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F979D0", Offset = "0x1F963D0", VA = "0x181F979D0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>> LNAHEEACPFF(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<FNJJLOFGLPE>? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F97620", Offset = "0x1F96020", VA = "0x181F97620")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<BKPMNJDBNBB>> GFOBMMCEFEC(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] byte? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<BKPMNJDBNBB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F97800", Offset = "0x1F96200", VA = "0x181F97800")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<FDJGKMNJDKI>> KIJOLHKPBBG(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<FDJGKMNJDKI>? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<FDJGKMNJDKI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F97530", Offset = "0x1F95F30", VA = "0x181F97530")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> EMPIIFCLJJM(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] HHMBKFJGHOO? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBE40", Offset = "0x2BBA840", VA = "0x182BBBE40")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<T>>> IKFJJFHOPFH<T>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<T>>? DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F96EC0", Offset = "0x1F958C0", VA = "0x181F96EC0")]
	public static void PKCOIIONEKJ(this KHFGELOKLHG<byte> BBCPNLGGBMJ, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>> LEONGBOKNFC, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD10", Offset = "0x2BBA710", VA = "0x182BBBD10")]
	public static void DBNCOBFHIMP<T>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<T>>> LMJCPBMGFKO, AEAOKLPMJLF<MPIMPNCNAOI<T>> DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD10", Offset = "0x2BBA710", VA = "0x182BBBD10")]
	public static void MMKLLELIAKK<T>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<T>>> KFJLKENJMCJ, AEAOKLPMJLF<PNEAIIFMLDM<T>> DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IGLPOEFFANG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F97340", Offset = "0x1F95D40", VA = "0x181F97340")]
	public static KMKODCHIEIO MMFGALDMKOA([In] this ReadOnlySpan<byte> KKELJOOMKNM, int JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F973B0", Offset = "0x1F95DB0", VA = "0x181F973B0")]
	public static KMKODCHIEIO MMFGALDMKOA([In] this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B57060", Offset = "0x2B55A60", VA = "0x182B57060")]
	public static KMKODCHIEIO MMFGALDMKOA<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B57210", Offset = "0x2B55C10", VA = "0x182B57210")]
	public static KMKODCHIEIO MMFGALDMKOA<M>([In] this IIHCBBNJLCK<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B571B0", Offset = "0x2B55BB0", VA = "0x182B571B0")]
	public static KMKODCHIEIO MMFGALDMKOA<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B57370", Offset = "0x2B55D70", VA = "0x182B57370")]
	public static KMKODCHIEIO MMFGALDMKOA<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B573E0", Offset = "0x2B55DE0", VA = "0x182B573E0")]
	public static KMKODCHIEIO MMFGALDMKOA<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F97340", Offset = "0x1F95D40", VA = "0x181F97340")]
	public static int BGDEPADMODO([In] this ReadOnlySpan<byte> KKELJOOMKNM, int JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F96F00", Offset = "0x1F95900", VA = "0x181F96F00")]
	public static int BGDEPADMODO([In] this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static int BGDEPADMODO<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static int BGDEPADMODO<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static int BGDEPADMODO<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static int BGDEPADMODO<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B56D80", Offset = "0x2B55780", VA = "0x182B56D80")]
	public static float JDALJJMAGHE<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B56D80", Offset = "0x2B55780", VA = "0x182B56D80")]
	public static float JDALJJMAGHE<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B56D80", Offset = "0x2B55780", VA = "0x182B56D80")]
	public static float JDALJJMAGHE<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B57580", Offset = "0x2B55F80", VA = "0x182B57580")]
	public static byte PGNKOBIJBGE<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B574A0", Offset = "0x2B55EA0", VA = "0x182B574A0")]
	public static byte PGNKOBIJBGE<M>([In] this IIHCBBNJLCK<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B571B0", Offset = "0x2B55BB0", VA = "0x182B571B0")]
	public static byte PGNKOBIJBGE<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B57370", Offset = "0x2B55D70", VA = "0x182B57370")]
	public static byte PGNKOBIJBGE<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B574C0", Offset = "0x2B55EC0", VA = "0x182B574C0")]
	public static byte PGNKOBIJBGE<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F96F00", Offset = "0x1F95900", VA = "0x181F96F00")]
	public static HHMBKFJGHOO CPAIKOFGJGC([In] this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ)
	{
		return default(HHMBKFJGHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static HHMBKFJGHOO CPAIKOFGJGC<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(HHMBKFJGHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B56C30", Offset = "0x2B55630", VA = "0x182B56C30")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> IALCCDEAHHO<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B56D10", Offset = "0x2B55710", VA = "0x182B56D10")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> IALCCDEAHHO<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B56CA0", Offset = "0x2B556A0", VA = "0x182B56CA0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> IALCCDEAHHO<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B56FF0", Offset = "0x2B559F0", VA = "0x182B56FF0")]
	public static AEAOKLPMJLF<PNEAIIFMLDM<ABOEOBPACKI>> MJJNJIMJKOI<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<PNEAIIFMLDM<ABOEOBPACKI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B56DC0", Offset = "0x2B557C0", VA = "0x182B56DC0")]
	public static AEAOKLPMJLF<FDJGKMNJDKI> JGIACINIDMI<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<FDJGKMNJDKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B56EA0", Offset = "0x2B558A0", VA = "0x182B56EA0")]
	public static AEAOKLPMJLF<FDJGKMNJDKI> JGIACINIDMI<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<FDJGKMNJDKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B56E30", Offset = "0x2B55830", VA = "0x182B56E30")]
	public static AEAOKLPMJLF<FDJGKMNJDKI> JGIACINIDMI<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<FDJGKMNJDKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B56F80", Offset = "0x2B55980", VA = "0x182B56F80")]
	public static AEAOKLPMJLF<PLOGIFEADJP> KMMODHPIKDF<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<PLOGIFEADJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B56F10", Offset = "0x2B55910", VA = "0x182B56F10")]
	public static AEAOKLPMJLF<PLOGIFEADJP> KMMODHPIKDF<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<PLOGIFEADJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B56BC0", Offset = "0x2B555C0", VA = "0x182B56BC0")]
	public static AEAOKLPMJLF<FNJJLOFGLPE> FLMDAPIDHCA<M>(this GHNOBFHKCJH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ)
	{
		return default(AEAOKLPMJLF<FNJJLOFGLPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CMMBDLLAEIM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F97150", Offset = "0x1F95B50", VA = "0x181F97150")]
	public static void KIBCEKPJNFJ(this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ, KMKODCHIEIO DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F97060", Offset = "0x1F95A60", VA = "0x181F97060")]
	public static void KIBCEKPJNFJ(this byte[] KKELJOOMKNM, int JPMGDOMJOOJ, KMKODCHIEIO DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F970D0", Offset = "0x1F95AD0", VA = "0x181F970D0")]
	public static void KIBCEKPJNFJ([In] this Span<byte> KKELJOOMKNM, int JPMGDOMJOOJ, KMKODCHIEIO DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2934370", Offset = "0x2932D70", VA = "0x182934370")]
	public static void KIBCEKPJNFJ<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, KMKODCHIEIO DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2934510", Offset = "0x2932F10", VA = "0x182934510")]
	public static void KIBCEKPJNFJ<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, KMKODCHIEIO DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F96EC0", Offset = "0x1F958C0", VA = "0x181F96EC0")]
	public static void PKCOIIONEKJ(this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F97290", Offset = "0x1F95C90", VA = "0x181F97290")]
	public static void PKCOIIONEKJ(this byte[] KKELJOOMKNM, int JPMGDOMJOOJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F97210", Offset = "0x1F95C10", VA = "0x181F97210")]
	public static void PKCOIIONEKJ([In] this Span<byte> KKELJOOMKNM, int JPMGDOMJOOJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2934710", Offset = "0x2933110", VA = "0x182934710")]
	public static void PKCOIIONEKJ<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29346B0", Offset = "0x29330B0", VA = "0x1829346B0")]
	public static void PKCOIIONEKJ<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F97020", Offset = "0x1F95A20", VA = "0x181F97020")]
	public static void KDDDDIAPFPD(this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ, float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29342B0", Offset = "0x2932CB0", VA = "0x1829342B0")]
	public static void KDDDDIAPFPD<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2934310", Offset = "0x2932D10", VA = "0x182934310")]
	public static void KDDDDIAPFPD<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F96FB0", Offset = "0x1F959B0", VA = "0x181F96FB0")]
	public static void JANPEHEIBJI(this KHFGELOKLHG<byte> KKELJOOMKNM, int JPMGDOMJOOJ, byte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2934210", Offset = "0x2932C10", VA = "0x182934210")]
	public static void JANPEHEIBJI<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, byte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2934260", Offset = "0x2932C60", VA = "0x182934260")]
	public static void JANPEHEIBJI<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, byte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29341E0", Offset = "0x2932BE0", VA = "0x1829341E0")]
	public static void DBNCOBFHIMP<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29341E0", Offset = "0x2932BE0", VA = "0x1829341E0")]
	public static void DBNCOBFHIMP<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29341E0", Offset = "0x2932BE0", VA = "0x1829341E0")]
	public static void GCGJFANPHJK<M>(this PIKOAONDHKH<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, AEAOKLPMJLF<FDJGKMNJDKI> DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29341E0", Offset = "0x2932BE0", VA = "0x1829341E0")]
	public static void GCGJFANPHJK<M>([In] this JBOGPJDECJB<M, byte> KKELJOOMKNM, AEAOKLPMJLF<M> JPMGDOMJOOJ, AEAOKLPMJLF<FDJGKMNJDKI> DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NFMAILMAEHO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A6D0", Offset = "0x1F990D0", VA = "0x181F9A6D0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) JGOHIPDBLDH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F99940", Offset = "0x1F98340", VA = "0x181F99940")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) HALKAMHNBAK(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1F99E20", Offset = "0x1F98820", VA = "0x181F99E20")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) IFMBOODCPPJ(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C400", Offset = "0x1F9AE00", VA = "0x181F9C400")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) NACJGBOPLIM(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F98820", Offset = "0x1F97220", VA = "0x181F98820")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) CEOBLHIOEAC(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D3F0", Offset = "0x1F9BDF0", VA = "0x181F9D3F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) PLEONMANJMH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B2C0", Offset = "0x1F99CC0", VA = "0x181F9B2C0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) KOBMMJMBDLK(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D140", Offset = "0x1F9BB40", VA = "0x181F9D140")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) PBBHNAAMBML(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F99050", Offset = "0x1F97A50", VA = "0x181F99050")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) EADOFBKBEGE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CD00", Offset = "0x1F9B700", VA = "0x181F9CD00")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>) OBHCCFJMBEH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? DBOBEHLEAAE, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? CHFLMAIPEDD)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F996D0", Offset = "0x1F980D0", VA = "0x181F996D0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>) FDEMEGEBPGD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? DBOBEHLEAAE, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? CHFLMAIPEDD)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AC60", Offset = "0x1F99660", VA = "0x181F9AC60")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>) KFEDMFEFEBG(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? DBOBEHLEAAE, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? CHFLMAIPEDD)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F99450", Offset = "0x1F97E50", VA = "0x181F99450")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>) ELBACKGDBNP(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? DBOBEHLEAAE, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? CHFLMAIPEDD)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BFF0", Offset = "0x1F9A9F0", VA = "0x181F9BFF0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PLOGIFEADJP>>) MLEKBPHOJPL(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? NGFMHNJIMKH, [Optional] AEAOKLPMJLF<PLOGIFEADJP>? MFKPABNLOJE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PLOGIFEADJP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CBF0", Offset = "0x1F9B5F0", VA = "0x181F9CBF0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<PLOGIFEADJP>>>) NPPLGPIHGHH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? NGFMHNJIMKH, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<PLOGIFEADJP>>? MFKPABNLOJE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<PLOGIFEADJP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B120", Offset = "0x1F99B20", VA = "0x181F9B120")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<FDJGKMNJDKI>>) KMNOMBLKEOL(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? NGFMHNJIMKH, [Optional] AEAOKLPMJLF<FDJGKMNJDKI>? MFKPABNLOJE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<FDJGKMNJDKI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CAE0", Offset = "0x1F9B4E0", VA = "0x181F9CAE0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<FDJGKMNJDKI>>>) NOBJBFBGFLA(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? NGFMHNJIMKH, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<FDJGKMNJDKI>>? MFKPABNLOJE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<FDJGKMNJDKI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DA20", Offset = "0x2C7C420", VA = "0x182C7DA20")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>) HEEDPDKKIHC<TMarker>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<FNJJLOFGLPE>? MFKPABNLOJE, [Optional][In] ReadOnlySpan<byte> EEOBDBMOHPL)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F98470", Offset = "0x1F96E70", VA = "0x181F98470")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BMNIIIEHIGF(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int CLIKFJHOANF, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? IAJKDACGMME)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B800", Offset = "0x1F9A200", VA = "0x181F9B800")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) LIOJGAPHCBP(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? CLIKFJHOANF, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? IAJKDACGMME)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DC20", Offset = "0x2C7C620", VA = "0x182C7DC20")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>) PKAFMPJEEIC<TMarker>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<TMarker>>? IAJKDACGMME, [Optional] int? BKEGNEKBPFA, [Optional][In] ReadOnlySpan<byte> CLIKFJHOANF)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D8D0", Offset = "0x2C7C2D0", VA = "0x182C7D8D0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>) DDNALPDGGKK<TMarker>(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<TMarker>>? CLIKFJHOANF, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<TMarker>>? IAJKDACGMME, [Optional] int? BKEGNEKBPFA)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<TMarker>>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C830", Offset = "0x1F9B230", VA = "0x181F9C830")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) NGJGOGMFCKH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AEC0", Offset = "0x1F998C0", VA = "0x181F9AEC0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) KIMENAJPAPD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F99BE0", Offset = "0x1F985E0", VA = "0x181F99BE0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) HGGBNFBIJDD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B910", Offset = "0x1F9A310", VA = "0x181F9B910")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MBAHMPDLGIB(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BA70", Offset = "0x1F9A470", VA = "0x181F9BA70")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MCHGIJBOEHB(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1F98700", Offset = "0x1F97100", VA = "0x181F98700")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) CCHMFDHBJHB(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1F992F0", Offset = "0x1F97CF0", VA = "0x181F992F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) EGJKAKJHKBI(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F99A90", Offset = "0x1F98490", VA = "0x181F99A90")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) HGBCMECGNFM(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F989F0", Offset = "0x1F973F0", VA = "0x181F989F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) CIPEBKMFHOC(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CE10", Offset = "0x1F9B810", VA = "0x181F9CE10")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>) OFEOAKHBBDF(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? DJIFAMLOLPE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BD10", Offset = "0x1F9A710", VA = "0x181F9BD10")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MJNINAKNAKP(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F99570", Offset = "0x1F97F70", VA = "0x181F99570")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) ENMEKJOHFBE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A0C0", Offset = "0x1F98AC0", VA = "0x181F9A0C0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) IIAPBILJDPP(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1F98D90", Offset = "0x1F97790", VA = "0x181F98D90")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) DBLAONIFKGI(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A460", Offset = "0x1F98E60", VA = "0x181F9A460")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) JEHGBPIMHEF(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C190", Offset = "0x1F9AB90", VA = "0x181F9C190")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MLNDPKLMCLA(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F98050", Offset = "0x1F96A50", VA = "0x181F98050")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BIIFNEGNPOB(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B420", Offset = "0x1F99E20", VA = "0x181F9B420")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) KOEOIJMNIAI(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B580", Offset = "0x1F99F80", VA = "0x181F9B580")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) LAIFCIHHIEH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BE90", Offset = "0x1F9A890", VA = "0x181F9BE90")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MKADPPKPGOJ(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F997F0", Offset = "0x1F981F0", VA = "0x181F997F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) FKDFDGOGONL(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F97F30", Offset = "0x1F96930", VA = "0x181F97F30")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BGIAABCIFMA(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C6B0", Offset = "0x1F9B0B0", VA = "0x181F9C6B0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) NCLHEOMIGCN(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F98B10", Offset = "0x1F97510", VA = "0x181F98B10")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) CNAFCNCBDCC(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C9B0", Offset = "0x1F9B3B0", VA = "0x181F9C9B0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) NLDGAGFBNNH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F97DD0", Offset = "0x1F967D0", VA = "0x181F97DD0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) AGHGHIELBKG(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AD70", Offset = "0x1F99770", VA = "0x181F9AD70")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) KIBCLIBLCAG(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F98C70", Offset = "0x1F97670", VA = "0x181F98C70")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) CPMLIFLEBEL(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F982F0", Offset = "0x1F96CF0", VA = "0x181F982F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BLMLCOKNPIH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A9A0", Offset = "0x1F993A0", VA = "0x181F9A9A0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) JMLLJPFLLBH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D010", Offset = "0x1F9BA10", VA = "0x181F9D010")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) OPGDGHKLFJO(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F98EF0", Offset = "0x1F978F0", VA = "0x181F98EF0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) DNDGOIGFEII(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C2B0", Offset = "0x1F9ACB0", VA = "0x181F9C2B0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) NAAODFIJABE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F981D0", Offset = "0x1F96BD0", VA = "0x181F981D0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BLBNBNIMBJH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1F99F40", Offset = "0x1F98940", VA = "0x181F99F40")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) IHEMOFJILID(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B6B0", Offset = "0x1F9A0B0", VA = "0x181F9B6B0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) LDMIJDFOLGF(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F97CB0", Offset = "0x1F966B0", VA = "0x181F97CB0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) ACDMOFHPKAH(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F985A0", Offset = "0x1F96FA0", VA = "0x181F985A0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) BODNLBHFHMD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A310", Offset = "0x1F98D10", VA = "0x181F9A310")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) JAGHNECCMEN(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A1F0", Offset = "0x1F98BF0", VA = "0x181F9A1F0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) IMGEFKNILJB(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CF00", Offset = "0x1F9B900", VA = "0x181F9CF00")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) OMILFEBPMAE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] int? BADPHCDPFGF, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B010", Offset = "0x1F99A10", VA = "0x181F9B010")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) KKKHJMPNCKJ(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? BADPHCDPFGF, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F98970", Offset = "0x1F97370", VA = "0x181F98970")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CIOIFNNBADE(this KHFGELOKLHG<byte> BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F99170", Offset = "0x1F97B70", VA = "0x181F99170")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) EEPDMCFFPNE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C560", Offset = "0x1F9AF60", VA = "0x181F9C560")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) NAKAPPOFBLP(this KHFGELOKLHG<byte> BBCPNLGGBMJ, float JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<BEOPNPDIICN>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F97B90", Offset = "0x1F96590", VA = "0x181F97B90")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>) AAKEGOOGHLE(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<BEOPNPDIICN>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<BEOPNPDIICN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AB00", Offset = "0x1F99500", VA = "0x181F9AB00")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) KBPJLCIIEHO(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BBC0", Offset = "0x1F9A5C0", VA = "0x181F9BBC0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) MDBKHGANLDD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A5B0", Offset = "0x1F98FB0", VA = "0x181F9A5B0")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) JFANDMLFICL(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D290", Offset = "0x1F9BC90", VA = "0x181F9D290")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) PLAGFEJPFJD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A850", Offset = "0x1F99250", VA = "0x181F9A850")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) JJGDPFKCFBD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, int JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F99D00", Offset = "0x1F98700", VA = "0x181F99D00")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>) HIKNEHLFIJD(this KHFGELOKLHG<byte> BBCPNLGGBMJ, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? JAEBINEILPK, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? HODNNKKLCPA, [Optional] AEAOKLPMJLF<PNEAIIFMLDM<CHLIDABPDDH>>? PAJPAPGLHBE)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<CHLIDABPDDH>>>));
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
