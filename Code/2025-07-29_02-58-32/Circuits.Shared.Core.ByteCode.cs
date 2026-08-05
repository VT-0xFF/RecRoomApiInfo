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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5DD60", Offset = "0x2A5C760", VA = "0x182A5DD60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JGLMMLPMFAM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C40190", Offset = "0x3C3EB90", VA = "0x183C40190")]
	public static COBPPOBACAG<EIIIOAJCEPD<M>> FOCAGDKEGJD<M>(this int NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D610", Offset = "0x2A5C010", VA = "0x182A5D610")]
	public static COBPPOBACAG<KGIFHJJEBBG> FJKHIHCGDKI(this int NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<KGIFHJJEBBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C40190", Offset = "0x3C3EB90", VA = "0x183C40190")]
	public static COBPPOBACAG<MLOCJABKMLJ<M>> FDMFHMPJIFE<M>(this int NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<MLOCJABKMLJ<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EIIIOAJCEPD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PLPNJALFIND
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AOALJIIJMIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KGIFHJJEBBG
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AALHAEKNAFA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FICOCMEEINI
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BFHDKEFBEOP
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
public static class DDNLBDJGEPI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct CBMHOMCAPML<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr BEIIPNIOBFN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
		public CBMHOMCAPML(IntPtr JDFAIEBLNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69621B0", Offset = "0x6960BB0", VA = "0x1869621B0")]
		public int ELEPNCJAFML(TDeps MADJNKEDNDC, TContext HBBBMBPBDCO, TCompileState EHLPLKANNDI, [In] GNGEHCNCBFJ<byte> ADDNKJJIBOJ, int CGEHFMOCKHC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4580", Offset = "0x3AB2F80", VA = "0x183AB4580")]
	public static void ELCDEFDPCMA<TDeps, TContext, TCompileState>(TDeps MADJNKEDNDC, TContext HBBBMBPBDCO, TCompileState EHLPLKANNDI, [In] GNGEHCNCBFJ<byte> OJIPOLDHHDD, GNGEHCNCBFJ<byte> JIENMCFLFHJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IHEJKLBCCFG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? KNFMJDPLOLF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LLFBDBEFBOD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FEKLIDPKDDF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? GDAIKPAGPAG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BELIGONCDDB, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PJBCOJKAHAE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FGIOJOGAPPD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LKPHEHLJNIE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EPEAHLOJBFP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NEEOEIEFNCB, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DIJDHMPEAAD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ICODFEPMFNE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? GNAKPPDMAKI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ACLFDNJGFIA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ANOHMKCMGJL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AFHKEJOMDIA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HLHBAGDBPNO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MPEOOLKGDFH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MBMBPOCLNOD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AKIGHBHNMPE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AHOCBOIDGAH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LJLKLKNKDIL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AOKIJFNCHEI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AALPEIOJEMF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DKKEDDKGDBN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HFMNFBAEEKG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PLHKHJCKEAB, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MAEODGLOGID, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? CGBDPLFPHHE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NHDDOAKEDMO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IDGLKBDHHHH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ECICOGJBEBJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EJFKJHMFGFN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ODODCMOCBPN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HEIAGOONDPP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PGNCHFDPBCE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NHMLFMEDFDP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BBEBGNIINNM, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EFCGIDCCAGJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FNNLAFIELHD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NHAMKIHICPH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IGHEJHIHLNO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LDGHHNFJENH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? CJNCLDJGJEL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MHBMMNACEGJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LPHPCEDMAEG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? GMIHPGOCLMO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HDNFGKCEFJA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? CBCAGMAKMGP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DHJEKAKEOKL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EGNLDAGIJEO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ADJEJBDPLBL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PGJODCGDAOE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OEONJFCHEAP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AOMIBNEFMFO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MPFMPMILFPI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LGKJOOEILHA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HLFJBCABIIJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OLGFINDJMIG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HAJOHNOOLGE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MGKNOKAIECL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? INJHGGGMPNP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LHLBLNKDFDJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LKCGGMJPILL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? MBNDIDNKGAA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? KBGGNLIJBJF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HNKIDOJDFEP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ONNLPKCCHEH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DNMJCEBCFBL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NOPDAPLGHPA, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PINECOKAMIO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HKADIHOJOAM, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LCCCPLAMFCE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? APHAHGGOGMI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EFELHEAFIBD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PPMFCAHOIFD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LCIOLINEDNN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NOELFBMMMFD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LEFPPPKDFOK, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DENAJPOGGCM, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DPECFEHGLAD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? POEMAJFMOBB, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? CAKONGCOEHG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? PEECJMMFFLP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? ELEDIFEGKCH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OGGFKOLGGLE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HNLLBHKIMAF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? JEILMBMPFPD, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? JLOBLDNHIAJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EMOBLFCJLEG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HCBONEEFEIH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AAAFPNJJCPH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OOCECGNIKLL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LEPAAMFCJEP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IBPHDLKOLBO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EOGLHDGALHH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? GHGCEJKKFEO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BECJHJPEFAI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? KCLMLDHODLO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LPCGJHDABLJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OLHNIAPLANN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NEPCFMIFFNJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LAPPEDJNNAC, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? GLAHDEFBPGG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BILDPLAMMKJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NALJJFJKIBE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FMPLAMALMNO, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? JJNNNDBMHJJ, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? KCDBMDNFODG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BKDKGICJIII, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? HNJPNIMGFHL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DLEDNIPPFEP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IHDKFJAECAC, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EALPAJJCKDL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DAHALNBLJPC, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AGGHGABAOJC, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NAMOFJOFAKL, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IECGKMFAHFP, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? IKKBIFNEAMB, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LMBOIIIKMKI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OCCPDMGNPPK, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FIGLLEKJOPG, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AEKMLMBGEHC, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? APGIBAFLIDF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? LJFFJPLFCLE, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? OIFJJDJNCAN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? KCPJFCMOGCF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AFJOOOANEJK, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? BGCPNPBJNLF, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? EKCDPDEOOFN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? AACNPNHKKOI, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? FFMIMOKDKLH, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? NIKMACCMJMN, [Optional] CBMHOMCAPML<TContext, TDeps, TCompileState>? DALOGNEIFIN) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A57BF0", Offset = "0x2A565F0", VA = "0x182A57BF0")]
	private static int KIGPGDCPGBJ([In] GNGEHCNCBFJ<byte> LJJKDPNMLNL, GNGEHCNCBFJ<byte> GHCLINPMECF, int PAEPPOFDFDK, int CDCPIGCEABM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MDJNGKGMBDM
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int BFADPCGKBEO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3DA02D0", Offset = "0x3D9ECD0", VA = "0x183DA02D0")]
	public static COBPPOBACAG<EIIIOAJCEPD<T>> MNBEPFNIOLI<T>([In] this GNGEHCNCBFJ<byte> NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0140", Offset = "0x3D9EB40", VA = "0x183DA0140")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<T>>> BLCKAJPKJKC<T>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<EIIIOAJCEPD<T>>? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DAB0", Offset = "0x2A5C4B0", VA = "0x182A5DAB0")]
	public static COBPPOBACAG<EIIIOAJCEPD<COKJODFCCBA>> LDFFBJGHDBD(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<COKJODFCCBA>? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<COKJODFCCBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D840", Offset = "0x2A5C240", VA = "0x182A5D840")]
	public static COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>> DFHKGCOMEKC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] float? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D9E0", Offset = "0x2A5C3E0", VA = "0x182A5D9E0")]
	public static COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>> JDNPEPNGNGC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DC50", Offset = "0x2A5C650", VA = "0x182A5DC50")]
	public static COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>> PBIBENONENK(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<JIAAFONGLED>? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D750", Offset = "0x2A5C150", VA = "0x182A5D750")]
	public static COBPPOBACAG<EIIIOAJCEPD<FICOCMEEINI>> CIINEALBACG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] byte? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<FICOCMEEINI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DB80", Offset = "0x2A5C580", VA = "0x182A5DB80")]
	public static COBPPOBACAG<EIIIOAJCEPD<KGIFHJJEBBG>> MDANBEKPLHA(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<KGIFHJJEBBG>? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<KGIFHJJEBBG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D910", Offset = "0x2A5C310", VA = "0x182A5D910")]
	public static COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> GPFHOODCNOJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] BFHDKEFBEOP? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0210", Offset = "0x3D9EC10", VA = "0x183DA0210")]
	public static COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<T>>> FNNFNBGDEAP<T>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<T>>? PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A577A0", Offset = "0x2A561A0", VA = "0x182A577A0")]
	public static void IMPNDCNDDEH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>> GFAJAKHLNLG, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0200", Offset = "0x3D9EC00", VA = "0x183DA0200")]
	public static void FHLJOPLOLMA<T>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<T>>> CGEHFMOCKHC, COBPPOBACAG<EIIIOAJCEPD<T>> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0200", Offset = "0x3D9EC00", VA = "0x183DA0200")]
	public static void CCFLFCDHMFA<T>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<T>>> BNFFAEBEFDG, COBPPOBACAG<MLOCJABKMLJ<T>> PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LEIKLFIEDEG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D640", Offset = "0x2A5C040", VA = "0x182A5D640")]
	public static LOALHEIKMIM EEJMMBLHCPI([In] this ReadOnlySpan<byte> LHALFHPGBPD, int KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D6B0", Offset = "0x2A5C0B0", VA = "0x182A5D6B0")]
	public static LOALHEIKMIM EEJMMBLHCPI([In] this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A3E0", Offset = "0x3D38DE0", VA = "0x183D3A3E0")]
	public static LOALHEIKMIM EEJMMBLHCPI<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A610", Offset = "0x3D39010", VA = "0x183D3A610")]
	public static LOALHEIKMIM EEJMMBLHCPI<M>([In] this MPADBDFBIOM<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A560", Offset = "0x3D38F60", VA = "0x183D3A560")]
	public static LOALHEIKMIM EEJMMBLHCPI<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A5B0", Offset = "0x3D38FB0", VA = "0x183D3A5B0")]
	public static LOALHEIKMIM EEJMMBLHCPI<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A4F0", Offset = "0x3D38EF0", VA = "0x183D3A4F0")]
	public static LOALHEIKMIM EEJMMBLHCPI<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D640", Offset = "0x2A5C040", VA = "0x182A5D640")]
	public static int MIIBNLNONBC([In] this ReadOnlySpan<byte> LHALFHPGBPD, int KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A57880", Offset = "0x2A56280", VA = "0x182A57880")]
	public static int MIIBNLNONBC([In] this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CB0", Offset = "0x3CF36B0", VA = "0x183CF4CB0")]
	public static int MIIBNLNONBC<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CB0", Offset = "0x3CF36B0", VA = "0x183CF4CB0")]
	public static int MIIBNLNONBC<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CB0", Offset = "0x3CF36B0", VA = "0x183CF4CB0")]
	public static int MIIBNLNONBC<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CB0", Offset = "0x3CF36B0", VA = "0x183CF4CB0")]
	public static int MIIBNLNONBC<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A960", Offset = "0x3D39360", VA = "0x183D3A960")]
	public static float OEKAOPKNHDI<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A960", Offset = "0x3D39360", VA = "0x183D3A960")]
	public static float OEKAOPKNHDI<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A960", Offset = "0x3D39360", VA = "0x183D3A960")]
	public static float OEKAOPKNHDI<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AA10", Offset = "0x3D39410", VA = "0x183D3AA10")]
	public static byte OJGDOGKJMPJ<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A980", Offset = "0x3D39380", VA = "0x183D3A980")]
	public static byte OJGDOGKJMPJ<M>([In] this MPADBDFBIOM<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A560", Offset = "0x3D38F60", VA = "0x183D3A560")]
	public static byte OJGDOGKJMPJ<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A5B0", Offset = "0x3D38FB0", VA = "0x183D3A5B0")]
	public static byte OJGDOGKJMPJ<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A9A0", Offset = "0x3D393A0", VA = "0x183D3A9A0")]
	public static byte OJGDOGKJMPJ<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A57880", Offset = "0x2A56280", VA = "0x182A57880")]
	public static BFHDKEFBEOP BODIPNFNJEB([In] this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI)
	{
		return default(BFHDKEFBEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4CB0", Offset = "0x3CF36B0", VA = "0x183CF4CB0")]
	public static BFHDKEFBEOP BODIPNFNJEB<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(BFHDKEFBEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AAA0", Offset = "0x3D394A0", VA = "0x183D3AAA0")]
	public static COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PLLEJBIMPPK<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AA40", Offset = "0x3D39440", VA = "0x183D3AA40")]
	public static COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PLLEJBIMPPK<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AB00", Offset = "0x3D39500", VA = "0x183D3AB00")]
	public static COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PLLEJBIMPPK<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A380", Offset = "0x3D38D80", VA = "0x183D3A380")]
	public static COBPPOBACAG<MLOCJABKMLJ<LPPGLHMNLFG>> BBEDBAHFOCB<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<MLOCJABKMLJ<LPPGLHMNLFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A840", Offset = "0x3D39240", VA = "0x183D3A840")]
	public static COBPPOBACAG<KGIFHJJEBBG> JPHBAIMLINH<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<KGIFHJJEBBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A7E0", Offset = "0x3D391E0", VA = "0x183D3A7E0")]
	public static COBPPOBACAG<KGIFHJJEBBG> JPHBAIMLINH<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<KGIFHJJEBBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A780", Offset = "0x3D39180", VA = "0x183D3A780")]
	public static COBPPOBACAG<KGIFHJJEBBG> JPHBAIMLINH<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<KGIFHJJEBBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A8A0", Offset = "0x3D392A0", VA = "0x183D3A8A0")]
	public static COBPPOBACAG<COKJODFCCBA> LHAGFJANFHP<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<COKJODFCCBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A900", Offset = "0x3D39300", VA = "0x183D3A900")]
	public static COBPPOBACAG<COKJODFCCBA> LHAGFJANFHP<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<COKJODFCCBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A720", Offset = "0x3D39120", VA = "0x183D3A720")]
	public static COBPPOBACAG<JIAAFONGLED> IIKOINLNCMP<M>(this DKFNNOJMGBI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI)
	{
		return default(COBPPOBACAG<JIAAFONGLED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AEMMNHFNHOM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A578D0", Offset = "0x2A562D0", VA = "0x182A578D0")]
	public static void GBEPHJEDNNO(this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI, LOALHEIKMIM PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A57990", Offset = "0x2A56390", VA = "0x182A57990")]
	public static void GBEPHJEDNNO(this byte[] LHALFHPGBPD, int KINAHJPOBLI, LOALHEIKMIM PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A00", Offset = "0x2A56400", VA = "0x182A57A00")]
	public static void GBEPHJEDNNO([In] this Span<byte> LHALFHPGBPD, int KINAHJPOBLI, LOALHEIKMIM PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31C3B00", Offset = "0x31C2500", VA = "0x1831C3B00")]
	public static void GBEPHJEDNNO<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, LOALHEIKMIM PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x31C3BF0", Offset = "0x31C25F0", VA = "0x1831C3BF0")]
	public static void GBEPHJEDNNO<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, LOALHEIKMIM PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A577A0", Offset = "0x2A561A0", VA = "0x182A577A0")]
	public static void IMPNDCNDDEH(this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A80", Offset = "0x2A56480", VA = "0x182A57A80")]
	public static void IMPNDCNDDEH(this byte[] LHALFHPGBPD, int KINAHJPOBLI, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A57B00", Offset = "0x2A56500", VA = "0x182A57B00")]
	public static void IMPNDCNDDEH([In] this Span<byte> LHALFHPGBPD, int KINAHJPOBLI, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31C3CE0", Offset = "0x31C26E0", VA = "0x1831C3CE0")]
	public static void IMPNDCNDDEH<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31C3D30", Offset = "0x31C2730", VA = "0x1831C3D30")]
	public static void IMPNDCNDDEH<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A57890", Offset = "0x2A56290", VA = "0x182A57890")]
	public static void FNPMFLBDICN(this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A60", Offset = "0x31C2460", VA = "0x1831C3A60")]
	public static void FNPMFLBDICN<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31C3AB0", Offset = "0x31C24B0", VA = "0x1831C3AB0")]
	public static void FNPMFLBDICN<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A57B80", Offset = "0x2A56580", VA = "0x182A57B80")]
	public static void KHPGMEAGJMH(this GNGEHCNCBFJ<byte> LHALFHPGBPD, int KINAHJPOBLI, byte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31C3DB0", Offset = "0x31C27B0", VA = "0x1831C3DB0")]
	public static void KHPGMEAGJMH<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, byte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31C3D80", Offset = "0x31C2780", VA = "0x1831C3D80")]
	public static void KHPGMEAGJMH<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, byte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A50", Offset = "0x31C2450", VA = "0x1831C3A50")]
	public static void FHLJOPLOLMA<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A50", Offset = "0x31C2450", VA = "0x1831C3A50")]
	public static void FHLJOPLOLMA<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A50", Offset = "0x31C2450", VA = "0x1831C3A50")]
	public static void DHKNPBEGBLP<M>(this PCAFLGCMOOA<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, COBPPOBACAG<KGIFHJJEBBG> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31C3A50", Offset = "0x31C2450", VA = "0x1831C3A50")]
	public static void DHKNPBEGBLP<M>([In] this FJGFBBDMKOI<M, byte> LHALFHPGBPD, COBPPOBACAG<M> KINAHJPOBLI, COBPPOBACAG<KGIFHJJEBBG> PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DOPNNEDPGEI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A59FF0", Offset = "0x2A589F0", VA = "0x182A59FF0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) GEMMKHAOGPF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A581D0", Offset = "0x2A56BD0", VA = "0x182A581D0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) AJEIBNKAHGF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A5BF50", Offset = "0x2A5A950", VA = "0x182A5BF50")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) LIPLCKAMHAP(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C5D0", Offset = "0x2A5AFD0", VA = "0x182A5C5D0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) MJIJAGKOHCG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AFA0", Offset = "0x2A599A0", VA = "0x182A5AFA0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) JOJFACICKME(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D390", Offset = "0x2A5BD90", VA = "0x182A5D390")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) PNNJDOGLIGO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D4B0", Offset = "0x2A5BEB0", VA = "0x182A5D4B0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) PPHEJNADODI(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A58B90", Offset = "0x2A57590", VA = "0x182A58B90")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) CGFNOOENMFG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A5C0", Offset = "0x2A58FC0", VA = "0x182A5A5C0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) GPPJCEJOACM(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A599A0", Offset = "0x2A583A0", VA = "0x182A599A0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>) ENKCOGKMFOH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? PDKJBMPOMNC, [Optional] COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? GNDHPAINOCL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A5BA90", Offset = "0x2A5A490", VA = "0x182A5BA90")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>) LDJGLNKAMJM(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? PDKJBMPOMNC, [Optional] COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? GNDHPAINOCL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A59250", Offset = "0x2A57C50", VA = "0x182A59250")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>) DGHPIBLIFFA(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? PDKJBMPOMNC, [Optional] COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? GNDHPAINOCL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CC60", Offset = "0x2A5B660", VA = "0x182A5CC60")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>) NNHBCJBFPFN(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? PDKJBMPOMNC, [Optional] COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? GNDHPAINOCL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B7D0", Offset = "0x2A5A1D0", VA = "0x182A5B7D0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<COKJODFCCBA>>) KOHFEKMDMLK(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? LEAGCHOOIEE, [Optional] COBPPOBACAG<COKJODFCCBA>? JENFFPGIJNL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<COKJODFCCBA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AAC0", Offset = "0x2A594C0", VA = "0x182A5AAC0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<COKJODFCCBA>>>) IJHFLBLNFDL(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? LEAGCHOOIEE, [Optional] COBPPOBACAG<MLOCJABKMLJ<COKJODFCCBA>>? JENFFPGIJNL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<COKJODFCCBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A58640", Offset = "0x2A57040", VA = "0x182A58640")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<KGIFHJJEBBG>>) BJKIJAMLCAC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? LEAGCHOOIEE, [Optional] COBPPOBACAG<KGIFHJJEBBG>? JENFFPGIJNL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<KGIFHJJEBBG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C190", Offset = "0x2A5AB90", VA = "0x182A5C190")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<KGIFHJJEBBG>>>) MACBOKGPCCN(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? LEAGCHOOIEE, [Optional] COBPPOBACAG<MLOCJABKMLJ<KGIFHJJEBBG>>? JENFFPGIJNL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<KGIFHJJEBBG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AC18C0", Offset = "0x3AC02C0", VA = "0x183AC18C0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>) GPIHNLBFKCG<TMarker>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<JIAAFONGLED>? JENFFPGIJNL, [Optional][In] ReadOnlySpan<byte> GPCDCFCPGFK)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ACF0", Offset = "0x2A596F0", VA = "0x182A5ACF0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) JFDFGIBNHJF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int LJJKDPNMLNL, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? GHCLINPMECF)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A59730", Offset = "0x2A58130", VA = "0x182A59730")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) DMEPEALAGME(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LJJKDPNMLNL, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? GHCLINPMECF)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1AB0", Offset = "0x3AC04B0", VA = "0x183AC1AB0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>) KGHLMCPDCEK<TMarker>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<TMarker>>? GHCLINPMECF, [Optional] int? CGAAPEOHPIP, [Optional][In] ReadOnlySpan<byte> LJJKDPNMLNL)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3AC17A0", Offset = "0x3AC01A0", VA = "0x183AC17A0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>) ACEFBJEHCEM<TMarker>(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<TMarker>>? LJJKDPNMLNL, [Optional] COBPPOBACAG<MLOCJABKMLJ<TMarker>>? GHCLINPMECF, [Optional] int? CGAAPEOHPIP)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<TMarker>>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A2F0", Offset = "0x2A58CF0", VA = "0x182A5A2F0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) GIJCBPMNKCO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A59360", Offset = "0x2A57D60", VA = "0x182A59360")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) DHEIAPHBDDJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C2A0", Offset = "0x2A5ACA0", VA = "0x182A5C2A0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) MDGODABCKMK(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B270", Offset = "0x2A59C70", VA = "0x182A5B270")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) KBOPMPLODFO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A58320", Offset = "0x2A56D20", VA = "0x182A58320")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) AOHKOHMPPLC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CD80", Offset = "0x2A5B780", VA = "0x182A5CD80")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NOGIDMGBKPP(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C9E0", Offset = "0x2A5B3E0", VA = "0x182A5C9E0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NGKMJMKCKMH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A470", Offset = "0x2A58E70", VA = "0x182A5A470")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) GJMHAIMKJBO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CB40", Offset = "0x2A5B540", VA = "0x182A5CB40")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NLOLFHEHKFF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C4E0", Offset = "0x2A5AEE0", VA = "0x182A5C4E0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>) MIGDLHLEEFL(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? IEBNNPCNGGE)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B0F0", Offset = "0x2A59AF0", VA = "0x182A5B0F0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) JPDMJNALDHO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A58E40", Offset = "0x2A57840", VA = "0x182A58E40")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) COCKJFLBJMO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A58A60", Offset = "0x2A57460", VA = "0x182A58A60")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) CEBJJLHCJAJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CEA0", Offset = "0x2A5B8A0", VA = "0x182A5CEA0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NONIFIEEKLL(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A6E0", Offset = "0x2A590E0", VA = "0x182A5A6E0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) HBMFEDLBGKD(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B970", Offset = "0x2A5A370", VA = "0x182A5B970")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) LBCHFIBEIMI(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A59BC0", Offset = "0x2A585C0", VA = "0x182A59BC0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) FKAPIPFBECM(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D230", Offset = "0x2A5BC30", VA = "0x182A5D230")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) PICBGDGMONJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2A5BE20", Offset = "0x2A5A820", VA = "0x182A5BE20")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) LFPKBGIOMEN(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A58CE0", Offset = "0x2A576E0", VA = "0x182A58CE0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) CILKLNNGJBH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2A5BCD0", Offset = "0x2A5A6D0", VA = "0x182A5BCD0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) LFOMOPOICOH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5BBB0", Offset = "0x2A5A5B0", VA = "0x182A5BBB0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) LEEFPLGBIKG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A170", Offset = "0x2A58B70", VA = "0x182A5A170")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) GGLONCCJMFF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A59840", Offset = "0x2A58240", VA = "0x182A59840")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) EBAOHANNPJC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A990", Offset = "0x2A59390", VA = "0x182A5A990")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) IALLFMPKIOD(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A830", Offset = "0x2A59230", VA = "0x182A5A830")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) HEDJNLLBPDH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2A59D40", Offset = "0x2A58740", VA = "0x182A59D40")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) FMOINBOOPGE(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C070", Offset = "0x2A5AA70", VA = "0x182A5C070")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) LLFCPLBENDH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AE20", Offset = "0x2A59820", VA = "0x182A5AE20")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) JKMMHKKEENE(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2A590F0", Offset = "0x2A57AF0", VA = "0x182A590F0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) DFPDCLCJIHO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2A59600", Offset = "0x2A58000", VA = "0x182A59600")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) DLOMOBFFPIF(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B3D0", Offset = "0x2A59DD0", VA = "0x182A5B3D0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) KCFOGCBPKJO(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C890", Offset = "0x2A5B290", VA = "0x182A5C890")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NEKHGFMPMFA(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B530", Offset = "0x2A59F30", VA = "0x182A5B530")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) KGDOGBOFKOL(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B650", Offset = "0x2A5A050", VA = "0x182A5B650")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) KHEPHDNCFHJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2A594B0", Offset = "0x2A57EB0", VA = "0x182A594B0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) DJGKNEEEACD(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C3C0", Offset = "0x2A5ADC0", VA = "0x182A5C3C0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) MIABMGGEGPH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A58900", Offset = "0x2A57300", VA = "0x182A58900")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) BMNKEPKILBG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A57DE0", Offset = "0x2A567E0", VA = "0x182A57DE0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) ABCPHHBDIIM(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A587E0", Offset = "0x2A571E0", VA = "0x182A587E0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) BMAGJEIAKKH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A59AB0", Offset = "0x2A584B0", VA = "0x182A59AB0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) FDKKPGADNEC(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] int? OBOFPNGDMOM, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D000", Offset = "0x2A5BA00", VA = "0x182A5D000")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) OKACADFPDJN(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OBOFPNGDMOM, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A58470", Offset = "0x2A56E70", VA = "0x182A58470")]
	public static COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> APGNOKINALI(this GNGEHCNCBFJ<byte> NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A58050", Offset = "0x2A56A50", VA = "0x182A58050")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) AICJNBCCLNG(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A584F0", Offset = "0x2A56EF0", VA = "0x182A584F0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) BDEHNABIIDN(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, float OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<PLPNJALFIND>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ABD0", Offset = "0x2A595D0", VA = "0x182A5ABD0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>) ILELJGMGAIK(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<PLPNJALFIND>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<PLPNJALFIND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A59E90", Offset = "0x2A58890", VA = "0x182A59E90")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) GCIJPHHAKAI(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A58FA0", Offset = "0x2A579A0", VA = "0x182A58FA0")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) DECCCBBEKAA(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D110", Offset = "0x2A5BB10", VA = "0x182A5D110")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) PFDCEEKDLOJ(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A5C730", Offset = "0x2A5B130", VA = "0x182A5C730")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) NAEHOFKLPHA(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A57C90", Offset = "0x2A56690", VA = "0x182A57C90")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) AAFDDNBHDBH(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, int OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A57F30", Offset = "0x2A56930", VA = "0x182A57F30")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>) AEHLKFBIHLP(this GNGEHCNCBFJ<byte> NLDLHIJAJBO, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? OGEEJDNANBD, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? NEKBMMAICDE, [Optional] COBPPOBACAG<MLOCJABKMLJ<AOALJIIJMIN>>? LPEEKGCHLCB)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<AOALJIIJMIN>>>));
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
