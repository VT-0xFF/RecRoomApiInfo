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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEAB00", Offset = "0x1FE9F00", VA = "0x181FEAB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MGMILHGMMOP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28F75F0", Offset = "0x28F69F0", VA = "0x1828F75F0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<M>> KLHLLHJGMBO<M>(this int ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAAD0", Offset = "0x1FE9ED0", VA = "0x181FEAAD0")]
	public static DFKPAEMPCKH<ALBOPLJHKOM> KJAGGBNMMKH(this int ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<ALBOPLJHKOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28F75F0", Offset = "0x28F69F0", VA = "0x1828F75F0")]
	public static DFKPAEMPCKH<IKPMLKELNKD<M>> DAPDDJOHDGA<M>(this int ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<IKPMLKELNKD<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MHCHLGAGEPI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LJJLEELIGLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PJBCDDGDFDM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ALBOPLJHKOM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class OLJMCCBPJLK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GBFGLFBMEEE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GDBGOOJOMPI
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
public static class HNHEBHGEJJC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct ILMMNKIPCIH<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KFOIPMICHFF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
		public ILMMNKIPCIH(IntPtr DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E74220", Offset = "0x3E73620", VA = "0x183E74220")]
		public int KGLFFAEFCMK(TDeps GPENJAMDJGM, TContext JPBIJLLMGPO, TCompileState ACPICEINECI, [In] PCPLEDLJHDN<byte> JAPLNJDKPMD, int JJBIHGLNEFN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E850", Offset = "0x2B7DC50", VA = "0x182B7E850")]
	public static void FHPBOIAOLOH<TDeps, TContext, TCompileState>(TDeps GPENJAMDJGM, TContext JPBIJLLMGPO, TCompileState ACPICEINECI, [In] PCPLEDLJHDN<byte> FCIJPGBBFBG, PCPLEDLJHDN<byte> HJGGIDEBGAO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JEACHDKHKFP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KPGHOPFNKOE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LAONPNDPBEI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FKCMFLGBDOJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AAKMBPODHFE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FLIGEJFPGNP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FHIFENBBCNM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? APECPKIEJBO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OLJBFECHMPC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FPCBDADHIEJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AKDFCANJIEE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OPCKNBALMDH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KGPOFHLBJKE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PPJHDACJNLI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? IIFEIMHINKF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HDBJJKCPCCD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? CLMPHFNOHOL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? EGHLDDFGALL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? IBCHJOGHFEF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DFIFHCONOPO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? CFEPLIAMMIL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KJGMPEBDKAK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JANPLLFMKLB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? IKCJANHNBIA, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AECMCALECEP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MDHPDHDDNJO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LCLCGNKLKFI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? IFPMHGJLHPI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BOEDDKBPDND, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? CGLMGFKJKGC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JGPDKADMMOM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AONDEBIMNKE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? ACHJKKECFFE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BIMEJHCDAGH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JHJMGOMFHBJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LPIBCIPBLAF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FHLPIBDPJAI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PPLFCHEHJCC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BCNBCDKMHBC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? CEOHBFFDBBK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JDKPLACCMGK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JOGACCOIDBE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GKGPLFOMEPP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MCGMGMDMGMM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FMFLDMCIALP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? EMHIOPFKBFO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? INBABPECKFD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JKBMBJLHEBL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FLFBNKEHKJM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LIONKMDIODE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BKDEPPMBECF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PGBIEGKNMFK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LNLCOGKKALJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MDFJOCLLELP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KOHJPKJGJDA, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? IAJMAGCHFGP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HPOAIONEJMF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JKJKHGGCHFL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DIJOOJGIADD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AMIKHDIGJPL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PMFIDNNFIPJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HONJNCJIHBP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MKENIKBELJB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KJLEBLPGNCP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MPGKMFFCIDF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LFDCAKJMKMJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LMHIIPPDOIL, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HLJJGPDNHMC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MFKILLOBBFJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LIIFCPOBCMI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BLNHGEIGEJK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LBNMMPFCBHC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FCBNGDJAJMG, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? ACAHNCPNKAK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JDCDFOBECCJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LINKJDKDJHO, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MEAJAOEPGFK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NCKFGEPKBNG, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PNMMAPNKALD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? MKJNNCNENNC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JNEALPMOPIK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HFBLCNDGFPC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JHBOMHEAMHA, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? EEMEKONBHHH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OCJMOBLKKEE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BDMEMOCCKKC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? LBCJPDMIBEJ, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BBNFCEBCJOI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PAIPHLNKDCF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JLDNFCBCBEK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JMGNEPJLHBM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NADEMIOHPNB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JOLKIFCBHCB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GNABKOCKOMH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PBIBPPFNOBP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PLHAJFHEFHH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? APICAAAKBDK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AJIIPEAGMJK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OIPDLKJPDJF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HNPFGBGIJFP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FEIPJEKDCEK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BGDDHCEEKDE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KJBOJMBABCI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DHEFOKDNODB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HGECNLIBJIF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GMKFELPPNIP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GKKBFGCJFIC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GOOGANFLECF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? EDAJLAJPGFG, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? ILDLPMKOGIE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DHDOMCENAGC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PCFMMCFEGHH, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? HEEMBJCMCNM, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? FGJHDDPCFJE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? ANDHJEHJONG, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? JDMIDADEAKD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DFLKAMHJPIF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KMLDCLLCIEE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OHKKGBKIBHI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? GNOHPKLMKJP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KLJIGACKEFE, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? CGALFMMOIKF, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? AMNINKLFMBK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? PCDFCKIKACN, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NJNPKBJBGIN, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DPFNPLPCAGB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NPJNKANHNPI, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? OBHAMAFPGAD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NCPNGLDMHAK, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? NLMNKIADGIC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DBEJLOPJAEC, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? BEOGNEDCJEP, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KKHOGIALIKD, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? DIBGENDHBNB, [Optional] ILMMNKIPCIH<TContext, TDeps, TCompileState>? KADLHFNHBDK) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA390", Offset = "0x1FE9790", VA = "0x181FEA390")]
	private static int NCMMJPNAPGA([In] PCPLEDLJHDN<byte> FIJIJLPKIHA, PCPLEDLJHDN<byte> KFGKPLPCACH, int DEABOIPAFEI, int MLMABEGDEJH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KFBNEGPMDOD
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int PLACFFKHLJC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2C21CA0", Offset = "0x2C210A0", VA = "0x182C21CA0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<T>> AKGODEADOIB<T>([In] this PCPLEDLJHDN<byte> ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C21D10", Offset = "0x2C21110", VA = "0x182C21D10")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<T>>> NEGKGJLEBMF<T>(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<T>>? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA430", Offset = "0x1FE9830", VA = "0x181FEA430")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<EHPHFEHIOBB>> BCJILOOBJCG(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<EHPHFEHIOBB>? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<EHPHFEHIOBB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA9A0", Offset = "0x1FE9DA0", VA = "0x181FEA9A0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>> PFMHBEEPEPO(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] float? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA510", Offset = "0x1FE9910", VA = "0x181FEA510")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>> COCDCFJIPOP(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA5F0", Offset = "0x1FE99F0", VA = "0x181FEA5F0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>> DGBFNINJJOJ(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<LMIGEMJAMLD>? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA8A0", Offset = "0x1FE9CA0", VA = "0x181FEA8A0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<GBFGLFBMEEE>> LLLMMMCHDPO(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] byte? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<GBFGLFBMEEE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA7C0", Offset = "0x1FE9BC0", VA = "0x181FEA7C0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<ALBOPLJHKOM>> LIDFMAICMBL(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<ALBOPLJHKOM>? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<ALBOPLJHKOM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA6D0", Offset = "0x1FE9AD0", VA = "0x181FEA6D0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> GBLCLNFPBEL(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] GDBGOOJOMPI? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2C21DD0", Offset = "0x2C211D0", VA = "0x182C21DD0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<T>>> OAONJJKJLDK<T>(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<T>>? OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FE44B0", Offset = "0x1FE38B0", VA = "0x181FE44B0")]
	public static void ONAGJGGJHGM(this PCPLEDLJHDN<byte> ABPJKOBADEP, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>> JMBEPIIBJDM, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2C21D00", Offset = "0x2C21100", VA = "0x182C21D00")]
	public static void GBPCNLDCFIH<T>(this PCPLEDLJHDN<byte> ABPJKOBADEP, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<T>>> JJBIHGLNEFN, DFKPAEMPCKH<MHCHLGAGEPI<T>> OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C21D00", Offset = "0x2C21100", VA = "0x182C21D00")]
	public static void FEIPIONDAJC<T>(this PCPLEDLJHDN<byte> ABPJKOBADEP, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<T>>> CDAOGBEDNOP, DFKPAEMPCKH<IKPMLKELNKD<T>> OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FAHGOAIECNL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA280", Offset = "0x1FE9680", VA = "0x181FEA280")]
	public static KOIDIICODKL JDPMPPBBEGP([In] this ReadOnlySpan<byte> PLMCKIPFEOJ, int MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA2F0", Offset = "0x1FE96F0", VA = "0x181FEA2F0")]
	public static KOIDIICODKL JDPMPPBBEGP([In] this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A790", Offset = "0x2B49B90", VA = "0x182B4A790")]
	public static KOIDIICODKL JDPMPPBBEGP<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A630", Offset = "0x2B49A30", VA = "0x182B4A630")]
	public static KOIDIICODKL JDPMPPBBEGP<M>([In] this KOPENLPFCKJ<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A240", Offset = "0x2B49640", VA = "0x182B4A240")]
	public static KOIDIICODKL JDPMPPBBEGP<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A3B0", Offset = "0x2B497B0", VA = "0x182B4A3B0")]
	public static KOIDIICODKL JDPMPPBBEGP<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A570", Offset = "0x2B49970", VA = "0x182B4A570")]
	public static KOIDIICODKL JDPMPPBBEGP<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA280", Offset = "0x1FE9680", VA = "0x181FEA280")]
	public static int LLCMKBIHFEL([In] this ReadOnlySpan<byte> PLMCKIPFEOJ, int MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4590", Offset = "0x1FE3990", VA = "0x181FE4590")]
	public static int LLCMKBIHFEL([In] this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8D10", VA = "0x1828F9910")]
	public static int LLCMKBIHFEL<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8D10", VA = "0x1828F9910")]
	public static int LLCMKBIHFEL<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8D10", VA = "0x1828F9910")]
	public static int LLCMKBIHFEL<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8D10", VA = "0x1828F9910")]
	public static int LLCMKBIHFEL<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AB10", Offset = "0x2B49F10", VA = "0x182B4AB10")]
	public static float NJIFLPFCMIM<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AB10", Offset = "0x2B49F10", VA = "0x182B4AB10")]
	public static float NJIFLPFCMIM<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AB10", Offset = "0x2B49F10", VA = "0x182B4AB10")]
	public static float NJIFLPFCMIM<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A2A0", Offset = "0x2B496A0", VA = "0x182B4A2A0")]
	public static byte AJIFIONDFCE<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A390", Offset = "0x2B49790", VA = "0x182B4A390")]
	public static byte AJIFIONDFCE<M>([In] this KOPENLPFCKJ<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A240", Offset = "0x2B49640", VA = "0x182B4A240")]
	public static byte AJIFIONDFCE<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A3B0", Offset = "0x2B497B0", VA = "0x182B4A3B0")]
	public static byte AJIFIONDFCE<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A2D0", Offset = "0x2B496D0", VA = "0x182B4A2D0")]
	public static byte AJIFIONDFCE<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4590", Offset = "0x1FE3990", VA = "0x181FE4590")]
	public static GDBGOOJOMPI JIHKJKHCLPM([In] this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI)
	{
		return default(GDBGOOJOMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28F9910", Offset = "0x28F8D10", VA = "0x1828F9910")]
	public static GDBGOOJOMPI JIHKJKHCLPM<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(GDBGOOJOMPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A500", Offset = "0x2B49900", VA = "0x182B4A500")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> CMNEFGEIAGP<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A420", Offset = "0x2B49820", VA = "0x182B4A420")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> CMNEFGEIAGP<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A490", Offset = "0x2B49890", VA = "0x182B4A490")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> CMNEFGEIAGP<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A1D0", Offset = "0x2B495D0", VA = "0x182B4A1D0")]
	public static DFKPAEMPCKH<IKPMLKELNKD<OMICMMHGCKE>> AAGLFCOJNOO<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<IKPMLKELNKD<OMICMMHGCKE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AAA0", Offset = "0x2B49EA0", VA = "0x182B4AAA0")]
	public static DFKPAEMPCKH<ALBOPLJHKOM> NFGPEAEMKGK<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<ALBOPLJHKOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A9C0", Offset = "0x2B49DC0", VA = "0x182B4A9C0")]
	public static DFKPAEMPCKH<ALBOPLJHKOM> NFGPEAEMKGK<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<ALBOPLJHKOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AA30", Offset = "0x2B49E30", VA = "0x182B4AA30")]
	public static DFKPAEMPCKH<ALBOPLJHKOM> NFGPEAEMKGK<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<ALBOPLJHKOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A950", Offset = "0x2B49D50", VA = "0x182B4A950")]
	public static DFKPAEMPCKH<EHPHFEHIOBB> NFAKPGHNDAN<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<EHPHFEHIOBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A8E0", Offset = "0x2B49CE0", VA = "0x182B4A8E0")]
	public static DFKPAEMPCKH<EHPHFEHIOBB> NFAKPGHNDAN<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<EHPHFEHIOBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AB50", Offset = "0x2B49F50", VA = "0x182B4AB50")]
	public static DFKPAEMPCKH<LMIGEMJAMLD> NODMBAPDIIA<M>(this LNNPJBHEINB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI)
	{
		return default(DFKPAEMPCKH<LMIGEMJAMLD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DCAEHFJNIDA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4690", Offset = "0x1FE3A90", VA = "0x181FE4690")]
	public static void BKDBKDEKNFB(this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, KOIDIICODKL OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE45A0", Offset = "0x1FE39A0", VA = "0x181FE45A0")]
	public static void BKDBKDEKNFB(this byte[] PLMCKIPFEOJ, int MNFLPNCDDMI, KOIDIICODKL OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4610", Offset = "0x1FE3A10", VA = "0x181FE4610")]
	public static void BKDBKDEKNFB([In] this Span<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, KOIDIICODKL OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29946A0", Offset = "0x2993AA0", VA = "0x1829946A0")]
	public static void BKDBKDEKNFB<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, KOIDIICODKL OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2994500", Offset = "0x2993900", VA = "0x182994500")]
	public static void BKDBKDEKNFB<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, KOIDIICODKL OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FE44B0", Offset = "0x1FE38B0", VA = "0x181FE44B0")]
	public static void ONAGJGGJHGM(this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4880", Offset = "0x1FE3C80", VA = "0x181FE4880")]
	public static void ONAGJGGJHGM(this byte[] PLMCKIPFEOJ, int MNFLPNCDDMI, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4800", Offset = "0x1FE3C00", VA = "0x181FE4800")]
	public static void ONAGJGGJHGM([In] this Span<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29949A0", Offset = "0x2993DA0", VA = "0x1829949A0")]
	public static void ONAGJGGJHGM<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2994A00", Offset = "0x2993E00", VA = "0x182994A00")]
	public static void ONAGJGGJHGM<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4750", Offset = "0x1FE3B50", VA = "0x181FE4750")]
	public static void EJCDGJHEEPB(this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2994840", Offset = "0x2993C40", VA = "0x182994840")]
	public static void EJCDGJHEEPB<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29948A0", Offset = "0x2993CA0", VA = "0x1829948A0")]
	public static void EJCDGJHEEPB<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4790", Offset = "0x1FE3B90", VA = "0x181FE4790")]
	public static void HOJPMKKBMEE(this PCPLEDLJHDN<byte> PLMCKIPFEOJ, int MNFLPNCDDMI, byte OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2994900", Offset = "0x2993D00", VA = "0x182994900")]
	public static void HOJPMKKBMEE<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, byte OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2994950", Offset = "0x2993D50", VA = "0x182994950")]
	public static void HOJPMKKBMEE<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, byte OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28F9CC0", Offset = "0x28F90C0", VA = "0x1828F9CC0")]
	public static void GBPCNLDCFIH<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28F9CC0", Offset = "0x28F90C0", VA = "0x1828F9CC0")]
	public static void GBPCNLDCFIH<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28F9CC0", Offset = "0x28F90C0", VA = "0x1828F9CC0")]
	public static void PCMLDFMLMOO<M>(this ADPFOAGAIMM<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, DFKPAEMPCKH<ALBOPLJHKOM> OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28F9CC0", Offset = "0x28F90C0", VA = "0x1828F9CC0")]
	public static void PCMLDFMLMOO<M>([In] this PODJMHNEFPB<M, byte> PLMCKIPFEOJ, DFKPAEMPCKH<M> MNFLPNCDDMI, DFKPAEMPCKH<ALBOPLJHKOM> OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DGBNPOIEOFA
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5D90", Offset = "0x1FE5190", VA = "0x181FE5D90")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) DCLOLLMPGFF(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6030", Offset = "0x1FE5430", VA = "0x181FE6030")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) DNAEKKIGNIC(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA160", Offset = "0x1FE9560", VA = "0x181FEA160")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) PPAGIMIMLCK(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5080", Offset = "0x1FE4480", VA = "0x181FE5080")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) BFJLGOLGPIL(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8F40", Offset = "0x1FE8340", VA = "0x181FE8F40")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) LOLMBBOACDH(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6E80", Offset = "0x1FE6280", VA = "0x181FE6E80")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) FGADJPMDFGN(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8C90", Offset = "0x1FE8090", VA = "0x181FE8C90")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) KOBLLOIGAEP(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9E90", Offset = "0x1FE9290", VA = "0x181FE9E90")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) PFPKONIFOPD(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6180", Offset = "0x1FE5580", VA = "0x181FE6180")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) DOJELKDPGOH(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5B20", Offset = "0x1FE4F20", VA = "0x181FE5B20")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>) CMIHIMADLHG(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? OBEEJPGJPFD, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? HBPENMPNJMK)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8B70", Offset = "0x1FE7F70", VA = "0x181FE8B70")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>) KHDNMGHKBON(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? OBEEJPGJPFD, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? HBPENMPNJMK)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7500", Offset = "0x1FE6900", VA = "0x181FE7500")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>) GFPNHJPPAPB(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? OBEEJPGJPFD, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? HBPENMPNJMK)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5F10", Offset = "0x1FE5310", VA = "0x181FE5F10")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>) DMELOBFEGEJ(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? OBEEJPGJPFD, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? HBPENMPNJMK)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6A60", Offset = "0x1FE5E60", VA = "0x181FE6A60")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<EHPHFEHIOBB>>) EMLHKJBDEKI(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? NMMGFEAPHED, [Optional] DFKPAEMPCKH<EHPHFEHIOBB>? IAJCFKFGJIF)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<EHPHFEHIOBB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6FA0", Offset = "0x1FE63A0", VA = "0x181FE6FA0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<EHPHFEHIOBB>>>) FGAFBJCADCP(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? NMMGFEAPHED, [Optional] DFKPAEMPCKH<IKPMLKELNKD<EHPHFEHIOBB>>? IAJCFKFGJIF)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<EHPHFEHIOBB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7C10", Offset = "0x1FE7010", VA = "0x181FE7C10")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<ALBOPLJHKOM>>) IHPLIBOOPMB(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? NMMGFEAPHED, [Optional] DFKPAEMPCKH<ALBOPLJHKOM>? IAJCFKFGJIF)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<ALBOPLJHKOM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5740", Offset = "0x1FE4B40", VA = "0x181FE5740")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<ALBOPLJHKOM>>>) CEMHBMMNNEK(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? NMMGFEAPHED, [Optional] DFKPAEMPCKH<IKPMLKELNKD<ALBOPLJHKOM>>? IAJCFKFGJIF)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<ALBOPLJHKOM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29968A0", Offset = "0x2995CA0", VA = "0x1829968A0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>) DNNLIBKFOGA<TMarker>(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<LMIGEMJAMLD>? IAJCFKFGJIF, [Optional][In] ReadOnlySpan<byte> LDNEPNAGEGN)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9D60", Offset = "0x1FE9160", VA = "0x181FE9D60")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) PCFOGAOMPKE(this PCPLEDLJHDN<byte> ABPJKOBADEP, int FIJIJLPKIHA, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KFGKPLPCACH)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8050", Offset = "0x1FE7450", VA = "0x181FE8050")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) IOGFJFELCII(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? FIJIJLPKIHA, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KFGKPLPCACH)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2996BF0", Offset = "0x2995FF0", VA = "0x182996BF0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>) NEEDCMOIJPL<TMarker>(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<TMarker>>? KFGKPLPCACH, [Optional] int? CGDIEJGGJMK, [Optional][In] ReadOnlySpan<byte> FIJIJLPKIHA)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2996AA0", Offset = "0x2995EA0", VA = "0x182996AA0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>) FLGAILPNDGI<TMarker>(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<TMarker>>? FIJIJLPKIHA, [Optional] DFKPAEMPCKH<IKPMLKELNKD<TMarker>>? KFGKPLPCACH, [Optional] int? CGDIEJGGJMK)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<TMarker>>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FE96A0", Offset = "0x1FE8AA0", VA = "0x181FE96A0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) NIOCMMAMNDI(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FE70B0", Offset = "0x1FE64B0", VA = "0x181FE70B0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) FLPLEADFMJH(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FE73E0", Offset = "0x1FE67E0", VA = "0x181FE73E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) FOIHNGIHABL(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6D20", Offset = "0x1FE6120", VA = "0x181FE6D20")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) FDMLPBHJLEJ(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7AC0", Offset = "0x1FE6EC0", VA = "0x181FE7AC0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) IBJBJJCIJJB(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6540", Offset = "0x1FE5940", VA = "0x181FE6540")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) EGBIDAFCEGB(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9AB0", Offset = "0x1FE8EB0", VA = "0x181FE9AB0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) OJKKMLCBGOG(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9C10", Offset = "0x1FE9010", VA = "0x181FE9C10")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) OPCNBDPKLOH(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9460", Offset = "0x1FE8860", VA = "0x181FE9460")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) NGGKFCKLNOH(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7770", Offset = "0x1FE6B70", VA = "0x181FE7770")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>) GPKCFGNMMAA(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? MEAHMAFFPAM)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6780", Offset = "0x1FE5B80", VA = "0x181FE6780")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) EKMNGCEHPCM(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FE87E0", Offset = "0x1FE7BE0", VA = "0x181FE87E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) JKBCNMDEKDF(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9820", Offset = "0x1FE8C20", VA = "0x181FE9820")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) NOEIEBALKIM(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6900", Offset = "0x1FE5D00", VA = "0x181FE6900")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) ELCMFPBJACO(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8690", Offset = "0x1FE7A90", VA = "0x181FE8690")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) JJLBCADHFKF(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4F60", Offset = "0x1FE4360", VA = "0x181FE4F60")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) AOHMPIFDADG(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9FE0", Offset = "0x1FE93E0", VA = "0x181FE9FE0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) POLJIEKHLIB(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8530", Offset = "0x1FE7930", VA = "0x181FE8530")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) JIGONOIKPLB(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FE54B0", Offset = "0x1FE48B0", VA = "0x181FE54B0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) CDIANAHCIIC(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9950", Offset = "0x1FE8D50", VA = "0x181FE9950")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) NPPBGKCMING(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FE91E0", Offset = "0x1FE85E0", VA = "0x181FE91E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) MEENBKODGLO(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9580", Offset = "0x1FE8980", VA = "0x181FE9580")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) NILHFCHAGMG(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE62A0", Offset = "0x1FE56A0", VA = "0x181FE62A0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) DPJEMFNKHDB(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7280", Offset = "0x1FE6680", VA = "0x181FE7280")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) FOGABMIDJIB(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4900", Offset = "0x1FE3D00", VA = "0x181FE4900")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) AAFFEPIPAFA(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7610", Offset = "0x1FE6A10", VA = "0x181FE7610")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) GILJAOIBKAH(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7860", Offset = "0x1FE6C60", VA = "0x181FE7860")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) HDLOMHIHNEP(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6420", Offset = "0x1FE5820", VA = "0x181FE6420")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) EEMKECFBCPJ(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7DB0", Offset = "0x1FE71B0", VA = "0x181FE7DB0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) ILFIPKMMLIB(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5C30", Offset = "0x1FE5030", VA = "0x181FE5C30")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) CODGCOFJICM(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9330", Offset = "0x1FE8730", VA = "0x181FE9330")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) NALIDECNCHA(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4CA0", Offset = "0x1FE40A0", VA = "0x181FE4CA0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) AIFMPLNLJFM(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8DF0", Offset = "0x1FE81F0", VA = "0x181FE8DF0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) KOILGAPPGPC(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8A50", Offset = "0x1FE7E50", VA = "0x181FE8A50")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) KEJGJEOJBMD(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5330", Offset = "0x1FE4730", VA = "0x181FE5330")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) CDCMABGDFHK(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4A30", Offset = "0x1FE3E30", VA = "0x181FE4A30")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) ACLNJDJGIAO(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6660", Offset = "0x1FE5A60", VA = "0x181FE6660")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) EJHHHLGPCPB(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE55E0", Offset = "0x1FE49E0", VA = "0x181FE55E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) CEENIMGLONO(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE83E0", Offset = "0x1FE77E0", VA = "0x181FE83E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) JGOAACGJKOF(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7F30", Offset = "0x1FE7330", VA = "0x181FE7F30")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) IMNPNDALBIF(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE79B0", Offset = "0x1FE6DB0", VA = "0x181FE79B0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) HMPONLFMEGI(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] int? IBIJOOBGIJK, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8940", Offset = "0x1FE7D40", VA = "0x181FE8940")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) KAMHMEHAKJE(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? IBIJOOBGIJK, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7200", Offset = "0x1FE6600", VA = "0x181FE7200")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> FOFMKFKBOPJ(this PCPLEDLJHDN<byte> ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FE59A0", Offset = "0x1FE4DA0", VA = "0x181FE59A0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) CGNNAFJCEGH(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9090", Offset = "0x1FE8490", VA = "0x181FE9090")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) MACCFBOGFLJ(this PCPLEDLJHDN<byte> ABPJKOBADEP, float KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LJJLEELIGLI>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8160", Offset = "0x1FE7560", VA = "0x181FE8160")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>) IPIFIMOLALI(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<LJJLEELIGLI>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<LJJLEELIGLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4E00", Offset = "0x1FE4200", VA = "0x181FE4E00")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) AJKKGDEEGHN(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FE51E0", Offset = "0x1FE45E0", VA = "0x181FE51E0")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) BGHJPBCDGBC(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6C00", Offset = "0x1FE6000", VA = "0x181FE6C00")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) FCNCBFDEDKP(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8280", Offset = "0x1FE7680", VA = "0x181FE8280")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) JCJFNALHEOL(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5850", Offset = "0x1FE4C50", VA = "0x181FE5850")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) CFGMNIACPLN(this PCPLEDLJHDN<byte> ABPJKOBADEP, int KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4B80", Offset = "0x1FE3F80", VA = "0x181FE4B80")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>) AIBHJOHNANI(this PCPLEDLJHDN<byte> ABPJKOBADEP, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? KNNDCNIIFGC, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? LLOJENMANAJ, [Optional] DFKPAEMPCKH<IKPMLKELNKD<PJBCDDGDFDM>>? COOJCFHJMFO)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<PJBCDDGDFDM>>>));
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
