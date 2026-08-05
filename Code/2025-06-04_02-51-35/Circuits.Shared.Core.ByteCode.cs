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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x287E5E0", Offset = "0x287CDE0", VA = "0x18287E5E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDADOJOJKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C00", Offset = "0x37F5400", VA = "0x1837F6C00")]
	public static DPJIAIFILPM<PFNHDDPMOMF<M>> EBECIPBOENB<M>(this int DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x287E250", Offset = "0x287CA50", VA = "0x18287E250")]
	public static DPJIAIFILPM<HJCIKCOKJHA> GLBHPONDJAB(this int DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<HJCIKCOKJHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C00", Offset = "0x37F5400", VA = "0x1837F6C00")]
	public static DPJIAIFILPM<GHOAHPDFPIH<M>> AJLIAOANFOA<M>(this int DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<GHOAHPDFPIH<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PFNHDDPMOMF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PHDCGGGGNEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EIIOPMEMHJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HJCIKCOKJHA
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NFHBLMMELNO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KOECFMBPGBL
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IAFCMNCJMKF
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
public static class PBKCCCLJMCG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct PKIGDLLICFL<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr HMEAKNABFCG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
		public PKIGDLLICFL(IntPtr DIIOBAFKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58B7DD0", Offset = "0x58B65D0", VA = "0x1858B7DD0")]
		public int DMJBMMIBENB(TDeps GGLINDGLEPB, TContext HEKEBEBCDAB, TCompileState PHJAMFIDJNA, [In] GJEDEGEJPLA<byte> HGBLFLIIBDJ, int NJNGIMABDDP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B96D50", Offset = "0x3B95550", VA = "0x183B96D50")]
	public static void BFOJDJMOEPN<TDeps, TContext, TCompileState>(TDeps GGLINDGLEPB, TContext HEKEBEBCDAB, TCompileState PHJAMFIDJNA, [In] GJEDEGEJPLA<byte> LBABCJFEKJI, GJEDEGEJPLA<byte> JHLFOKGENMD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BIBDJBJKMBF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KIBAKKJPGCC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AFDMJBCNJBP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CPJNLNDEFJD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DPEHGGKBDBA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? MKDBHDDLJEF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LPKAMGDEAOA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EEIMOAOLGEG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NDIFOCLCAOI, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? POCLFLOBCFL, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HMBBNLLGMJJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LMAKNFJGPHF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HCOCIAEDBHK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AKKOHKDGDIM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GLCIIJONODJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CNIAPMLGLPD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GJOHAHPKMEI, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OJDMIPGBDHF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OAPNOHGJGAG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JOJGLFGDBHI, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EGJNJHFOKIC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FHKBMDEEKEL, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NGGPKGOLPCG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LFJAOCIMKEL, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JMOENDIMJLJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LNGMFFPDDHC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DKFLLCEFHEO, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EPIDONOHEDE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NDOKOEOPEBA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? INMFHAAPDEB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FLJPJPLNAHE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PHCPDHINNIH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LINOFBOEENN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KLAMKCJDABM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HIIFANIBGLJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EHPAJGOLPED, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AMGCKKMMCHG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LLEHPALHBEO, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OPECPBNOOMG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OFJKCLLJNGP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BLMKBDIMEBO, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? IEDPPLAFOMH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AKMBBHAGJKM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GJJKJBAIAMG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CILLIDIKAGB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BJFEMABHLFM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PEOBCMMGOHE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FBELHEMIKFH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? ECGNJDIDLLP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JNGNLJIKLKK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? IBHIHANELGD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BCPMBGEKEHM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FDCDNCMCINH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FNPBHOKJKOC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? ELEBPLOLACE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HNKALMAODMK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GIGOHJIOCLM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HECMMOFHBDG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KKOFCCEADJD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? ONMNPBGMLNG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LFCPHLDNOHH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KMDMBJOMHLN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NBHLFGCOOGM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KNHONALCDMN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GFNGLDPIMPK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CPKGPMECKMM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LONOBGHJEDJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CCCDFCGGLON, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GAGBFEDKCNP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LMFBCNBPACM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DCILBOGDFDG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OOHCKLHPANP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? MCCBACJKPFN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KGNHPGAFBAI, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? INNMNBMOLIH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? MHNAAMEDALK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OIGGNFBDJBD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? MKCCNBBMGBA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BIDKDMLOBKM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? COHCOJFGJBK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BABPLFEHBFF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? MLKAMCFBNIB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OPOJCAHGGNF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BIANENEENKG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JBLOPPIFBGN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DJPHGIIOPGG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NCBDBNPKGDD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PDAIKGJFLAH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AHHEPCCHIFG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FPFEGPDOMJJ, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EBMCEPCKGCI, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JIIDAIIIKDB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DNOEKCLMFBH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AKBAKMKFAGP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? FKHOMOGPANG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KCJMAKEBGKM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DLDPHIBDFLC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? BJBAAOLJHHB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NKNPLAJJCMD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? INKJLOPFEPF, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GMDANOAEJAN, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KOKFJDFAOGD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OLEKHGIGCBB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? NEOPNAGAIHA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KCAOBEMMBBO, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JBENPBFLACD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KLEAAEEGIEE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AOIDGOJLJED, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EMNMDPALOKC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? HPPCAFOBJPP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? LBFPPIMCPHL, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DGLCDLNJKCE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? EOHOCELOBEC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? KJONNOICCAA, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OJPPHFMCJNM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DMCDJGHOCLO, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AEDHKGKGPOC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PFEDNLHAOOG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? ONKMDEFLGCD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PJPMJCHPCON, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GJCDEHJEOPB, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DFLMPJFKNOP, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GHOJCOCECKG, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JAMNNLLPDDE, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? PBIKCDJPGHM, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? CHKGAJFHGME, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? ELEFEPCAGEC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JIBHFFMGKEK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? OHDEGFHKENK, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? JIJBLFJIFLH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? AKOAEIEBIKD, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? DJHAPJLIHKL, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? GEBEBMJAALC, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? COHBCKPHKEH, [Optional] PKIGDLLICFL<TContext, TDeps, TCompileState>? INAGDHJLCBH) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x287E660", Offset = "0x287CE60", VA = "0x18287E660")]
	private static int EDHIEIPIGEP([In] GJEDEGEJPLA<byte> JPGKLKLGGMN, GJEDEGEJPLA<byte> OOGMCHHLIPA, int BAGLBFCLNDM, int FMGALNGIOGC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class POPLEJCGHPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int GJBPFCHKAMH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8D40", Offset = "0x3BA7540", VA = "0x183BA8D40")]
	public static DPJIAIFILPM<PFNHDDPMOMF<T>> DHHEMJFMDJK<T>([In] this GJEDEGEJPLA<byte> DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8BC0", Offset = "0x3BA73C0", VA = "0x183BA8BC0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<T>>> BIIJEDFJAEL<T>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<PFNHDDPMOMF<T>>? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x287E700", Offset = "0x287CF00", VA = "0x18287E700")]
	public static DPJIAIFILPM<PFNHDDPMOMF<GLIIMLJLBGC>> AKEJANBOKIH(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GLIIMLJLBGC>? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<GLIIMLJLBGC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x287EAA0", Offset = "0x287D2A0", VA = "0x18287EAA0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>> HLIINJNHIJK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] float? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x287E7E0", Offset = "0x287CFE0", VA = "0x18287E7E0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>> BHOJCMIHLLB(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x287E9C0", Offset = "0x287D1C0", VA = "0x18287E9C0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>> ECMEADEAPFO(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<CCHCFBIDMLI>? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x287E8C0", Offset = "0x287D0C0", VA = "0x18287E8C0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<KOECFMBPGBL>> BNLMBLPFJEI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] byte? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<KOECFMBPGBL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x287EC80", Offset = "0x287D480", VA = "0x18287EC80")]
	public static DPJIAIFILPM<PFNHDDPMOMF<HJCIKCOKJHA>> OKKKAMDBMPO(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<HJCIKCOKJHA>? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<HJCIKCOKJHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x287EB90", Offset = "0x287D390", VA = "0x18287EB90")]
	public static DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> IKOHALCHKFB(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] IAFCMNCJMKF? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8C80", Offset = "0x3BA7480", VA = "0x183BA8C80")]
	public static DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<T>>> CEJHOONGGHD<T>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<T>>? MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28786C0", Offset = "0x2876EC0", VA = "0x1828786C0")]
	public static void BCGOPJCILEN(this GJEDEGEJPLA<byte> DKBBJFIDEGB, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>> JFAONAMNHII, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8DA0", Offset = "0x3BA75A0", VA = "0x183BA8DA0")]
	public static void PENNBEFLLPJ<T>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<T>>> NJNGIMABDDP, DPJIAIFILPM<PFNHDDPMOMF<T>> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8DA0", Offset = "0x3BA75A0", VA = "0x183BA8DA0")]
	public static void IBMLGLENGEN<T>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<T>>> BHFCCHPPOFN, DPJIAIFILPM<GHOAHPDFPIH<T>> MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BPBDHLECPCI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28787C0", Offset = "0x2876FC0", VA = "0x1828787C0")]
	public static KGJKGFJIMIK PHDAKDMBBCG([In] this ReadOnlySpan<byte> LLNMEIMBBLB, int PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2878830", Offset = "0x2877030", VA = "0x182878830")]
	public static KGJKGFJIMIK PHDAKDMBBCG([In] this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3738890", Offset = "0x3737090", VA = "0x183738890")]
	public static KGJKGFJIMIK PHDAKDMBBCG<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3738AA0", Offset = "0x37372A0", VA = "0x183738AA0")]
	public static KGJKGFJIMIK PHDAKDMBBCG<M>([In] this NCCNPDPCOJO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37386E0", Offset = "0x3736EE0", VA = "0x1837386E0")]
	public static KGJKGFJIMIK PHDAKDMBBCG<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3738670", Offset = "0x3736E70", VA = "0x183738670")]
	public static KGJKGFJIMIK PHDAKDMBBCG<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37389E0", Offset = "0x37371E0", VA = "0x1837389E0")]
	public static KGJKGFJIMIK PHDAKDMBBCG<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28787C0", Offset = "0x2876FC0", VA = "0x1828787C0")]
	public static int FNGJDGJOHHH([In] this ReadOnlySpan<byte> LLNMEIMBBLB, int PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2878610", Offset = "0x2876E10", VA = "0x182878610")]
	public static int FNGJDGJOHHH([In] this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3738290", Offset = "0x3736A90", VA = "0x183738290")]
	public static int FNGJDGJOHHH<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3738290", Offset = "0x3736A90", VA = "0x183738290")]
	public static int FNGJDGJOHHH<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3738290", Offset = "0x3736A90", VA = "0x183738290")]
	public static int FNGJDGJOHHH<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3738290", Offset = "0x3736A90", VA = "0x183738290")]
	public static int FNGJDGJOHHH<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37381E0", Offset = "0x37369E0", VA = "0x1837381E0")]
	public static float COBKIGPJLPP<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37381E0", Offset = "0x37369E0", VA = "0x1837381E0")]
	public static float COBKIGPJLPP<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37381E0", Offset = "0x37369E0", VA = "0x1837381E0")]
	public static float COBKIGPJLPP<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3738580", Offset = "0x3736D80", VA = "0x183738580")]
	public static byte NEDDHPKCMGE<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3738560", Offset = "0x3736D60", VA = "0x183738560")]
	public static byte NEDDHPKCMGE<M>([In] this NCCNPDPCOJO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37386E0", Offset = "0x3736EE0", VA = "0x1837386E0")]
	public static byte NEDDHPKCMGE<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3738670", Offset = "0x3736E70", VA = "0x183738670")]
	public static byte NEDDHPKCMGE<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37385B0", Offset = "0x3736DB0", VA = "0x1837385B0")]
	public static byte NEDDHPKCMGE<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2878610", Offset = "0x2876E10", VA = "0x182878610")]
	public static IAFCMNCJMKF MPKLPMDFMDF([In] this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK)
	{
		return default(IAFCMNCJMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3738290", Offset = "0x3736A90", VA = "0x183738290")]
	public static IAFCMNCJMKF MPKLPMDFMDF<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(IAFCMNCJMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37383A0", Offset = "0x3736BA0", VA = "0x1837383A0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> HCLADICIFFH<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3738330", Offset = "0x3736B30", VA = "0x183738330")]
	public static DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> HCLADICIFFH<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37382C0", Offset = "0x3736AC0", VA = "0x1837382C0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> HCLADICIFFH<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3738410", Offset = "0x3736C10", VA = "0x183738410")]
	public static DPJIAIFILPM<GHOAHPDFPIH<DPNAIGBABBE>> JDMKKJKGBEE<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<GHOAHPDFPIH<DPNAIGBABBE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3738740", Offset = "0x3736F40", VA = "0x183738740")]
	public static DPJIAIFILPM<HJCIKCOKJHA> PFHENHJLGJP<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<HJCIKCOKJHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37387B0", Offset = "0x3736FB0", VA = "0x1837387B0")]
	public static DPJIAIFILPM<HJCIKCOKJHA> PFHENHJLGJP<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<HJCIKCOKJHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3738820", Offset = "0x3737020", VA = "0x183738820")]
	public static DPJIAIFILPM<HJCIKCOKJHA> PFHENHJLGJP<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<HJCIKCOKJHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3738480", Offset = "0x3736C80", VA = "0x183738480")]
	public static DPJIAIFILPM<GLIIMLJLBGC> MAKOMAGAFKI<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<GLIIMLJLBGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37384F0", Offset = "0x3736CF0", VA = "0x1837384F0")]
	public static DPJIAIFILPM<GLIIMLJLBGC> MAKOMAGAFKI<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<GLIIMLJLBGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3738220", Offset = "0x3736A20", VA = "0x183738220")]
	public static DPJIAIFILPM<CCHCFBIDMLI> EADKNMFANKL<M>(this EGJGIDLOLKO<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK)
	{
		return default(DPJIAIFILPM<CCHCFBIDMLI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LGDHPKCNIAO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x287E380", Offset = "0x287CB80", VA = "0x18287E380")]
	public static void MCJCAGDAODA(this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK, KGJKGFJIMIK MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x287E440", Offset = "0x287CC40", VA = "0x18287E440")]
	public static void MCJCAGDAODA(this byte[] LLNMEIMBBLB, int PKOADNLIJDK, KGJKGFJIMIK MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x287E4B0", Offset = "0x287CCB0", VA = "0x18287E4B0")]
	public static void MCJCAGDAODA([In] this Span<byte> LLNMEIMBBLB, int PKOADNLIJDK, KGJKGFJIMIK MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6260", Offset = "0x3AA4A60", VA = "0x183AA6260")]
	public static void MCJCAGDAODA<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, KGJKGFJIMIK MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6400", Offset = "0x3AA4C00", VA = "0x183AA6400")]
	public static void MCJCAGDAODA<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, KGJKGFJIMIK MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28786C0", Offset = "0x2876EC0", VA = "0x1828786C0")]
	public static void BCGOPJCILEN(this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x287E300", Offset = "0x287CB00", VA = "0x18287E300")]
	public static void BCGOPJCILEN(this byte[] LLNMEIMBBLB, int PKOADNLIJDK, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x287E280", Offset = "0x287CA80", VA = "0x18287E280")]
	public static void BCGOPJCILEN([In] this Span<byte> LLNMEIMBBLB, int PKOADNLIJDK, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6200", Offset = "0x3AA4A00", VA = "0x183AA6200")]
	public static void BCGOPJCILEN<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3AA61A0", Offset = "0x3AA49A0", VA = "0x183AA61A0")]
	public static void BCGOPJCILEN<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x287E530", Offset = "0x287CD30", VA = "0x18287E530")]
	public static void NDLEKGFIPKB(this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6600", Offset = "0x3AA4E00", VA = "0x183AA6600")]
	public static void NDLEKGFIPKB<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AA65A0", Offset = "0x3AA4DA0", VA = "0x183AA65A0")]
	public static void NDLEKGFIPKB<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x287E570", Offset = "0x287CD70", VA = "0x18287E570")]
	public static void OCKBFLMLDBB(this GJEDEGEJPLA<byte> LLNMEIMBBLB, int PKOADNLIJDK, byte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AA66B0", Offset = "0x3AA4EB0", VA = "0x183AA66B0")]
	public static void OCKBFLMLDBB<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, byte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6660", Offset = "0x3AA4E60", VA = "0x183AA6660")]
	public static void OCKBFLMLDBB<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, byte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37F6CB0", Offset = "0x37F54B0", VA = "0x1837F6CB0")]
	public static void PENNBEFLLPJ<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37F6CB0", Offset = "0x37F54B0", VA = "0x1837F6CB0")]
	public static void PENNBEFLLPJ<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x37F6CB0", Offset = "0x37F54B0", VA = "0x1837F6CB0")]
	public static void DDEOHHANLHD<M>(this LCOBDACGLOG<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, DPJIAIFILPM<HJCIKCOKJHA> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37F6CB0", Offset = "0x37F54B0", VA = "0x1837F6CB0")]
	public static void DDEOHHANLHD<M>([In] this HMGCANBKJNM<M, byte> LLNMEIMBBLB, DPJIAIFILPM<M> PKOADNLIJDK, DPJIAIFILPM<HJCIKCOKJHA> MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DAMAHDOBNLP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x287A690", Offset = "0x2878E90", VA = "0x18287A690")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) ELJKCMIJAOA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x287A300", Offset = "0x2878B00", VA = "0x18287A300")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) EHENANMJADP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2879CD0", Offset = "0x28784D0", VA = "0x182879CD0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) EDAKIGDMIKB(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x287C380", Offset = "0x287AB80", VA = "0x18287C380")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) JFBBHPOCLAM(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x287D8A0", Offset = "0x287C0A0", VA = "0x18287D8A0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) NJCAIOIMFFL(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2879480", Offset = "0x2877C80", VA = "0x182879480")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) CDLDGLPPAMD(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x287B280", Offset = "0x2879A80", VA = "0x18287B280")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) GGMNLCOLHOJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x287CA60", Offset = "0x287B260", VA = "0x18287CA60")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) KOPMNLLBDOB(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x287A570", Offset = "0x2878D70", VA = "0x18287A570")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EKNCIKHLCCD(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x287B650", Offset = "0x2879E50", VA = "0x18287B650")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>) GLGLHGJFGEP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? MGONBEDEDON, [Optional] DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? FBJBKIGKFLE)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x287ABF0", Offset = "0x28793F0", VA = "0x18287ABF0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>) FDEENCCBLBF(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? MGONBEDEDON, [Optional] DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? FBJBKIGKFLE)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x287DB40", Offset = "0x287C340", VA = "0x18287DB40")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>) NMNHGLLDBBG(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? MGONBEDEDON, [Optional] DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? FBJBKIGKFLE)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x287DC50", Offset = "0x287C450", VA = "0x18287DC50")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>) ODDOOJFOGKL(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? MGONBEDEDON, [Optional] DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? FBJBKIGKFLE)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x287B890", Offset = "0x287A090", VA = "0x18287B890")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GLIIMLJLBGC>>) HFPCOCLKJKK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? JHGKOELCDFM, [Optional] DPJIAIFILPM<GLIIMLJLBGC>? OHENIKPHLCF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GLIIMLJLBGC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x287C140", Offset = "0x287A940", VA = "0x18287C140")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<GLIIMLJLBGC>>>) IGLINNHEIMC(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? JHGKOELCDFM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<GLIIMLJLBGC>>? OHENIKPHLCF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<GLIIMLJLBGC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287A620", VA = "0x18287BE20")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<HJCIKCOKJHA>>) HJLMBOJOHPJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? JHGKOELCDFM, [Optional] DPJIAIFILPM<HJCIKCOKJHA>? OHENIKPHLCF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<HJCIKCOKJHA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2879DF0", Offset = "0x28785F0", VA = "0x182879DF0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<HJCIKCOKJHA>>>) EEJOMALKONG(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? JHGKOELCDFM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<HJCIKCOKJHA>>? OHENIKPHLCF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<HJCIKCOKJHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37F2C30", Offset = "0x37F1430", VA = "0x1837F2C30")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>) APBFPMFIINM<TMarker>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<CCHCFBIDMLI>? OHENIKPHLCF, [Optional][In] ReadOnlySpan<byte> IMINNNCPCJF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x287B760", Offset = "0x2879F60", VA = "0x18287B760")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) GPKBHMHIOLJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int JPGKLKLGGMN, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? OOGMCHHLIPA)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28788D0", Offset = "0x28770D0", VA = "0x1828788D0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) AOMPOODGKPA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JPGKLKLGGMN, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? OOGMCHHLIPA)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37F2E30", Offset = "0x37F1630", VA = "0x1837F2E30")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>) EKNOANOBIED<TMarker>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<TMarker>>? OOGMCHHLIPA, [Optional] int? GGIJOHIPOOO, [Optional][In] ReadOnlySpan<byte> JPGKLKLGGMN)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37F3020", Offset = "0x37F1820", VA = "0x1837F3020")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>) LGCMCHCCJLA<TMarker>(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<TMarker>>? JPGKLKLGGMN, [Optional] DPJIAIFILPM<GHOAHPDFPIH<TMarker>>? OOGMCHHLIPA, [Optional] int? GGIJOHIPOOO)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<TMarker>>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28791B0", Offset = "0x28779B0", VA = "0x1828791B0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) CBPNEGPHJEO(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x287D0B0", Offset = "0x287B8B0", VA = "0x18287D0B0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) LBIJBLNGDFE(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x287B530", Offset = "0x2879D30", VA = "0x18287B530")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) GKCLMJBKGMK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x287BBD0", Offset = "0x287A3D0", VA = "0x18287BBD0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) HHKEIMOOBCJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x287DE90", Offset = "0x287C690", VA = "0x18287DE90")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) OJFADEODHIG(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x287DFE0", Offset = "0x287C7E0", VA = "0x18287DFE0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) PGIBOHFIBHI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x287D200", Offset = "0x287BA00", VA = "0x18287D200")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) LFHCEDBOJLH(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2878F00", Offset = "0x2877700", VA = "0x182878F00")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) BMIIFKBMHOJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x287CE70", Offset = "0x287B670", VA = "0x18287CE70")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) KPNLPJDCCIM(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x287BD30", Offset = "0x287A530", VA = "0x18287BD30")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>) HIPNIJHDCGF(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? NCCPIHEJNCI)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2879F00", Offset = "0x2878700", VA = "0x182879F00")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EFIIPNMEFII(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x287C780", Offset = "0x287AF80", VA = "0x18287C780")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) KIPIOOMNPNH(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x287D770", Offset = "0x287BF70", VA = "0x18287D770")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) NGDNKNJLBIE(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x287AD10", Offset = "0x2879510", VA = "0x18287AD10")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) FGDGIDBACFP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x287AAA0", Offset = "0x28792A0", VA = "0x18287AAA0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) FADNHIKHGPJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x28796B0", Offset = "0x2877EB0", VA = "0x1828796B0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) CKJMMNBGAGJ(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x287A810", Offset = "0x2879010", VA = "0x18287A810")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EMLPECLKJCK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x287B120", Offset = "0x2879920", VA = "0x18287B120")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) GBMLLGCOPGO(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2879A40", Offset = "0x2878240", VA = "0x182879A40")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) DNMFLLHMJII(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x287D610", Offset = "0x287BE10", VA = "0x18287D610")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) MBLLEFJNFCM(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x287D360", Offset = "0x287BB60", VA = "0x18287D360")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) LKPLEFJDEKC(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x287BAB0", Offset = "0x287A2B0", VA = "0x18287BAB0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) HGFFKDELMAN(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x287AFA0", Offset = "0x28797A0", VA = "0x18287AFA0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) FJCCKDLAFOI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2879B70", Offset = "0x2878370", VA = "0x182879B70")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EAJHBMLDDPA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x287C250", Offset = "0x287AA50", VA = "0x18287C250")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) JDIGKNCIBIP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x287D4B0", Offset = "0x287BCB0", VA = "0x18287D4B0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) LLDOHJJPLJC(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x287B3E0", Offset = "0x2879BE0", VA = "0x18287B3E0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) GIKGJCNBJPA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28789E0", Offset = "0x28771E0", VA = "0x1828789E0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) BDDHEEFCPEK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x287BFC0", Offset = "0x287A7C0", VA = "0x18287BFC0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) IGKMELPHHPF(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2879050", Offset = "0x2877850", VA = "0x182879050")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) CAMOGNCKOEI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x287AE70", Offset = "0x2879670", VA = "0x18287AE70")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) FJAOLBIJJJP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x287CBB0", Offset = "0x287B3B0", VA = "0x18287CBB0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) KPIBNKLIDCC(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2879330", Offset = "0x2877B30", VA = "0x182879330")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) CCNHBOKHIJK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2879920", Offset = "0x2878120", VA = "0x182879920")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) DNIAINHEPKK(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x287C600", Offset = "0x287AE00", VA = "0x18287C600")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) JOLIJJNLHBE(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2878DB0", Offset = "0x28775B0", VA = "0x182878DB0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) BFPOMJLNFDP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x287CF90", Offset = "0x287B790", VA = "0x18287CF90")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) KPPGJMJNGDN(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x287A080", Offset = "0x2878880", VA = "0x18287A080")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EGBPLJKCNHP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x287D9F0", Offset = "0x287C1F0", VA = "0x18287D9F0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) NLAMPDECDHN(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x287A1E0", Offset = "0x28789E0", VA = "0x18287A1E0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EGMICJKDIJI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x287A990", Offset = "0x2879190", VA = "0x18287A990")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EOCJBKPKMNG(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] int? HMNIBPOIAMO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28795A0", Offset = "0x2877DA0", VA = "0x1828795A0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) CEDPHMAOIFA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HMNIBPOIAMO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x287BA30", Offset = "0x287A230", VA = "0x18287BA30")]
	public static DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> HGAGAINPEHA(this GJEDEGEJPLA<byte> DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x287C8E0", Offset = "0x287B0E0", VA = "0x18287C8E0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) KLMBPCJEIAI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28797D0", Offset = "0x2877FD0", VA = "0x1828797D0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) DEJMEPODPBI(this GJEDEGEJPLA<byte> DKBBJFIDEGB, float FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PHDCGGGGNEL>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x287DD70", Offset = "0x287C570", VA = "0x18287DD70")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>) OHNGCLDCHPO(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<PHDCGGGGNEL>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<PHDCGGGGNEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x287CD10", Offset = "0x287B510", VA = "0x18287CD10")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) KPKMGKGJNDD(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2878B00", Offset = "0x2877300", VA = "0x182878B00")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) BDKOBJBOOJA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x287A450", Offset = "0x2878C50", VA = "0x18287A450")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) EIILHLLAAJP(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2878C50", Offset = "0x2877450", VA = "0x182878C50")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) BFINMOMCDCA(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x287E100", Offset = "0x287C900", VA = "0x18287E100")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) PIEDPNBNAFF(this GJEDEGEJPLA<byte> DKBBJFIDEGB, int FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x287C4E0", Offset = "0x287ACE0", VA = "0x18287C4E0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>) JFMGBAHFDLB(this GJEDEGEJPLA<byte> DKBBJFIDEGB, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? FDGFOMMHJHO, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? JAEFIGHHDIM, [Optional] DPJIAIFILPM<GHOAHPDFPIH<EIIOPMEMHJA>>? HAAMBJLHELL)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<EIIOPMEMHJA>>>));
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
