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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2221250", Offset = "0x2220650", VA = "0x182221250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JJOJPGOOINN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4140", Offset = "0x2CA3540", VA = "0x182CA4140")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<M>> NGGBLGDCLBE<M>(this int MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2220B80", Offset = "0x221FF80", VA = "0x182220B80")]
	public static MIEEFIOIIBN<DILABIFDKAP> BOHGKIMKGJE(this int MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<DILABIFDKAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4140", Offset = "0x2CA3540", VA = "0x182CA4140")]
	public static MIEEFIOIIBN<CMBJJMFFHEG<M>> EGLIEEFNDNA<M>(this int MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<CMBJJMFFHEG<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FLIDLELCAJJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KBFOMKLFLIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GKANNGPKLLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DILABIFDKAP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LOIEPIHKKBL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DAENPLDLENC
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum LIELBHJDJPK
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
public static class OMIOHANLDKN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MKLDBDONFEK<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr BAIKAGNNDHE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
		public MKLDBDONFEK(IntPtr JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4806310", Offset = "0x4805710", VA = "0x184806310")]
		public int NCEDFJEFMFN(TDeps CLOGBAKPPIL, TContext GMBKOAJKCLF, TCompileState HOEAJCDADPH, [In] OCJDOODMLMI<byte> EGAGMJPDKCA, int OEEKMEPGGIJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30030C0", Offset = "0x30024C0", VA = "0x1830030C0")]
	public static void JNAIGGENJEL<TDeps, TContext, TCompileState>(TDeps CLOGBAKPPIL, TContext GMBKOAJKCLF, TCompileState HOEAJCDADPH, [In] OCJDOODMLMI<byte> KIBNGLDFMGP, OCJDOODMLMI<byte> FIGKFHBIBDO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? ABEBKDDBFIG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AMINOKPJNPM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BDEDENOBLCN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MKIELHHNMFL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BEOLFNNJIHP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EBKFGKLKAOL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FKHIACAOEPA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JLLDENPDFMM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GOFCEFENLEH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LPPNINNEGGJ, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FELMBLFIBHJ, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GAFCBGMCFPD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BOFNAFAFAOC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NOGMNPHHIKE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CAEFGJKCBMP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DNMPEIDAOLB, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KNKHFFOPCKA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IJAOIPFJJOM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JAAINOACGDA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BCMPILLHBNA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MLGEGCMEGNE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CHNLLBDAGBP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PABEAIMHEFN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OBOONCAJKPK, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EELJLCHKHKI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JDKOKDJLIDG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CLOHEHCMFNB, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IEEPFJNOIKK, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AOHNLPMCOKO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PNOBABFECFE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PDLKCDLMBPG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MPFFECIDFLP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CGNCHBIDPLD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DEMEKMNOBPC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BPKJKNKMGCB, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CCBOPMCBOLC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AOBKBOBJGED, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JEDAMNAMNKH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IMGONDEBHIN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? HONJKBOIGFD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LBODNJPCAAG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OCPAOLMKPDD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KGJMHOGJDBM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MEFHKFAAEAI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MMAAFMFFHKC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JMLHPMPEEGC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AEFDAFEIHFA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KKLJLAFLNEL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LGGCMGCGHCK, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JMICKKDFAFA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LOKJFHGJJJE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FDJBLELLMCC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FLJODLMBIPM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? ENMGDLDDLDA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CFBGDFMFMHO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EFFFCGMPAKO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FCPBDOMJDOI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FLLOMLNIDPN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CFFMIHMMFID, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EJPANHMPHEE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AKCALMMEDPO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? HIHHOHOOELD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CGIAHHPPEKH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IFIGFMBICHN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IIMEIAJLEMJ, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NEAIDLDJPNO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OFAGGMFGJEF, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? HBINNHEPPDE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BCFAKKDOEMO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KCGALIFCNMO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NDKGFMMJFCO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CDMDIKEEFGH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DADBIMPIGGM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JEBGOEFHEAG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OIPNKIPANLE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MJFFKHJGECI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DPDFEIHFAPE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BGIPGANBHKO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OMKKNNAJDEP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JNIDOKKIMIP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DAKDMKEDLPL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DMDKMJLIAFF, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MEFBCIODAAO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NDJLDDLLEGL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LCBBJIEACLM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MCJKDBEONDD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? BJFBGJMJIMM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? APMABBLOBGN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DJNAJCPOACN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GPKAICLMFNI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KLIJOOFKCII, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? HPABFHCMMGG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AMJLFEHGBCA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AFMKCGMGIJE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EIPJEKOCCMH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? HDBJLEOMMDP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JFCPLIKNCAM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DILNGHKBGAP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EJHLNPOKAFJ, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KICOCIJLDNG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OAKMPOCMONN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PCFGPNHDEGO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AOGJOGEMADE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FPMMFPONCNI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? MFNABEABEEC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GIMNANPNOBI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? DALFEANLAMA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CLMNHNCJMEK, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KOHBADHOCCP, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FBOPKGOICOC, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LGIADGJELFH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FEKFIBKAFFN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PEHPJJKPPDB, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NPFFHFHGNIL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? EMANAILDABN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? ODPNPLALIDE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GDDOFJBKPPA, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CNEJEDJIONE, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IHMCDDMMBKD, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? LJLALCJIGKN, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NNPMIBJKNAO, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? JKNJEGCJBEL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CIOOKDHJKHM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NJBPLLHDFBB, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IILDOCJIAOI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? ADHPCELNODM, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? KKPCPADGNLH, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? CJOBGFHNFBI, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? GJDHAJINAGF, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? IJGAOALOJPF, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? FGIMBFDMOAK, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? AEOLBDCIBLL, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? OOCPPEPEGDG, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? NMEEOLHOCML, [Optional] MKLDBDONFEK<TContext, TDeps, TCompileState>? PLFFBLKCLPJ) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22212D0", Offset = "0x22206D0", VA = "0x1822212D0")]
	private static int FOMHJLIBFJH([In] OCJDOODMLMI<byte> AEMACDNHKLC, OCJDOODMLMI<byte> KNKLOPPILKI, int IJLPKFECKFC, int HMELIAGANNM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MECJBPKMEJP
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int OMFJPFEILMC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F269A0", Offset = "0x2F25DA0", VA = "0x182F269A0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<T>> JDKMDPIBGNC<T>([In] this OCJDOODMLMI<byte> MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F268E0", Offset = "0x2F25CE0", VA = "0x182F268E0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<T>>> HKJHKLCHHDL<T>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<T>>? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2220F60", Offset = "0x2220360", VA = "0x182220F60")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<APDAHEMLLEN>> IBFGHDNKFIL(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<APDAHEMLLEN>? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<APDAHEMLLEN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2220BB0", Offset = "0x221FFB0", VA = "0x182220BB0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>> ALLDBPGBPFF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] float? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2220D80", Offset = "0x2220180", VA = "0x182220D80")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>> EFAJJBIPMMI(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2220CA0", Offset = "0x22200A0", VA = "0x182220CA0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>> BGHHJFPKPJK(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<AEMFFDNPCNP>? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2220E60", Offset = "0x2220260", VA = "0x182220E60")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<DAENPLDLENC>> FMICCHNJLKE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] byte? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<DAENPLDLENC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2221130", Offset = "0x2220530", VA = "0x182221130")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<DILABIFDKAP>> JKJMHLPMNGC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<DILABIFDKAP>? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<DILABIFDKAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2221040", Offset = "0x2220440", VA = "0x182221040")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> JEEDJJPGNPE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] LIELBHJDJPK? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F26A10", Offset = "0x2F25E10", VA = "0x182F26A10")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<T>>> PHAGPAPFHJD<T>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<T>>? EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x221AD50", Offset = "0x221A150", VA = "0x18221AD50")]
	public static void LMFJONPBHGA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>> OEICKOBBALL, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F26A00", Offset = "0x2F25E00", VA = "0x182F26A00")]
	public static void NDOOBJDKFJE<T>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<T>>> OEEKMEPGGIJ, MIEEFIOIIBN<FLIDLELCAJJ<T>> EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F26A00", Offset = "0x2F25E00", VA = "0x182F26A00")]
	public static void NNKOOLMOOFG<T>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<T>>> OIFBGFLFHCE, MIEEFIOIIBN<CMBJJMFFHEG<T>> EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CLPLKPGDGCL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x221AD90", Offset = "0x221A190", VA = "0x18221AD90")]
	public static GKIFKJFALJB NAJEMBBOBIH([In] this ReadOnlySpan<byte> FAHBHOHHIKE, int CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x221AE00", Offset = "0x221A200", VA = "0x18221AE00")]
	public static GKIFKJFALJB NAJEMBBOBIH([In] this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C65EF0", Offset = "0x2C652F0", VA = "0x182C65EF0")]
	public static GKIFKJFALJB NAJEMBBOBIH<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C66040", Offset = "0x2C65440", VA = "0x182C66040")]
	public static GKIFKJFALJB NAJEMBBOBIH<M>([In] this PBDKMDBPLBP<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C65D20", Offset = "0x2C65120", VA = "0x182C65D20")]
	public static GKIFKJFALJB NAJEMBBOBIH<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C65DA0", Offset = "0x2C651A0", VA = "0x182C65DA0")]
	public static GKIFKJFALJB NAJEMBBOBIH<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C661A0", Offset = "0x2C655A0", VA = "0x182C661A0")]
	public static GKIFKJFALJB NAJEMBBOBIH<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x221AD90", Offset = "0x221A190", VA = "0x18221AD90")]
	public static int OGCJGFLPLJB([In] this ReadOnlySpan<byte> FAHBHOHHIKE, int CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x221AC80", Offset = "0x221A080", VA = "0x18221AC80")]
	public static int OGCJGFLPLJB([In] this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static int OGCJGFLPLJB<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static int OGCJGFLPLJB<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static int OGCJGFLPLJB<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static int OGCJGFLPLJB<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C65870", Offset = "0x2C64C70", VA = "0x182C65870")]
	public static float BAJJKCHOLGI<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C65870", Offset = "0x2C64C70", VA = "0x182C65870")]
	public static float BAJJKCHOLGI<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C65870", Offset = "0x2C64C70", VA = "0x182C65870")]
	public static float BAJJKCHOLGI<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C65C30", Offset = "0x2C65030", VA = "0x182C65C30")]
	public static byte HCKJALLMDBG<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C65D80", Offset = "0x2C65180", VA = "0x182C65D80")]
	public static byte HCKJALLMDBG<M>([In] this PBDKMDBPLBP<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2C65D20", Offset = "0x2C65120", VA = "0x182C65D20")]
	public static byte HCKJALLMDBG<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C65DA0", Offset = "0x2C651A0", VA = "0x182C65DA0")]
	public static byte HCKJALLMDBG<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C65C60", Offset = "0x2C65060", VA = "0x182C65C60")]
	public static byte HCKJALLMDBG<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x221AC80", Offset = "0x221A080", VA = "0x18221AC80")]
	public static LIELBHJDJPK PPIPKCBAECM([In] this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ)
	{
		return default(LIELBHJDJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static LIELBHJDJPK PPIPKCBAECM<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(LIELBHJDJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C65BC0", Offset = "0x2C64FC0", VA = "0x182C65BC0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> GBMMBNEKKNC<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C65B50", Offset = "0x2C64F50", VA = "0x182C65B50")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> GBMMBNEKKNC<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C65AE0", Offset = "0x2C64EE0", VA = "0x182C65AE0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> GBMMBNEKKNC<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E80", Offset = "0x2C65280", VA = "0x182C65E80")]
	public static MIEEFIOIIBN<CMBJJMFFHEG<LCMAICEDDBI>> LNPNPLJDBFB<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<CMBJJMFFHEG<LCMAICEDDBI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C65990", Offset = "0x2C64D90", VA = "0x182C65990")]
	public static MIEEFIOIIBN<DILABIFDKAP> CONPGNKBPOK<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<DILABIFDKAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C65A00", Offset = "0x2C64E00", VA = "0x182C65A00")]
	public static MIEEFIOIIBN<DILABIFDKAP> CONPGNKBPOK<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<DILABIFDKAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C65A70", Offset = "0x2C64E70", VA = "0x182C65A70")]
	public static MIEEFIOIIBN<DILABIFDKAP> CONPGNKBPOK<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<DILABIFDKAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C658B0", Offset = "0x2C64CB0", VA = "0x182C658B0")]
	public static MIEEFIOIIBN<APDAHEMLLEN> BPKABMJKOFJ<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<APDAHEMLLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C65920", Offset = "0x2C64D20", VA = "0x182C65920")]
	public static MIEEFIOIIBN<APDAHEMLLEN> BPKABMJKOFJ<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<APDAHEMLLEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E10", Offset = "0x2C65210", VA = "0x182C65E10")]
	public static MIEEFIOIIBN<AEMFFDNPCNP> LGLBAAHLFLF<M>(this JEMAAAJFJBC<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ)
	{
		return default(MIEEFIOIIBN<AEMFFDNPCNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FJMGEGCKGPO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x221AEE0", Offset = "0x221A2E0", VA = "0x18221AEE0")]
	public static void EINGBJOBLNM(this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, GKIFKJFALJB EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x221B020", Offset = "0x221A420", VA = "0x18221B020")]
	public static void EINGBJOBLNM(this byte[] FAHBHOHHIKE, int CJGJMOGBHAJ, GKIFKJFALJB EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x221AFA0", Offset = "0x221A3A0", VA = "0x18221AFA0")]
	public static void EINGBJOBLNM([In] this Span<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, GKIFKJFALJB EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A320", Offset = "0x2E49720", VA = "0x182E4A320")]
	public static void EINGBJOBLNM<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, GKIFKJFALJB EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A4C0", Offset = "0x2E498C0", VA = "0x182E4A4C0")]
	public static void EINGBJOBLNM<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, GKIFKJFALJB EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x221AD50", Offset = "0x221A150", VA = "0x18221AD50")]
	public static void LMFJONPBHGA(this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x221B100", Offset = "0x221A500", VA = "0x18221B100")]
	public static void LMFJONPBHGA(this byte[] FAHBHOHHIKE, int CJGJMOGBHAJ, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x221B180", Offset = "0x221A580", VA = "0x18221B180")]
	public static void LMFJONPBHGA([In] this Span<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A760", Offset = "0x2E49B60", VA = "0x182E4A760")]
	public static void LMFJONPBHGA<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A700", Offset = "0x2E49B00", VA = "0x182E4A700")]
	public static void LMFJONPBHGA<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x221AEA0", Offset = "0x221A2A0", VA = "0x18221AEA0")]
	public static void ECPNDNDAGAA(this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A2C0", Offset = "0x2E496C0", VA = "0x182E4A2C0")]
	public static void ECPNDNDAGAA<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A260", Offset = "0x2E49660", VA = "0x182E4A260")]
	public static void ECPNDNDAGAA<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x221B090", Offset = "0x221A490", VA = "0x18221B090")]
	public static void GLNHOLMBIJK(this OCJDOODMLMI<byte> FAHBHOHHIKE, int CJGJMOGBHAJ, byte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A660", Offset = "0x2E49A60", VA = "0x182E4A660")]
	public static void GLNHOLMBIJK<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, byte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A6B0", Offset = "0x2E49AB0", VA = "0x182E4A6B0")]
	public static void GLNHOLMBIJK<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, byte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A230", Offset = "0x2E49630", VA = "0x182E4A230")]
	public static void NDOOBJDKFJE<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A230", Offset = "0x2E49630", VA = "0x182E4A230")]
	public static void NDOOBJDKFJE<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A230", Offset = "0x2E49630", VA = "0x182E4A230")]
	public static void BOGDHBNFNAN<M>(this LMPCPDJAHLE<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, MIEEFIOIIBN<DILABIFDKAP> EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A230", Offset = "0x2E49630", VA = "0x182E4A230")]
	public static void BOGDHBNFNAN<M>([In] this IHIIGPMDDIH<M, byte> FAHBHOHHIKE, MIEEFIOIIBN<M> CJGJMOGBHAJ, MIEEFIOIIBN<DILABIFDKAP> EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IKFELAGJECH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2220340", Offset = "0x221F740", VA = "0x182220340")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) NNHJKDAHIPF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x221B620", Offset = "0x221AA20", VA = "0x18221B620")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) BABDGEDCOGB(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2220620", Offset = "0x221FA20", VA = "0x182220620")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) OINPIBBEFBE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x221C820", Offset = "0x221BC20", VA = "0x18221C820")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) DKNIAEFFCAJ(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x221C6D0", Offset = "0x221BAD0", VA = "0x18221C6D0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) DKCGONMHKCN(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x221EB40", Offset = "0x221DF40", VA = "0x18221EB40")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KBHPGGFDDAK(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x221D4F0", Offset = "0x221C8F0", VA = "0x18221D4F0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) GCFNEEIHDNF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x221B380", Offset = "0x221A780", VA = "0x18221B380")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) AONEDCLMLJM(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x221DDD0", Offset = "0x221D1D0", VA = "0x18221DDD0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) HCCDKJCOHMH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x221FCA0", Offset = "0x221F0A0", VA = "0x18221FCA0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>) MDBMKGNELLJ(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? EEPLCHCGAIN, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? NAGJFMCMHKD)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x221BA40", Offset = "0x221AE40", VA = "0x18221BA40")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>) BNHIENMOAID(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? EEPLCHCGAIN, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? NAGJFMCMHKD)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x221E660", Offset = "0x221DA60", VA = "0x18221E660")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>) JFOCHMMHMLP(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? EEPLCHCGAIN, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? NAGJFMCMHKD)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x221D3D0", Offset = "0x221C7D0", VA = "0x18221D3D0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>) FPNKKCMAKFE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? EEPLCHCGAIN, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? NAGJFMCMHKD)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x221FFC0", Offset = "0x221F3C0", VA = "0x18221FFC0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<APDAHEMLLEN>>) MKGGHNJCKKC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? LDHLMIFLONJ, [Optional] MIEEFIOIIBN<APDAHEMLLEN>? KNNCNNMDAMC)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<APDAHEMLLEN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x221C4A0", Offset = "0x221B8A0", VA = "0x18221C4A0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<APDAHEMLLEN>>>) DAOPHIEKPLH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? LDHLMIFLONJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<APDAHEMLLEN>>? KNNCNNMDAMC)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<APDAHEMLLEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x221C1E0", Offset = "0x221B5E0", VA = "0x18221C1E0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<DILABIFDKAP>>) CLBCHIBMEEO(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? LDHLMIFLONJ, [Optional] MIEEFIOIIBN<DILABIFDKAP>? KNNCNNMDAMC)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<DILABIFDKAP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x221CB00", Offset = "0x221BF00", VA = "0x18221CB00")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<DILABIFDKAP>>>) DOOPMOKCNKO(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? LDHLMIFLONJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<DILABIFDKAP>>? KNNCNNMDAMC)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<DILABIFDKAP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E96810", Offset = "0x2E95C10", VA = "0x182E96810")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>) BDFOAOEBKIA<TMarker>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<AEMFFDNPCNP>? KNNCNNMDAMC, [Optional][In] ReadOnlySpan<byte> AIKOCCMKKAE)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x221CE90", Offset = "0x221C290", VA = "0x18221CE90")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) EEKPGGLPINE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int AEMACDNHKLC, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? KNKLOPPILKI)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x221F180", Offset = "0x221E580", VA = "0x18221F180")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KKJKBJJIKMA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? AEMACDNHKLC, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? KNKLOPPILKI)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E96B60", Offset = "0x2E95F60", VA = "0x182E96B60")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>) LEMAMLJAMKM<TMarker>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<TMarker>>? KNKLOPPILKI, [Optional] int? IKJKAFPPDBP, [Optional][In] ReadOnlySpan<byte> AEMACDNHKLC)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E96A10", Offset = "0x2E95E10", VA = "0x182E96A10")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>) DCPAFFBPDNN<TMarker>(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<TMarker>>? AEMACDNHKLC, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<TMarker>>? KNKLOPPILKI, [Optional] int? IKJKAFPPDBP)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<TMarker>>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x221C980", Offset = "0x221BD80", VA = "0x18221C980")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) DOLJJLCIAMB(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x221BF60", Offset = "0x221B360", VA = "0x18221BF60")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) CIGJHIBJPHG(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x221F290", Offset = "0x221E690", VA = "0x18221F290")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) KKPEBCADLGC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2220160", Offset = "0x221F560", VA = "0x182220160")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) MLGNFIIOJKE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x221BB60", Offset = "0x221AF60", VA = "0x18221BB60")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) BOIOEIPAHKD(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x221CD70", Offset = "0x221C170", VA = "0x18221CD70")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) EDOHEFKKMDA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x221F8E0", Offset = "0x221ECE0", VA = "0x18221F8E0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) LIMHOBONDEG(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x221E160", Offset = "0x221D560", VA = "0x18221E160")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) IMENJLEGMOJ(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x221FDB0", Offset = "0x221F1B0", VA = "0x18221FDB0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) MDIBEJCOFKD(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x221FED0", Offset = "0x221F2D0", VA = "0x18221FED0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>) MGFMIGEHNLA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? CKNFKEAEMGM)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x221CFC0", Offset = "0x221C3C0", VA = "0x18221CFC0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) EJCCBAAOBAF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x221D140", Offset = "0x221C540", VA = "0x18221D140")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) FANKHOLPFAB(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x221E530", Offset = "0x221D930", VA = "0x18221E530")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) JEPGKNGNGKO(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x221F3B0", Offset = "0x221E7B0", VA = "0x18221F3B0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KNHKOGEFBIH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x221B4D0", Offset = "0x221A8D0", VA = "0x18221B4D0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) APAJHOJEIMA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x221E040", Offset = "0x221D440", VA = "0x18221E040")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) HMCFCPMDCML(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2220A00", Offset = "0x221FE00", VA = "0x182220A00")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) PIPPLIGPDEO(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x221E3D0", Offset = "0x221D7D0", VA = "0x18221E3D0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) JENEFFIJNKE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x221C0B0", Offset = "0x221B4B0", VA = "0x18221C0B0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) CJFCDMBAHHG(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x221EED0", Offset = "0x221E2D0", VA = "0x18221EED0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KGKMNDOHNGC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x221E770", Offset = "0x221DB70", VA = "0x18221E770")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) JGBBBLFCFIC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x221DCB0", Offset = "0x221D0B0", VA = "0x18221DCB0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) HBBDENBEENB(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x221B200", Offset = "0x221A600", VA = "0x18221B200")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) ANGDNKGBDNP(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x22208A0", Offset = "0x221FCA0", VA = "0x1822208A0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) PGCPNPKJLFJ(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x221BE30", Offset = "0x221B230", VA = "0x18221BE30")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) CGIJBJLCJEC(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x22204C0", Offset = "0x221F8C0", VA = "0x1822204C0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) OBCICPBODAH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x221FB50", Offset = "0x221EF50", VA = "0x18221FB50")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) MBBHHPNHDFI(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x221EDB0", Offset = "0x221E1B0", VA = "0x18221EDB0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KFMADPPKDOI(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x221DB30", Offset = "0x221CF30", VA = "0x18221DB30")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) GPMBDCNNHAF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2220740", Offset = "0x221FB40", VA = "0x182220740")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) OLIKMIEKIJF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x221D2A0", Offset = "0x221C6A0", VA = "0x18221D2A0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) FKEOFEHPDPF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x221D760", Offset = "0x221CB60", VA = "0x18221D760")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) GHHGJPBDOHM(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x221B8F0", Offset = "0x221ACF0", VA = "0x18221B8F0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) BJNGLCCHELE(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x221F7C0", Offset = "0x221EBC0", VA = "0x18221F7C0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) LGBANDMOINO(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x221BCB0", Offset = "0x221B0B0", VA = "0x18221BCB0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) CAAICFNAANL(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x221D8C0", Offset = "0x221CCC0", VA = "0x18221D8C0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) GLLGINFOBNA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x221E8C0", Offset = "0x221DCC0", VA = "0x18221E8C0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) JGEGPNCDIIG(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x221CC10", Offset = "0x221C010", VA = "0x18221CC10")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) EBKIFADFALI(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x221DEF0", Offset = "0x221D2F0", VA = "0x18221DEF0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) HCPLOJIHAAH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x221C5B0", Offset = "0x221B9B0", VA = "0x18221C5B0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) DFIMPGGMLCN(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x221FA40", Offset = "0x221EE40", VA = "0x18221FA40")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) LPGHOGNPCAF(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] int? ONHDJJDFOKI, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x221D650", Offset = "0x221CA50", VA = "0x18221D650")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) GFNCNKEKEHL(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? ONHDJJDFOKI, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x22202C0", Offset = "0x221F6C0", VA = "0x1822202C0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> NDGCAHDAMIK(this OCJDOODMLMI<byte> MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x221B770", Offset = "0x221AB70", VA = "0x18221B770")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) BHAKDAOPLAH(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x221F510", Offset = "0x221E910", VA = "0x18221F510")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) LAELBKNEMHD(this OCJDOODMLMI<byte> MCPMOAEEEOJ, float HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<KBFOMKLFLIH>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x221DA10", Offset = "0x221CE10", VA = "0x18221DA10")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>) GMLEGIKIANA(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<KBFOMKLFLIH>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<KBFOMKLFLIH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x221F660", Offset = "0x221EA60", VA = "0x18221F660")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) LBBGNBKDPEP(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x221F030", Offset = "0x221E430", VA = "0x18221F030")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KICOIDFANID(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x221E2B0", Offset = "0x221D6B0", VA = "0x18221E2B0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) IOHLIEKDPJD(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x221E9E0", Offset = "0x221DDE0", VA = "0x18221E9E0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) JNBLIDDIFJI(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x221EC60", Offset = "0x221E060", VA = "0x18221EC60")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) KCFGAAEOODJ(this OCJDOODMLMI<byte> MCPMOAEEEOJ, int HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x221C380", Offset = "0x221B780", VA = "0x18221C380")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>) CLCGBPLBIAM(this OCJDOODMLMI<byte> MCPMOAEEEOJ, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? HIPFNFECPMD, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? IFNNNCDKMOA, [Optional] MIEEFIOIIBN<CMBJJMFFHEG<GKANNGPKLLI>>? PLBMABGAFGA)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<GKANNGPKLLI>>>));
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
