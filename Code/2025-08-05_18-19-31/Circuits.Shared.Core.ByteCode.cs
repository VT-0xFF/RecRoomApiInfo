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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A733F0", Offset = "0x2A727F0", VA = "0x182A733F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMECCJCACML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FD0", Offset = "0x31E73D0", VA = "0x1831E7FD0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<M>> CMIEGMAMOIB<M>(this int DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A73320", Offset = "0x2A72720", VA = "0x182A73320")]
	public static JGDCCHDHIKG<LAMDHOIBIPH> OMAABJIKFEA(this int DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<LAMDHOIBIPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FD0", Offset = "0x31E73D0", VA = "0x1831E7FD0")]
	public static JGDCCHDHIKG<IDFKDLADJBB<M>> HHJBKAOOHKI<M>(this int DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<IDFKDLADJBB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GIBAEBEBPGD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LOELOJFKOHG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FHCHDMFAKBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LAMDHOIBIPH
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GLEOMBKNPNP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GDIFPOIBCOI
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JKNFINGOCML
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
public static class NKMHPEDGHLB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OLILCOOENPF<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr MGLMDMDAILN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
		public OLILCOOENPF(IntPtr FCHDCHMAIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x59E77E0", Offset = "0x59E6BE0", VA = "0x1859E77E0")]
		public int COEOEEINBLF(TDeps MOHOCDOOLDA, TContext PCEKLOBPOGK, TCompileState LFFGLDJBMNF, [In] JAEBKFJJIPK<byte> DCDMBBHABEB, int OIKKFAGGFEP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E602B0", Offset = "0x3E5F6B0", VA = "0x183E602B0")]
	public static void IEKAOOFOEML<TDeps, TContext, TCompileState>(TDeps MOHOCDOOLDA, TContext PCEKLOBPOGK, TCompileState LFFGLDJBMNF, [In] JAEBKFJJIPK<byte> DKDCDKHFLLG, JAEBKFJJIPK<byte> BBDOLJBIIIE, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KKMFOFLMAGD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? ILMNBILDPKP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KHDAHPADECO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DFGNDCHBEDA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MNHHGIBBLKB, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LHMHGOPIIPF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OHNIOAGOBCP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HHPOBHOCDFD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NPJOBEHHEEB, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PHJEFLPFCGH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FCIADFFCMLO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FEEFFCCPKOJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KIPGBNMFLMP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KINAELHDBOE, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PKOIKDINIBA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OAEFMIEMIOK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OMKPEBINIHK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HOMDFMAMNNN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MIFCENLHFMJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? CCDFLGLEOBC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LGOEEAEGAHG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NLODFLFPLAN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OJDHKNJJKJC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BPKHKNBIGGF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JJKFEMLBFNI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JGOJGHDHFFP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KBKKKOGKAJH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KDDIMCGNADP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IJGOCKHKHKJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FDMFONCNHEP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JLDPNDENOMA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OBAINPICMOF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MAFLBGCENPN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? AFHFLBLPAAK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? INOFGEJEGHM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FJGBJPFNMAH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MMHGMJHEHNO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MCCNDJNGGIP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PAMOBHHAKBD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HOGELCNFOEN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EJMFMMDANAL, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NOFNCHPALPD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EJNHPOLDLDC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? CNJFJPDCMAK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GNAJONJDCDC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PAFMFGNILMG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BKINHGDNPCP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FILPAFDIEJD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? ECAALBEGDDM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GLPECPPLBAF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KOHBEHIJOFE, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NOJIKOCAOMH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JIKCOPDNBCI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KFHKAEEECKC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PEHDLOOJKLN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BAHCCLHICOA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OIPJDAMOPJI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HAEGBMLFLIL, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OMHAPIAEMOI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DBAFEIGBOOD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PJMLKFONBKO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? ILANFLLLKKA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OIMOEOOGNFK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GHEDCJKBGMM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BLBDKMBJCPL, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IHAMFNNPBEA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HDLJGHKLEBK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DHJODPLHFDJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NGPOMMIKJBP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? ENOMDJFBEGA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BBELBIPJHAF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FCGAGIOANAA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IINHCPBICLJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KHDEJLIGOHH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LPCHACPDNNJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? CBBBJBHMKGC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JAPPPBDJBKF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? APNDCONFACJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LCKMKPCAOEE, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FHOFCMLNHJF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EDHPCIPAEGB, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KFPLIHFOFKC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? CDPBIKOPJIO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GMNGAHHHKFO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BKALLENBGOJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GDPLPKIAPJN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IALBJHMIGNN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LIFHHIDIFGO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GJGKDDKKICN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OCOOAMALNLG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OGKFHCKIHEJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LKIEFHNJMMN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IOOFHFHFOAJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DHMGAEJJCLD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MLDNLBEJJJK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OEGCJJNFENM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DFNKILKOBOD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? JFBJNAEGCGA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EDIDKDGCIHJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MPLMGOKCCJD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PEDBDKJFIEE, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? POIIDCHCBEH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IOBDODHJCDG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PIDDFIDJBFF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OCOFEIGAOEJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OMLOJNNJJGM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KIKIONCMKAO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FDJEJAMNEOP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LDOKDNJFJNJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EPEMOLPOIBI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PNAHICPJOIA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PIEEADLDEOD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MCBGDOLCECG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GNOEJEOHEFN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? LBKOAMEPLAF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NEKOCCFINEI, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? FHJIKENEDKB, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? DPKBFGANIHF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? HFAMJAMHCOM, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PENFPPDNJMD, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PLLILMANKEB, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GMNEOMJOJPO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? OCPEDJFNAHC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IHNFDMOBAAC, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? KKPGAGDKPIJ, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? CECGDDGECLF, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NLDCIOFBJHO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? MDENPMEEMFK, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? PCFIPNOHCOO, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? EJDKMECPNAN, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? IMBGBDFGCPP, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BPBJHIINFCA, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? NJGNLKAMAEH, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? GDFLLMNNOEG, [Optional] OLILCOOENPF<TContext, TDeps, TCompileState>? BOJGCHCPGJM) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A73350", Offset = "0x2A72750", VA = "0x182A73350")]
	private static int ILKOCLCFNMI([In] JAEBKFJJIPK<byte> EOHGCIHCMID, JAEBKFJJIPK<byte> BEKKFILOPCK, int FEMDGHMCLCC, int PPNAGMANAKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DOHGAMMGCJA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int HOBLJPLFBNK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B14C70", Offset = "0x3B14070", VA = "0x183B14C70")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<T>> EHGOHOOKLJJ<T>([In] this JAEBKFJJIPK<byte> DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B14BB0", Offset = "0x3B13FB0", VA = "0x183B14BB0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<T>>> ABAFHKMFDHP<T>(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<T>>? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A72C00", Offset = "0x2A72000", VA = "0x182A72C00")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<HEMEAAEFNEI>> BCEOAKMNAHF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<HEMEAAEFNEI>? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<HEMEAAEFNEI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A72CD0", Offset = "0x2A720D0", VA = "0x182A72CD0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>> FPOIDGIBCAO(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] float? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A73100", Offset = "0x2A72500", VA = "0x182A73100")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>> MPELGMKPHJJ(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A72DA0", Offset = "0x2A721A0", VA = "0x182A72DA0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>> HDLGOAKEHFM(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<MCNDOOFJGPD>? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A73010", Offset = "0x2A72410", VA = "0x182A73010")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GDIFPOIBCOI>> LMLOBIJEDAM(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] byte? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GDIFPOIBCOI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A72E70", Offset = "0x2A72270", VA = "0x182A72E70")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<LAMDHOIBIPH>> HLENAGLHOMO(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<LAMDHOIBIPH>? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<LAMDHOIBIPH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A72F40", Offset = "0x2A72340", VA = "0x182A72F40")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> JIKINDLKPKB(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JKNFINGOCML? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B14CD0", Offset = "0x3B140D0", VA = "0x183B14CD0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<T>>> GKEGGKJIJKG<T>(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<T>>? CBMEHPPMEEA)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A72B00", Offset = "0x2A71F00", VA = "0x182A72B00")]
	public static void OMOIJGGMFCP(this JAEBKFJJIPK<byte> DMFKPMONDPO, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>> HMNLIHLCCLO, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B14CC0", Offset = "0x3B140C0", VA = "0x183B14CC0")]
	public static void GHOOIFJMMOG<T>(this JAEBKFJJIPK<byte> DMFKPMONDPO, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<T>>> OIKKFAGGFEP, JGDCCHDHIKG<GIBAEBEBPGD<T>> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B14CC0", Offset = "0x3B140C0", VA = "0x183B14CC0")]
	public static void EKMNEJPLAJH<T>(this JAEBKFJJIPK<byte> DMFKPMONDPO, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<T>>> HBLHLFNBCFC, JGDCCHDHIKG<IDFKDLADJBB<T>> CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IJEJNEBEOHC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A73210", Offset = "0x2A72610", VA = "0x182A73210")]
	public static OKGEIGJJJJK OLGBAOICIIE([In] this ReadOnlySpan<byte> FGHKEPJEKFP, int KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A73280", Offset = "0x2A72680", VA = "0x182A73280")]
	public static OKGEIGJJJJK OLGBAOICIIE([In] this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D23B30", Offset = "0x3D22F30", VA = "0x183D23B30")]
	public static OKGEIGJJJJK OLGBAOICIIE<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D23C40", Offset = "0x3D23040", VA = "0x183D23C40")]
	public static OKGEIGJJJJK OLGBAOICIIE<M>([In] this ECMPHMAHIGO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D23600", Offset = "0x3D22A00", VA = "0x183D23600")]
	public static OKGEIGJJJJK OLGBAOICIIE<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D236F0", Offset = "0x3D22AF0", VA = "0x183D236F0")]
	public static OKGEIGJJJJK OLGBAOICIIE<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D23D50", Offset = "0x3D23150", VA = "0x183D23D50")]
	public static OKGEIGJJJJK OLGBAOICIIE<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A73210", Offset = "0x2A72610", VA = "0x182A73210")]
	public static int NHOPCOIFKNM([In] this ReadOnlySpan<byte> FGHKEPJEKFP, int KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A72A50", Offset = "0x2A71E50", VA = "0x182A72A50")]
	public static int NHOPCOIFKNM([In] this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FB0", Offset = "0x31E73B0", VA = "0x1831E7FB0")]
	public static int NHOPCOIFKNM<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FB0", Offset = "0x31E73B0", VA = "0x1831E7FB0")]
	public static int NHOPCOIFKNM<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FB0", Offset = "0x31E73B0", VA = "0x1831E7FB0")]
	public static int NHOPCOIFKNM<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FB0", Offset = "0x31E73B0", VA = "0x1831E7FB0")]
	public static int NHOPCOIFKNM<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D239F0", Offset = "0x3D22DF0", VA = "0x183D239F0")]
	public static float JPNALNFBPBA<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D239F0", Offset = "0x3D22DF0", VA = "0x183D239F0")]
	public static float JPNALNFBPBA<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D239F0", Offset = "0x3D22DF0", VA = "0x183D239F0")]
	public static float JPNALNFBPBA<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D23650", Offset = "0x3D22A50", VA = "0x183D23650")]
	public static byte ACIBIHDCKFK<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D235E0", Offset = "0x3D229E0", VA = "0x183D235E0")]
	public static byte ACIBIHDCKFK<M>([In] this ECMPHMAHIGO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D23600", Offset = "0x3D22A00", VA = "0x183D23600")]
	public static byte ACIBIHDCKFK<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D236F0", Offset = "0x3D22AF0", VA = "0x183D236F0")]
	public static byte ACIBIHDCKFK<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D23680", Offset = "0x3D22A80", VA = "0x183D23680")]
	public static byte ACIBIHDCKFK<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A72A50", Offset = "0x2A71E50", VA = "0x182A72A50")]
	public static JKNFINGOCML KDBLFMLKDID([In] this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID)
	{
		return default(JKNFINGOCML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FB0", Offset = "0x31E73B0", VA = "0x1831E7FB0")]
	public static JKNFINGOCML KDBLFMLKDID<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JKNFINGOCML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D23930", Offset = "0x3D22D30", VA = "0x183D23930")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> IGMFHMEHEGD<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D238D0", Offset = "0x3D22CD0", VA = "0x183D238D0")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> IGMFHMEHEGD<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D23990", Offset = "0x3D22D90", VA = "0x183D23990")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> IGMFHMEHEGD<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D23750", Offset = "0x3D22B50", VA = "0x183D23750")]
	public static JGDCCHDHIKG<IDFKDLADJBB<FJJLGBAEDPD>> BDJLIOKGCMF<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<IDFKDLADJBB<FJJLGBAEDPD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D23A70", Offset = "0x3D22E70", VA = "0x183D23A70")]
	public static JGDCCHDHIKG<LAMDHOIBIPH> KKBHAMJPLCH<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<LAMDHOIBIPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D23A10", Offset = "0x3D22E10", VA = "0x183D23A10")]
	public static JGDCCHDHIKG<LAMDHOIBIPH> KKBHAMJPLCH<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<LAMDHOIBIPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D23AD0", Offset = "0x3D22ED0", VA = "0x183D23AD0")]
	public static JGDCCHDHIKG<LAMDHOIBIPH> KKBHAMJPLCH<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<LAMDHOIBIPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D237B0", Offset = "0x3D22BB0", VA = "0x183D237B0")]
	public static JGDCCHDHIKG<HEMEAAEFNEI> BNHLIFGLOKN<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<HEMEAAEFNEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D23810", Offset = "0x3D22C10", VA = "0x183D23810")]
	public static JGDCCHDHIKG<HEMEAAEFNEI> BNHLIFGLOKN<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<HEMEAAEFNEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D23870", Offset = "0x3D22C70", VA = "0x183D23870")]
	public static JGDCCHDHIKG<MCNDOOFJGPD> DDFIGKMOLPK<M>(this LHABNBDCIPF<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID)
	{
		return default(JGDCCHDHIKG<MCNDOOFJGPD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OADNOACJHCP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A73710", Offset = "0x2A72B10", VA = "0x182A73710")]
	public static void PHOBJOPCNID(this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID, OKGEIGJJJJK CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A73620", Offset = "0x2A72A20", VA = "0x182A73620")]
	public static void PHOBJOPCNID(this byte[] FGHKEPJEKFP, int KKANHCDLFID, OKGEIGJJJJK CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A73690", Offset = "0x2A72A90", VA = "0x182A73690")]
	public static void PHOBJOPCNID([In] this Span<byte> FGHKEPJEKFP, int KKANHCDLFID, OKGEIGJJJJK CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E84EF0", Offset = "0x3E842F0", VA = "0x183E84EF0")]
	public static void PHOBJOPCNID<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, OKGEIGJJJJK CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E84E00", Offset = "0x3E84200", VA = "0x183E84E00")]
	public static void PHOBJOPCNID<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, OKGEIGJJJJK CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A72B00", Offset = "0x2A71F00", VA = "0x182A72B00")]
	public static void OMOIJGGMFCP(this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A73520", Offset = "0x2A72920", VA = "0x182A73520")]
	public static void OMOIJGGMFCP(this byte[] FGHKEPJEKFP, int KKANHCDLFID, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A735A0", Offset = "0x2A729A0", VA = "0x182A735A0")]
	public static void OMOIJGGMFCP([In] this Span<byte> FGHKEPJEKFP, int KKANHCDLFID, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E84DB0", Offset = "0x3E841B0", VA = "0x183E84DB0")]
	public static void OMOIJGGMFCP<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E84D60", Offset = "0x3E84160", VA = "0x183E84D60")]
	public static void OMOIJGGMFCP<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A73470", Offset = "0x2A72870", VA = "0x182A73470")]
	public static void FBLDNANEBGH(this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID, float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E84CB0", Offset = "0x3E840B0", VA = "0x183E84CB0")]
	public static void FBLDNANEBGH<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E84C60", Offset = "0x3E84060", VA = "0x183E84C60")]
	public static void FBLDNANEBGH<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A734B0", Offset = "0x2A728B0", VA = "0x182A734B0")]
	public static void NKBDMILJIOE(this JAEBKFJJIPK<byte> FGHKEPJEKFP, int KKANHCDLFID, byte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E84D30", Offset = "0x3E84130", VA = "0x183E84D30")]
	public static void NKBDMILJIOE<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, byte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E84D00", Offset = "0x3E84100", VA = "0x183E84D00")]
	public static void NKBDMILJIOE<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, byte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31E99F0", Offset = "0x31E8DF0", VA = "0x1831E99F0")]
	public static void GHOOIFJMMOG<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x31E99F0", Offset = "0x31E8DF0", VA = "0x1831E99F0")]
	public static void GHOOIFJMMOG<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, JGDCCHDHIKG<GIBAEBEBPGD<FJJLGBAEDPD>> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x31E99F0", Offset = "0x31E8DF0", VA = "0x1831E99F0")]
	public static void HNFNAMJIKML<M>(this AHHLMJNMMOO<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, JGDCCHDHIKG<LAMDHOIBIPH> CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31E99F0", Offset = "0x31E8DF0", VA = "0x1831E99F0")]
	public static void HNFNAMJIKML<M>([In] this MCBDLIJCJPC<M, byte> FGHKEPJEKFP, JGDCCHDHIKG<M> KKANHCDLFID, JGDCCHDHIKG<LAMDHOIBIPH> CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class POILEFAEPNB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A78170", Offset = "0x2A77570", VA = "0x182A78170")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) NADLBFDEHNK(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A78690", Offset = "0x2A77A90", VA = "0x182A78690")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) NIDAJBDFPBA(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A77DE0", Offset = "0x2A771E0", VA = "0x182A77DE0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) MGMCOABJGAC(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A738F0", Offset = "0x2A72CF0", VA = "0x182A738F0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) ADOJOCFFCDK(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A74630", Offset = "0x2A73A30", VA = "0x182A74630")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BPGJMNDGKGC(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A74510", Offset = "0x2A73910", VA = "0x182A74510")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BNDIGBINJJH(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A78960", Offset = "0x2A77D60", VA = "0x182A78960")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) ODKGCEDDBCG(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A76BD0", Offset = "0x2A75FD0", VA = "0x182A76BD0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) JKECBNIPIEE(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A73B70", Offset = "0x2A72F70", VA = "0x182A73B70")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) AGBEEJHOMOA(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A74EB0", Offset = "0x2A742B0", VA = "0x182A74EB0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>) DJGDFDAOJPG(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? CBMEHPPMEEA, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? NFPLNNFHFNO)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B40", Offset = "0x2A73F40", VA = "0x182A74B40")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>) DEECLDIPLJB(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? CBMEHPPMEEA, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? NFPLNNFHFNO)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A73DB0", Offset = "0x2A731B0", VA = "0x182A73DB0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>) ANJGBALOLNL(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? CBMEHPPMEEA, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? NFPLNNFHFNO)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A73EC0", Offset = "0x2A732C0", VA = "0x182A73EC0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>) AOOFCCDPNJF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? CBMEHPPMEEA, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? NFPLNNFHFNO)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A763F0", Offset = "0x2A757F0", VA = "0x182A763F0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<HEMEAAEFNEI>>) IJKODHAPDGA(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? JEAMICHCALI, [Optional] JGDCCHDHIKG<HEMEAAEFNEI>? PEHELHMLLIK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<HEMEAAEFNEI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A75920", Offset = "0x2A74D20", VA = "0x182A75920")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<HEMEAAEFNEI>>>) FCGJMIPFMLP(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? JEAMICHCALI, [Optional] JGDCCHDHIKG<IDFKDLADJBB<HEMEAAEFNEI>>? PEHELHMLLIK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<HEMEAAEFNEI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75E60", Offset = "0x2A75260", VA = "0x182A75E60")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<LAMDHOIBIPH>>) HECIGBLBCNM(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? JEAMICHCALI, [Optional] JGDCCHDHIKG<LAMDHOIBIPH>? PEHELHMLLIK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<LAMDHOIBIPH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A752C0", Offset = "0x2A746C0", VA = "0x182A752C0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LAMDHOIBIPH>>>) EDBHJAOINLF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? JEAMICHCALI, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LAMDHOIBIPH>>? PEHELHMLLIK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LAMDHOIBIPH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4AA0", Offset = "0x3ED3EA0", VA = "0x183ED4AA0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>) LJMOGLOFAIL<TMarker>(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<MCNDOOFJGPD>? PEHELHMLLIK, [Optional][In] ReadOnlySpan<byte> NGIAGNLBILI)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<MCNDOOFJGPD>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A770F0", Offset = "0x2A764F0", VA = "0x182A770F0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) KIDEGAFJMPG(this JAEBKFJJIPK<byte> DMFKPMONDPO, int EOHGCIHCMID, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BEKKFILOPCK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A777A0", Offset = "0x2A76BA0", VA = "0x182A777A0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) MBPFDINOLKM(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? EOHGCIHCMID, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BEKKFILOPCK)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3ED48C0", Offset = "0x3ED3CC0", VA = "0x183ED48C0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>) EAEGBAANCCH<TMarker>(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<TMarker>>? BEKKFILOPCK, [Optional] int? MPDDFCCPIOM, [Optional][In] ReadOnlySpan<byte> EOHGCIHCMID)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4C90", Offset = "0x3ED4090", VA = "0x183ED4C90")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>) PMPHMPDMILH<TMarker>(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<TMarker>>? EOHGCIHCMID, [Optional] JGDCCHDHIKG<IDFKDLADJBB<TMarker>>? BEKKFILOPCK, [Optional] int? MPDDFCCPIOM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<TMarker>>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A75530", Offset = "0x2A74930", VA = "0x182A75530")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) EIHMCIJPJDH(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A74780", Offset = "0x2A73B80", VA = "0x182A74780")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) CAMEDPBFNJF(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A76FD0", Offset = "0x2A763D0", VA = "0x182A76FD0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) KHLAFBEIGND(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A77220", Offset = "0x2A76620", VA = "0x182A77220")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) KPAGPAJCHJI(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A76D20", Offset = "0x2A76120", VA = "0x182A76D20")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) KAFDMLLKDLK(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A766E0", Offset = "0x2A75AE0", VA = "0x182A766E0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) IOAOGLCCGFJ(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2A76950", Offset = "0x2A75D50", VA = "0x182A76950")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) JCBICAJIMAE(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A78ED0", Offset = "0x2A782D0", VA = "0x182A78ED0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) PEMHGJADLNM(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A782F0", Offset = "0x2A776F0", VA = "0x182A782F0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) NCOJFEFNPAF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A77F00", Offset = "0x2A77300", VA = "0x182A77F00")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>) MMBLFOHIFAG(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>? ABBEEGNFEOH)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<GIBAEBEBPGD<GLEOMBKNPNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2A74110", Offset = "0x2A73510", VA = "0x182A74110")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BFHFIPJAOOJ(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D70", Offset = "0x2A78170", VA = "0x182A78D70")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) PEAAPEMPGEH(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A74290", Offset = "0x2A73690", VA = "0x182A74290")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BGAECKPMKMA(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A76E70", Offset = "0x2A76270", VA = "0x182A76E70")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) KCBHKHFMMKF(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A76590", Offset = "0x2A75990", VA = "0x182A76590")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) INMOCEAGNPG(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A78570", Offset = "0x2A77970", VA = "0x182A78570")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) NICKELEFDBA(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A74FC0", Offset = "0x2A743C0", VA = "0x182A74FC0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) DKBJLECEEJG(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2A779D0", Offset = "0x2A76DD0", VA = "0x182A779D0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) MEICALOKKKI(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2A79020", Offset = "0x2A78420", VA = "0x182A79020")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) PJGKGMELBCN(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A77C80", Offset = "0x2A77080", VA = "0x182A77C80")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) MFMBGCLOMCE(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2A76000", Offset = "0x2A75400", VA = "0x182A76000")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) HEMHNLLOBBB(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2A77400", Offset = "0x2A76800", VA = "0x182A77400")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) LFMCINJLKJF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2A75B90", Offset = "0x2A74F90", VA = "0x182A75B90")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) GBNPAJMLHNI(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A77520", Offset = "0x2A76920", VA = "0x182A77520")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) LHIIKOKIOAE(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A74D80", Offset = "0x2A74180", VA = "0x182A74D80")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) DGFIKLLCELL(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75A30", Offset = "0x2A74E30", VA = "0x182A75A30")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) FGKGOFKMLKB(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2A743C0", Offset = "0x2A737C0", VA = "0x182A743C0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BJGLGBIANMP(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2A76AB0", Offset = "0x2A75EB0", VA = "0x182A76AB0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) JIBEMOAGBCI(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2A787E0", Offset = "0x2A77BE0", VA = "0x182A787E0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) NOLGJHNPHPC(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2A78C10", Offset = "0x2A78010", VA = "0x182A78C10")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) OJBMFKJDFHK(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2A73FE0", Offset = "0x2A733E0", VA = "0x182A73FE0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) BDMGDDNPOJL(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A78410", Offset = "0x2A77810", VA = "0x182A78410")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) NDLEDBGPNKG(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A78AC0", Offset = "0x2A77EC0", VA = "0x182A78AC0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) OIGBDFHBBFJ(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2A778B0", Offset = "0x2A76CB0", VA = "0x182A778B0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) MEBMHAPJBKP(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A75140", Offset = "0x2A74540", VA = "0x182A75140")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) DNOENPFLNAO(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2A76150", Offset = "0x2A75550", VA = "0x182A76150")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) HPOEGNAHKAD(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A73A50", Offset = "0x2A72E50", VA = "0x182A73A50")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) AFKKCGFMFHI(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A753D0", Offset = "0x2A747D0", VA = "0x182A753D0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) EEAOEABAJGK(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A75D10", Offset = "0x2A75110", VA = "0x182A75D10")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) HBOOOKOJGEH(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A737D0", Offset = "0x2A72BD0", VA = "0x182A737D0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) AAMAMANIJND(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A74A30", Offset = "0x2A73E30", VA = "0x182A74A30")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) CLCMPLKFKPP(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] int? IMKMFEHEDHC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A756B0", Offset = "0x2A74AB0", VA = "0x182A756B0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) EKPNDPCDLNF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? IMKMFEHEDHC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A77380", Offset = "0x2A76780", VA = "0x182A77380")]
	public static JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>> LECJPHAAOMF(this JAEBKFJJIPK<byte> DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A77FF0", Offset = "0x2A773F0", VA = "0x182A77FF0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) NAAFKDGMGLH(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, float JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A762A0", Offset = "0x2A756A0", VA = "0x182A762A0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) IBLJPADFKNG(this JAEBKFJJIPK<byte> DMFKPMONDPO, float GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<LOELOJFKOHG>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A77680", Offset = "0x2A76A80", VA = "0x182A77680")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>) LLAKMHOBIFM(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<LOELOJFKOHG>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<LOELOJFKOHG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A748D0", Offset = "0x2A73CD0", VA = "0x182A748D0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) CFDDPODGAEI(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A76800", Offset = "0x2A75C00", VA = "0x182A76800")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) IPEFDGNLDJL(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A74C60", Offset = "0x2A74060", VA = "0x182A74C60")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) DEENACJIGNF(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A757C0", Offset = "0x2A74BC0", VA = "0x182A757C0")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) ELKGLFLLGKB(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, int JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B30", Offset = "0x2A76F30", VA = "0x182A77B30")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) MFHJCGNLJKF(this JAEBKFJJIPK<byte> DMFKPMONDPO, int GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<FHCHDMFAKBP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A73C90", Offset = "0x2A73090", VA = "0x182A73C90")]
	public static (JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>) AMPKJIAOBLA(this JAEBKFJJIPK<byte> DMFKPMONDPO, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? GKOMMDHCBKC, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? JOPKPOCDHNJ, [Optional] JGDCCHDHIKG<IDFKDLADJBB<FHCHDMFAKBP>>? BNOCMLLODIM)
	{
		return default((JGDCCHDHIKG<GIBAEBEBPGD<GLEOMBKNPNP>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>, JGDCCHDHIKG<GIBAEBEBPGD<IDFKDLADJBB<FHCHDMFAKBP>>>));
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
