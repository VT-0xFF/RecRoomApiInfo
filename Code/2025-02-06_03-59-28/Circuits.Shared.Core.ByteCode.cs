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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2531AA0", Offset = "0x25308A0", VA = "0x182531AA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OLENMFCGDDD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3094C60", Offset = "0x3093A60", VA = "0x183094C60")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<M>> BHANBECAPMB<M>(this int DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2531B20", Offset = "0x2530920", VA = "0x182531B20")]
	public static MMBOLDIBAHF<DEKEAGJKOGP> DEHCFMKKHOG(this int DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<DEKEAGJKOGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3094C60", Offset = "0x3093A60", VA = "0x183094C60")]
	public static MMBOLDIBAHF<OHHDAOJKLLK<M>> JKDFMPEEEGJ<M>(this int DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<OHHDAOJKLLK<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GDBEKIHBPGN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FPJODPMGBJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NMADBMEFDOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DEKEAGJKOGP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class PNDHOCJOEON
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BEEAOHJPLGA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HMLOLOIIMGD
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
public static class KLKLFPMFELI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct EOKPBHEOKBB<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr IFFADEBAIFJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
		public EOKPBHEOKBB(IntPtr MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4007030", Offset = "0x4005E30", VA = "0x184007030")]
		public int GAFILCALGLM(TDeps FLOGLGIGMAI, TContext OHLKKDIOCBG, TCompileState EKFMOEJCKAL, [In] ICNNLNCPOAH<byte> FOABEJKJDEG, int GCNEJGKFJLN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x338DD50", Offset = "0x338CB50", VA = "0x18338DD50")]
	public static void FLJGHCKCDOI<TDeps, TContext, TCompileState>(TDeps FLOGLGIGMAI, TContext OHLKKDIOCBG, TCompileState EKFMOEJCKAL, [In] ICNNLNCPOAH<byte> NIPABKIAJGI, ICNNLNCPOAH<byte> KJOCGBDMOGN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? COGFFHIMBDC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GAOONPFLINB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MOGLAKBGFIO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BBCKCCOMABD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KLAEOHDKGJH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MLJFNAKDDAA, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? EEKEFHNPDFN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KOBDALHIBPC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CNNBNBLNKMI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FEGFACKEIEE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KABPEOFFDIE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OMGMNCECOID, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PMDDANNGHEF, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BDBHGMJNEFK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JHDEBKAAIEI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HNICHLPBLLN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BJHEONLFADD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? ONDMPBGICGM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BOKKBHBJACE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AMKPOIGHKGL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JJPFPPIHIJA, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OJOIHDEPEEK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DDBMEDLBFKC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HLEDMIFIOHO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IJOBBHOKMMB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IOKOOMBLMHO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PDGIHEBBFCI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CLKCLFJGOAB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LKBIMPBKBCL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BMBCOJMKLAE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BDCIOFOBNDG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JELDLEHKNCL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PKKENHJMKGN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PELOCPACHNN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HGGHDEENNFA, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AMLGLMDBCGO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LNMIHECKBPG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HKMPCJLCHLE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JLMBAIKDMAD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IHLFDONIMKE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DGNOLOOPALC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AGCABECCPPD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LBLAIJJFHID, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PGPMLPDIIJC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HEJCCHLNIOM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MDIKBIAHIMH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? ENNHIBNDENI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HALODKHAJGH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IGEFAPEBJFK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MNEDAPCMLDI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AFFBMPEBOEN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CDFIALLGFIF, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DAMKHAJIMLD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PBMCEELFLBO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CLCELAHMJOL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JPMPGMKEACK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DBCCAKFJDJB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CEPAPBCMNJM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MOHONFHNABO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KJOBPLHPHBI, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DPIABENOMOB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AHDLDHNNHEC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KCBCIAEMFCD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GHNPFCPPGAO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BAFBNDPGHIO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AIFBIHNBMNJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HHKGBHMJFNB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FMFKHOEKMIC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JLNIAFJHMLJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PIKHOMDKALA, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KLGNEJKBPIK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BNEDGGAMDJB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HJOLKIENINF, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LDFIMPHOAOP, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JAFBOPLHAOJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FOAJNMDHDBE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? EJKPHJIOKLB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AIBIDNGGEAG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FNLLEBGOCCB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HMMGNBILBLE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KJJKOJPGCEB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? MFAMBKPLGIC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OLJKBNHFHGO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LBCEFJLIJFD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DDKHFBFIBDC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? NFEOCOPMKIN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FBCGJOJMFFB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? ECCHGHFIFDP, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DHOOGGBJNOM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IHBMENLCIFL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? FLGIPHLELAM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? NDJCFENACNJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? COJJENGJLPD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DODLCJKILDE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GHDIEALFJPG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? EJABPCMANDJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BIOAJINGLKB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BLFHCOMMMGB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AACFJKPFIJH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AGOPBIINJII, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GKLBOJDOFNB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KHJIPOMILKP, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LONCHKEMPCJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? IBJDPHFOGJE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? NBBNPLJHDOC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OMEEHEGPMBJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GOOIBFMBFGA, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PBNHFHNMHOO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LPDKCKAODDH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HDEGEPEMNPJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OFKFOCJIHNP, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? NFDGKENJPDE, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? PLCFAKKCEDL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? BBDFCLBPBIJ, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JCCPENHAIIL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? LGPKICHEBPC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? OGBLOPFIHBL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AOHHODHBNIK, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? EPNLIEHONLC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KKGJJHKBDGG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JJHCDIHLGPM, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AIIBOBJALJN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JCLLGKCNDPH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DALBPPGCKOG, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? NADPCFKHPPO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? CMNMLMDBLKO, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? HFKAHOGJCIP, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? AIKLCEBKNDN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? INJIFKGLEJL, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? JDPKKPBJEPB, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DNAEBLIPIJN, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KKCNNCHJNMD, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? KGKIPAECBBC, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? DKDMAGIBPOH, [Optional] EOKPBHEOKBB<TContext, TDeps, TCompileState>? GIMFPDPBAHM) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2531360", Offset = "0x2530160", VA = "0x182531360")]
	private static int PIMACKFDHAO([In] ICNNLNCPOAH<byte> CEJLFCDIIBN, ICNNLNCPOAH<byte> CPMDMKKPICC, int EBKPEOBONHB, int BMGBDLLODJK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEAAKDJBCAI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int CGBEOHEABDL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x33A0820", Offset = "0x339F620", VA = "0x1833A0820")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<T>> FGNIBDEHGKB<T>([In] this ICNNLNCPOAH<byte> DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x33A0760", Offset = "0x339F560", VA = "0x1833A0760")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<T>>> AJPGPCOOOJH<T>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<T>>? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x25316B0", Offset = "0x25304B0", VA = "0x1825316B0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<CKICNIFKGGD>> HFIDNBJCLPK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<CKICNIFKGGD>? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<CKICNIFKGGD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2531890", Offset = "0x2530690", VA = "0x182531890")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>> NFGIJJHLJAG(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] float? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2531980", Offset = "0x2530780", VA = "0x182531980")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>> NHAJCLLKFCO(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x25315D0", Offset = "0x25303D0", VA = "0x1825315D0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>> GAADLBFBINP(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<MOJBBOONJIG>? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2531790", Offset = "0x2530590", VA = "0x182531790")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<BEEAOHJPLGA>> LGFLKNFAEMB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] byte? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<BEEAOHJPLGA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25314F0", Offset = "0x25302F0", VA = "0x1825314F0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<DEKEAGJKOGP>> CJHKKHLPEPI(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<DEKEAGJKOGP>? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<DEKEAGJKOGP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2531400", Offset = "0x2530200", VA = "0x182531400")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> BPBLCPMECKF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] HMLOLOIIMGD? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33A0880", Offset = "0x339F680", VA = "0x1833A0880")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<T>>> GCHEFJBBOPO<T>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<T>>? IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x252B3C0", Offset = "0x252A1C0", VA = "0x18252B3C0")]
	public static void BECCDOKIAFG(this ICNNLNCPOAH<byte> DJAJDIFOIHP, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>> GNHPHOJLJCM, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33A0750", Offset = "0x339F550", VA = "0x1833A0750")]
	public static void AKGFKCJDNDG<T>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<T>>> GCNEJGKFJLN, MMBOLDIBAHF<GDBEKIHBPGN<T>> IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x33A0750", Offset = "0x339F550", VA = "0x1833A0750")]
	public static void AGNPHMLANGF<T>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<T>>> EOLHPECCJAO, MMBOLDIBAHF<OHHDAOJKLLK<T>> IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DPPMPMNCFAH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x252B970", Offset = "0x252A770", VA = "0x18252B970")]
	public static OJEEBABOFGM JHGEFCGBOBC([In] this ReadOnlySpan<byte> MDJJEFJEKNO, int FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x252B8D0", Offset = "0x252A6D0", VA = "0x18252B8D0")]
	public static OJEEBABOFGM JHGEFCGBOBC([In] this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x314A1D0", Offset = "0x3148FD0", VA = "0x18314A1D0")]
	public static OJEEBABOFGM JHGEFCGBOBC<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x314A070", Offset = "0x3148E70", VA = "0x18314A070")]
	public static OJEEBABOFGM JHGEFCGBOBC<M>([In] this DAAALCKMBCH<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3149BB0", Offset = "0x31489B0", VA = "0x183149BB0")]
	public static OJEEBABOFGM JHGEFCGBOBC<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3149AF0", Offset = "0x31488F0", VA = "0x183149AF0")]
	public static OJEEBABOFGM JHGEFCGBOBC<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3149FB0", Offset = "0x3148DB0", VA = "0x183149FB0")]
	public static OJEEBABOFGM JHGEFCGBOBC<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x252B970", Offset = "0x252A770", VA = "0x18252B970")]
	public static int PFIFDBAMJHF([In] this ReadOnlySpan<byte> MDJJEFJEKNO, int FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x252B560", Offset = "0x252A360", VA = "0x18252B560")]
	public static int PFIFDBAMJHF([In] this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3093670", Offset = "0x3092470", VA = "0x183093670")]
	public static int PFIFDBAMJHF<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3093670", Offset = "0x3092470", VA = "0x183093670")]
	public static int PFIFDBAMJHF<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3093670", Offset = "0x3092470", VA = "0x183093670")]
	public static int PFIFDBAMJHF<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3093670", Offset = "0x3092470", VA = "0x183093670")]
	public static int PFIFDBAMJHF<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3149F70", Offset = "0x3148D70", VA = "0x183149F70")]
	public static float JENAMPMCHCM<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3149F70", Offset = "0x3148D70", VA = "0x183149F70")]
	public static float JENAMPMCHCM<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3149F70", Offset = "0x3148D70", VA = "0x183149F70")]
	public static float JENAMPMCHCM<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3149B80", Offset = "0x3148980", VA = "0x183149B80")]
	public static byte DBBEDMEOODG<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3149B60", Offset = "0x3148960", VA = "0x183149B60")]
	public static byte DBBEDMEOODG<M>([In] this DAAALCKMBCH<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3149BB0", Offset = "0x31489B0", VA = "0x183149BB0")]
	public static byte DBBEDMEOODG<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3149AF0", Offset = "0x31488F0", VA = "0x183149AF0")]
	public static byte DBBEDMEOODG<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3149C10", Offset = "0x3148A10", VA = "0x183149C10")]
	public static byte DBBEDMEOODG<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x252B560", Offset = "0x252A360", VA = "0x18252B560")]
	public static HMLOLOIIMGD BIONLFLLJBB([In] this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK)
	{
		return default(HMLOLOIIMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3093670", Offset = "0x3092470", VA = "0x183093670")]
	public static HMLOLOIIMGD BIONLFLLJBB<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(HMLOLOIIMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x314A400", Offset = "0x3149200", VA = "0x18314A400")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> KFOPKNAJFFM<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x314A390", Offset = "0x3149190", VA = "0x18314A390")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> KFOPKNAJFFM<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x314A320", Offset = "0x3149120", VA = "0x18314A320")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> KFOPKNAJFFM<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3149CD0", Offset = "0x3148AD0", VA = "0x183149CD0")]
	public static MMBOLDIBAHF<OHHDAOJKLLK<BJAKAGNMCDN>> DCGBOCODFKB<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<OHHDAOJKLLK<BJAKAGNMCDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3149D40", Offset = "0x3148B40", VA = "0x183149D40")]
	public static MMBOLDIBAHF<DEKEAGJKOGP> DLCAGJINLBD<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<DEKEAGJKOGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3149E20", Offset = "0x3148C20", VA = "0x183149E20")]
	public static MMBOLDIBAHF<DEKEAGJKOGP> DLCAGJINLBD<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<DEKEAGJKOGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3149DB0", Offset = "0x3148BB0", VA = "0x183149DB0")]
	public static MMBOLDIBAHF<DEKEAGJKOGP> DLCAGJINLBD<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<DEKEAGJKOGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3149F00", Offset = "0x3148D00", VA = "0x183149F00")]
	public static MMBOLDIBAHF<CKICNIFKGGD> GKFOBPJBDIE<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<CKICNIFKGGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3149E90", Offset = "0x3148C90", VA = "0x183149E90")]
	public static MMBOLDIBAHF<CKICNIFKGGD> GKFOBPJBDIE<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<CKICNIFKGGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3149A80", Offset = "0x3148880", VA = "0x183149A80")]
	public static MMBOLDIBAHF<MOJBBOONJIG> BCFLOCAPEPB<M>(this AMNAKHMFIGM<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK)
	{
		return default(MMBOLDIBAHF<MOJBBOONJIG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CCMBBKGJENK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x252B720", Offset = "0x252A520", VA = "0x18252B720")]
	public static void PPCKKPPEHNJ(this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK, OJEEBABOFGM IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x252B7E0", Offset = "0x252A5E0", VA = "0x18252B7E0")]
	public static void PPCKKPPEHNJ(this byte[] MDJJEFJEKNO, int FPFPCKOIAOK, OJEEBABOFGM IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x252B850", Offset = "0x252A650", VA = "0x18252B850")]
	public static void PPCKKPPEHNJ([In] this Span<byte> MDJJEFJEKNO, int FPFPCKOIAOK, OJEEBABOFGM IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30F3FD0", Offset = "0x30F2DD0", VA = "0x1830F3FD0")]
	public static void PPCKKPPEHNJ<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, OJEEBABOFGM IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30F3E30", Offset = "0x30F2C30", VA = "0x1830F3E30")]
	public static void PPCKKPPEHNJ<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, OJEEBABOFGM IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x252B3C0", Offset = "0x252A1C0", VA = "0x18252B3C0")]
	public static void BECCDOKIAFG(this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x252B5F0", Offset = "0x252A3F0", VA = "0x18252B5F0")]
	public static void BECCDOKIAFG(this byte[] MDJJEFJEKNO, int FPFPCKOIAOK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x252B570", Offset = "0x252A370", VA = "0x18252B570")]
	public static void BECCDOKIAFG([In] this Span<byte> MDJJEFJEKNO, int FPFPCKOIAOK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30F3C10", Offset = "0x30F2A10", VA = "0x1830F3C10")]
	public static void BECCDOKIAFG<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30F3C70", Offset = "0x30F2A70", VA = "0x1830F3C70")]
	public static void BECCDOKIAFG<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x252B670", Offset = "0x252A470", VA = "0x18252B670")]
	public static void GCKOCHLDCJM(this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30F3CD0", Offset = "0x30F2AD0", VA = "0x1830F3CD0")]
	public static void GCKOCHLDCJM<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x30F3D30", Offset = "0x30F2B30", VA = "0x1830F3D30")]
	public static void GCKOCHLDCJM<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x252B6B0", Offset = "0x252A4B0", VA = "0x18252B6B0")]
	public static void ODPCKFBJNJK(this ICNNLNCPOAH<byte> MDJJEFJEKNO, int FPFPCKOIAOK, byte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x30F3DE0", Offset = "0x30F2BE0", VA = "0x1830F3DE0")]
	public static void ODPCKFBJNJK<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, byte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x30F3D90", Offset = "0x30F2B90", VA = "0x1830F3D90")]
	public static void ODPCKFBJNJK<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, byte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3093760", Offset = "0x3092560", VA = "0x183093760")]
	public static void AKGFKCJDNDG<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3093760", Offset = "0x3092560", VA = "0x183093760")]
	public static void AKGFKCJDNDG<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3093760", Offset = "0x3092560", VA = "0x183093760")]
	public static void MNLNAKMCJPC<M>(this BANIPINFFJB<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, MMBOLDIBAHF<DEKEAGJKOGP> IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3093760", Offset = "0x3092560", VA = "0x183093760")]
	public static void MNLNAKMCJPC<M>([In] this ABIKHBFGDED<M, byte> MDJJEFJEKNO, MMBOLDIBAHF<M> FPFPCKOIAOK, MMBOLDIBAHF<DEKEAGJKOGP> IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HBAGBDMBDKM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x252EE90", Offset = "0x252DC90", VA = "0x18252EE90")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) KGOHPFNMANC(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x252C950", Offset = "0x252B750", VA = "0x18252C950")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) EKCCLMOIILJ(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x252BB40", Offset = "0x252A940", VA = "0x18252BB40")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) ANMKMENIFGF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x252ED30", Offset = "0x252DB30", VA = "0x18252ED30")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) KEPOFIDBIII(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x252CF80", Offset = "0x252BD80", VA = "0x18252CF80")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) GEIPHHMIHMH(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2531130", Offset = "0x252FF30", VA = "0x182531130")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PPEJJBPNDAO(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2530D20", Offset = "0x252FB20", VA = "0x182530D20")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PKCOPEJCGGD(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2530950", Offset = "0x252F750", VA = "0x182530950")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PGLPOOCFOLH(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x252D4A0", Offset = "0x252C2A0", VA = "0x18252D4A0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) HFNMFCDNGKB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x252C6F0", Offset = "0x252B4F0", VA = "0x18252C6F0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>) EIKMIKJHJLH(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? IPHILEOFJLB, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? MHMHKCPJANO)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25301A0", Offset = "0x252EFA0", VA = "0x1825301A0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>) NKHEJMLNEKL(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? IPHILEOFJLB, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? MHMHKCPJANO)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x252F430", Offset = "0x252E230", VA = "0x18252F430")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>) KOMJMKGNAMP(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? IPHILEOFJLB, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? MHMHKCPJANO)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x252FA00", Offset = "0x252E800", VA = "0x18252FA00")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>) MBPGBBHIBJF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? IPHILEOFJLB, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? MHMHKCPJANO)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x252F170", Offset = "0x252DF70", VA = "0x18252F170")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<CKICNIFKGGD>>) KLBJPPGNHMJ(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? EGHCOJMFANM, [Optional] MMBOLDIBAHF<CKICNIFKGGD>? LLGCEMPPLIJ)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<CKICNIFKGGD>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x252CD50", Offset = "0x252BB50", VA = "0x18252CD50")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<CKICNIFKGGD>>>) FLANODCFLEE(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? EGHCOJMFANM, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<CKICNIFKGGD>>? LLGCEMPPLIJ)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<CKICNIFKGGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x252C460", Offset = "0x252B260", VA = "0x18252C460")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<DEKEAGJKOGP>>) EBPDJKDKMIL(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? EGHCOJMFANM, [Optional] MMBOLDIBAHF<DEKEAGJKOGP>? LLGCEMPPLIJ)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<DEKEAGJKOGP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x252F7A0", Offset = "0x252E5A0", VA = "0x18252F7A0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<DEKEAGJKOGP>>>) LLHBMADAPGK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? EGHCOJMFANM, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<DEKEAGJKOGP>>? LLGCEMPPLIJ)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<DEKEAGJKOGP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x32BA880", Offset = "0x32B9680", VA = "0x1832BA880")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>) FBKDIPMBJKL<TMarker>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<MOJBBOONJIG>? LLGCEMPPLIJ, [Optional][In] ReadOnlySpan<byte> JOAPLPPIFPC)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2530E80", Offset = "0x252FC80", VA = "0x182530E80")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) POAECEGKPCF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CEJLFCDIIBN, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CPMDMKKPICC)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2531250", Offset = "0x2530050", VA = "0x182531250")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PPJHAHMMGHJ(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CEJLFCDIIBN, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CPMDMKKPICC)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x32BAA80", Offset = "0x32B9880", VA = "0x1832BAA80")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>) JMFNNDOKELH<TMarker>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<TMarker>>? CPMDMKKPICC, [Optional] int? IECADCKMGOP, [Optional][In] ReadOnlySpan<byte> CEJLFCDIIBN)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x32BA730", Offset = "0x32B9530", VA = "0x1832BA730")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>) EFKJLMHNFBJ<TMarker>(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<TMarker>>? CEJLFCDIIBN, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<TMarker>>? CPMDMKKPICC, [Optional] int? IECADCKMGOP)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<TMarker>>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2530FB0", Offset = "0x252FDB0", VA = "0x182530FB0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) PPDLHJNFEAC(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x252FB20", Offset = "0x252E920", VA = "0x18252FB20")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) MPHADJDNEJL(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x252D850", Offset = "0x252C650", VA = "0x18252D850")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) HKNPODONFEB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x252C060", Offset = "0x252AE60", VA = "0x18252C060")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) CGPMNICOIGL(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2530AA0", Offset = "0x252F8A0", VA = "0x182530AA0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PILIOBPJJAK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x252D0D0", Offset = "0x252BED0", VA = "0x18252D0D0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) GIAMPPONAEA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x252DF00", Offset = "0x252CD00", VA = "0x18252DF00")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) ICONKOHMDED(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x252CC00", Offset = "0x252BA00", VA = "0x18252CC00")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) EMFFBLCLCMN(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x252CE60", Offset = "0x252BC60", VA = "0x18252CE60")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) GBEDEBFCIEB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x252C600", Offset = "0x252B400", VA = "0x18252C600")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>) ECOJCJKPNLN(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? FICLBNOAAMC)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x252E180", Offset = "0x252CF80", VA = "0x18252E180")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) IIEPDEBJGMA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x252E860", Offset = "0x252D660", VA = "0x18252E860")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) JJMIPHHOGOH(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x252BC60", Offset = "0x252AA60", VA = "0x18252BC60")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) APLANCEFGMP(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x252D1F0", Offset = "0x252BFF0", VA = "0x18252D1F0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) GIAPLPDMOON(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2530050", Offset = "0x252EE50", VA = "0x182530050")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) NJGNDMIMEII(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x252E060", Offset = "0x252CE60", VA = "0x18252E060")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) IDJLHDPNMPD(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x252E460", Offset = "0x252D260", VA = "0x18252E460")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) IPFECLHNDHF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x252E300", Offset = "0x252D100", VA = "0x18252E300")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) IILIMPMLPIK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x252E9C0", Offset = "0x252D7C0", VA = "0x18252E9C0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) JKCFCMGNOKM(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x252B9E0", Offset = "0x252A7E0", VA = "0x18252B9E0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) AAFJNACPNME(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x252D970", Offset = "0x252C770", VA = "0x18252D970")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) HLONEECLAED(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x252DDE0", Offset = "0x252CBE0", VA = "0x18252DDE0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) ICAOKOCECCE(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x252BD90", Offset = "0x252AB90", VA = "0x18252BD90")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) BKBHJMLJNFK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x252CAA0", Offset = "0x252B8A0", VA = "0x18252CAA0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) ELOMNACHEJI(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x252D720", Offset = "0x252C520", VA = "0x18252D720")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) HHEMFOCGNEB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x252F010", Offset = "0x252DE10", VA = "0x18252F010")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) KIFKPBJOCNL(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x252C800", Offset = "0x252B600", VA = "0x18252C800")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) EJFOHDEFOEA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x252E5E0", Offset = "0x252D3E0", VA = "0x18252E5E0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) JDDNCLCGCCA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2530650", Offset = "0x252F450", VA = "0x182530650")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) OKFADFBMNAD(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x252D5C0", Offset = "0x252C3C0", VA = "0x18252D5C0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) HGKOIFJPEKC(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2530BF0", Offset = "0x252F9F0", VA = "0x182530BF0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) PJIJFPKACFG(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25304F0", Offset = "0x252F2F0", VA = "0x1825304F0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) OIBIEPFOPGO(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x252C310", Offset = "0x252B110", VA = "0x18252C310")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) DBKCPPGDFPG(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25303D0", Offset = "0x252F1D0", VA = "0x1825303D0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) ODNOLHHPJLA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x252DB40", Offset = "0x252C940", VA = "0x18252DB40")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) IAHIKBLLAHC(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x252BF10", Offset = "0x252AD10", VA = "0x18252BF10")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) CEOOFBNLHMB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x252DCC0", Offset = "0x252CAC0", VA = "0x18252DCC0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) IAIHOAIAAFB(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x252E700", Offset = "0x252D500", VA = "0x18252E700")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) JGMCACEMEDD(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x252F540", Offset = "0x252E340", VA = "0x18252F540")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) LAJDHGKONBD(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x252EAF0", Offset = "0x252D8F0", VA = "0x18252EAF0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) JNENPLJPOHA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25302C0", Offset = "0x252F0C0", VA = "0x1825302C0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) NLAIDJNPNGP(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] int? ACKCJOKCDIF, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x252F690", Offset = "0x252E490", VA = "0x18252F690")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) LGBMPMDECDK(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? ACKCJOKCDIF, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x252DAC0", Offset = "0x252C8C0", VA = "0x18252DAC0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> HPIEMBEHGCM(this ICNNLNCPOAH<byte> DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x25307D0", Offset = "0x252F5D0", VA = "0x1825307D0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) PBBNJPKGPPI(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x252F8B0", Offset = "0x252E6B0", VA = "0x18252F8B0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) LLPHGNCMMEF(this ICNNLNCPOAH<byte> DJAJDIFOIHP, float CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<FPJODPMGBJE>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x252FDD0", Offset = "0x252EBD0", VA = "0x18252FDD0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>) NDJPDAGCGDM(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<FPJODPMGBJE>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<FPJODPMGBJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x252FEF0", Offset = "0x252ECF0", VA = "0x18252FEF0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) NDKFECIFGFI(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x252C1C0", Offset = "0x252AFC0", VA = "0x18252C1C0")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) CNCJGPGBONE(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x252F310", Offset = "0x252E110", VA = "0x18252F310")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) KOJKLDOODCP(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x252FC70", Offset = "0x252EA70", VA = "0x18252FC70")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) NCILHECCLDG(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x252D350", Offset = "0x252C150", VA = "0x18252D350")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) GKIAKNCCLGA(this ICNNLNCPOAH<byte> DJAJDIFOIHP, int CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x252EC10", Offset = "0x252DA10", VA = "0x18252EC10")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>) KCEDDIBLKEJ(this ICNNLNCPOAH<byte> DJAJDIFOIHP, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? CHIIBHFIPJG, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? DHELNALCLMK, [Optional] MMBOLDIBAHF<OHHDAOJKLLK<NMADBMEFDOA>>? GCCCGNBLCGL)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<NMADBMEFDOA>>>));
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
