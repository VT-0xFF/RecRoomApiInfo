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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0BAC0", Offset = "0x2A0A6C0", VA = "0x182A0BAC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FECOJBNPJPD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39BF2F0", Offset = "0x39BDEF0", VA = "0x1839BF2F0")]
	public static COMEADPNKEA<CCENJBIACBA<M>> PPDNBGBLOHC<M>(this int JBDFDFABHKD)
	{
		return default(COMEADPNKEA<CCENJBIACBA<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A055F0", Offset = "0x2A041F0", VA = "0x182A055F0")]
	public static COMEADPNKEA<FAJGAHEJLCP> CLOFGCAEPKJ(this int JBDFDFABHKD)
	{
		return default(COMEADPNKEA<FAJGAHEJLCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39BF2F0", Offset = "0x39BDEF0", VA = "0x1839BF2F0")]
	public static COMEADPNKEA<PLDBDINAHFP<M>> CHADOBJDDDB<M>(this int JBDFDFABHKD)
	{
		return default(COMEADPNKEA<PLDBDINAHFP<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CCENJBIACBA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FGHHJMOCEKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NBJDCAGIHKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FAJGAHEJLCP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AIPDCGCKEGD
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AOLPFGCPMDI
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NCCJGOEKFJI
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
public static class ILANIGLDDKJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct PCADPIHGKNL<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr NPLJHLAPOPB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
		public PCADPIHGKNL(IntPtr EIFNOCFPPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x59BBFA0", Offset = "0x59BABA0", VA = "0x1859BBFA0")]
		public int JMBILAAMFIC(TDeps BNLBDNCLLFN, TContext HOOFNNHOJJK, TCompileState KDLBDLALKMJ, [In] FAGJNHNKCLB<byte> BMKCMMJDNIF, int LJCMPAAEJAG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CABA60", Offset = "0x3CAA660", VA = "0x183CABA60")]
	public static void DAMGFIGCFBO<TDeps, TContext, TCompileState>(TDeps BNLBDNCLLFN, TContext HOOFNNHOJJK, TCompileState KDLBDLALKMJ, [In] FAGJNHNKCLB<byte> OLAILOBNIOA, FAGJNHNKCLB<byte> PDFDJJECLCJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? HLLFLPNAHAC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LIKEBHDNOLK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JAGBDDGPBHD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FBJANALAJPL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CBECCMHINPK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? PFEONLIMODJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CALOKCMEKHE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? EEPNDKMNLIA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NCKIBFFKFAN, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JBNMJLODCFJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? MNNANGGAAAG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? COEDFKMOMAA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DEOACELKPIO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AFOIAAEDENH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AOMFPBBMLLF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LMKGJOADNFC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FDIPCGECCJD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NBGCMDAAHPB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IOICJJIPDCF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LBIAAFMCAOF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IHJOBBDBKCH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? EELENIMPOIM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IGIEDJPOPHC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IOHGKKFNMOP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KGDOPHFNNJI, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GHFIOMIFKDL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AGOBPNJPILN, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FELCPBHAKJB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LAIAHKKDNMH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GNPNLBIMIDJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JEBMPPEKDFA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BMJAGOAPDJE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DPCEAFABFMB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? EFLCPMIGFOF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BKBKOGNNECG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? ICIGJPNCIOG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? PFFPPEOFPOD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DFMGDEMKJEO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AAEMHOIGPJI, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JKALNLKBDJD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KMIPJLMAFHC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? COGPDKALNOH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AJJNBOOJACP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JMIDMKNNOKF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LMFKBFBCFHA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GNBCOHBJDDJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JDICHDIHKKJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KHPJEFCGJHI, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KLHCGHCADDH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OJDKIIHOCOK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LGAGFJCGAOA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? PDHDDGBHNJL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? MHMIDIGFOKO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GAGDGAEHHEF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GDHBOEAAOKF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? EADACLJLLOL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DNDPLOGGPGO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LHOCMLELPBD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LEMNADBCLIJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OFJMFPCNGPJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? HNFBKEKCJFB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JNMEJIGGLOE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DHADILEJHDE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LJMMAHBGMDJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? EGCBOIILOFB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FJCPAGEPAPL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AJAMPNBNDJH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LKEGHLOPDFL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? AGKPOEDIMIH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JNNOOOOMFKM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LGKOEJPILHF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BPGFJKJCPMO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? ELCGDCGELEF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KFIJMKCIFIM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KDMLJAPNLBI, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IFDHCALHBJD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? ADHNDBIPLBF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KJENGLCKLCG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GKOBMCOFMOO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DKPCDBOEDJO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CIHMCMEFLGK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LEGFFIBFFNP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JOCBAOBKLOH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BNPFOLAGFLE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OGHHMOGNKFO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NEOOPJJKNHL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? MBJFBLHFIBJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? PGMGDMFIEJM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GDKHFNOOOEE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JEHFMKNALEN, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IDOIIOJPHDF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OANBHFJNIMF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JMMIEGJOIGG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BOPALIPPBFP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? HFBJAHEPFBM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OMNNGCJODKC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OOPKGNJGAFH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OIMFNKBMMGH, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LEMIGKNHBAE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IJNAOBJHFKJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FOGDNJMFNCP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CPJPAFBGJOB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JENPABGDECD, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CBEGCAKHHGL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JKAMLKLPELF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CIPNBNFPMOB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NNDELJFLKIK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FOCMLIMPDJB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BHMFLNOMNPO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? HOGBANPANBA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? OEOAEHABIKG, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GABEGLMCHGF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NAEKAGCHBOA, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? NCGDKECOIDJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? GMNANOHLKAB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? HEKKMEJJINJ, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LKCAIHGECOM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FLBENHIJNKK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JMPNPPMCBNM, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KGIDDCOCAKN, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FKHBDAPPAOF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DBEEJLGGHNB, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LBCPNAEMPPL, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? PPBHGNNKMFK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? DEDOLIJNKKC, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CFOEGMNLKNK, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JEIEOKKPDNP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? FCCGENOHOPP, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? JPBPAPLEFFO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? IFOBEKJHMGF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BIHHIEODHEF, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? KAKPBDHBBAE, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? CCDGKLDIIKI, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? LBNBDHDCHIO, [Optional] PCADPIHGKNL<TContext, TDeps, TCompileState>? BENALKKAAKE) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A05620", Offset = "0x2A04220", VA = "0x182A05620")]
	private static int MIEOMOLBNOE([In] FAGJNHNKCLB<byte> EHLKIKGNNGK, FAGJNHNKCLB<byte> MMGNGPFBICG, int LJEEMMFNMLE, int NKGPOLKDIPE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LHNAKNPDPEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int MEAHEDDAIJA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D263F0", Offset = "0x3D24FF0", VA = "0x183D263F0")]
	public static COMEADPNKEA<CCENJBIACBA<T>> CNHLNHAEPHO<T>([In] this FAGJNHNKCLB<byte> JBDFDFABHKD)
	{
		return default(COMEADPNKEA<CCENJBIACBA<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D26500", Offset = "0x3D25100", VA = "0x183D26500")]
	public static COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<T>>> KHEEEPIJHHP<T>(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<CCENJBIACBA<T>>? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A05A60", Offset = "0x2A04660", VA = "0x182A05A60")]
	public static COMEADPNKEA<CCENJBIACBA<HGKBALAIDPF>> IPIEOMCEOEL(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<HGKBALAIDPF>? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<HGKBALAIDPF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A05C00", Offset = "0x2A04800", VA = "0x182A05C00")]
	public static COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>> LEPCGGILELN(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] float? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A057D0", Offset = "0x2A043D0", VA = "0x182A057D0")]
	public static COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>> AIBGJEHENJM(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A05990", Offset = "0x2A04590", VA = "0x182A05990")]
	public static COMEADPNKEA<CCENJBIACBA<LGHGHGJNMHC>> GABAGGLBJFP(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<LGHGHGJNMHC>? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<LGHGHGJNMHC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A058A0", Offset = "0x2A044A0", VA = "0x182A058A0")]
	public static COMEADPNKEA<CCENJBIACBA<AOLPFGCPMDI>> FNLCCNKCJAI(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] byte? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<AOLPFGCPMDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A05CD0", Offset = "0x2A048D0", VA = "0x182A05CD0")]
	public static COMEADPNKEA<CCENJBIACBA<FAJGAHEJLCP>> LHCGNNCLKHG(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<FAJGAHEJLCP>? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<FAJGAHEJLCP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A05B30", Offset = "0x2A04730", VA = "0x182A05B30")]
	public static COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>> JAAFKJHPFDJ(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] NCCJGOEKFJI? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D26440", Offset = "0x3D25040", VA = "0x183D26440")]
	public static COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<T>>> IKMGHHBDHOL<T>(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<T>>? BKMPCFIAHIG)
	{
		return default(COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A055B0", Offset = "0x2A041B0", VA = "0x182A055B0")]
	public static void OHAMLBHOGGL(this FAGJNHNKCLB<byte> JBDFDFABHKD, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>> EDGAHCLJAKN, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D263E0", Offset = "0x3D24FE0", VA = "0x183D263E0")]
	public static void NNBAGICFGCD<T>(this FAGJNHNKCLB<byte> JBDFDFABHKD, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<T>>> LJCMPAAEJAG, COMEADPNKEA<CCENJBIACBA<T>> BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D263E0", Offset = "0x3D24FE0", VA = "0x183D263E0")]
	public static void BADGOIHOCNH<T>(this FAGJNHNKCLB<byte> JBDFDFABHKD, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<T>>> IKAJOHKIPOA, COMEADPNKEA<PLDBDINAHFP<T>> BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGOCGGMDOAL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A056C0", Offset = "0x2A042C0", VA = "0x182A056C0")]
	public static ACPCGMFEMME DCAIKFCKBDF([In] this ReadOnlySpan<byte> LNEJCNPADCI, int IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A05730", Offset = "0x2A04330", VA = "0x182A05730")]
	public static ACPCGMFEMME DCAIKFCKBDF([In] this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D24A30", Offset = "0x3D23630", VA = "0x183D24A30")]
	public static ACPCGMFEMME DCAIKFCKBDF<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D24800", Offset = "0x3D23400", VA = "0x183D24800")]
	public static ACPCGMFEMME DCAIKFCKBDF<M>([In] this NIMONOEGIOL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D24910", Offset = "0x3D23510", VA = "0x183D24910")]
	public static ACPCGMFEMME DCAIKFCKBDF<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D24960", Offset = "0x3D23560", VA = "0x183D24960")]
	public static ACPCGMFEMME DCAIKFCKBDF<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D249C0", Offset = "0x3D235C0", VA = "0x183D249C0")]
	public static ACPCGMFEMME DCAIKFCKBDF<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A056C0", Offset = "0x2A042C0", VA = "0x182A056C0")]
	public static int KHMFKFBNICL([In] this ReadOnlySpan<byte> LNEJCNPADCI, int IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A054E0", Offset = "0x2A040E0", VA = "0x182A054E0")]
	public static int KHMFKFBNICL([In] this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AC0", Offset = "0x39BF6C0", VA = "0x1839C0AC0")]
	public static int KHMFKFBNICL<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AC0", Offset = "0x39BF6C0", VA = "0x1839C0AC0")]
	public static int KHMFKFBNICL<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AC0", Offset = "0x39BF6C0", VA = "0x1839C0AC0")]
	public static int KHMFKFBNICL<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AC0", Offset = "0x39BF6C0", VA = "0x1839C0AC0")]
	public static int KHMFKFBNICL<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D247E0", Offset = "0x3D233E0", VA = "0x183D247E0")]
	public static float CODFPIACHNH<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D247E0", Offset = "0x3D233E0", VA = "0x183D247E0")]
	public static float CODFPIACHNH<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D247E0", Offset = "0x3D233E0", VA = "0x183D247E0")]
	public static float CODFPIACHNH<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D24D90", Offset = "0x3D23990", VA = "0x183D24D90")]
	public static byte MDKALOENEPE<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D24DC0", Offset = "0x3D239C0", VA = "0x183D24DC0")]
	public static byte MDKALOENEPE<M>([In] this NIMONOEGIOL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D24910", Offset = "0x3D23510", VA = "0x183D24910")]
	public static byte MDKALOENEPE<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D24960", Offset = "0x3D23560", VA = "0x183D24960")]
	public static byte MDKALOENEPE<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D24D20", Offset = "0x3D23920", VA = "0x183D24D20")]
	public static byte MDKALOENEPE<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A054E0", Offset = "0x2A040E0", VA = "0x182A054E0")]
	public static NCCJGOEKFJI EMJKOMPAMNP([In] this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL)
	{
		return default(NCCJGOEKFJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AC0", Offset = "0x39BF6C0", VA = "0x1839C0AC0")]
	public static NCCJGOEKFJI EMJKOMPAMNP<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(NCCJGOEKFJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D246C0", Offset = "0x3D232C0", VA = "0x183D246C0")]
	public static COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>> CBPPPKLOLCK<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D24780", Offset = "0x3D23380", VA = "0x183D24780")]
	public static COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>> CBPPPKLOLCK<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D24720", Offset = "0x3D23320", VA = "0x183D24720")]
	public static COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>> CBPPPKLOLCK<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D24B40", Offset = "0x3D23740", VA = "0x183D24B40")]
	public static COMEADPNKEA<PLDBDINAHFP<CFJKGDEOFEP>> DCNCKJMEAKO<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<PLDBDINAHFP<CFJKGDEOFEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D24C00", Offset = "0x3D23800", VA = "0x183D24C00")]
	public static COMEADPNKEA<FAJGAHEJLCP> GOLKLGLLHJB<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<FAJGAHEJLCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D24C60", Offset = "0x3D23860", VA = "0x183D24C60")]
	public static COMEADPNKEA<FAJGAHEJLCP> GOLKLGLLHJB<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<FAJGAHEJLCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D24CC0", Offset = "0x3D238C0", VA = "0x183D24CC0")]
	public static COMEADPNKEA<FAJGAHEJLCP> GOLKLGLLHJB<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<FAJGAHEJLCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D24E40", Offset = "0x3D23A40", VA = "0x183D24E40")]
	public static COMEADPNKEA<HGKBALAIDPF> MECNCBDHPEK<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<HGKBALAIDPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D24DE0", Offset = "0x3D239E0", VA = "0x183D24DE0")]
	public static COMEADPNKEA<HGKBALAIDPF> MECNCBDHPEK<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<HGKBALAIDPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D24BA0", Offset = "0x3D237A0", VA = "0x183D24BA0")]
	public static COMEADPNKEA<LGHGHGJNMHC> DEPBOBIPHNE<M>(this LJMABMKBOOJ<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL)
	{
		return default(COMEADPNKEA<LGHGHGJNMHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NKNJFBPIFDP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B7D0", Offset = "0x2A0A3D0", VA = "0x182A0B7D0")]
	public static void CKLDJJJAMIJ(this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL, ACPCGMFEMME BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B910", Offset = "0x2A0A510", VA = "0x182A0B910")]
	public static void CKLDJJJAMIJ(this byte[] LNEJCNPADCI, int IHJNIKBKIPL, ACPCGMFEMME BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B890", Offset = "0x2A0A490", VA = "0x182A0B890")]
	public static void CKLDJJJAMIJ([In] this Span<byte> LNEJCNPADCI, int IHJNIKBKIPL, ACPCGMFEMME BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9950", Offset = "0x3DC8550", VA = "0x183DC9950")]
	public static void CKLDJJJAMIJ<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, ACPCGMFEMME BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9A40", Offset = "0x3DC8640", VA = "0x183DC9A40")]
	public static void CKLDJJJAMIJ<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, ACPCGMFEMME BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A055B0", Offset = "0x2A041B0", VA = "0x182A055B0")]
	public static void OHAMLBHOGGL(this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B9C0", Offset = "0x2A0A5C0", VA = "0x182A0B9C0")]
	public static void OHAMLBHOGGL(this byte[] LNEJCNPADCI, int IHJNIKBKIPL, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BA40", Offset = "0x2A0A640", VA = "0x182A0BA40")]
	public static void OHAMLBHOGGL([In] this Span<byte> LNEJCNPADCI, int IHJNIKBKIPL, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9C20", Offset = "0x3DC8820", VA = "0x183DC9C20")]
	public static void OHAMLBHOGGL<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9BD0", Offset = "0x3DC87D0", VA = "0x183DC9BD0")]
	public static void OHAMLBHOGGL<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B980", Offset = "0x2A0A580", VA = "0x182A0B980")]
	public static void KLJFINABFPE(this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9B80", Offset = "0x3DC8780", VA = "0x183DC9B80")]
	public static void KLJFINABFPE<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9B30", Offset = "0x3DC8730", VA = "0x183DC9B30")]
	public static void KLJFINABFPE<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B760", Offset = "0x2A0A360", VA = "0x182A0B760")]
	public static void AEANMJDDIIE(this FAGJNHNKCLB<byte> LNEJCNPADCI, int IHJNIKBKIPL, byte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9920", Offset = "0x3DC8520", VA = "0x183DC9920")]
	public static void AEANMJDDIIE<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, byte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC98F0", Offset = "0x3DC84F0", VA = "0x183DC98F0")]
	public static void AEANMJDDIIE<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, byte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AB0", Offset = "0x39BF6B0", VA = "0x1839C0AB0")]
	public static void NNBAGICFGCD<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>> BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AB0", Offset = "0x39BF6B0", VA = "0x1839C0AB0")]
	public static void NNBAGICFGCD<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, COMEADPNKEA<CCENJBIACBA<CFJKGDEOFEP>> BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AB0", Offset = "0x39BF6B0", VA = "0x1839C0AB0")]
	public static void JIBCNBINHGO<M>(this EEGHPOHFELL<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, COMEADPNKEA<FAJGAHEJLCP> BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AB0", Offset = "0x39BF6B0", VA = "0x1839C0AB0")]
	public static void JIBCNBINHGO<M>([In] this HNMAGDHONDF<M, byte> LNEJCNPADCI, COMEADPNKEA<M> IHJNIKBKIPL, COMEADPNKEA<FAJGAHEJLCP> BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NAIADOEMLHD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A08DA0", Offset = "0x2A079A0", VA = "0x182A08DA0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) KCFAFNIMLOA(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A06A40", Offset = "0x2A05640", VA = "0x182A06A40")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) DBPGADCMCNC(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A06D10", Offset = "0x2A05910", VA = "0x182A06D10")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) DENFLCHENDE(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A097F0", Offset = "0x2A083F0", VA = "0x182A097F0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) LKBPOHFMBHM(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A760", Offset = "0x2A09360", VA = "0x182A0A760")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) NKPEJFKDFHC(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A09460", Offset = "0x2A08060", VA = "0x182A09460")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) KMJAIAHIPMM(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A0ACF0", Offset = "0x2A098F0", VA = "0x182A0ACF0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) PBBGDHPGGOK(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AA80", Offset = "0x2A09680", VA = "0x182A0AA80")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) NOBFAAAOJKO(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A640", Offset = "0x2A09240", VA = "0x182A0A640")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) NJNIKNCEKJP(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A062B0", Offset = "0x2A04EB0", VA = "0x182A062B0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>) BIFJCCNEMML(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? BKMPCFIAHIG, [Optional] COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>? JBDLFCFJNAM)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A06190", Offset = "0x2A04D90", VA = "0x182A06190")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>) BDGDOBPGHAH(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? BKMPCFIAHIG, [Optional] COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>? JBDLFCFJNAM)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A09580", Offset = "0x2A08180", VA = "0x182A09580")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>) LGHCHINKGAG(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? BKMPCFIAHIG, [Optional] COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>? JBDLFCFJNAM)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A08920", Offset = "0x2A07520", VA = "0x182A08920")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>) IOHNOMHBDON(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? BKMPCFIAHIG, [Optional] COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>? JBDLFCFJNAM)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A08110", Offset = "0x2A06D10", VA = "0x182A08110")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<HGKBALAIDPF>>) HKJJDCGHLLM(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? HPMLAOAADIA, [Optional] COMEADPNKEA<HGKBALAIDPF>? LOCAHCLFLKF)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<HGKBALAIDPF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A09EF0", Offset = "0x2A08AF0", VA = "0x182A09EF0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<HGKBALAIDPF>>>) MHNPGFDGOOC(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? HPMLAOAADIA, [Optional] COMEADPNKEA<PLDBDINAHFP<HGKBALAIDPF>>? LOCAHCLFLKF)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<HGKBALAIDPF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A09AA0", Offset = "0x2A086A0", VA = "0x182A09AA0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<FAJGAHEJLCP>>) MGAGIMBPHMD(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? HPMLAOAADIA, [Optional] COMEADPNKEA<FAJGAHEJLCP>? LOCAHCLFLKF)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<FAJGAHEJLCP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A3B0", Offset = "0x2A08FB0", VA = "0x182A0A3B0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FAJGAHEJLCP>>>) NGCCHIMNDBA(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? HPMLAOAADIA, [Optional] COMEADPNKEA<PLDBDINAHFP<FAJGAHEJLCP>>? LOCAHCLFLKF)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FAJGAHEJLCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDDE0", Offset = "0x3DBC9E0", VA = "0x183DBDDE0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<LGHGHGJNMHC>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<TMarker>>) BAFOCDAGJOP<TMarker>(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<LGHGHGJNMHC>? LOCAHCLFLKF, [Optional][In] ReadOnlySpan<byte> CBCNBAPLLJM)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<LGHGHGJNMHC>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A073C0", Offset = "0x2A05FC0", VA = "0x182A073C0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) FDFDOLDLADL(this FAGJNHNKCLB<byte> JBDFDFABHKD, int EHLKIKGNNGK, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? MMGNGPFBICG)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A07640", Offset = "0x2A06240", VA = "0x182A07640")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) FJHAEIJEBNO(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? EHLKIKGNNGK, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? MMGNGPFBICG)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDFD0", Offset = "0x3DBCBD0", VA = "0x183DBDFD0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<TMarker>>) BFKADOPBEDI<TMarker>(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<TMarker>>? MMGNGPFBICG, [Optional] int? PFHGPMHBODB, [Optional][In] ReadOnlySpan<byte> EHLKIKGNNGK)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE1B0", Offset = "0x3DBCDB0", VA = "0x183DBE1B0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>) LJGLDBKKDBP<TMarker>(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<TMarker>>? EHLKIKGNNGK, [Optional] COMEADPNKEA<PLDBDINAHFP<TMarker>>? MMGNGPFBICG, [Optional] int? PFHGPMHBODB)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<TMarker>>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A07750", Offset = "0x2A06350", VA = "0x182A07750")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) FNKDAIAKKDI(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B220", Offset = "0x2A09E20", VA = "0x182A0B220")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) PGKLBELAODG(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A0ABD0", Offset = "0x2A097D0", VA = "0x182A0ABD0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) OFGOICJMIHK(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A09080", Offset = "0x2A07C80", VA = "0x182A09080")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) KGPPDGJMCAD(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A930", Offset = "0x2A09530", VA = "0x182A0A930")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) NNFDILBGGPE(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A091E0", Offset = "0x2A07DE0", VA = "0x182A091E0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) KJGCJKOPECL(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B480", Offset = "0x2A0A080", VA = "0x182A0B480")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) PJCCDLHPGCL(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A09950", Offset = "0x2A08550", VA = "0x182A09950")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) LOPJKHHNNIO(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A078D0", Offset = "0x2A064D0", VA = "0x182A078D0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) GAIDDCADOLC(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A08400", Offset = "0x2A07000", VA = "0x182A08400")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>) HPCCOMADLJG(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>? CBMECIOLLNN)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<CCENJBIACBA<AIPDCGCKEGD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A4C0", Offset = "0x2A090C0", VA = "0x182A0A4C0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) NJBEDIOMMCE(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A070E0", Offset = "0x2A05CE0", VA = "0x182A070E0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) DHKPHPKHCNH(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A066A0", Offset = "0x2A052A0", VA = "0x182A066A0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) CHABLPFPCMD(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A09690", Offset = "0x2A08290", VA = "0x182A09690")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) LJGGEKLMHDM(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A082B0", Offset = "0x2A06EB0", VA = "0x182A082B0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) HOOLOIIHAAC(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A08C80", Offset = "0x2A07880", VA = "0x182A08C80")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) JJGJLNLKAKB(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A06B90", Offset = "0x2A05790", VA = "0x182A06B90")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) DEMHPFBNKBL(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AF70", Offset = "0x2A09B70", VA = "0x182A0AF70")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) PGFJNJCKDEC(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2A08A40", Offset = "0x2A07640", VA = "0x182A08A40")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) JCCBMFHMJJB(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A063C0", Offset = "0x2A04FC0", VA = "0x182A063C0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) BNGELFAMCBD(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2A07D80", Offset = "0x2A06980", VA = "0x182A07D80")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) HCCPFJPHONP(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AE50", Offset = "0x2A09A50", VA = "0x182A0AE50")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) PBEBHGGEFOH(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2A07240", Offset = "0x2A05E40", VA = "0x182A07240")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) EGHBCCFKAIN(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A09C40", Offset = "0x2A08840", VA = "0x182A09C40")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) MHAMGAKNNFH(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A05DE0", Offset = "0x2A049E0", VA = "0x182A05DE0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) ACPHKKEDBFJ(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A06F80", Offset = "0x2A05B80", VA = "0x182A06F80")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) DFECFPNAMHD(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2A074F0", Offset = "0x2A060F0", VA = "0x182A074F0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) FDIPICPFLJO(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2A05F10", Offset = "0x2A04B10", VA = "0x182A05F10")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) AGDMNGPPLIJ(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2A06520", Offset = "0x2A05120", VA = "0x182A06520")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) BNHOAKGGDLM(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A000", Offset = "0x2A08C00", VA = "0x182A0A000")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) MILLBCKNBFB(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A280", Offset = "0x2A08E80", VA = "0x182A0A280")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) MLPCLCJLFOJ(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A08F20", Offset = "0x2A07B20", VA = "0x182A08F20")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) KEGHCELDICJ(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A07C30", Offset = "0x2A06830", VA = "0x182A07C30")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) GOPKBFHDLKN(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A160", Offset = "0x2A08D60", VA = "0x182A0A160")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) MKGAOIENDJG(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B5E0", Offset = "0x2A0A1E0", VA = "0x182A0B5E0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) PKLCENGKBCA(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2A084F0", Offset = "0x2A070F0", VA = "0x182A084F0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) HPEPLFHICFE(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A07B10", Offset = "0x2A06710", VA = "0x182A07B10")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) GOCGABGHMCK(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A06030", Offset = "0x2A04C30", VA = "0x182A06030")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) AGHMGFOBCFG(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A06E30", Offset = "0x2A05A30", VA = "0x182A06E30")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) DEONALPFFPH(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A07ED0", Offset = "0x2A06AD0", VA = "0x182A07ED0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) HCOFIBOGPGC(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A08B70", Offset = "0x2A07770", VA = "0x182A08B70")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) JHCAJELLAGK(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] int? NGNHDNPJLGK, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B370", Offset = "0x2A09F70", VA = "0x182A0B370")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) PGNNIPECAHI(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? NGNHDNPJLGK, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A8B0", Offset = "0x2A094B0", VA = "0x182A0A8B0")]
	public static COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>> NNEGHPGKKHP(this FAGJNHNKCLB<byte> JBDFDFABHKD)
	{
		return default(COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A087A0", Offset = "0x2A073A0", VA = "0x182A087A0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) INCHJOANGMI(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, float CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B0D0", Offset = "0x2A09CD0", VA = "0x182A0B0D0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) PGKFPBOCHJM(this FAGJNHNKCLB<byte> JBDFDFABHKD, float ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<FGHHJMOCEKO>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A07FF0", Offset = "0x2A06BF0", VA = "0x182A07FF0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>) HIMOEJPKOGH(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<FGHHJMOCEKO>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<FGHHJMOCEKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A09300", Offset = "0x2A07F00", VA = "0x182A09300")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) KJIGDHAPOKO(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A09DA0", Offset = "0x2A089A0", VA = "0x182A09DA0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) MHJMOCMGANG(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A067D0", Offset = "0x2A053D0", VA = "0x182A067D0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) CKJNLGFIMMA(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A08640", Offset = "0x2A07240", VA = "0x182A08640")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) IFDHFKMEFIH(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, int CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A068F0", Offset = "0x2A054F0", VA = "0x182A068F0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) CNNHMMGMKHI(this FAGJNHNKCLB<byte> JBDFDFABHKD, int ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<NBJDCAGIHKJ>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A079F0", Offset = "0x2A065F0", VA = "0x182A079F0")]
	public static (COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>) GJMBIEPINCC(this FAGJNHNKCLB<byte> JBDFDFABHKD, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? ILOJAFGHOLB, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? CINAHHMFBGL, [Optional] COMEADPNKEA<PLDBDINAHFP<NBJDCAGIHKJ>>? FAHNMANIJDE)
	{
		return default((COMEADPNKEA<CCENJBIACBA<AIPDCGCKEGD>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>, COMEADPNKEA<CCENJBIACBA<PLDBDINAHFP<NBJDCAGIHKJ>>>));
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
