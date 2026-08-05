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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FBAA40", Offset = "0x1FB9440", VA = "0x181FBAA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FNFDHPEPPFF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2995950", Offset = "0x2994350", VA = "0x182995950")]
	public static OMNCLBBEMMM<EEHEIECAIMH<M>> BLPEPBHCFDN<M>(this int HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA860", Offset = "0x1FB9260", VA = "0x181FBA860")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> GGDCDBHNHLE(this int HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2995950", Offset = "0x2994350", VA = "0x182995950")]
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
		[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
		public KGPBIEPNJHN(IntPtr CIGKBEKHOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x417BE00", Offset = "0x417A800", VA = "0x18417BE00")]
		public int APPOJKGPLJE(TDeps HDLOJHGAFKF, TContext MOPANCMKHLH, TCompileState CMLBKFIDFAP, [In] MAHDLFLAHIJ<byte> HNBDOKAPHPI, int KJJBKOMLKJA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C8E0", Offset = "0x2B6B2E0", VA = "0x182B6C8E0")]
	public static void ENFANOGMMKK<TDeps, TContext, TCompileState>(TDeps HDLOJHGAFKF, TContext MOPANCMKHLH, TCompileState CMLBKFIDFAP, [In] MAHDLFLAHIJ<byte> BODDDCFDMEH, MAHDLFLAHIJ<byte> NOJCKECOEKH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BDOELNCNKKL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MMNGLKHJHFA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EHKCJGHMFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PBLKOFNDJCI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OFECAGLFNAE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KFIBMINOJFA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EBNKHLOKHCE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FCPJODBLILG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OKKCCKADMNB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EMHJPHLNAGD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ODMMFHPGNMO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PIBODIEAMCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KALDEOBEELK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LCENLBMCAJE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CHAEGPFANIC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GNDFGKCLFAM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GBCPABKECAC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GHJBCPIECKK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GONHIDKEKJH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NHOJODDBJJK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FNOCMJNKHJE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FHDINBCEJCH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FCFOCMLNALE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ILEMDAOBOFH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IEFMEIONGDD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LCODHOHDDEO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMDFNOOOIMN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ALGDOLKDDBG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BPPFGHDBKAK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JHEPIOFDIIJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PGPCLKONPMF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LEFCJDMDGMJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MDGNFGJEMFL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OIFGHKPGILO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JAIJKLOKMBO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OECFBCBNFLG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JJHDKDPBIKB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NNOLMOGDHBB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GMPMCFELGLB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PELICLJLJMK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CCEBJJJLOIP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MKNAJMKJNIE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KIEOCGMNENP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CPIPNIOBDDP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KPOMEPJGFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DDHACHJCMAN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EOKCPJPFINI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PHGEMDMEHMO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FAHKOKANAAK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EPLGDJNALJA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANHJPNLGOLK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IGPJKCAPOIL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMEBPJKLGDM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GNPAAFFELOG, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HMMIPJNONJC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PMAGNCHBIOK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MFGAIIJNHJD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JGGDCEFADKC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NJHDHDCOONF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BAJILNNFMFC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NBHLBJFKDBH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NIHKAGHJMFL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OMNNGKNENBE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NFLHFBHOCKP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LILOIGCMFPL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DIGNKOEJBEI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LHKLDELJLHH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JBJPILFLDCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IGHLONDCCJI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANBDMCGBCMP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ACCPKIFNONL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LJHHKHFBFBK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KDLEDKJOMEF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JEMLFNCBLDP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MLHAOHHNHFB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NGOCDHJPLEB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CLCMPBAJDIN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GIILMBJPIKL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ANDIFCCLADH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LOJDBONONEL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FGFNHFNLCOJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IBELBHBPDBA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LKKJFEJKIHI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HNKDKDJKBMK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PIICGCCHBKF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EHELBLMAINF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? LEPBKEGGEAF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EKHMBOGDNCD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GEJDBJFANOA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KOMAAEMFPBC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CGLOAAMPEOK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ADMAPBDBIJI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BCCAIFAFDCC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BFBNFPFBCMH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EOGNGMEJCBE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KHHCJFKFHCH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OIOICCMIIAM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GKNGJIMNJJC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BAHAHBAHDBJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DKNMLEIMLNF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CICFJIAOJDA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BMIBDOACJCK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IBBEGHPGJOO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IEINNMDINIL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AGCMDODNKEO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HEEFDADJGAL, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? OOFAPONKDFJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FMJLIGJDKJB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? HHNKIPLNOLI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? GEMJFPPJPHC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PPPNLNAIHBJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CAGPJBALJMJ, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? NHCJAKDHENC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? JJGLNKCBEGI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MBNGEPLOEJN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? IPNMDDALOKE, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PBKDHHPIJOD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? PDHDLIJHJML, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? BGPMODCJJEP, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FAHMDKFEHAI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CDECHGILKCN, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? KIGPBNOPAEK, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MCOOCJKNIKC, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? DDCHPAKPLJB, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FDOIDLLKNJF, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FPGMHPFKALI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ALGFGLDLJCO, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? FEIHKKIFJNA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MIABFKNCINI, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? CDJDFLLJKFH, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AOLIAGKHGJD, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? ECPGIIDGEHM, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? AOKMFOEGPBA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? EKMHKEKCPIA, [Optional] KGPBIEPNJHN<TContext, TDeps, TCompileState>? MJOPCMLJOBH) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA890", Offset = "0x1FB9290", VA = "0x181FBA890")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CD2990", Offset = "0x2CD1390", VA = "0x182CD2990")]
	public static OMNCLBBEMMM<EEHEIECAIMH<T>> FOOCDGFJIMD<T>([In] this MAHDLFLAHIJ<byte> HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD29F0", Offset = "0x2CD13F0", VA = "0x182CD29F0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>> NGOLHFEAEBC<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<EEHEIECAIMH<T>>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB030", Offset = "0x1FB9A30", VA = "0x181FBB030")]
	public static OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>> PPEBFLODMIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<FLHNECBBMMA>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBABA0", Offset = "0x1FB95A0", VA = "0x181FBABA0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>> EIIGDBPMENH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] float? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAAC0", Offset = "0x1FB94C0", VA = "0x181FBAAC0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>> DPCCODOICHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAE70", Offset = "0x1FB9870", VA = "0x181FBAE70")]
	public static OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>> JENNOMPPPON(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<GDGJOIIKKHE>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAC80", Offset = "0x1FB9680", VA = "0x181FBAC80")]
	public static OMNCLBBEMMM<EEHEIECAIMH<BFHAAPCPJEO>> GMADPNLDJNI(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] byte? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<BFHAAPCPJEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAF50", Offset = "0x1FB9950", VA = "0x181FBAF50")]
	public static OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>> NNBEIGPAHIL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<DPDKCKKCEBB>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAD80", Offset = "0x1FB9780", VA = "0x181FBAD80")]
	public static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> IOFKCJJAFPF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] FCKNPEIOHKG? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2AB0", Offset = "0x2CD14B0", VA = "0x182CD2AB0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>> PGDNGGKDGAD<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<T>>? JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A90", Offset = "0x1FB3490", VA = "0x181FB4A90")]
	public static void MINMMGPGIJK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>> PEONPFKEDHI, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2980", Offset = "0x2CD1380", VA = "0x182CD2980")]
	public static void JBGOPDHBDHF<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<T>>> KJJBKOMLKJA, OMNCLBBEMMM<EEHEIECAIMH<T>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2980", Offset = "0x2CD1380", VA = "0x182CD2980")]
	public static void FGCILONMDIC<T>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<T>>> NMEKIECFIEP, OMNCLBBEMMM<PLNLGICOJDD<T>> JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NAHCJCHHPLH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA9D0", Offset = "0x1FB93D0", VA = "0x181FBA9D0")]
	public static NKFCAEJKJCA LMMLLMFKNJF([In] this ReadOnlySpan<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA930", Offset = "0x1FB9330", VA = "0x181FBA930")]
	public static NKFCAEJKJCA LMMLLMFKNJF([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BBB0", Offset = "0x2C8A5B0", VA = "0x182C8BBB0")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BD00", Offset = "0x2C8A700", VA = "0x182C8BD00")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>([In] this APFLCPGGLDF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BA00", Offset = "0x2C8A400", VA = "0x182C8BA00")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B990", Offset = "0x2C8A390", VA = "0x182C8B990")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BE50", Offset = "0x2C8A850", VA = "0x182C8BE50")]
	public static NKFCAEJKJCA LMMLLMFKNJF<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA9D0", Offset = "0x1FB93D0", VA = "0x181FBA9D0")]
	public static int POENGODBEHI([In] this ReadOnlySpan<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4B70", Offset = "0x1FB3570", VA = "0x181FB4B70")]
	public static int POENGODBEHI([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2995AE0", Offset = "0x29944E0", VA = "0x182995AE0")]
	public static int POENGODBEHI<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2995AE0", Offset = "0x29944E0", VA = "0x182995AE0")]
	public static int POENGODBEHI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2995AE0", Offset = "0x29944E0", VA = "0x182995AE0")]
	public static int POENGODBEHI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2995AE0", Offset = "0x29944E0", VA = "0x182995AE0")]
	public static int POENGODBEHI<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B690", Offset = "0x2C8A090", VA = "0x182C8B690")]
	public static float EEBMAGMDHMG<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B690", Offset = "0x2C8A090", VA = "0x182C8B690")]
	public static float EEBMAGMDHMG<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B690", Offset = "0x2C8A090", VA = "0x182C8B690")]
	public static float EEBMAGMDHMG<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B890", Offset = "0x2C8A290", VA = "0x182C8B890")]
	public static byte JCLGNFBAFEN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B970", Offset = "0x2C8A370", VA = "0x182C8B970")]
	public static byte JCLGNFBAFEN<M>([In] this APFLCPGGLDF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BA00", Offset = "0x2C8A400", VA = "0x182C8BA00")]
	public static byte JCLGNFBAFEN<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B990", Offset = "0x2C8A390", VA = "0x182C8B990")]
	public static byte JCLGNFBAFEN<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B8C0", Offset = "0x2C8A2C0", VA = "0x182C8B8C0")]
	public static byte JCLGNFBAFEN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4B70", Offset = "0x1FB3570", VA = "0x181FB4B70")]
	public static FCKNPEIOHKG NDFEINOHHMM([In] this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP)
	{
		return default(FCKNPEIOHKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2995AE0", Offset = "0x29944E0", VA = "0x182995AE0")]
	public static FCKNPEIOHKG NDFEINOHHMM<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(FCKNPEIOHKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BA60", Offset = "0x2C8A460", VA = "0x182C8BA60")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BB40", Offset = "0x2C8A540", VA = "0x182C8BB40")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BAD0", Offset = "0x2C8A4D0", VA = "0x182C8BAD0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JPGGIDEODKC<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BFE0", Offset = "0x2C8A9E0", VA = "0x182C8BFE0")]
	public static OMNCLBBEMMM<PLNLGICOJDD<JHGAOCPFCLJ>> PDFJGJCEKOK<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<PLNLGICOJDD<JHGAOCPFCLJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B820", Offset = "0x2C8A220", VA = "0x182C8B820")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B740", Offset = "0x2C8A140", VA = "0x182C8B740")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B7B0", Offset = "0x2C8A1B0", VA = "0x182C8B7B0")]
	public static OMNCLBBEMMM<DPDKCKKCEBB> FFIAKBAKLGG<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<DPDKCKKCEBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BF70", Offset = "0x2C8A970", VA = "0x182C8BF70")]
	public static OMNCLBBEMMM<FLHNECBBMMA> MFCPAADGOHJ<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<FLHNECBBMMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BF00", Offset = "0x2C8A900", VA = "0x182C8BF00")]
	public static OMNCLBBEMMM<FLHNECBBMMA> MFCPAADGOHJ<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<FLHNECBBMMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B6D0", Offset = "0x2C8A0D0", VA = "0x182C8B6D0")]
	public static OMNCLBBEMMM<GDGJOIIKKHE> FBJCMOLBIBN<M>(this AFBKHNCNAOF<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP)
	{
		return default(OMNCLBBEMMM<GDGJOIIKKHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ALGKBOIGCEC
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4BF0", Offset = "0x1FB35F0", VA = "0x181FB4BF0")]
	public static void EHGLDIKDBJK(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4D30", Offset = "0x1FB3730", VA = "0x181FB4D30")]
	public static void EHGLDIKDBJK(this byte[] DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4CB0", Offset = "0x1FB36B0", VA = "0x181FB4CB0")]
	public static void EHGLDIKDBJK([In] this Span<byte> DDNKCFIIBGP, int ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31D7000", Offset = "0x31D5A00", VA = "0x1831D7000")]
	public static void EHGLDIKDBJK<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x31D7190", Offset = "0x31D5B90", VA = "0x1831D7190")]
	public static void EHGLDIKDBJK<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, NKFCAEJKJCA JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A90", Offset = "0x1FB3490", VA = "0x181FB4A90")]
	public static void MINMMGPGIJK(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4DE0", Offset = "0x1FB37E0", VA = "0x181FB4DE0")]
	public static void MINMMGPGIJK(this byte[] DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4E60", Offset = "0x1FB3860", VA = "0x181FB4E60")]
	public static void MINMMGPGIJK([In] this Span<byte> DDNKCFIIBGP, int ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31D7440", Offset = "0x31D5E40", VA = "0x1831D7440")]
	public static void MINMMGPGIJK<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31D73E0", Offset = "0x31D5DE0", VA = "0x1831D73E0")]
	public static void MINMMGPGIJK<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4DA0", Offset = "0x1FB37A0", VA = "0x181FB4DA0")]
	public static void IFBNILNLBMI(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31D7380", Offset = "0x31D5D80", VA = "0x1831D7380")]
	public static void IFBNILNLBMI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31D7320", Offset = "0x31D5D20", VA = "0x1831D7320")]
	public static void IFBNILNLBMI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4B80", Offset = "0x1FB3580", VA = "0x181FB4B80")]
	public static void DEJOMJMCBID(this MAHDLFLAHIJ<byte> DDNKCFIIBGP, int ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31D6FB0", Offset = "0x31D59B0", VA = "0x1831D6FB0")]
	public static void DEJOMJMCBID<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31D6F60", Offset = "0x31D5960", VA = "0x1831D6F60")]
	public static void DEJOMJMCBID<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2995A20", Offset = "0x2994420", VA = "0x182995A20")]
	public static void JBGOPDHBDHF<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2995A20", Offset = "0x2994420", VA = "0x182995A20")]
	public static void JBGOPDHBDHF<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2995A20", Offset = "0x2994420", VA = "0x182995A20")]
	public static void LLBHCJHGIHI<M>(this NEJMCMAKMAA<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<DPDKCKKCEBB> JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2995A20", Offset = "0x2994420", VA = "0x182995A20")]
	public static void LLBHCJHGIHI<M>([In] this MNBCKJGJMMH<M, byte> DDNKCFIIBGP, OMNCLBBEMMM<M> ENHCCNBGHAP, OMNCLBBEMMM<DPDKCKKCEBB> JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CHBOJGHDDPM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8710", Offset = "0x1FB7110", VA = "0x181FB8710")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) IPIPKIEKNHK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6080", Offset = "0x1FB4A80", VA = "0x181FB6080")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) CNGANHIJJID(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5650", Offset = "0x1FB4050", VA = "0x181FB5650")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) BGPJHIKELJC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7630", Offset = "0x1FB6030", VA = "0x181FB7630")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FMEIHHKIBOA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8B30", Offset = "0x1FB7530", VA = "0x181FB8B30")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KJFJAALAAFH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6B70", Offset = "0x1FB5570", VA = "0x181FB6B70")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) EHGEFOKKNHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7A40", Offset = "0x1FB6440", VA = "0x181FB7A40")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GHGHAIFCDEN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA5F0", Offset = "0x1FB8FF0", VA = "0x181FBA5F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) PFEFGFDMINJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8C80", Offset = "0x1FB7680", VA = "0x181FB8C80")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KLJHJGJHNOJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8340", Offset = "0x1FB6D40", VA = "0x181FB8340")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) HIJOEIHBKDF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7F70", Offset = "0x1FB6970", VA = "0x181FB7F70")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) HBHPHEHMBDM(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB62F0", Offset = "0x1FB4CF0", VA = "0x181FB62F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) DGJOFDEKCHF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA4D0", Offset = "0x1FB8ED0", VA = "0x181FBA4D0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) OHDBJDMHMDB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? JMDCGOKJIDA, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? ILFNFKJIIMJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9EB0", Offset = "0x1FB88B0", VA = "0x181FB9EB0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>) NCHMCDDNMMB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<FLHNECBBMMA>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<FLHNECBBMMA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8DA0", Offset = "0x1FB77A0", VA = "0x181FB8DA0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<FLHNECBBMMA>>>) KLLDEHFDHHB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<PLNLGICOJDD<FLHNECBBMMA>>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<FLHNECBBMMA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB59F0", Offset = "0x1FB43F0", VA = "0x181FB59F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>) BMODOOFLIAH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<DPDKCKKCEBB>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<DPDKCKKCEBB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9C40", Offset = "0x1FB8640", VA = "0x181FB9C40")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<DPDKCKKCEBB>>>) MMKLAFNHPCN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? LCKHINNBHPI, [Optional] OMNCLBBEMMM<PLNLGICOJDD<DPDKCKKCEBB>>? GPJOKKOGGOF)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<DPDKCKKCEBB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x293AB30", Offset = "0x2939530", VA = "0x18293AB30")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>) OIHKEBDPBJJ<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<GDGJOIIKKHE>? GPJOKKOGGOF, [Optional][In] ReadOnlySpan<byte> LINJEFIAFHO)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5030", Offset = "0x1FB3A30", VA = "0x181FB5030")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) AIJILIOOBOK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GIEIMDLAKLP)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5410", Offset = "0x1FB3E10", VA = "0x181FB5410")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BFECMBCNCMK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? GIEIMDLAKLP)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x293A940", Offset = "0x2939340", VA = "0x18293A940")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>) JDLODOOPKLG<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GIEIMDLAKLP, [Optional] int? ECGAAJFODGN, [Optional][In] ReadOnlySpan<byte> GHPNOJNBADJ)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x293A7F0", Offset = "0x29391F0", VA = "0x18293A7F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>) CGGPOLKFJGO<TMarker>(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PLNLGICOJDD<TMarker>>? GIEIMDLAKLP, [Optional] int? ECGAAJFODGN)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<TMarker>>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5290", Offset = "0x1FB3C90", VA = "0x181FB5290")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) BDIEGPNBFEP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9830", Offset = "0x1FB8230", VA = "0x181FB9830")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) MDLIDKMMDBH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FB61D0", Offset = "0x1FB4BD0", VA = "0x181FB61D0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) DGCOBEMPGGK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8FD0", Offset = "0x1FB79D0", VA = "0x181FB8FD0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) KNNBPCNLFMB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7790", Offset = "0x1FB6190", VA = "0x181FB7790")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FOKFOLEIKKO(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA290", Offset = "0x1FB8C90", VA = "0x181FBA290")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ODPLLELJBON(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6DE0", Offset = "0x1FB57E0", VA = "0x181FB6DE0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ELOKPOGCNAD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5F30", Offset = "0x1FB4930", VA = "0x181FB5F30")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CLPGHBBGBCH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5E10", Offset = "0x1FB4810", VA = "0x181FB5E10")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CKMKDOOBBJH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6A80", Offset = "0x1FB5480", VA = "0x181FB6A80")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>) EGGOJINGKEC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? OGIOCNLNLJG)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6780", Offset = "0x1FB5180", VA = "0x181FB6780")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DNIOLMJKFKL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B90", Offset = "0x1FB4590", VA = "0x181FB5B90")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CALMLILNMHI(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5160", Offset = "0x1FB3B60", VA = "0x181FB5160")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ALIDOAHBKMA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FB96D0", Offset = "0x1FB80D0", VA = "0x181FB96D0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MCKDFCKFFPP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FB81F0", Offset = "0x1FB6BF0", VA = "0x181FB81F0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HEKBJOIGJGG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA170", Offset = "0x1FB8B70", VA = "0x181FBA170")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) NDEECNOPFKD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6900", Offset = "0x1FB5300", VA = "0x181FB6900")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ECMDCNFGENB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9D50", Offset = "0x1FB8750", VA = "0x181FB9D50")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MPLMADFCKIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5520", Offset = "0x1FB3F20", VA = "0x181FB5520")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BFNDHFGFHCE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8090", Offset = "0x1FB6A90", VA = "0x181FB8090")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HDKBJHABFBF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FB58A0", Offset = "0x1FB42A0", VA = "0x181FB58A0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BMJHPHCLFIE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB70C0", Offset = "0x1FB5AC0", VA = "0x181FB70C0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FHIEOKLKJNE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9300", Offset = "0x1FB7D00", VA = "0x181FB9300")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LBPPOODJNNN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9AE0", Offset = "0x1FB84E0", VA = "0x181FB9AE0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MLEFEGGEEKG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9480", Offset = "0x1FB7E80", VA = "0x181FB9480")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LCFHOLIBJLH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9980", Offset = "0x1FB8380", VA = "0x181FB9980")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) MJBEGNDKBBG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4EE0", Offset = "0x1FB38E0", VA = "0x181FB4EE0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) AHMNHCGJJIL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FB95B0", Offset = "0x1FB7FB0", VA = "0x181FB95B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LDIGAAGDCPF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FB71E0", Offset = "0x1FB5BE0", VA = "0x181FB71E0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FIFJDIBBDHD(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8450", Offset = "0x1FB6E50", VA = "0x181FB8450")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) HMGJAIPAKEP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5770", Offset = "0x1FB4170", VA = "0x181FB5770")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) BMGEABFEBHE(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7E10", Offset = "0x1FB6810", VA = "0x181FB7E10")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GOGPCGNGCFG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FB91B0", Offset = "0x1FB7BB0", VA = "0x181FB91B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) LBJEHGMNDBK(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5CF0", Offset = "0x1FB46F0", VA = "0x181FB5CF0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) CHOIFCGHIIN(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FB74B0", Offset = "0x1FB5EB0", VA = "0x181FB74B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) FLFFHKPFHJH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8890", Offset = "0x1FB7290", VA = "0x181FB8890")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) JDCIJLGPDLH(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA740", Offset = "0x1FB9140", VA = "0x181FBA740")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) PPKLGFIFNNA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB85B0", Offset = "0x1FB6FB0", VA = "0x181FB85B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) ILIJGAHMPDC(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB89E0", Offset = "0x1FB73E0", VA = "0x181FB89E0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) JFPALJEOBIB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6400", Offset = "0x1FB4E00", VA = "0x181FB6400")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DIPANNNNKCF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6670", Offset = "0x1FB5070", VA = "0x181FB6670")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) DJPHAPEOIKA(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] int? PBNDEDBFMFG, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7D00", Offset = "0x1FB6700", VA = "0x181FB7D00")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GODIAHPLEHF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? PBNDEDBFMFG, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9130", Offset = "0x1FB7B30", VA = "0x181FB9130")]
	public static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> KPANLHLFIGJ(this MAHDLFLAHIJ<byte> HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6F40", Offset = "0x1FB5940", VA = "0x181FB6F40")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) FFHAPONKGHG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6520", Offset = "0x1FB4F20", VA = "0x181FB6520")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) DJDHFODCECG(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, float DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<OCBKIHBIOMI>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA050", Offset = "0x1FB8A50", VA = "0x181FBA050")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>) NCLNKDOIMDP(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<OCBKIHBIOMI>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<OCBKIHBIOMI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7BA0", Offset = "0x1FB65A0", VA = "0x181FB7BA0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GNGAPADJJNF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7360", Offset = "0x1FB5D60", VA = "0x181FB7360")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) FJMHANCPLML(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA3B0", Offset = "0x1FB8DB0", VA = "0x181FBA3B0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) OGDJHFPOAOL(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FB78E0", Offset = "0x1FB62E0", VA = "0x181FB78E0")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) GCMPFHGEDJF(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6C90", Offset = "0x1FB5690", VA = "0x181FB6C90")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>) EHPEJFAEOAB(this MAHDLFLAHIJ<byte> HIKEOGPAJAF, int DCFFNODJOBH, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? DGCFGPHGFGD, [Optional] OMNCLBBEMMM<PLNLGICOJDD<BALKHKDPIOA>>? HOHIMKEEDFI)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<BALKHKDPIOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8EB0", Offset = "0x1FB78B0", VA = "0x181FB8EB0")]
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
