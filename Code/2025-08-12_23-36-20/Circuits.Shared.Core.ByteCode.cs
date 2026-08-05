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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AC39B0", Offset = "0x2AC27B0", VA = "0x182AC39B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IBNNGDPPPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9630", Offset = "0x3CD8430", VA = "0x183CD9630")]
	public static PFJMKELOBBL<NJLCIAHJLMB<M>> APFDPPHKCIE<M>(this int DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3580", Offset = "0x2AC2380", VA = "0x182AC3580")]
	public static PFJMKELOBBL<HIJLELAFBEP> BHHFGEBPGLN(this int DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<HIJLELAFBEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9630", Offset = "0x3CD8430", VA = "0x183CD9630")]
	public static PFJMKELOBBL<CGDJGEPODDI<M>> NJEKEIPIIEI<M>(this int DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<CGDJGEPODDI<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class NJLCIAHJLMB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CJKBFODCICO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class KHMMNKGODGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HIJLELAFBEP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BCFGFIPPBHM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IMJNMNAPHOF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NINDBDCCGAM
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
public static class IGLPOAIMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct JGPJOKKOJJC<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr CNJHCCDKGNK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
		public JGPJOKKOJJC(IntPtr ICNBLBLHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54680C0", Offset = "0x5466EC0", VA = "0x1854680C0")]
		public int AHMKNKCPDKI(TDeps OPJFEEDOIEH, TContext HLKBHABLPJJ, TCompileState IIPMCOPEFHG, [In] MHNDIBEMFIN<byte> NMHDPOJBJFC, int HPPOJIEMODI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D481D0", Offset = "0x3D46FD0", VA = "0x183D481D0")]
	public static void FHMHGPMHHOA<TDeps, TContext, TCompileState>(TDeps OPJFEEDOIEH, TContext HLKBHABLPJJ, TCompileState IIPMCOPEFHG, [In] MHNDIBEMFIN<byte> NDGJNOACIPA, MHNDIBEMFIN<byte> ABCMFANMKLJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BDGCABJLKOM, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DINBPJPPMOI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LNBKAIHMHFH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JPINEHOFLPO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PJEMELPFEPH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FGNHDBNCCNH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KDEIKMDGLOM, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LNKAILJHBLK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BJLPMAEFPKA, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HMGIFANKBMP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? ICCBHGEEHFM, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BJMHJACKCKG, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DJNBOJFFILP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OLAJCPLGFOJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LGGIEGCBJIK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GNGDPEJHIBC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KOGNBGAJPPN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EDIPOPNJFFI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DDKHBMEIJPB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EEPGKPKBGBF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GJHLJLMOHDE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PAOHGCFLMGO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HNMOPNNKKLB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MPMCIPJDLIJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BIGJBELGMLB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FDOCEGJCPME, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OIKEEHKGPBB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PEGFELOMNBC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CLNLHMFFONP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JIHAEFAAMDH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LMKLCBHIAAB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KGGEJNDONFI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FLPHIPNDOFH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MEBNDMEHCEL, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FCAJHCPKDFD, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CLONEAPCEMB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JKMPOGNHKNH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BKFNLICLHJF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PKNDBOCAGCP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LDBCIKCJEEC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? ONAGNBFHIAB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HKEIEHBBHLE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? COJHHHEHINN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? AFEMANGDJKC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? AMOIHFBKCEP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BFPDKDJGPMC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GPAOOJGFNAB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NOCFCEKIOGO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KCFFNGLDDAE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EEDNPKNGMGP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LKJDMGBBBCL, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CBFCKOPHEEF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OEPFIKNHHHK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EIFFNNBFHFI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EIPCMFIGNGO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IGGPKEOGFON, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BPBMBBKLPNB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NALOFIBAOCM, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? AHNNBKBEENB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MJEICNJGBIP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NFELAENMKKH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CNFHLPLAEIN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IPJMDEOGJJF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BJNDMHNEPPN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IKOCOALFPPP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IHLBEABJHIC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BCEOGFEODJK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IAGHBNPELHB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CNPMGGEHHDK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JEADBKDHNIE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IENAMLCOJEP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JIIOKANEANC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PCMHKKLNNEL, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HDKHJMGLFON, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BGGIGDCHFKE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IMIHIFDENDN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OBLNOILBFFB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IGCPBAGJLOA, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EOMJJGGCBJE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LJKBCCCAILJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NJBPLEGPECE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FPJNCENIIBJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MBFHNIGNMJG, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FNJEOMAEAHH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PMJDFEPABJG, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OLOEONPCDMJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KBAGNMJKLKH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EIIBCKKDBON, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OAJGLEKDKFO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BHIILEGGFPE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HDAHJBDJIMF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JIHLKDLJFIK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? LBCPOHBLDIM, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CEAEKAAANAP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HALMADMBEIG, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DJJCPBBDBKA, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KMFFAKNDCJK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CGINFIIJLFK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DGPJFJGKLGF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GGACNPIMMLD, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BJHMPAJHMFC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KFKKPBCOAOE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NIFMAMCLMOD, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FCHAKPILAMC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MEKIACFLCDF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FPIKODPBEGO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PNKNPABEBLH, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CKEKLJOPOMG, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NCJOIPOJGBE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? DIKHIJMPMNP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GFDEEPBJFGI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? APELOGGDGOO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MBPLOBGDOAD, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? JBBKOEBEGAO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EOBFPPDHMGF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? CEDNKIDHGNO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? EDGDKMOMDOO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MFIIIHONGIF, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? FMGMAIIIPDJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NGJEBLCBGBC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NADOGHCJNNO, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? GGOANEBKHPL, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NHOIFLEOIFC, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? ALCIHLHKHKJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? IHKABPCDPIE, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? BKGACOKGKNK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NCPGKEMBJFI, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? KAIFJCHKIIB, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HAFLPOJHBFJ, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? NOOPPPNOFEN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? MIFBMBIMKDP, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HHAELFGJJIK, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? HHFNOAKEMFN, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? PCFKGFNGLCL, [Optional] JGPJOKKOJJC<TContext, TDeps, TCompileState>? OFDEHOPEJLJ) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AC35B0", Offset = "0x2AC23B0", VA = "0x182AC35B0")]
	private static int CPJKMHPBAMC([In] MHNDIBEMFIN<byte> ODAFCJJIICF, MHNDIBEMFIN<byte> AMOBAKBDGHA, int NBLNCONJINM, int FFKCBONKOOM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FMHMFFAFDGI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int DCCBCFHNLKH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE41C0", Offset = "0x3CE2FC0", VA = "0x183CE41C0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<T>> LOEALOJOECF<T>([In] this MHNDIBEMFIN<byte> DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4210", Offset = "0x3CE3010", VA = "0x183CE4210")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<T>>> LOPCDBDHICJ<T>(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<NJLCIAHJLMB<T>>? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3110", Offset = "0x2AC1F10", VA = "0x182AC3110")]
	public static PFJMKELOBBL<NJLCIAHJLMB<FHAMANOFCLM>> IBEEELPJJCN(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<FHAMANOFCLM>? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<FHAMANOFCLM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3470", Offset = "0x2AC2270", VA = "0x182AC3470")]
	public static PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>> PIHIGPIFGDH(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] float? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2F70", Offset = "0x2AC1D70", VA = "0x182AC2F70")]
	public static PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>> FMAPNHJMDEM(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2AC33A0", Offset = "0x2AC21A0", VA = "0x182AC33A0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>> LABNKPAEFBA(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<OCONFHNBCBE>? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AC31E0", Offset = "0x2AC1FE0", VA = "0x182AC31E0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<IMJNMNAPHOF>> IELCNNMKGCK(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] byte? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<IMJNMNAPHOF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3040", Offset = "0x2AC1E40", VA = "0x182AC3040")]
	public static PFJMKELOBBL<NJLCIAHJLMB<HIJLELAFBEP>> FMMHMMCCJNF(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<HIJLELAFBEP>? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<HIJLELAFBEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2AC32D0", Offset = "0x2AC20D0", VA = "0x182AC32D0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> IGLOBOOPCKF(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] NINDBDCCGAM? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CE42D0", Offset = "0x3CE30D0", VA = "0x183CE42D0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<T>>> MBPGCBGOLIC<T>(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<T>>? HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2E80", Offset = "0x2AC1C80", VA = "0x182AC2E80")]
	public static void NNDGGHMDAIO(this MHNDIBEMFIN<byte> DBBEADIHLKO, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>> LFIANJINNPL, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CE41B0", Offset = "0x3CE2FB0", VA = "0x183CE41B0")]
	public static void EDCIOPPFHAE<T>(this MHNDIBEMFIN<byte> DBBEADIHLKO, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<T>>> HPPOJIEMODI, PFJMKELOBBL<NJLCIAHJLMB<T>> HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CE41B0", Offset = "0x3CE2FB0", VA = "0x183CE41B0")]
	public static void IABFGJLKCMO<T>(this MHNDIBEMFIN<byte> DBBEADIHLKO, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<T>>> HJENLLDPFON, PFJMKELOBBL<CGDJGEPODDI<T>> HGMAIPELJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class POPAAGEAJLG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC93B0", Offset = "0x2AC81B0", VA = "0x182AC93B0")]
	public static FHLAGALJACB LAFOKCEMNOB([In] this ReadOnlySpan<byte> JICDOIHAMGB, int NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9420", Offset = "0x2AC8220", VA = "0x182AC9420")]
	public static FHLAGALJACB LAFOKCEMNOB([In] this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F06680", Offset = "0x3F05480", VA = "0x183F06680")]
	public static FHLAGALJACB LAFOKCEMNOB<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F06860", Offset = "0x3F05660", VA = "0x183F06860")]
	public static FHLAGALJACB LAFOKCEMNOB<M>([In] this MKCJHPMBEDC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F06970", Offset = "0x3F05770", VA = "0x183F06970")]
	public static FHLAGALJACB LAFOKCEMNOB<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F06800", Offset = "0x3F05600", VA = "0x183F06800")]
	public static FHLAGALJACB LAFOKCEMNOB<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F06790", Offset = "0x3F05590", VA = "0x183F06790")]
	public static FHLAGALJACB LAFOKCEMNOB<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2AC93B0", Offset = "0x2AC81B0", VA = "0x182AC93B0")]
	public static int DNGEJBIFPBC([In] this ReadOnlySpan<byte> JICDOIHAMGB, int NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2EC0", Offset = "0x2AC1CC0", VA = "0x182AC2EC0")]
	public static int DNGEJBIFPBC([In] this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CD00", Offset = "0x3E0BB00", VA = "0x183E0CD00")]
	public static int DNGEJBIFPBC<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CD00", Offset = "0x3E0BB00", VA = "0x183E0CD00")]
	public static int DNGEJBIFPBC<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CD00", Offset = "0x3E0BB00", VA = "0x183E0CD00")]
	public static int DNGEJBIFPBC<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CD00", Offset = "0x3E0BB00", VA = "0x183E0CD00")]
	public static int DNGEJBIFPBC<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F06420", Offset = "0x3F05220", VA = "0x183F06420")]
	public static float ACCENFCKHCG<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F06420", Offset = "0x3F05220", VA = "0x183F06420")]
	public static float ACCENFCKHCG<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F06420", Offset = "0x3F05220", VA = "0x183F06420")]
	public static float ACCENFCKHCG<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F069C0", Offset = "0x3F057C0", VA = "0x183F069C0")]
	public static byte LFHAMJHFJEE<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F06A60", Offset = "0x3F05860", VA = "0x183F06A60")]
	public static byte LFHAMJHFJEE<M>([In] this MKCJHPMBEDC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F06970", Offset = "0x3F05770", VA = "0x183F06970")]
	public static byte LFHAMJHFJEE<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F06800", Offset = "0x3F05600", VA = "0x183F06800")]
	public static byte LFHAMJHFJEE<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F069F0", Offset = "0x3F057F0", VA = "0x183F069F0")]
	public static byte LFHAMJHFJEE<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2EC0", Offset = "0x2AC1CC0", VA = "0x182AC2EC0")]
	public static NINDBDCCGAM NLLBONDDIGE([In] this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM)
	{
		return default(NINDBDCCGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CD00", Offset = "0x3E0BB00", VA = "0x183E0CD00")]
	public static NINDBDCCGAM NLLBONDDIGE<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(NINDBDCCGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F06500", Offset = "0x3F05300", VA = "0x183F06500")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> CFCJNANHJHJ<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3F064A0", Offset = "0x3F052A0", VA = "0x183F064A0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> CFCJNANHJHJ<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3F06440", Offset = "0x3F05240", VA = "0x183F06440")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> CFCJNANHJHJ<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3F06620", Offset = "0x3F05420", VA = "0x183F06620")]
	public static PFJMKELOBBL<CGDJGEPODDI<BFKJLNKNPDF>> JHABCOAHKDO<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<CGDJGEPODDI<BFKJLNKNPDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F06BA0", Offset = "0x3F059A0", VA = "0x183F06BA0")]
	public static PFJMKELOBBL<HIJLELAFBEP> OGJALDECEAJ<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<HIJLELAFBEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F06AE0", Offset = "0x3F058E0", VA = "0x183F06AE0")]
	public static PFJMKELOBBL<HIJLELAFBEP> OGJALDECEAJ<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<HIJLELAFBEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F06B40", Offset = "0x3F05940", VA = "0x183F06B40")]
	public static PFJMKELOBBL<HIJLELAFBEP> OGJALDECEAJ<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<HIJLELAFBEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F06560", Offset = "0x3F05360", VA = "0x183F06560")]
	public static PFJMKELOBBL<FHAMANOFCLM> DLHKBBFPKOP<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<FHAMANOFCLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F065C0", Offset = "0x3F053C0", VA = "0x183F065C0")]
	public static PFJMKELOBBL<FHAMANOFCLM> DLHKBBFPKOP<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<FHAMANOFCLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3F06A80", Offset = "0x3F05880", VA = "0x183F06A80")]
	public static PFJMKELOBBL<OCONFHNBCBE> MCCKHKEJLCP<M>(this FMPMKNPPLMC<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM)
	{
		return default(PFJMKELOBBL<OCONFHNBCBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KFLJIDABACP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3700", Offset = "0x2AC2500", VA = "0x182AC3700")]
	public static void DIOEKOIDGLI(this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM, FHLAGALJACB HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC37C0", Offset = "0x2AC25C0", VA = "0x182AC37C0")]
	public static void DIOEKOIDGLI(this byte[] JICDOIHAMGB, int NDPAACFPBHM, FHLAGALJACB HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3830", Offset = "0x2AC2630", VA = "0x182AC3830")]
	public static void DIOEKOIDGLI([In] this Span<byte> JICDOIHAMGB, int NDPAACFPBHM, FHLAGALJACB HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAAB0", Offset = "0x3DA98B0", VA = "0x183DAAAB0")]
	public static void DIOEKOIDGLI<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, FHLAGALJACB HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DAABA0", Offset = "0x3DA99A0", VA = "0x183DAABA0")]
	public static void DIOEKOIDGLI<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, FHLAGALJACB HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2E80", Offset = "0x2AC1C80", VA = "0x182AC2E80")]
	public static void NNDGGHMDAIO(this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AC38B0", Offset = "0x2AC26B0", VA = "0x182AC38B0")]
	public static void NNDGGHMDAIO(this byte[] JICDOIHAMGB, int NDPAACFPBHM, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3930", Offset = "0x2AC2730", VA = "0x182AC3930")]
	public static void NNDGGHMDAIO([In] this Span<byte> JICDOIHAMGB, int NDPAACFPBHM, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DAACF0", Offset = "0x3DA9AF0", VA = "0x183DAACF0")]
	public static void NNDGGHMDAIO<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DAACA0", Offset = "0x3DA9AA0", VA = "0x183DAACA0")]
	public static void NNDGGHMDAIO<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3650", Offset = "0x2AC2450", VA = "0x182AC3650")]
	public static void CNNLALFGOOD(this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA9B0", Offset = "0x3DA97B0", VA = "0x183DAA9B0")]
	public static void CNNLALFGOOD<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAA00", Offset = "0x3DA9800", VA = "0x183DAAA00")]
	public static void CNNLALFGOOD<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3690", Offset = "0x2AC2490", VA = "0x182AC3690")]
	public static void DHIHAGBCDOG(this MHNDIBEMFIN<byte> JICDOIHAMGB, int NDPAACFPBHM, byte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAA50", Offset = "0x3DA9850", VA = "0x183DAAA50")]
	public static void DHIHAGBCDOG<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, byte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAA80", Offset = "0x3DA9880", VA = "0x183DAAA80")]
	public static void DHIHAGBCDOG<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, byte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAC90", Offset = "0x3DA9A90", VA = "0x183DAAC90")]
	public static void EDCIOPPFHAE<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAC90", Offset = "0x3DA9A90", VA = "0x183DAAC90")]
	public static void EDCIOPPFHAE<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAC90", Offset = "0x3DA9A90", VA = "0x183DAAC90")]
	public static void IOGPIACAOHJ<M>(this NGFPJLFCPGM<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, PFJMKELOBBL<HIJLELAFBEP> HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAC90", Offset = "0x3DA9A90", VA = "0x183DAAC90")]
	public static void IOGPIACAOHJ<M>([In] this JIMNMKFGOAN<M, byte> JICDOIHAMGB, PFJMKELOBBL<M> NDPAACFPBHM, PFJMKELOBBL<HIJLELAFBEP> HGMAIPELJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ONDBBNFAAKO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8A60", Offset = "0x2AC7860", VA = "0x182AC8A60")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) OGJJPNALALO(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5D20", Offset = "0x2AC4B20", VA = "0x182AC5D20")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) FICGFONNJFD(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6E70", Offset = "0x2AC5C70", VA = "0x182AC6E70")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) JNCMDHKNNJN(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4D10", Offset = "0x2AC3B10", VA = "0x182AC4D10")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) DOIGEBGKCCF(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5320", Offset = "0x2AC4120", VA = "0x182AC5320")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ECMCNJGPAGG(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9290", Offset = "0x2AC8090", VA = "0x182AC9290")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) POMHHDIDPKM(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BB0", Offset = "0x2AC39B0", VA = "0x182AC4BB0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) DLAJFILFPAJ(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7720", Offset = "0x2AC6520", VA = "0x182AC7720")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) KOPNENCLPBB(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AC44E0", Offset = "0x2AC32E0", VA = "0x182AC44E0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) CKPOPNLKCHB(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3DB0", Offset = "0x2AC2BB0", VA = "0x182AC3DB0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>) AIHDLGCCCLH(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? HGMAIPELJHM, [Optional] PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? LLNNDLNKECB)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8690", Offset = "0x2AC7490", VA = "0x182AC8690")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>) OEPJHBNNIPM(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? HGMAIPELJHM, [Optional] PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? LLNNDLNKECB)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5FF0", Offset = "0x2AC4DF0", VA = "0x182AC5FF0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>) FOOHGKAKOEG(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? HGMAIPELJHM, [Optional] PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? LLNNDLNKECB)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7600", Offset = "0x2AC6400", VA = "0x182AC7600")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>) KIGBDHFJIEN(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? HGMAIPELJHM, [Optional] PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? LLNNDLNKECB)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5B80", Offset = "0x2AC4980", VA = "0x182AC5B80")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<FHAMANOFCLM>>) FHLNEHBMODA(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? BEMACINCOHJ, [Optional] PFJMKELOBBL<FHAMANOFCLM>? OHHICGADAKK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<FHAMANOFCLM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5590", Offset = "0x2AC4390", VA = "0x182AC5590")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<FHAMANOFCLM>>>) ENOHFJPFCDO(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? BEMACINCOHJ, [Optional] PFJMKELOBBL<CGDJGEPODDI<FHAMANOFCLM>>? OHHICGADAKK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<FHAMANOFCLM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4760", Offset = "0x2AC3560", VA = "0x182AC4760")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<HIJLELAFBEP>>) CNBGMIDPNBG(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? BEMACINCOHJ, [Optional] PFJMKELOBBL<HIJLELAFBEP>? OHHICGADAKK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<HIJLELAFBEP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6250", Offset = "0x2AC5050", VA = "0x182AC6250")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<HIJLELAFBEP>>>) GDOPOALKDJJ(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? BEMACINCOHJ, [Optional] PFJMKELOBBL<CGDJGEPODDI<HIJLELAFBEP>>? OHHICGADAKK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<HIJLELAFBEP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF0A0", Offset = "0x3EEDEA0", VA = "0x183EEF0A0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>) FDICOCJBPOI<TMarker>(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<OCONFHNBCBE>? OHHICGADAKK, [Optional][In] ReadOnlySpan<byte> KANAIIDGHCH)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7270", Offset = "0x2AC6070", VA = "0x182AC7270")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) KBGPBNAJJAM(this MHNDIBEMFIN<byte> DBBEADIHLKO, int ODAFCJJIICF, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? AMOBAKBDGHA)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2AC74F0", Offset = "0x2AC62F0", VA = "0x182AC74F0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) KFNBFMKOEOM(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? ODAFCJJIICF, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? AMOBAKBDGHA)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF3B0", Offset = "0x3EEE1B0", VA = "0x183EEF3B0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>) NOJGEOBJLMM<TMarker>(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<TMarker>>? AMOBAKBDGHA, [Optional] int? BCMFMCHGEKF, [Optional][In] ReadOnlySpan<byte> ODAFCJJIICF)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF290", Offset = "0x3EEE090", VA = "0x183EEF290")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>) LADNKGPKJIC<TMarker>(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<TMarker>>? ODAFCJJIICF, [Optional] PFJMKELOBBL<CGDJGEPODDI<TMarker>>? AMOBAKBDGHA, [Optional] int? BCMFMCHGEKF)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<TMarker>>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2AC70F0", Offset = "0x2AC5EF0", VA = "0x182AC70F0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) KAHFPCPEMJP(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7EA0", Offset = "0x2AC6CA0", VA = "0x182AC7EA0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) NGDAANCKNKF(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7870", Offset = "0x2AC6670", VA = "0x182AC7870")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) LHDJJDGDHOL(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4900", Offset = "0x2AC3700", VA = "0x182AC4900")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) CODGIFKMEGB(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AC82E0", Offset = "0x2AC70E0", VA = "0x182AC82E0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) NMADPNLBHIA(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4E70", Offset = "0x2AC3C70", VA = "0x182AC4E70")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) DOJAMNFJMDL(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC68D0", Offset = "0x2AC56D0", VA = "0x182AC68D0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) INKMAGCMFLE(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8190", Offset = "0x2AC6F90", VA = "0x182AC8190")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) NKBCLOCAMAP(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7C30", Offset = "0x2AC6A30", VA = "0x182AC7C30")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) MEPMPLJFJKO(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3B60", Offset = "0x2AC2960", VA = "0x182AC3B60")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>) ADFNEGJCDEB(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? CAKJBKCFAOL)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6B90", Offset = "0x2AC5990", VA = "0x182AC6B90")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) JFOLDGDACOE(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8EB0", Offset = "0x2AC7CB0", VA = "0x182AC8EB0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) PIACINOEFHO(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2AC43B0", Offset = "0x2AC31B0", VA = "0x182AC43B0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) CBLECPJMLJN(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6610", Offset = "0x2AC5410", VA = "0x182AC6610")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) GPJGNBEDMHK(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2AC73A0", Offset = "0x2AC61A0", VA = "0x182AC73A0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) KEBGKNHAGKF(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4F90", Offset = "0x2AC3D90", VA = "0x182AC4F90")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ECEGIMCABPL(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2AC88E0", Offset = "0x2AC76E0", VA = "0x182AC88E0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) OGEBABPOLFC(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6D10", Offset = "0x2AC5B10", VA = "0x182AC6D10")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) JIIJHIKJLPK(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3A30", Offset = "0x2AC2830", VA = "0x182AC3A30")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ACKDDLIMDHA(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3C50", Offset = "0x2AC2A50", VA = "0x182AC3C50")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ADPCCJJICLD(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2AC56A0", Offset = "0x2AC44A0", VA = "0x182AC56A0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) FBDCDGJNKOO(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3EC0", Offset = "0x2AC2CC0", VA = "0x182AC3EC0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) AJNLLKJALIL(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8D30", Offset = "0x2AC7B30", VA = "0x182AC8D30")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) PHEOAPHLNLP(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC64B0", Offset = "0x2AC52B0", VA = "0x182AC64B0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) GOLELHDFCIG(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4280", Offset = "0x2AC3080", VA = "0x182AC4280")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) BLOMGPNEMFL(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4600", Offset = "0x2AC3400", VA = "0x182AC4600")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) CLLPMFEBKDN(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8430", Offset = "0x2AC7230", VA = "0x182AC8430")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) OALJJHMCDEP(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7990", Offset = "0x2AC6790", VA = "0x182AC7990")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) LLENKCNDEIK(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4100", Offset = "0x2AC2F00", VA = "0x182AC4100")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) BLCOJOBOPNP(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6F90", Offset = "0x2AC5D90", VA = "0x182AC6F90")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) JOJBMDMJPAI(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2AC87B0", Offset = "0x2AC75B0", VA = "0x182AC87B0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) OFECFBGANKH(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5A20", Offset = "0x2AC4820", VA = "0x182AC5A20")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) FHFDCLHDJKE(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6100", Offset = "0x2AC4F00", VA = "0x182AC6100")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) GADNJDJKIED(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9170", Offset = "0x2AC7F70", VA = "0x182AC9170")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) PMLCFLIKFEA(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5E70", Offset = "0x2AC4C70", VA = "0x182AC5E70")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) FNONADAILLL(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4A60", Offset = "0x2AC3860", VA = "0x182AC4A60")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) DGBFLMFEHCP(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8070", Offset = "0x2AC6E70", VA = "0x182AC8070")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) NIOAJGPDJEN(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6770", Offset = "0x2AC5570", VA = "0x182AC6770")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ICBOBHBGFFI(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6360", Offset = "0x2AC5160", VA = "0x182AC6360")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) GFICOIPHGOC(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3FE0", Offset = "0x2AC2DE0", VA = "0x182AC3FE0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) BAHGBBNJPCE(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8580", Offset = "0x2AC7380", VA = "0x182AC8580")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ODKAJIAJCJK(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] int? OBFCGGNKBCH, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC57F0", Offset = "0x2AC45F0", VA = "0x182AC57F0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) FDLMFAJIDOC(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? OBFCGGNKBCH, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7FF0", Offset = "0x2AC6DF0", VA = "0x182AC7FF0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> NHKMIPFFCOL(this MHNDIBEMFIN<byte> DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7AB0", Offset = "0x2AC68B0", VA = "0x182AC7AB0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) LPPEPOOOFPN(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2AC51D0", Offset = "0x2AC3FD0", VA = "0x182AC51D0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) ECLKOFGDPCB(this MHNDIBEMFIN<byte> DBBEADIHLKO, float FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CJKBFODCICO>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5900", Offset = "0x2AC4700", VA = "0x182AC5900")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>) FHAJFAFFOGM(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<CJKBFODCICO>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<CJKBFODCICO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9010", Offset = "0x2AC7E10", VA = "0x182AC9010")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) PKKGDHDDBGH(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8BE0", Offset = "0x2AC79E0", VA = "0x182AC8BE0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) PBJHBIMJHAD(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5470", Offset = "0x2AC4270", VA = "0x182AC5470")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) EELMNCHPPAO(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6A30", Offset = "0x2AC5830", VA = "0x182AC6A30")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) IPCPDNHBEHK(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7D50", Offset = "0x2AC6B50", VA = "0x182AC7D50")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) MOLFGKFCBMB(this MHNDIBEMFIN<byte> DBBEADIHLKO, int FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2AC50B0", Offset = "0x2AC3EB0", VA = "0x182AC50B0")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>) ECJODEDKCCP(this MHNDIBEMFIN<byte> DBBEADIHLKO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FDBNKNKPGEM, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? FBKHPANKMDO, [Optional] PFJMKELOBBL<CGDJGEPODDI<KHMMNKGODGP>>? CHICFLNGGHK)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<KHMMNKGODGP>>>));
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
