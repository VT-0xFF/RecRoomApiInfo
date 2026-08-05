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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2328140", Offset = "0x2327540", VA = "0x182328140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class POPBNJFOAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0990", Offset = "0x2DDFD90", VA = "0x182DE0990")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<M>> OBKIGAOPIPI<M>(this int MPLBPEBNKFP)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23281C0", Offset = "0x23275C0", VA = "0x1823281C0")]
	public static AHPCDKCOAJM<IPMFEDIBEJG> HHGAGBFOBGE(this int MPLBPEBNKFP)
	{
		return default(AHPCDKCOAJM<IPMFEDIBEJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0990", Offset = "0x2DDFD90", VA = "0x182DE0990")]
	public static AHPCDKCOAJM<KDELIBNFOCF<M>> LPKLPAHDLEB<M>(this int MPLBPEBNKFP)
	{
		return default(AHPCDKCOAJM<KDELIBNFOCF<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class KAJPEAJEOBP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PEDFLONPPIM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GDHCOENIGOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class IPMFEDIBEJG
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class OEAKGGMIJOK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PABNIFALCFK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GAHHCLECEIM
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
public static class FOCHJECJNOH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KBIMONMMJAJ<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr ICFOFAMGABF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
		public KBIMONMMJAJ(IntPtr HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x46596F0", Offset = "0x4658AF0", VA = "0x1846596F0")]
		public int CAHJKFNDGBI(TDeps CFAPAOIIPAA, TContext FODBDHHLEGI, TCompileState DJMKAOCFEID, [In] OGHLOBLCDJI<byte> FBPEIIJLOML, int FKKFEPOMLIK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x302E750", Offset = "0x302DB50", VA = "0x18302E750")]
	public static void BBLNMGKFHDE<TDeps, TContext, TCompileState>(TDeps CFAPAOIIPAA, TContext FODBDHHLEGI, TCompileState DJMKAOCFEID, [In] OGHLOBLCDJI<byte> BBCANLAKKNJ, OGHLOBLCDJI<byte> JOHHAGPKCEG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CONKGABEDBN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? POCABKOIGDK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FMMDNHPNEHJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CDELCEDIHHJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NFDAFPIEPLG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DNFOKGILFPP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DNMCFJAIFNF, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OOEMKHHDGMO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LKBCLCOIFAO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CKONGDNJMEP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DFAEMOECDIG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NCLKCLFDKJF, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? HKPIMHMANIE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JOHKHDEDNBE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? KCAACIGJBPH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DLOOMEHAAEK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AMKMGMOAPNJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MHMFCMOOMDE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OGNLHOKDALF, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CHOAGIMADFI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ECKOJGPFKIA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FJJKPKKHILK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AFBFKKCFAGG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? HPDCDKCNAIN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DNMELJCLPNM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GPOGKFCBNBO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LHNEMPCCANE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BDIFJLOAHLK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AIPAGJJBEGD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AADGMNEKFDO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JNFGPDLLFHE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? EKDLOIICHBJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DKLCDNNIFMB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ECCNMMGPMOP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LGDAANIPBMP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AEPKPBDPLFP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PLNMGPMIEKB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OKAMLEMOGLA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NIDJMNPJBCJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GONDBGGCIIM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LHNFJPDMCMO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JOJDILAIPHN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DFCJPHEAGBA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GCCLHGJMNJI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DECPCEOGAPM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CAFEBNLMEGG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JJEBGJIFMAL, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FAJBBDAJDLJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FGMCFOJCLEH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BGGHGDGNGHD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JLFMDKLFHMF, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DDAIKHFMKHK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DOPOPEOPJJD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PKLBFLDNLFE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GAACHHHNPNH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DLPIMHADKBN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? IEJICLONBLD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MKEBMIIBIKM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? EJEFIKMJIEE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JPPBHNHLMJI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BLEFHDPDJLN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LDNHEMEMECO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BDKOFGDAHAJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OJJDEFGCMMA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? HCCAJIIDHOA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? KCBDOMICPGI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OJCNEGNNLLC, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CBBFKOPAHNB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? KMFLLODEJHB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MJBODFJBHOD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ILEBCBDALMO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PLLDJHKMILK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PFAPNCPCGFH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OIDIKMPNBGG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CILBFHCEKFH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MMKAOOCAHAM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GKIOCPMGAGK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OGJNOCJMLIN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FCCKNNPLMKJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? KBNLHBGMJOP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LPABLMKAGLC, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ADABHBOFDAN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CLCELHNFGJM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MCHCHDEDFOB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AFKFNNFCMID, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BPHMKPNEIOO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NOLDADMDJBA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BPNICEBOPCE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PBMOKEPHOPK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CGMJEOGIIAM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? PGIGAOLFJBP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JLBFPKDNOOP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ONCBICPMBFF, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BBDDCAPKPKC, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MBCBMNMAOEC, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OPFJELAKCFO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CAALKAKMOOI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BABHGKANHLP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? APHPJNJMFDN, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MJAJJKOHJLP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GBCAKBKMGGM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LNIPHENMKKE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BMOHLHOIEAB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? IBEMAHDHNLM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OLLBAHAINHK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CKIBENIGDKJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NOOMHMFLNGG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DMGIFBMHMKL, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? BEDKGDFMFBH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AMKGLPEIKLI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CBGPOGLMPAE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NMFEKHLPHBH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NOPOGBKJNAP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JJLEPDNJDAJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DMMKPJDAHGB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? FDBBFANCLIE, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? HFNIGJJIOLD, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DLPCOFLIJNI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? OPLHKGGHIOO, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CNCHNJJELMK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? MDAMOIBNFBJ, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AKPIGHILODM, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JEGFIFPODEA, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? JADELNLOKOC, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? LFKFHPMJHBB, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? AHKAFJOLPIH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GGEOHCBPEEG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? EJICEFMGBNG, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? DOFPNAJCEBI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? KCHIMLPBGJH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? GGACJNNKIOI, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? HAIFDCFDGBK, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? NJOBJCLFNAP, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? CNMCLIDGFIH, [Optional] KBIMONMMJAJ<TContext, TDeps, TCompileState>? ANHEOCFHCPF) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2322610", Offset = "0x2321A10", VA = "0x182322610")]
	private static int BBLPCDCACKA([In] OGHLOBLCDJI<byte> INPBKEEADJL, OGHLOBLCDJI<byte> NHJAKHBPCNL, int JJJPINFOLNN, int ABPDJOGPHFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AKDHPLCGCPO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int ONNFDNOCNAE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x372D160", Offset = "0x372C560", VA = "0x18372D160")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<T>> DLAHAMBKABF<T>([In] this OGHLOBLCDJI<byte> MPLBPEBNKFP)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x372D280", Offset = "0x372C680", VA = "0x18372D280")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<T>>> IHPEFOCFPPG<T>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<T>>? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23224F0", Offset = "0x23218F0", VA = "0x1823224F0")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<LIBEKEBHKBM>> OOHKPBJGMFA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<LIBEKEBHKBM>? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<LIBEKEBHKBM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2322150", Offset = "0x2321550", VA = "0x182322150")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>> IDNFOHEIDBA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] float? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2322070", Offset = "0x2321470", VA = "0x182322070")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>> EAIFLGDCKIJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2322410", Offset = "0x2321810", VA = "0x182322410")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<DDMDBKCCCHF>> MBGIFFMCPJP(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<DDMDBKCCCHF>? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<DDMDBKCCCHF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2321F70", Offset = "0x2321370", VA = "0x182321F70")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<PABNIFALCFK>> DFMAGFPEGPH(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] byte? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<PABNIFALCFK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2322240", Offset = "0x2321640", VA = "0x182322240")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<IPMFEDIBEJG>> JKKOABPHPDN(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<IPMFEDIBEJG>? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<IPMFEDIBEJG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2322320", Offset = "0x2321720", VA = "0x182322320")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>> JNMCFFHIJGM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] GAHHCLECEIM? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x372D1C0", Offset = "0x372C5C0", VA = "0x18372D1C0")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<T>>> HGCPPAHOEPB<T>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<T>>? HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2321A60", Offset = "0x2320E60", VA = "0x182321A60")]
	public static void KLLAPLBPGMD(this OGHLOBLCDJI<byte> MPLBPEBNKFP, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>> MIIDKOMADBP, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x372D340", Offset = "0x372C740", VA = "0x18372D340")]
	public static void IPKOKLLGOKB<T>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<T>>> FKKFEPOMLIK, AHPCDKCOAJM<KAJPEAJEOBP<T>> HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x372D340", Offset = "0x372C740", VA = "0x18372D340")]
	public static void PBLEFIJDBHF<T>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<T>>> EIJGHAFOKOO, AHPCDKCOAJM<KDELIBNFOCF<T>> HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JANFAFEMBBA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x23226B0", Offset = "0x2321AB0", VA = "0x1823226B0")]
	public static FNGOKDJHLLJ PEMLFAFNECD([In] this ReadOnlySpan<byte> MDABPMPEKPN, int FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2322720", Offset = "0x2321B20", VA = "0x182322720")]
	public static FNGOKDJHLLJ PEMLFAFNECD([In] this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30C9C50", Offset = "0x30C9050", VA = "0x1830C9C50")]
	public static FNGOKDJHLLJ PEMLFAFNECD<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x30C9A40", Offset = "0x30C8E40", VA = "0x1830C9A40")]
	public static FNGOKDJHLLJ PEMLFAFNECD<M>([In] this LPBGCOBPNFC<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x30C9470", Offset = "0x30C8870", VA = "0x1830C9470")]
	public static FNGOKDJHLLJ PEMLFAFNECD<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30C9520", Offset = "0x30C8920", VA = "0x1830C9520")]
	public static FNGOKDJHLLJ PEMLFAFNECD<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30C9B90", Offset = "0x30C8F90", VA = "0x1830C9B90")]
	public static FNGOKDJHLLJ PEMLFAFNECD<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23226B0", Offset = "0x2321AB0", VA = "0x1823226B0")]
	public static int CBBEPPLMNCI([In] this ReadOnlySpan<byte> MDABPMPEKPN, int FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2321B60", Offset = "0x2320F60", VA = "0x182321B60")]
	public static int CBBEPPLMNCI([In] this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30C9390", Offset = "0x30C8790", VA = "0x1830C9390")]
	public static int CBBEPPLMNCI<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30C9390", Offset = "0x30C8790", VA = "0x1830C9390")]
	public static int CBBEPPLMNCI<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30C9390", Offset = "0x30C8790", VA = "0x1830C9390")]
	public static int CBBEPPLMNCI<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30C9390", Offset = "0x30C8790", VA = "0x1830C9390")]
	public static int CBBEPPLMNCI<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30C9430", Offset = "0x30C8830", VA = "0x1830C9430")]
	public static float EPFAHBDOHBH<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30C9430", Offset = "0x30C8830", VA = "0x1830C9430")]
	public static float EPFAHBDOHBH<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30C9430", Offset = "0x30C8830", VA = "0x1830C9430")]
	public static float EPFAHBDOHBH<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30C94F0", Offset = "0x30C88F0", VA = "0x1830C94F0")]
	public static byte HIJDLLPNLFK<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30C94D0", Offset = "0x30C88D0", VA = "0x1830C94D0")]
	public static byte HIJDLLPNLFK<M>([In] this LPBGCOBPNFC<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30C9470", Offset = "0x30C8870", VA = "0x1830C9470")]
	public static byte HIJDLLPNLFK<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30C9520", Offset = "0x30C8920", VA = "0x1830C9520")]
	public static byte HIJDLLPNLFK<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30C9590", Offset = "0x30C8990", VA = "0x1830C9590")]
	public static byte HIJDLLPNLFK<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2321B60", Offset = "0x2320F60", VA = "0x182321B60")]
	public static GAHHCLECEIM BBHNIKFJLBO([In] this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC)
	{
		return default(GAHHCLECEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30C9390", Offset = "0x30C8790", VA = "0x1830C9390")]
	public static GAHHCLECEIM BBHNIKFJLBO<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(GAHHCLECEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30C9810", Offset = "0x30C8C10", VA = "0x1830C9810")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>> OEJGOHCJCHM<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30C9880", Offset = "0x30C8C80", VA = "0x1830C9880")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>> OEJGOHCJCHM<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30C97A0", Offset = "0x30C8BA0", VA = "0x1830C97A0")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>> OEJGOHCJCHM<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30C93C0", Offset = "0x30C87C0", VA = "0x1830C93C0")]
	public static AHPCDKCOAJM<KDELIBNFOCF<AHCNMMMKNCO>> CMMJJAIOKDK<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<KDELIBNFOCF<AHCNMMMKNCO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30C99D0", Offset = "0x30C8DD0", VA = "0x1830C99D0")]
	public static AHPCDKCOAJM<IPMFEDIBEJG> PBPCFFPPAJN<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<IPMFEDIBEJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30C98F0", Offset = "0x30C8CF0", VA = "0x1830C98F0")]
	public static AHPCDKCOAJM<IPMFEDIBEJG> PBPCFFPPAJN<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<IPMFEDIBEJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30C9960", Offset = "0x30C8D60", VA = "0x1830C9960")]
	public static AHPCDKCOAJM<IPMFEDIBEJG> PBPCFFPPAJN<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<IPMFEDIBEJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30C9650", Offset = "0x30C8A50", VA = "0x1830C9650")]
	public static AHPCDKCOAJM<LIBEKEBHKBM> JIAEPKNBAGI<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<LIBEKEBHKBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x30C96C0", Offset = "0x30C8AC0", VA = "0x1830C96C0")]
	public static AHPCDKCOAJM<LIBEKEBHKBM> JIAEPKNBAGI<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<LIBEKEBHKBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30C9730", Offset = "0x30C8B30", VA = "0x1830C9730")]
	public static AHPCDKCOAJM<DDMDBKCCCHF> NOCELKCNDCA<M>(this GLJFFNDGJDM<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC)
	{
		return default(AHPCDKCOAJM<DDMDBKCCCHF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AIDALHECCKA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2321DC0", Offset = "0x23211C0", VA = "0x182321DC0")]
	public static void MNLMIMKKGFJ(this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC, FNGOKDJHLLJ HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2321F00", Offset = "0x2321300", VA = "0x182321F00")]
	public static void MNLMIMKKGFJ(this byte[] MDABPMPEKPN, int FIKHCKAHJLC, FNGOKDJHLLJ HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2321E80", Offset = "0x2321280", VA = "0x182321E80")]
	public static void MNLMIMKKGFJ([In] this Span<byte> MDABPMPEKPN, int FIKHCKAHJLC, FNGOKDJHLLJ HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3729960", Offset = "0x3728D60", VA = "0x183729960")]
	public static void MNLMIMKKGFJ<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, FNGOKDJHLLJ HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3729AF0", Offset = "0x3728EF0", VA = "0x183729AF0")]
	public static void MNLMIMKKGFJ<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, FNGOKDJHLLJ HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2321A60", Offset = "0x2320E60", VA = "0x182321A60")]
	public static void KLLAPLBPGMD(this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2321CD0", Offset = "0x23210D0", VA = "0x182321CD0")]
	public static void KLLAPLBPGMD(this byte[] MDABPMPEKPN, int FIKHCKAHJLC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2321C50", Offset = "0x2321050", VA = "0x182321C50")]
	public static void KLLAPLBPGMD([In] this Span<byte> MDABPMPEKPN, int FIKHCKAHJLC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3729800", Offset = "0x3728C00", VA = "0x183729800")]
	public static void KLLAPLBPGMD<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3729860", Offset = "0x3728C60", VA = "0x183729860")]
	public static void KLLAPLBPGMD<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2321C10", Offset = "0x2321010", VA = "0x182321C10")]
	public static void JGDKPJNILCI(this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37297A0", Offset = "0x3728BA0", VA = "0x1837297A0")]
	public static void JGDKPJNILCI<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3729740", Offset = "0x3728B40", VA = "0x183729740")]
	public static void JGDKPJNILCI<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2321D50", Offset = "0x2321150", VA = "0x182321D50")]
	public static void KNHLNKFPMMB(this OGHLOBLCDJI<byte> MDABPMPEKPN, int FIKHCKAHJLC, byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3729910", Offset = "0x3728D10", VA = "0x183729910")]
	public static void KNHLNKFPMMB<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37298C0", Offset = "0x3728CC0", VA = "0x1837298C0")]
	public static void KNHLNKFPMMB<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30D8760", Offset = "0x30D7B60", VA = "0x1830D8760")]
	public static void IPKOKLLGOKB<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>> HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30D8760", Offset = "0x30D7B60", VA = "0x1830D8760")]
	public static void IPKOKLLGOKB<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, AHPCDKCOAJM<KAJPEAJEOBP<AHCNMMMKNCO>> HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x30D8760", Offset = "0x30D7B60", VA = "0x1830D8760")]
	public static void DCKNHDBDBLF<M>(this KLJMGMKKBPJ<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, AHPCDKCOAJM<IPMFEDIBEJG> HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30D8760", Offset = "0x30D7B60", VA = "0x1830D8760")]
	public static void DCKNHDBDBLF<M>([In] this HNJDBIEHJPE<M, byte> MDABPMPEKPN, AHPCDKCOAJM<M> FIKHCKAHJLC, AHPCDKCOAJM<IPMFEDIBEJG> HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NPPLAODAOOF
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2326BB0", Offset = "0x2325FB0", VA = "0x182326BB0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) LLLDNFMAFPI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2325C90", Offset = "0x2325090", VA = "0x182325C90")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) ILIKKPNJLOJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2327440", Offset = "0x2326840", VA = "0x182327440")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) NOKBGCBEEII(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2323550", Offset = "0x2322950", VA = "0x182323550")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) CFDNKECDOAA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2326430", Offset = "0x2325830", VA = "0x182326430")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) KFLFGBLGGBD(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2326A90", Offset = "0x2325E90", VA = "0x182326A90")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) LKHMBEIPGIB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2324050", Offset = "0x2323450", VA = "0x182324050")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) DOGHAMFCGDL(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2324EE0", Offset = "0x23242E0", VA = "0x182324EE0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) GAILEFMNOLF(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2327210", Offset = "0x2326610", VA = "0x182327210")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) MIDBIADIHIO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2327330", Offset = "0x2326730", VA = "0x182327330")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>) NGGHIFGAOPL(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? HCPAOILCJCB, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>? HACPNLLGFNI)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23227C0", Offset = "0x2321BC0", VA = "0x1823227C0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>) AAAOHIGPHJM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HCPAOILCJCB, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>? HACPNLLGFNI)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2323CA0", Offset = "0x23230A0", VA = "0x182323CA0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>) DJACGDAAKFO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? HCPAOILCJCB, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>? HACPNLLGFNI)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2324970", Offset = "0x2323D70", VA = "0x182324970")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>) FBCJBEMLJDD(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HCPAOILCJCB, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>? HACPNLLGFNI)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2324A90", Offset = "0x2323E90", VA = "0x182324A90")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<LIBEKEBHKBM>>) FDAKPGOFHNE(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? GFFCEFOLCEE, [Optional] AHPCDKCOAJM<LIBEKEBHKBM>? BDEDHGPGIGH)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<LIBEKEBHKBM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23238F0", Offset = "0x2322CF0", VA = "0x1823238F0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<LIBEKEBHKBM>>>) CNGNFKCBIEO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? GFFCEFOLCEE, [Optional] AHPCDKCOAJM<KDELIBNFOCF<LIBEKEBHKBM>>? BDEDHGPGIGH)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<LIBEKEBHKBM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2325DE0", Offset = "0x23251E0", VA = "0x182325DE0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<IPMFEDIBEJG>>) JHFKIAKDNIA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? GFFCEFOLCEE, [Optional] AHPCDKCOAJM<IPMFEDIBEJG>? BDEDHGPGIGH)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<IPMFEDIBEJG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23237E0", Offset = "0x2322BE0", VA = "0x1823237E0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<IPMFEDIBEJG>>>) CMFLJJCNIIF(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? GFFCEFOLCEE, [Optional] AHPCDKCOAJM<KDELIBNFOCF<IPMFEDIBEJG>>? BDEDHGPGIGH)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<IPMFEDIBEJG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31F5FC0", Offset = "0x31F53C0", VA = "0x1831F5FC0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<DDMDBKCCCHF>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<TMarker>>) CJGMMDGIGAN<TMarker>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<DDMDBKCCCHF>? BDEDHGPGIGH, [Optional][In] ReadOnlySpan<byte> JGCOLLOOLHL)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<DDMDBKCCCHF>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2326E50", Offset = "0x2326250", VA = "0x182326E50")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) LNJMPEKLKPL(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int INPBKEEADJL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? NHJAKHBPCNL)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23241B0", Offset = "0x23235B0", VA = "0x1823241B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) EAIIPPLLMHM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? INPBKEEADJL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? NHJAKHBPCNL)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x31F61C0", Offset = "0x31F55C0", VA = "0x1831F61C0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<TMarker>>) DNKKOANLKJK<TMarker>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<TMarker>>? NHJAKHBPCNL, [Optional] int? BGDDCGNLDBK, [Optional][In] ReadOnlySpan<byte> INPBKEEADJL)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31F63B0", Offset = "0x31F57B0", VA = "0x1831F63B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>) LPMAEFOKNBG<TMarker>(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<TMarker>>? INPBKEEADJL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<TMarker>>? NHJAKHBPCNL, [Optional] int? BGDDCGNLDBK)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<TMarker>>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2327D00", Offset = "0x2327100", VA = "0x182327D00")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) PGPNCONOJEI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x23228E0", Offset = "0x2321CE0", VA = "0x1823228E0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) AGGNGBLOHCJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2323090", Offset = "0x2322490", VA = "0x182323090")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) BAPPOGCFMEH(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2327FE0", Offset = "0x23273E0", VA = "0x182327FE0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) PNBBDAFCHFJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23267E0", Offset = "0x2325BE0", VA = "0x1823267E0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) LIEIKLPJNLF(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x23257B0", Offset = "0x2324BB0", VA = "0x1823257B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) ICCKGCLNAHB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2322F30", Offset = "0x2322330", VA = "0x182322F30")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) BACKBHCFGHI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x23242C0", Offset = "0x23236C0", VA = "0x1823242C0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) EGCPDOLICPH(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23231B0", Offset = "0x23225B0", VA = "0x1823231B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) CACKJDMMGLC(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2325310", Offset = "0x2324710", VA = "0x182325310")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>) HEPNBOJEHCI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>? DJDDIONMNEO)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KAJPEAJEOBP<OEAKGGMIJOK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2325030", Offset = "0x2324430", VA = "0x182325030")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) GMPELELAMOJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2324690", Offset = "0x2323A90", VA = "0x182324690")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) EPAHPLJKODG(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23266B0", Offset = "0x2325AB0", VA = "0x1823266B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) KHOCMDPJPBK(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x23277D0", Offset = "0x2326BD0", VA = "0x1823277D0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) OFPHHJHDNGL(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23262E0", Offset = "0x23256E0", VA = "0x1823262E0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) JPJLOJPJJLO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2326D30", Offset = "0x2326130", VA = "0x182326D30")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) LNAOILKKLMN(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2325630", Offset = "0x2324A30", VA = "0x182325630")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) HNAEINBAFIB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2327A50", Offset = "0x2326E50", VA = "0x182327A50")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) OLKACDPEBJA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2326580", Offset = "0x2325980", VA = "0x182326580")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) KGNDBINIJOI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2324C30", Offset = "0x2324030", VA = "0x182324C30")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) FFBECNAHIBD(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2325A20", Offset = "0x2324E20", VA = "0x182325A20")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) IGLHNDBGGFK(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2325B70", Offset = "0x2324F70", VA = "0x182325B70")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) IHNMCENOHAB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2325F80", Offset = "0x2325380", VA = "0x182325F80")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) JHOFFDMEGGB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x23232D0", Offset = "0x23226D0", VA = "0x1823232D0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) CCGJPNKNBKE(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2322E00", Offset = "0x2322200", VA = "0x182322E00")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) AMLGHAMJDEM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2326930", Offset = "0x2325D30", VA = "0x182326930")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) LJOAEANHJKK(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2323A00", Offset = "0x2322E00", VA = "0x182323A00")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) COGJIBIJBJK(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2325400", Offset = "0x2324800", VA = "0x182325400")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) HFJDDLGEJNJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23247F0", Offset = "0x2323BF0", VA = "0x1823247F0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) FANKBNPDDJB(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2324530", Offset = "0x2323930", VA = "0x182324530")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) EJFBOCBNAIN(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x23236B0", Offset = "0x2322AB0", VA = "0x1823236B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) CKDMCBIMANA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2327E80", Offset = "0x2327280", VA = "0x182327E80")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) PKMIIMFBPGO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x23258D0", Offset = "0x2324CD0", VA = "0x1823258D0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) IFCNEABDHFG(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2327560", Offset = "0x2326960", VA = "0x182327560")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) OALCPAJHDOI(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2327090", Offset = "0x2326490", VA = "0x182327090")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) MHCLBOPMKOO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2322B50", Offset = "0x2321F50", VA = "0x182322B50")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) AHPOKAPHDAA(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2323430", Offset = "0x2322830", VA = "0x182323430")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) CDAJDCNPNMP(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x23251B0", Offset = "0x23245B0", VA = "0x1823251B0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) GPLBOHGKKHH(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2327BB0", Offset = "0x2326FB0", VA = "0x182327BB0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) OOHAHKADKPM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2324410", Offset = "0x2323810", VA = "0x182324410")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) EHPLMHDHCBM(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2325520", Offset = "0x2324920", VA = "0x182325520")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) HHNGHDKDBON(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] int? NDHMOCOEGDJ, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2326F80", Offset = "0x2326380", VA = "0x182326F80")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) MDHCCIJOFED(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? NDHMOCOEGDJ, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2326260", Offset = "0x2325660", VA = "0x182326260")]
	public static AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>> JPAHLGPGAKG(this OGHLOBLCDJI<byte> MPLBPEBNKFP)
	{
		return default(AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2323ED0", Offset = "0x23232D0", VA = "0x182323ED0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) DLCNGPGIFAO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, float HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2324D90", Offset = "0x2324190", VA = "0x182324D90")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) FPHOFMIOPGO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, float LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<PEDFLONPPIM>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2327930", Offset = "0x2326D30", VA = "0x182327930")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>) OIJLNAFNOPO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<PEDFLONPPIM>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<PEDFLONPPIM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2322CA0", Offset = "0x23220A0", VA = "0x182322CA0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) ALHAJHMCFOE(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2323B50", Offset = "0x2322F50", VA = "0x182323B50")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) DHBNNMOACFC(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2323DB0", Offset = "0x23231B0", VA = "0x182323DB0")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) DKODMPJHFEO(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2326100", Offset = "0x2325500", VA = "0x182326100")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) JLMPPNCAPKJ(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, int HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2327680", Offset = "0x2326A80", VA = "0x182327680")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) ODDHJIHPOLG(this OGHLOBLCDJI<byte> MPLBPEBNKFP, int LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<GDHCOENIGOG>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2322A30", Offset = "0x2321E30", VA = "0x182322A30")]
	public static (AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>) AHCJPBOIDIC(this OGHLOBLCDJI<byte> MPLBPEBNKFP, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? LHGCDOBANHG, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? HOFJLNIHDOL, [Optional] AHPCDKCOAJM<KDELIBNFOCF<GDHCOENIGOG>>? MELFCIOFFMG)
	{
		return default((AHPCDKCOAJM<KAJPEAJEOBP<OEAKGGMIJOK>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>, AHPCDKCOAJM<KAJPEAJEOBP<KDELIBNFOCF<GDHCOENIGOG>>>));
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
