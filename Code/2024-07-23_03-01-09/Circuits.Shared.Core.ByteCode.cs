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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC5A00", Offset = "0x1FC4C00", VA = "0x181FC5A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FNFDHPEPPFF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29A3F40", Offset = "0x29A3140", VA = "0x1829A3F40")]
	public static OMNCLBBEMMM<EEHEIECAIMH<M>> BLPEPBHCFDN<M>(this int HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5820", Offset = "0x1FC4A20", VA = "0x181FC5820")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> GGDCDBHNHLE(this int HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29A3F40", Offset = "0x29A3140", VA = "0x1829A3F40")]
	public static OMNCLBBEMMM<PLNLGICOJDD<M>> BOOABHNIEFO<M>(this int HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<PLNLGICOJDD<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EEHEIECAIMH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OCBKIHBIOMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BALKHKDPIOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DPDKCKKCEBB
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KOHBJJHPJHN
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BFHAAPCPJEO
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FCKNPEIOHKG
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
public static class HKPEIGAJJAH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KGPBIEPNJHN<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr LJOEBDOHFJN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
		public KGPBIEPNJHN(IntPtr CIGKBEKHOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41915E0", Offset = "0x41907E0", VA = "0x1841915E0")]
		public int APPOJKGPLJE(TDeps HDLOJHGAFKF, TContext MOPANCMKHLH, TCompileState CMLBKFIDFAP, [In] MAHDLFLAHIJ<byte> HNBDOKAPHPI, int KJJBKOMLKJA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B050", Offset = "0x2B7A250", VA = "0x182B7B050")]
	public static void ENFANOGMMKK<TDeps, TContext, TCompileState>(TDeps HDLOJHGAFKF, TContext MOPANCMKHLH, TCompileState CMLBKFIDFAP, [In] MAHDLFLAHIJ<byte> BODDDCFDMEH, MAHDLFLAHIJ<byte> NOJCKECOEKH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BDOELNCNKKL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MMNGLKHJHFA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EHKCJGHMFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PBLKOFNDJCI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OFECAGLFNAE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KFIBMINOJFA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EBNKHLOKHCE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FCPJODBLILG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OKKCCKADMNB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EMHJPHLNAGD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ODMMFHPGNMO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PIBODIEAMCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KALDEOBEELK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LCENLBMCAJE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CHAEGPFANIC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GNDFGKCLFAM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GBCPABKECAC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GHJBCPIECKK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GONHIDKEKJH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NHOJODDBJJK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FNOCMJNKHJE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FHDINBCEJCH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FCFOCMLNALE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ILEMDAOBOFH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IEFMEIONGDD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LCODHOHDDEO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMDFNOOOIMN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ALGDOLKDDBG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BPPFGHDBKAK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JHEPIOFDIIJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PGPCLKONPMF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LEFCJDMDGMJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MDGNFGJEMFL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OIFGHKPGILO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JAIJKLOKMBO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OECFBCBNFLG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JJHDKDPBIKB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NNOLMOGDHBB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GMPMCFELGLB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PELICLJLJMK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CCEBJJJLOIP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MKNAJMKJNIE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KIEOCGMNENP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CPIPNIOBDDP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KPOMEPJGFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DDHACHJCMAN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EOKCPJPFINI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PHGEMDMEHMO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FAHKOKANAAK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EPLGDJNALJA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANHJPNLGOLK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IGPJKCAPOIL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMEBPJKLGDM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GNPAAFFELOG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HMMIPJNONJC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PMAGNCHBIOK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MFGAIIJNHJD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JGGDCEFADKC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NJHDHDCOONF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BAJILNNFMFC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NBHLBJFKDBH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NIHKAGHJMFL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMNNGKNENBE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NFLHFBHOCKP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LILOIGCMFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DIGNKOEJBEI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LHKLDELJLHH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JBJPILFLDCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IGHLONDCCJI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANBDMCGBCMP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ACCPKIFNONL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LJHHKHFBFBK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KDLEDKJOMEF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JEMLFNCBLDP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MLHAOHHNHFB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NGOCDHJPLEB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CLCMPBAJDIN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GIILMBJPIKL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANDIFCCLADH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LOJDBONONEL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FGFNHFNLCOJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IBELBHBPDBA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LKKJFEJKIHI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HNKDKDJKBMK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PIICGCCHBKF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EHELBLMAINF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LEPBKEGGEAF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EKHMBOGDNCD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GEJDBJFANOA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KOMAAEMFPBC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CGLOAAMPEOK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ADMAPBDBIJI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BCCAIFAFDCC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BFBNFPFBCMH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EOGNGMEJCBE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KHHCJFKFHCH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OIOICCMIIAM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GKNGJIMNJJC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BAHAHBAHDBJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DKNMLEIMLNF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CICFJIAOJDA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BMIBDOACJCK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IBBEGHPGJOO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IEINNMDINIL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AGCMDODNKEO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HEEFDADJGAL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OOFAPONKDFJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FMJLIGJDKJB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HHNKIPLNOLI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GEMJFPPJPHC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PPPNLNAIHBJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CAGPJBALJMJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NHCJAKDHENC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JJGLNKCBEGI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MBNGEPLOEJN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IPNMDDALOKE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PBKDHHPIJOD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PDHDLIJHJML, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BGPMODCJJEP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FAHMDKFEHAI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CDECHGILKCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KIGPBNOPAEK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MCOOCJKNIKC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DDCHPAKPLJB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FDOIDLLKNJF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FPGMHPFKALI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ALGFGLDLJCO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FEIHKKIFJNA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MIABFKNCINI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CDJDFLLJKFH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AOLIAGKHGJD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ECPGIIDGEHM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AOKMFOEGPBA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EKMHKEKCPIA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MJOPCMLJOBH) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5850", Offset = "0x1FC4A50", VA = "0x181FC5850")]
	private static int PBJLLELGGLA([In] MAHDLFLAHIJ<byte> GHPNOJNBADJ, MAHDLFLAHIJ<byte> GIEIMDLAKLP, int GBALKPFEDAI, int IHGHLPOONHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMABIIBDGJA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int MPDCHCJGMAG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE13A0", Offset = "0x2CE05A0", VA = "0x182CE13A0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<T>> FOOCDGFJIMD<T>([In] this MAHDLFLAHIJ<byte> HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1400", Offset = "0x2CE0600", VA = "0x182CE1400")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>> NGOLHFEAEBC<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<EEHEIECAIMH<T>>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5FF0", Offset = "0x1FC51F0", VA = "0x181FC5FF0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>> PPEBFLODMIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<FLHNECBBMMA>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5B60", Offset = "0x1FC4D60", VA = "0x181FC5B60")]
	public static OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>> EIIGDBPMENH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] float? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5A80", Offset = "0x1FC4C80", VA = "0x181FC5A80")]
	public static OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>> DPCCODOICHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5E30", Offset = "0x1FC5030", VA = "0x181FC5E30")]
	public static OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>> JENNOMPPPON(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<GDGJOIIKKHE>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5C40", Offset = "0x1FC4E40", VA = "0x181FC5C40")]
	public static OMNCLBBEMMM<EEHEIECAIMH<BFHAAPCPJEO>> GMADPNLDJNI(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] byte? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<BFHAAPCPJEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5F10", Offset = "0x1FC5110", VA = "0x181FC5F10")]
	public static OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>> NNBEIGPAHIL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<DPDKCKKCEBB>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5D40", Offset = "0x1FC4F40", VA = "0x181FC5D40")]
	public static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> IOFKCJJAFPF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] FCKNPEIOHKG? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CE14C0", Offset = "0x2CE06C0", VA = "0x182CE14C0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>> PGDNGGKDGAD<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<T>>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFA50", Offset = "0x1FBEC50", VA = "0x181FBFA50")]
	public static void MINMMGPGIJK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>> PEONPFKEDHI, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1390", Offset = "0x2CE0590", VA = "0x182CE1390")]
	public static void JBGOPDHBDHF<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>> KJJBKOMLKJA, OMNCLBBEMMM<EEHEIECAIMH<T>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1390", Offset = "0x2CE0590", VA = "0x182CE1390")]
	public static void FGCILONMDIC<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>> NMEKIECFIEP, OMNCLBBEMMM<PLNLGICOJDD<T>> JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NAHCJCHHPLH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5990", Offset = "0x1FC4B90", VA = "0x181FC5990")]
	public static NKFCAEJKJCA LMMLLMFKNJF([In] this ReadOnlySpan<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC58F0", Offset = "0x1FC4AF0", VA = "0x181FC58F0")]
	public static NKFCAEJKJCA LMMLLMFKNJF([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A5C0", Offset = "0x2C997C0", VA = "0x182C9A5C0")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A710", Offset = "0x2C99910", VA = "0x182C9A710")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>([In] this APFLCPGGLDF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A410", Offset = "0x2C99610", VA = "0x182C9A410")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A3A0", Offset = "0x2C995A0", VA = "0x182C9A3A0")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A860", Offset = "0x2C99A60", VA = "0x182C9A860")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5990", Offset = "0x1FC4B90", VA = "0x181FC5990")]
	public static int POENGODBEHI([In] this ReadOnlySpan<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFB30", Offset = "0x1FBED30", VA = "0x181FBFB30")]
	public static int POENGODBEHI([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29A40D0", Offset = "0x29A32D0", VA = "0x1829A40D0")]
	public static int POENGODBEHI<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29A40D0", Offset = "0x29A32D0", VA = "0x1829A40D0")]
	public static int POENGODBEHI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29A40D0", Offset = "0x29A32D0", VA = "0x1829A40D0")]
	public static int POENGODBEHI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29A40D0", Offset = "0x29A32D0", VA = "0x1829A40D0")]
	public static int POENGODBEHI<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A0A0", Offset = "0x2C992A0", VA = "0x182C9A0A0")]
	public static float EEBMAGMDHMG<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A0A0", Offset = "0x2C992A0", VA = "0x182C9A0A0")]
	public static float EEBMAGMDHMG<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A0A0", Offset = "0x2C992A0", VA = "0x182C9A0A0")]
	public static float EEBMAGMDHMG<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A2A0", Offset = "0x2C994A0", VA = "0x182C9A2A0")]
	public static byte JCLGNFBAFEN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A380", Offset = "0x2C99580", VA = "0x182C9A380")]
	public static byte JCLGNFBAFEN<M>([In] this APFLCPGGLDF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A410", Offset = "0x2C99610", VA = "0x182C9A410")]
	public static byte JCLGNFBAFEN<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A3A0", Offset = "0x2C995A0", VA = "0x182C9A3A0")]
	public static byte JCLGNFBAFEN<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A2D0", Offset = "0x2C994D0", VA = "0x182C9A2D0")]
	public static byte JCLGNFBAFEN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFB30", Offset = "0x1FBED30", VA = "0x181FBFB30")]
	public static FCKNPEIOHKG NDFEINOHHMM([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(FCKNPEIOHKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x29A40D0", Offset = "0x29A32D0", VA = "0x1829A40D0")]
	public static FCKNPEIOHKG NDFEINOHHMM<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(FCKNPEIOHKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A470", Offset = "0x2C99670", VA = "0x182C9A470")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A550", Offset = "0x2C99750", VA = "0x182C9A550")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A4E0", Offset = "0x2C996E0", VA = "0x182C9A4E0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A9F0", Offset = "0x2C99BF0", VA = "0x182C9A9F0")]
	public static OMNCLBBEMMM<PLNLGICOJDD<JHGAOCPFCLJ>> PDFJGJCEKOK<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<PLNLGICOJDD<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A230", Offset = "0x2C99430", VA = "0x182C9A230")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A150", Offset = "0x2C99350", VA = "0x182C9A150")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A1C0", Offset = "0x2C993C0", VA = "0x182C9A1C0")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A980", Offset = "0x2C99B80", VA = "0x182C9A980")]
	public static OMNCLBBEMMM<FLHNECBBMMA> MFCPAADGOHJ<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<FLHNECBBMMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A910", Offset = "0x2C99B10", VA = "0x182C9A910")]
	public static OMNCLBBEMMM<FLHNECBBMMA> MFCPAADGOHJ<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<FLHNECBBMMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9A0E0", Offset = "0x2C992E0", VA = "0x182C9A0E0")]
	public static OMNCLBBEMMM<GDGJOIIKKHE> FBJCMOLBIBN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<GDGJOIIKKHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ALGKBOIGCEC
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFBB0", Offset = "0x1FBEDB0", VA = "0x181FBFBB0")]
	public static void EHGLDIKDBJK(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFCF0", Offset = "0x1FBEEF0", VA = "0x181FBFCF0")]
	public static void EHGLDIKDBJK(this byte[] DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC70", Offset = "0x1FBEE70", VA = "0x181FBFC70")]
	public static void EHGLDIKDBJK([In] this Span<byte> DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31E6B90", Offset = "0x31E5D90", VA = "0x1831E6B90")]
	public static void EHGLDIKDBJK<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x31E6D20", Offset = "0x31E5F20", VA = "0x1831E6D20")]
	public static void EHGLDIKDBJK<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFA50", Offset = "0x1FBEC50", VA = "0x181FBFA50")]
	public static void MINMMGPGIJK(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFDA0", Offset = "0x1FBEFA0", VA = "0x181FBFDA0")]
	public static void MINMMGPGIJK(this byte[] DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFE20", Offset = "0x1FBF020", VA = "0x181FBFE20")]
	public static void MINMMGPGIJK([In] this Span<byte> DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31E6FD0", Offset = "0x31E61D0", VA = "0x1831E6FD0")]
	public static void MINMMGPGIJK<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31E6F70", Offset = "0x31E6170", VA = "0x1831E6F70")]
	public static void MINMMGPGIJK<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFD60", Offset = "0x1FBEF60", VA = "0x181FBFD60")]
	public static void IFBNILNLBMI(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31E6F10", Offset = "0x31E6110", VA = "0x1831E6F10")]
	public static void IFBNILNLBMI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31E6EB0", Offset = "0x31E60B0", VA = "0x1831E6EB0")]
	public static void IFBNILNLBMI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFB40", Offset = "0x1FBED40", VA = "0x181FBFB40")]
	public static void DEJOMJMCBID(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31E6B40", Offset = "0x31E5D40", VA = "0x1831E6B40")]
	public static void DEJOMJMCBID<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31E6AF0", Offset = "0x31E5CF0", VA = "0x1831E6AF0")]
	public static void DEJOMJMCBID<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29A4010", Offset = "0x29A3210", VA = "0x1829A4010")]
	public static void JBGOPDHBDHF<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29A4010", Offset = "0x29A3210", VA = "0x1829A4010")]
	public static void JBGOPDHBDHF<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29A4010", Offset = "0x29A3210", VA = "0x1829A4010")]
	public static void LLBHCJHGIHI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<DPDKCKKCEBB> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29A4010", Offset = "0x29A3210", VA = "0x1829A4010")]
	public static void LLBHCJHGIHI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<DPDKCKKCEBB> JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CHBOJGHDDPM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC36D0", Offset = "0x1FC28D0", VA = "0x181FC36D0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) IPIPKIEKNHK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1040", Offset = "0x1FC0240", VA = "0x181FC1040")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) CNGANHIJJID(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0610", Offset = "0x1FBF810", VA = "0x181FC0610")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) BGPJHIKELJC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FC25F0", Offset = "0x1FC17F0", VA = "0x181FC25F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FMEIHHKIBOA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3AF0", Offset = "0x1FC2CF0", VA = "0x181FC3AF0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KJFJAALAAFH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1B30", Offset = "0x1FC0D30", VA = "0x181FC1B30")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) EHGEFOKKNHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2A00", Offset = "0x1FC1C00", VA = "0x181FC2A00")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GHGHAIFCDEN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FC55B0", Offset = "0x1FC47B0", VA = "0x181FC55B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) PFEFGFDMINJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3C40", Offset = "0x1FC2E40", VA = "0x181FC3C40")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KLJHJGJHNOJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3300", Offset = "0x1FC2500", VA = "0x181FC3300")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) HIJOEIHBKDF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2F30", Offset = "0x1FC2130", VA = "0x181FC2F30")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) HBHPHEHMBDM(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC12B0", Offset = "0x1FC04B0", VA = "0x181FC12B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) DGJOFDEKCHF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5490", Offset = "0x1FC4690", VA = "0x181FC5490")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) OHDBJDMHMDB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4E70", Offset = "0x1FC4070", VA = "0x181FC4E70")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>) NCHMCDDNMMB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<FLHNECBBMMA>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3D60", Offset = "0x1FC2F60", VA = "0x181FC3D60")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<FLHNECBBMMA>>>) KLLDEHFDHHB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<PLNLGICOJDD<FLHNECBBMMA>>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<FLHNECBBMMA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC09B0", Offset = "0x1FBFBB0", VA = "0x181FC09B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>) BMODOOFLIAH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<DPDKCKKCEBB>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4C00", Offset = "0x1FC3E00", VA = "0x181FC4C00")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<DPDKCKKCEBB>>>) MMKLAFNHPCN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<PLNLGICOJDD<DPDKCKKCEBB>>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<DPDKCKKCEBB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2949160", Offset = "0x2948360", VA = "0x182949160")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>) OIHKEBDPBJJ<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<GDGJOIIKKHE>? GPJOKKOGGOF, [Optional][In] ReadOnlySpan<byte> LINJEFIAFHO)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFFF0", Offset = "0x1FBF1F0", VA = "0x181FBFFF0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) AIJILIOOBOK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GIEIMDLAKLP)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FC03D0", Offset = "0x1FBF5D0", VA = "0x181FC03D0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BFECMBCNCMK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GIEIMDLAKLP)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2948F70", Offset = "0x2948170", VA = "0x182948F70")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>) JDLODOOPKLG<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GIEIMDLAKLP, [Optional] int? ECGAAJFODGN, [Optional][In] ReadOnlySpan<byte> GHPNOJNBADJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2948E20", Offset = "0x2948020", VA = "0x182948E20")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>) CGGPOLKFJGO<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GIEIMDLAKLP, [Optional] int? ECGAAJFODGN)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0250", Offset = "0x1FBF450", VA = "0x181FC0250")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) BDIEGPNBFEP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FC47F0", Offset = "0x1FC39F0", VA = "0x181FC47F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) MDLIDKMMDBH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1190", Offset = "0x1FC0390", VA = "0x181FC1190")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) DGCOBEMPGGK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3F90", Offset = "0x1FC3190", VA = "0x181FC3F90")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KNNBPCNLFMB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2750", Offset = "0x1FC1950", VA = "0x181FC2750")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FOKFOLEIKKO(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5250", Offset = "0x1FC4450", VA = "0x181FC5250")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ODPLLELJBON(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DA0", Offset = "0x1FC0FA0", VA = "0x181FC1DA0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ELOKPOGCNAD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0EF0", Offset = "0x1FC00F0", VA = "0x181FC0EF0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CLPGHBBGBCH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0DD0", Offset = "0x1FBFFD0", VA = "0x181FC0DD0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CKMKDOOBBJH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1A40", Offset = "0x1FC0C40", VA = "0x181FC1A40")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) EGGOJINGKEC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? OGIOCNLNLJG)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1740", Offset = "0x1FC0940", VA = "0x181FC1740")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DNIOLMJKFKL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0B50", Offset = "0x1FBFD50", VA = "0x181FC0B50")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CALMLILNMHI(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0120", Offset = "0x1FBF320", VA = "0x181FC0120")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ALIDOAHBKMA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4690", Offset = "0x1FC3890", VA = "0x181FC4690")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MCKDFCKFFPP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FC31B0", Offset = "0x1FC23B0", VA = "0x181FC31B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HEKBJOIGJGG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5130", Offset = "0x1FC4330", VA = "0x181FC5130")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) NDEECNOPFKD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FC18C0", Offset = "0x1FC0AC0", VA = "0x181FC18C0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ECMDCNFGENB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4D10", Offset = "0x1FC3F10", VA = "0x181FC4D10")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MPLMADFCKIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FC04E0", Offset = "0x1FBF6E0", VA = "0x181FC04E0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BFNDHFGFHCE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3050", Offset = "0x1FC2250", VA = "0x181FC3050")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HDKBJHABFBF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0860", Offset = "0x1FBFA60", VA = "0x181FC0860")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BMJHPHCLFIE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2080", Offset = "0x1FC1280", VA = "0x181FC2080")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FHIEOKLKJNE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC42C0", Offset = "0x1FC34C0", VA = "0x181FC42C0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LBPPOODJNNN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4AA0", Offset = "0x1FC3CA0", VA = "0x181FC4AA0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MLEFEGGEEKG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4440", Offset = "0x1FC3640", VA = "0x181FC4440")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LCFHOLIBJLH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4940", Offset = "0x1FC3B40", VA = "0x181FC4940")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MJBEGNDKBBG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFEA0", Offset = "0x1FBF0A0", VA = "0x181FBFEA0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) AHMNHCGJJIL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4570", Offset = "0x1FC3770", VA = "0x181FC4570")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LDIGAAGDCPF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FC21A0", Offset = "0x1FC13A0", VA = "0x181FC21A0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FIFJDIBBDHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3410", Offset = "0x1FC2610", VA = "0x181FC3410")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HMGJAIPAKEP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0730", Offset = "0x1FBF930", VA = "0x181FC0730")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BMGEABFEBHE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2DD0", Offset = "0x1FC1FD0", VA = "0x181FC2DD0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GOGPCGNGCFG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4170", Offset = "0x1FC3370", VA = "0x181FC4170")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LBJEHGMNDBK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0CB0", Offset = "0x1FBFEB0", VA = "0x181FC0CB0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CHOIFCGHIIN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2470", Offset = "0x1FC1670", VA = "0x181FC2470")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) FLFFHKPFHJH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3850", Offset = "0x1FC2A50", VA = "0x181FC3850")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) JDCIJLGPDLH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5700", Offset = "0x1FC4900", VA = "0x181FC5700")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) PPKLGFIFNNA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3570", Offset = "0x1FC2770", VA = "0x181FC3570")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ILIJGAHMPDC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC39A0", Offset = "0x1FC2BA0", VA = "0x181FC39A0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) JFPALJEOBIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC13C0", Offset = "0x1FC05C0", VA = "0x181FC13C0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DIPANNNNKCF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1630", Offset = "0x1FC0830", VA = "0x181FC1630")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DJPHAPEOIKA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? PBNDEDBFMFG, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2CC0", Offset = "0x1FC1EC0", VA = "0x181FC2CC0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GODIAHPLEHF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? PBNDEDBFMFG, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC40F0", Offset = "0x1FC32F0", VA = "0x181FC40F0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> KPANLHLFIGJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1F00", Offset = "0x1FC1100", VA = "0x181FC1F00")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) FFHAPONKGHG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FC14E0", Offset = "0x1FC06E0", VA = "0x181FC14E0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) DJDHFODCECG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5010", Offset = "0x1FC4210", VA = "0x181FC5010")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) NCLNKDOIMDP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2B60", Offset = "0x1FC1D60", VA = "0x181FC2B60")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GNGAPADJJNF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2320", Offset = "0x1FC1520", VA = "0x181FC2320")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FJMHANCPLML(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5370", Offset = "0x1FC4570", VA = "0x181FC5370")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) OGDJHFPOAOL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FC28A0", Offset = "0x1FC1AA0", VA = "0x181FC28A0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GCMPFHGEDJF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1C50", Offset = "0x1FC0E50", VA = "0x181FC1C50")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) EHPEJFAEOAB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3E70", Offset = "0x1FC3070", VA = "0x181FC3E70")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KMNOPCAKFBL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
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
