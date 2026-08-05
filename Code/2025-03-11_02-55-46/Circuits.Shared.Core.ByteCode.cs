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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x25B8800", Offset = "0x25B7C00", VA = "0x1825B8800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KIHDHJKPAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3278E40", Offset = "0x3278240", VA = "0x183278E40")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<M>> GFFGHGGLMJC<M>(this int IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B8130", Offset = "0x25B7530", VA = "0x1825B8130")]
	public static DDIPAIMAGGM<JIDAEHPGGPO> DIJJIIMGPOE(this int IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JIDAEHPGGPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3278E40", Offset = "0x3278240", VA = "0x183278E40")]
	public static DDIPAIMAGGM<BLMNBLBFGJK<M>> JNHACCBIILM<M>(this int IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<BLMNBLBFGJK<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JGEBJEKIHIN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NKNDODPDENI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PPJMDEDELHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JIDAEHPGGPO
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KHCMNODBABG
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PHGMLKJCFNH
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ADOJCKECBOJ
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
public static class HLPOCKCIIDL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MIOFEPPLFBA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr DLJAHPJAFDH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
		public MIOFEPPLFBA(IntPtr FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E05A30", Offset = "0x4E04E30", VA = "0x184E05A30")]
		public int PLLPMLOMEJL(TDeps BDKFMFBFJII, TContext GAGLNNPOAHI, TCompileState FKFCNOEOCKJ, [In] FPKFBGDMAGD<byte> ELDECOCPLHM, int LDBPBJLJEDK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34E53E0", Offset = "0x34E47E0", VA = "0x1834E53E0")]
	public static void MGCMDIANBKA<TDeps, TContext, TCompileState>(TDeps BDKFMFBFJII, TContext GAGLNNPOAHI, TCompileState FKFCNOEOCKJ, [In] FPKFBGDMAGD<byte> NCCCDGALAAK, FPKFBGDMAGD<byte> NBMMMLDGEBC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DFGAMCJDKKA, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KDMNIHANEDO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GAPPBDGHJNK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NBALHBFKNPK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HEMMPELHBGL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GCHHLJJIMDC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LCMEHBLJBAE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GKNKFFDPAMM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? ILPEKIFMAAD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MLOJGFENJCJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NEAEECCFNGK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LGDOKCDJMFK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BKOFAFPMAGG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JLGJMPFLGKJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LCOLHEMLIHH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HAAFGGDDPBC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? ADCDAONBKIB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CJCJNCPLLIB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KAGHJHJOOPF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LGEALCOMGIO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EIBMIJGOGKE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NLCDJENAHLC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DGAFMEIKDMB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PJHMEBKEDAE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AIMCJKDKGKH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IOPOCHNHAFO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CGANGIGLHMM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AMNBNMHMFDF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CCLJJHDFPEH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MFCDLJDILIL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EDAGAELHOPD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BEHOOAJFMBD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CDBBPCHCHLF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CJPLEJJGDAO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GCAPIILLEKO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JGFEDEGILAH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EGKNPHLMMGL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LAOPNGPEEKE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DIPIIOHNJKA, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EDOBMIFOIIE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GKKDFMLEOML, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DPMNELFFODF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IHOKIMLHIOK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FMPKEPHLPCB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IMHGJOLCDGI, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IIOMEKGBGIK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CLIANKDEBJK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FOCNDMLGEEK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PMKMDECLODM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DPGJLKJEPIC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BLFEACLJOEB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KPCFCLOIJME, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IBEDFCKHDAJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KGBFKIEEMNE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GKEHBDIMMFB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MKFAGPPPEPK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IEIPGKCCHCG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LOAFKBFMDFM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DLEPHADEIAO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AGIAAGMAENF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EPMBEBMLFGJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? OPFPBGJMKCK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? APCDIOEGBLF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FFIEEFCDGMD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FIDBEOGHOEI, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KCICLLDIFAN, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GMNMBCJLCCJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BLIKPPCBGPP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GKBHMKBCGDK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FOJEKGDGDIM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AGHPLKFMBFB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JCFFFGOKFAE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IMIBFBHIMJE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BAKIJPDJFEM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NHEHGOFICEP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DIOCLGDFBIB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MGGIEFGJNDL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MPFHOINIPIJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HGDJNBONPDL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AIDNKOANNHP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EKFADDKKCGK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LCFNNKNOGND, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GHLCMFLONML, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EFGDCLHKPBN, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CKPKCPKICMD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NCBFFHBCIGI, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JJIMNLDMPGN, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PFMLGONJLEP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HKKFGGHPHOI, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JMOHDGLJMJF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IEOCBNPOLDE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DAFEFHEDIOE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MCKCBMPJMKD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? MLAOCBJIBGG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LJJPJJBDEJE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EMHMMIKHKPE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GKFBCKMIANK, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NOGENFDIACD, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AIDPPFOEHAF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FLDJMADCNFF, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GAICDEPKJGG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HIOBIPNKAII, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GEPPCNFANKE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IELBGJGFOJM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BNKJMGJGAEP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NIIGKPOADOG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CNEEPKMICGE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NJFEBHNAOCE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LBNLCHCIHAB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? FDAFACPCCLI, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? AJBMPNOAGID, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BDJBFINAOLC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? ECOGJIHDJEE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? CJBEODNAIAE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BLBJENDCHAH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? ECPLILEBJKA, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LBNGNAHCHPH, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GONFHLINCFG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DMODOPIAMLM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BLFEAILBELG, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PBHCHNKOECN, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PDHODFJEEKC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? PCACAOPNGBE, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? KPKNMLCMMOM, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? LBICGCMJLAB, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NABGAFFCIMJ, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? HMCOCNGKNND, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? GLMEIBNJMBP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? DEMMFHIMNDC, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JMAGNLBLHAO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? EOHPGBCJKCL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? BMFHDFIIDOP, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? IKJHBKJKLDO, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? NNEPJFBHJHL, [Optional] MIOFEPPLFBA<TContext, TDeps, TCompileState>? JNBODAIOGHD) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25B8090", Offset = "0x25B7490", VA = "0x1825B8090")]
	private static int PPFLABOLDIH([In] FPKFBGDMAGD<byte> HHINCEGHBKK, FPKFBGDMAGD<byte> LKAFJIABCIL, int BGLOMHIAAIH, int LOHPPDCIAAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NINJCENIADK
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int FJLNCMCPBPB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3626F30", Offset = "0x3626330", VA = "0x183626F30")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<T>> LHHKJIMDNHH<T>([In] this FPKFBGDMAGD<byte> IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3626E60", Offset = "0x3626260", VA = "0x183626E60")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<T>>> BNCLOGCCEKH<T>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<T>>? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x25B86E0", Offset = "0x25B7AE0", VA = "0x1825B86E0")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<OCOFJJGLOAJ>> LANJCIGAOMM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<OCOFJJGLOAJ>? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<OCOFJJGLOAJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25B8160", Offset = "0x25B7560", VA = "0x1825B8160")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>> APKJLFBNBID(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] float? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25B8250", Offset = "0x25B7650", VA = "0x1825B8250")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>> EHGIDGLFKGL(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x25B8430", Offset = "0x25B7830", VA = "0x1825B8430")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>> FDPBOGJCLII(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<ELHHKLOAKFK>? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25B8330", Offset = "0x25B7730", VA = "0x1825B8330")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<PHGMLKJCFNH>> EINODOEEIMG(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] byte? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<PHGMLKJCFNH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25B8600", Offset = "0x25B7A00", VA = "0x1825B8600")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JIDAEHPGGPO>> JCKLLOJHDKK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<JIDAEHPGGPO>? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JIDAEHPGGPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x25B8510", Offset = "0x25B7910", VA = "0x1825B8510")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> GBDDPAPFMML(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] ADOJCKECBOJ? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3626F90", Offset = "0x3626390", VA = "0x183626F90")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<T>>> NMMPBJFOAKP<T>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<T>>? PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x25B2260", Offset = "0x25B1660", VA = "0x1825B2260")]
	public static void GOHPJBNKDED(this FPKFBGDMAGD<byte> IIICNLIAPBJ, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>> MLINAAECALP, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3626F20", Offset = "0x3626320", VA = "0x183626F20")]
	public static void CELADENFDCB<T>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<T>>> LDBPBJLJEDK, DDIPAIMAGGM<JGEBJEKIHIN<T>> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3626F20", Offset = "0x3626320", VA = "0x183626F20")]
	public static void JKDOJMJMPDF<T>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<T>>> IJEGNJDDOMG, DDIPAIMAGGM<BLMNBLBFGJK<T>> PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BKGFPBMPAHN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25B2340", Offset = "0x25B1740", VA = "0x1825B2340")]
	public static LMMLKBHKBDN CLDDEHEGIGJ([In] this ReadOnlySpan<byte> KPLABGDDBEL, int LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25B22A0", Offset = "0x25B16A0", VA = "0x1825B22A0")]
	public static LMMLKBHKBDN CLDDEHEGIGJ([In] this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3210380", Offset = "0x320F780", VA = "0x183210380")]
	public static LMMLKBHKBDN CLDDEHEGIGJ<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3210220", Offset = "0x320F620", VA = "0x183210220")]
	public static LMMLKBHKBDN CLDDEHEGIGJ<M>([In] this EDHLJOJPPJL<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3210600", Offset = "0x320FA00", VA = "0x183210600")]
	public static LMMLKBHKBDN CLDDEHEGIGJ<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3210590", Offset = "0x320F990", VA = "0x183210590")]
	public static LMMLKBHKBDN CLDDEHEGIGJ<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32104D0", Offset = "0x320F8D0", VA = "0x1832104D0")]
	public static LMMLKBHKBDN CLDDEHEGIGJ<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25B2340", Offset = "0x25B1740", VA = "0x1825B2340")]
	public static int NAKGIMMLIBN([In] this ReadOnlySpan<byte> KPLABGDDBEL, int LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25B2190", Offset = "0x25B1590", VA = "0x1825B2190")]
	public static int NAKGIMMLIBN([In] this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320FE50", VA = "0x183210A50")]
	public static int NAKGIMMLIBN<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320FE50", VA = "0x183210A50")]
	public static int NAKGIMMLIBN<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320FE50", VA = "0x183210A50")]
	public static int NAKGIMMLIBN<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320FE50", VA = "0x183210A50")]
	public static int NAKGIMMLIBN<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3210A10", Offset = "0x320FE10", VA = "0x183210A10")]
	public static float MGHGGFFAMNH<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3210A10", Offset = "0x320FE10", VA = "0x183210A10")]
	public static float MGHGGFFAMNH<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3210A10", Offset = "0x320FE10", VA = "0x183210A10")]
	public static float MGHGGFFAMNH<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3210660", Offset = "0x320FA60", VA = "0x183210660")]
	public static byte HBPJAPEBAFF<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3210750", Offset = "0x320FB50", VA = "0x183210750")]
	public static byte HBPJAPEBAFF<M>([In] this EDHLJOJPPJL<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3210600", Offset = "0x320FA00", VA = "0x183210600")]
	public static byte HBPJAPEBAFF<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3210590", Offset = "0x320F990", VA = "0x183210590")]
	public static byte HBPJAPEBAFF<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3210690", Offset = "0x320FA90", VA = "0x183210690")]
	public static byte HBPJAPEBAFF<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25B2190", Offset = "0x25B1590", VA = "0x1825B2190")]
	public static ADOJCKECBOJ PJGKANCMEJM([In] this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN)
	{
		return default(ADOJCKECBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3210A50", Offset = "0x320FE50", VA = "0x183210A50")]
	public static ADOJCKECBOJ PJGKANCMEJM<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(ADOJCKECBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3210770", Offset = "0x320FB70", VA = "0x183210770")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> JELAAFJMNOE<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3210850", Offset = "0x320FC50", VA = "0x183210850")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> JELAAFJMNOE<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32107E0", Offset = "0x320FBE0", VA = "0x1832107E0")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> JELAAFJMNOE<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3210140", Offset = "0x320F540", VA = "0x183210140")]
	public static DDIPAIMAGGM<BLMNBLBFGJK<IAEDDOGNOPD>> BJGMJNHPKNF<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<BLMNBLBFGJK<IAEDDOGNOPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32108C0", Offset = "0x320FCC0", VA = "0x1832108C0")]
	public static DDIPAIMAGGM<JIDAEHPGGPO> JEPJDPIOPAF<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JIDAEHPGGPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32109A0", Offset = "0x320FDA0", VA = "0x1832109A0")]
	public static DDIPAIMAGGM<JIDAEHPGGPO> JEPJDPIOPAF<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JIDAEHPGGPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3210930", Offset = "0x320FD30", VA = "0x183210930")]
	public static DDIPAIMAGGM<JIDAEHPGGPO> JEPJDPIOPAF<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<JIDAEHPGGPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3210AF0", Offset = "0x320FEF0", VA = "0x183210AF0")]
	public static DDIPAIMAGGM<OCOFJJGLOAJ> ONKGGJCDDOD<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<OCOFJJGLOAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3210A80", Offset = "0x320FE80", VA = "0x183210A80")]
	public static DDIPAIMAGGM<OCOFJJGLOAJ> ONKGGJCDDOD<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<OCOFJJGLOAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32101B0", Offset = "0x320F5B0", VA = "0x1832101B0")]
	public static DDIPAIMAGGM<ELHHKLOAKFK> CBFJLENMODC<M>(this IHDDGPKENBI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN)
	{
		return default(DDIPAIMAGGM<ELHHKLOAKFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CHKAPGIBJOF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25B23B0", Offset = "0x25B17B0", VA = "0x1825B23B0")]
	public static void DPANIINPNGK(this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN, LMMLKBHKBDN PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25B2470", Offset = "0x25B1870", VA = "0x1825B2470")]
	public static void DPANIINPNGK(this byte[] KPLABGDDBEL, int LABPDJANKHN, LMMLKBHKBDN PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25B24E0", Offset = "0x25B18E0", VA = "0x1825B24E0")]
	public static void DPANIINPNGK([In] this Span<byte> KPLABGDDBEL, int LABPDJANKHN, LMMLKBHKBDN PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3275250", Offset = "0x3274650", VA = "0x183275250")]
	public static void DPANIINPNGK<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, LMMLKBHKBDN PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32753F0", Offset = "0x32747F0", VA = "0x1832753F0")]
	public static void DPANIINPNGK<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, LMMLKBHKBDN PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25B2260", Offset = "0x25B1660", VA = "0x1825B2260")]
	public static void GOHPJBNKDED(this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25B2620", Offset = "0x25B1A20", VA = "0x1825B2620")]
	public static void GOHPJBNKDED(this byte[] KPLABGDDBEL, int LABPDJANKHN, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25B25A0", Offset = "0x25B19A0", VA = "0x1825B25A0")]
	public static void GOHPJBNKDED([In] this Span<byte> KPLABGDDBEL, int LABPDJANKHN, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32756B0", Offset = "0x3274AB0", VA = "0x1832756B0")]
	public static void GOHPJBNKDED<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3275650", Offset = "0x3274A50", VA = "0x183275650")]
	public static void GOHPJBNKDED<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25B2560", Offset = "0x25B1960", VA = "0x1825B2560")]
	public static void GHFBKLJKGCB(this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN, float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32755F0", Offset = "0x32749F0", VA = "0x1832755F0")]
	public static void GHFBKLJKGCB<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3275590", Offset = "0x3274990", VA = "0x183275590")]
	public static void GHFBKLJKGCB<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25B26A0", Offset = "0x25B1AA0", VA = "0x1825B26A0")]
	public static void KNHGIGPMMLJ(this FPKFBGDMAGD<byte> KPLABGDDBEL, int LABPDJANKHN, byte PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3275760", Offset = "0x3274B60", VA = "0x183275760")]
	public static void KNHGIGPMMLJ<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, byte PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3275710", Offset = "0x3274B10", VA = "0x183275710")]
	public static void KNHGIGPMMLJ<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, byte PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3275220", Offset = "0x3274620", VA = "0x183275220")]
	public static void CELADENFDCB<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3275220", Offset = "0x3274620", VA = "0x183275220")]
	public static void CELADENFDCB<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3275220", Offset = "0x3274620", VA = "0x183275220")]
	public static void HLADIGDANDO<M>(this MANIMEFDFFM<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, DDIPAIMAGGM<JIDAEHPGGPO> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3275220", Offset = "0x3274620", VA = "0x183275220")]
	public static void HLADIGDANDO<M>([In] this OMFCPGIBIFI<M, byte> KPLABGDDBEL, DDIPAIMAGGM<M> LABPDJANKHN, DDIPAIMAGGM<JIDAEHPGGPO> PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ELLJGONFLPH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25B3120", Offset = "0x25B2520", VA = "0x1825B3120")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) CAIIJMBIOBH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25B2C00", Offset = "0x25B2000", VA = "0x1825B2C00")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) AHFMKMAMLCO(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25B4400", Offset = "0x25B3800", VA = "0x1825B4400")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) FEILLOEKLDM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25B5E30", Offset = "0x25B5230", VA = "0x1825B5E30")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) KBELGLNIIBA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25B6EF0", Offset = "0x25B62F0", VA = "0x1825B6EF0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) OHEHGIDOEEP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25B6600", Offset = "0x25B5A00", VA = "0x1825B6600")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) MMHOJDEGMNA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25B6340", Offset = "0x25B5740", VA = "0x1825B6340")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) MIPGBCMJEPL(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25B4E90", Offset = "0x25B4290", VA = "0x1825B4E90")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) IEBCCEOHEMA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25B3DA0", Offset = "0x25B31A0", VA = "0x1825B3DA0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) EJPELDBMFNC(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25B37B0", Offset = "0x25B2BB0", VA = "0x1825B37B0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>) DDAIIDGDLIK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? PEBNJNGMMHE, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? AKMGPHPOKIM)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25B77D0", Offset = "0x25B6BD0", VA = "0x1825B77D0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>) PGDFHJJPKBI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? PEBNJNGMMHE, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? AKMGPHPOKIM)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25B7410", Offset = "0x25B6810", VA = "0x1825B7410")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>) OOEBNKPEKFI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? PEBNJNGMMHE, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? AKMGPHPOKIM)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25B6840", Offset = "0x25B5C40", VA = "0x1825B6840")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>) MPCPPHGENGH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? PEBNJNGMMHE, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? AKMGPHPOKIM)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25B5440", Offset = "0x25B4840", VA = "0x1825B5440")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<OCOFJJGLOAJ>>) JFAAONDEKJH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? JFCJFIJAGAN, [Optional] DDIPAIMAGGM<OCOFJJGLOAJ>? JPHIIBFAEAA)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<OCOFJJGLOAJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25B4D80", Offset = "0x25B4180", VA = "0x1825B4D80")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<OCOFJJGLOAJ>>>) IAMBFEIEDEO(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? JFCJFIJAGAN, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<OCOFJJGLOAJ>>? JPHIIBFAEAA)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<OCOFJJGLOAJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25B4260", Offset = "0x25B3660", VA = "0x1825B4260")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JIDAEHPGGPO>>) FDINFLLDCKN(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? JFCJFIJAGAN, [Optional] DDIPAIMAGGM<JIDAEHPGGPO>? JPHIIBFAEAA)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<JIDAEHPGGPO>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25B5A00", Offset = "0x25B4E00", VA = "0x1825B5A00")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<JIDAEHPGGPO>>>) JLGDIAMLFFP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? JFCJFIJAGAN, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<JIDAEHPGGPO>>? JPHIIBFAEAA)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<JIDAEHPGGPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3312C90", Offset = "0x3312090", VA = "0x183312C90")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>) MOEFCGELAEP<TMarker>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<ELHHKLOAKFK>? JPHIIBFAEAA, [Optional][In] ReadOnlySpan<byte> MJFOKKFMONL)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25B4130", Offset = "0x25B3530", VA = "0x1825B4130")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) ENNONOEDDFE(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int HHINCEGHBKK, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? LKAFJIABCIL)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25B7A50", Offset = "0x25B6E50", VA = "0x1825B7A50")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PLDMEMKOHJN(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? HHINCEGHBKK, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? LKAFJIABCIL)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3312AA0", Offset = "0x3311EA0", VA = "0x183312AA0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>) HCODPCAEGAJ<TMarker>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<TMarker>>? LKAFJIABCIL, [Optional] int? NBPEDBIONNC, [Optional][In] ReadOnlySpan<byte> HHINCEGHBKK)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3312950", Offset = "0x3311D50", VA = "0x183312950")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>) CAMGPNLEHGD<TMarker>(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<TMarker>>? HHINCEGHBKK, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<TMarker>>? LKAFJIABCIL, [Optional] int? NBPEDBIONNC)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<TMarker>>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25B5160", Offset = "0x25B4560", VA = "0x1825B5160")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) IIADAOENIKM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25B3FE0", Offset = "0x25B33E0", VA = "0x1825B3FE0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) EMNFJIALPLP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25B2710", Offset = "0x25B1B10", VA = "0x1825B2710")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) AAKJFJMKNKG(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25B7F30", Offset = "0x25B7330", VA = "0x1825B7F30")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PPAALAOOEJA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25B2FD0", Offset = "0x25B23D0", VA = "0x1825B2FD0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) BHNCJMAGAFL(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25B5F90", Offset = "0x25B5390", VA = "0x1825B5F90")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) KGMICFAPDKM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25B7B60", Offset = "0x25B6F60", VA = "0x1825B7B60")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PLKGGANOBIO(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25B5CE0", Offset = "0x25B50E0", VA = "0x1825B5CE0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) KAIPHPGHECK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25B2AE0", Offset = "0x25B1EE0", VA = "0x1825B2AE0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) AHANJGADAMH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25B47B0", Offset = "0x25B3BB0", VA = "0x1825B47B0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>) GPDPCAINLHM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? AHCGIAFJHGD)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25B6960", Offset = "0x25B5D60", VA = "0x1825B6960")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) NBAOHNCNKJF(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x25B2E70", Offset = "0x25B2270", VA = "0x1825B2E70")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) BHBGINKKJHC(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25B60B0", Offset = "0x25B54B0", VA = "0x1825B60B0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) LFJLOJCFDAD(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25B2830", Offset = "0x25B1C30", VA = "0x1825B2830")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) AEMFBKEJDBD(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25B72C0", Offset = "0x25B66C0", VA = "0x1825B72C0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) ONHGLEDBMIO(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25B2D50", Offset = "0x25B2150", VA = "0x1825B2D50")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) BGLAIKLDHDK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25B5730", Offset = "0x25B4B30", VA = "0x1825B5730")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) JJHAPEMJACI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25B6D90", Offset = "0x25B6190", VA = "0x1825B6D90")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) NOHEIBMACCF(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25B4680", Offset = "0x25B3A80", VA = "0x1825B4680")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) FOFNIOGNMAJ(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25B32A0", Offset = "0x25B26A0", VA = "0x1825B32A0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) CFLDNLJNOGP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x25B58B0", Offset = "0x25B4CB0", VA = "0x1825B58B0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) JKJHODFNDIA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25B4C60", Offset = "0x25B4060", VA = "0x1825B4C60")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) IAIKKFEEIEP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x25B7520", Offset = "0x25B6920", VA = "0x1825B7520")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) OPCKAIDEOMI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25B7040", Offset = "0x25B6440", VA = "0x1825B7040")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) OIDKOCGOOFN(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25B76A0", Offset = "0x25B6AA0", VA = "0x1825B76A0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PDBMPJAEBDH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25B64A0", Offset = "0x25B58A0", VA = "0x1825B64A0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) MJHEFAOHLOD(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x25B39E0", Offset = "0x25B2DE0", VA = "0x1825B39E0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) DJCPOHNHGLI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25B3C80", Offset = "0x25B3080", VA = "0x1825B3C80")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) ECLIOPIKNPE(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B4FE0", Offset = "0x25B43E0", VA = "0x1825B4FE0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) IHKKPHJONOG(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x25B78F0", Offset = "0x25B6CF0", VA = "0x1825B78F0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PJKKBMCFBMA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x25B4B30", Offset = "0x25B3F30", VA = "0x1825B4B30")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) IAEADLKDHMC(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25B61E0", Offset = "0x25B55E0", VA = "0x1825B61E0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) MEFNNFINHOP(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25B7CC0", Offset = "0x25B70C0", VA = "0x1825B7CC0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) PMKHJOHNNJK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25B6720", Offset = "0x25B5B20", VA = "0x1825B6720")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) MMONCDADIDA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25B48A0", Offset = "0x25B3CA0", VA = "0x1825B48A0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) HHJCIEAJNIL(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x25B2990", Offset = "0x25B1D90", VA = "0x1825B2990")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) AFEDIBDAFOJ(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x25B3EC0", Offset = "0x25B32C0", VA = "0x1825B3EC0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) ELOKJOFLJNA(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25B6AE0", Offset = "0x25B5EE0", VA = "0x1825B6AE0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) NFPBKFGAOOG(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25B3B30", Offset = "0x25B2F30", VA = "0x1825B3B30")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) ECGJNHGGCCC(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x25B38C0", Offset = "0x25B2CC0", VA = "0x1825B38C0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) DFPFCLFFJGL(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25B3580", Offset = "0x25B2980", VA = "0x1825B3580")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) CLOAAELIMMJ(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] int? BMPKIADMCIK, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25B4A20", Offset = "0x25B3E20", VA = "0x1825B4A20")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) HKAPNLFGIIJ(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BMPKIADMCIK, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x25B5C60", Offset = "0x25B5060", VA = "0x1825B5C60")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> JNCGAAKJODO(this FPKFBGDMAGD<byte> IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x25B3400", Offset = "0x25B2800", VA = "0x1825B3400")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) CHJNNMIMDGJ(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25B5B10", Offset = "0x25B4F10", VA = "0x1825B5B10")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) JMJGIDPLBJC(this FPKFBGDMAGD<byte> IIICNLIAPBJ, float DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<NKNDODPDENI>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x25B3690", Offset = "0x25B2A90", VA = "0x1825B3690")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>) DCAMFDHKGDH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<NKNDODPDENI>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<NKNDODPDENI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x25B52E0", Offset = "0x25B46E0", VA = "0x1825B52E0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) JAOFAAKNLNK(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x25B55E0", Offset = "0x25B49E0", VA = "0x1825B55E0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) JGLFPPFKEJH(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x25B71A0", Offset = "0x25B65A0", VA = "0x1825B71A0")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) OKGGGBHHOFN(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25B4520", Offset = "0x25B3920", VA = "0x1825B4520")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) FMNBPDCEKAI(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x25B6C40", Offset = "0x25B6040", VA = "0x1825B6C40")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) NMHNMNLPBFM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, int DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25B7E10", Offset = "0x25B7210", VA = "0x1825B7E10")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>) POOEECIHCPM(this FPKFBGDMAGD<byte> IIICNLIAPBJ, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? DLGPHICDAGP, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? IMFBFGLLCGO, [Optional] DDIPAIMAGGM<BLMNBLBFGJK<PPJMDEDELHN>>? BEHFCENGGJI)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<PPJMDEDELHN>>>));
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
