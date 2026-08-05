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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E6DC0", Offset = "0x28E57C0", VA = "0x1828E6DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FJLLFKJDLHL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D40", Offset = "0x2FF0740", VA = "0x182FF1D40")]
	public static EHLNDDDNIPO<DBKGEMIMENE<M>> NBAPDILKNCA<M>(this int NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28E6380", Offset = "0x28E4D80", VA = "0x1828E6380")]
	public static EHLNDDDNIPO<PJODMDDODDF> ODLLMEEJFNN(this int NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<PJODMDDODDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D40", Offset = "0x2FF0740", VA = "0x182FF1D40")]
	public static EHLNDDDNIPO<NKFCLCHDDPH<M>> ONJIFMOMPNF<M>(this int NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<NKFCLCHDDPH<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class DBKGEMIMENE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CNPBEMHJCCG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HHAFOACDJND
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PJODMDDODDF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LMLEJHGBBKH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DPHKNILNJIK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum PKEBBPBCLND
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
public static class KJHMMEDHPCO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HJMIGGAAOEM<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr HMIMLECNHJK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
		public HJMIGGAAOEM(IntPtr LALBBHEFJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D01BD0", Offset = "0x4D005D0", VA = "0x184D01BD0")]
		public int LPGMHIBJMOO(TDeps BFPFMKIIKBG, TContext MOCCEAFKGMN, TCompileState PINNMMPLMCL, [In] KEIHFOCJOJN<byte> NILLPAMKAEK, int DDJAIBEMOAN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B098B0", Offset = "0x3B082B0", VA = "0x183B098B0")]
	public static void PIAEBKGAPLE<TDeps, TContext, TCompileState>(TDeps BFPFMKIIKBG, TContext MOCCEAFKGMN, TCompileState PINNMMPLMCL, [In] KEIHFOCJOJN<byte> MDPMPCGCLGF, KEIHFOCJOJN<byte> ANKKODFELCG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FFFEIHDABJH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GKPFGBOGFPO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? ANJCDDGEAFM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EKKELFAHHMH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EFCACHAPBBH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LMGKAMKBLNL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GCCHAFCFMDP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KAMNLGAKEAK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OGGBAMKHIGF, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NOKMLBMNAIE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BGLNDAAJNGJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NGCFIGJPKAC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KABKMLOCFNJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OJCMGHFPGFA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FOGEDBKNENJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JJCPIEGBNDP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JHDBPPHOPKD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? IONDHCHFIBB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CMNLDAEMPHC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MBFJLOEIDLE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KEFKMOFEFNP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NPCLGFEOGMA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NEBCAKAOKHD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AHHOHAJMHOL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GOHMNPGIGMO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MNBMIABBKOL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MLJFIBDFFJL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AMKBHGAONBG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BEJPOGCGPKM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OILJKLKFKNK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JLNGEKDGCCD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KIGMOIPJEON, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EIOEEOCFPGH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? ACOKLIKPGFP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JCFPLNFHHOM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AAJNDDGFIMJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DKGOJICENCC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BBDKMILAFND, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CLCOOBGBCNG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GCEHPFJKEBE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NPKOKKMIPEK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BNICOEFBMOC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KMEKIHNKEMO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OBKBEBDKNLG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AOCPJPIELBD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AMBIDHLIMBN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BMMPLEALIHE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LODJBJNOFLM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GHDHHGIBFLD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BNBKAIIJLEC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LMFKJHFLGFI, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DOKKCCCJPNK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LPJLDBLFCBE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OAHKHHIOAMN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CABNDFJNLOA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BDHIJBCIBPK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? APDNOGNDMIO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BLHEKFJOPLM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GPLBJGKLDMA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GIBOBCIINGE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MBALEIFLHOJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GJLDKKJEKOH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CACMIBKCMOA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KCJAKJOIPNL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EFODGHKKOPF, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MLKKPNLHPHO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GOJAEOCGMNH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FKINPELPMCB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FJPALMMAMKC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LGICJPAGHNP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CGJFIKIEEKB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NOMAFPBNMFL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KLEGOHPCDMD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? IOJHOOLABNH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GKPNDFPDMDL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? PGHLJALBLJE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JFHDNJFLNHJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DJKOECABKMN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GNBADABFAON, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LGPDMKOHHOL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BLODCCGKJKK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? HDOMAGIOGHC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? HCIJIPEPFAI, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JNGPIFFKDAE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FCEJAMMABCH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OPFEKJBOKBB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? PDKFMMEJKLL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? APMNHIGKICC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? APLJBNLMIDH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BALCLCGCCDL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CCCNGAFFCPA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EOGNJIKNNCA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EMAKCOGCLHE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AKIPOKMCHKG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MMHFHPDMAJA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JKKEKPFLPIJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? ODBLLFEFPKD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CAKCLCKKHCD, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NAONHOBCKEA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AJOEFJLMBMH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? PIAEOGNPJLC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KFGIAOJMEPJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DEKFAJPBLHN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? HMCLFDNMKGB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? ENMHDECPPKO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CDBLJMDLDBH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? BIDMDLJFBEF, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? OHENHBJBAIG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? IHGLFNIIMBO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GPFNBPCAMCM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JMDLHEDKNJB, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DPHDBBOJMMH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GHPCMGBOPPK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DIDPAAGKFFN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FIPIOBCIBBM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GICPMNICGCP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MFKIJMOEKGK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? GIJIBKCBLGG, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? HANAGDMGHKA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? KCGLPEFLHOO, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? AMDPBJOBKMC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NAAKHHGFHMA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FIHGCKAABFL, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? JHCGEFLHDBE, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MKDDOALKPCM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? DAJJBLNBNCC, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? MKIJCJMFECK, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? ADGGMIGLPNM, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? FMANHOIBMNH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? LMBEEHNKLIN, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? CCGMPJCIHNJ, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? PEJOEFOHHNA, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? EJLPIIPMKNP, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NEDCPOKCLKH, [Optional] HJMIGGAAOEM<TContext, TDeps, TCompileState>? NEHMECAIBGL) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28E69C0", Offset = "0x28E53C0", VA = "0x1828E69C0")]
	private static int OPBHGJMEBML([In] KEIHFOCJOJN<byte> PHBACDCOLMA, KEIHFOCJOJN<byte> NNIEOPCEMIL, int HKECPJKDGLJ, int IMCIONKBBCL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FLPOJAODKLF
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int NDKJADKBFGG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AEC0", Offset = "0x3A498C0", VA = "0x183A4AEC0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<T>> IJHBHACLAGK<T>([In] this KEIHFOCJOJN<byte> NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AF10", Offset = "0x3A49910", VA = "0x183A4AF10")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<T>>> KJICHLNECEC<T>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<DBKGEMIMENE<T>>? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28E67E0", Offset = "0x28E51E0", VA = "0x1828E67E0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<NMDBEOHACCF>> LCEMANPCMNF(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NMDBEOHACCF>? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<NMDBEOHACCF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28E6640", Offset = "0x28E5040", VA = "0x1828E6640")]
	public static EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>> GCMGBBGILMK(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] float? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28E6570", Offset = "0x28E4F70", VA = "0x1828E6570")]
	public static EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>> FKDKOFINGOC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28E63B0", Offset = "0x28E4DB0", VA = "0x1828E63B0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>> AFPDFBJOOKD(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<JGGKNECOACC>? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28E6480", Offset = "0x28E4E80", VA = "0x1828E6480")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DPHKNILNJIK>> BPLAKGDDKEL(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] byte? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DPHKNILNJIK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28E6710", Offset = "0x28E5110", VA = "0x1828E6710")]
	public static EHLNDDDNIPO<DBKGEMIMENE<PJODMDDODDF>> HHFHGDGODNF(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<PJODMDDODDF>? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<PJODMDDODDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28E68B0", Offset = "0x28E52B0", VA = "0x1828E68B0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> NEJJPHPHHBG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] PKEBBPBCLND? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AFD0", Offset = "0x3A499D0", VA = "0x183A4AFD0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<T>>> MJICILDBEKA<T>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<T>>? PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28E08B0", Offset = "0x28DF2B0", VA = "0x1828E08B0")]
	public static void KOLPPPLJOFG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>> OHMFHEDIMFB, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B090", Offset = "0x3A49A90", VA = "0x183A4B090")]
	public static void PLMOECHCAEA<T>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<T>>> DDJAIBEMOAN, EHLNDDDNIPO<DBKGEMIMENE<T>> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B090", Offset = "0x3A49A90", VA = "0x183A4B090")]
	public static void MOCNOBMJNCE<T>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<T>>> PAHDKHBFBCA, EHLNDDDNIPO<NKFCLCHDDPH<T>> PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DPFCAMOIIPD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28E6270", Offset = "0x28E4C70", VA = "0x1828E6270")]
	public static ILCBHHHGFAE ENCCHNMEOKL([In] this ReadOnlySpan<byte> OKLLDHNGOMI, int KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28E62E0", Offset = "0x28E4CE0", VA = "0x1828E62E0")]
	public static ILCBHHHGFAE ENCCHNMEOKL([In] this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38D7660", Offset = "0x38D6060", VA = "0x1838D7660")]
	public static ILCBHHHGFAE ENCCHNMEOKL<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38D7550", Offset = "0x38D5F50", VA = "0x1838D7550")]
	public static ILCBHHHGFAE ENCCHNMEOKL<M>([In] this AGKLHKILPEK<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38D7410", Offset = "0x38D5E10", VA = "0x1838D7410")]
	public static ILCBHHHGFAE ENCCHNMEOKL<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38D7480", Offset = "0x38D5E80", VA = "0x1838D7480")]
	public static ILCBHHHGFAE ENCCHNMEOKL<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38D74E0", Offset = "0x38D5EE0", VA = "0x1838D74E0")]
	public static ILCBHHHGFAE ENCCHNMEOKL<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28E6270", Offset = "0x28E4C70", VA = "0x1828E6270")]
	public static int DGBAIJCJBDH([In] this ReadOnlySpan<byte> OKLLDHNGOMI, int KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x28E0740", Offset = "0x28DF140", VA = "0x1828E0740")]
	public static int DGBAIJCJBDH([In] this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80")]
	public static int DGBAIJCJBDH<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80")]
	public static int DGBAIJCJBDH<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80")]
	public static int DGBAIJCJBDH<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80")]
	public static int DGBAIJCJBDH<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38D7770", Offset = "0x38D6170", VA = "0x1838D7770")]
	public static float JLIBAFGHAEL<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38D7770", Offset = "0x38D6170", VA = "0x1838D7770")]
	public static float JLIBAFGHAEL<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38D7770", Offset = "0x38D6170", VA = "0x1838D7770")]
	public static float JLIBAFGHAEL<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38D7370", Offset = "0x38D5D70", VA = "0x1838D7370")]
	public static byte DHKHICEAJCF<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38D7460", Offset = "0x38D5E60", VA = "0x1838D7460")]
	public static byte DHKHICEAJCF<M>([In] this AGKLHKILPEK<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38D7410", Offset = "0x38D5E10", VA = "0x1838D7410")]
	public static byte DHKHICEAJCF<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x38D7480", Offset = "0x38D5E80", VA = "0x1838D7480")]
	public static byte DHKHICEAJCF<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38D73A0", Offset = "0x38D5DA0", VA = "0x1838D73A0")]
	public static byte DHKHICEAJCF<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28E0740", Offset = "0x28DF140", VA = "0x1828E0740")]
	public static PKEBBPBCLND MLLJKDLAPFD([In] this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP)
	{
		return default(PKEBBPBCLND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C80", Offset = "0x2FF0680", VA = "0x182FF1C80")]
	public static PKEBBPBCLND MLLJKDLAPFD<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(PKEBBPBCLND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38D7910", Offset = "0x38D6310", VA = "0x1838D7910")]
	public static EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> KNJMKEPLJLL<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38D7970", Offset = "0x38D6370", VA = "0x1838D7970")]
	public static EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> KNJMKEPLJLL<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38D78B0", Offset = "0x38D62B0", VA = "0x1838D78B0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> KNJMKEPLJLL<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x38D79D0", Offset = "0x38D63D0", VA = "0x1838D79D0")]
	public static EHLNDDDNIPO<NKFCLCHDDPH<GJCAOKDFKPI>> PAKJIENMLPO<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<NKFCLCHDDPH<GJCAOKDFKPI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38D7310", Offset = "0x38D5D10", VA = "0x1838D7310")]
	public static EHLNDDDNIPO<PJODMDDODDF> BJMPNGINGIM<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<PJODMDDODDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38D7250", Offset = "0x38D5C50", VA = "0x1838D7250")]
	public static EHLNDDDNIPO<PJODMDDODDF> BJMPNGINGIM<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<PJODMDDODDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38D72B0", Offset = "0x38D5CB0", VA = "0x1838D72B0")]
	public static EHLNDDDNIPO<PJODMDDODDF> BJMPNGINGIM<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<PJODMDDODDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38D7790", Offset = "0x38D6190", VA = "0x1838D7790")]
	public static EHLNDDDNIPO<NMDBEOHACCF> KBGJJAIEGAF<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<NMDBEOHACCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38D77F0", Offset = "0x38D61F0", VA = "0x1838D77F0")]
	public static EHLNDDDNIPO<NMDBEOHACCF> KBGJJAIEGAF<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<NMDBEOHACCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x38D7850", Offset = "0x38D6250", VA = "0x1838D7850")]
	public static EHLNDDDNIPO<JGGKNECOACC> KGONCAOMBNG<M>(this MAHLJAIOJIO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP)
	{
		return default(EHLNDDDNIPO<JGGKNECOACC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MMGBNFDHPHH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28E6B90", Offset = "0x28E5590", VA = "0x1828E6B90")]
	public static void CMKNCEEAOKG(this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP, ILCBHHHGFAE PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28E6AA0", Offset = "0x28E54A0", VA = "0x1828E6AA0")]
	public static void CMKNCEEAOKG(this byte[] OKLLDHNGOMI, int KJPOKAJCMFP, ILCBHHHGFAE PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28E6B10", Offset = "0x28E5510", VA = "0x1828E6B10")]
	public static void CMKNCEEAOKG([In] this Span<byte> OKLLDHNGOMI, int KJPOKAJCMFP, ILCBHHHGFAE PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B58910", Offset = "0x3B57310", VA = "0x183B58910")]
	public static void CMKNCEEAOKG<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, ILCBHHHGFAE PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B58A00", Offset = "0x3B57400", VA = "0x183B58A00")]
	public static void CMKNCEEAOKG<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, ILCBHHHGFAE PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28E08B0", Offset = "0x28DF2B0", VA = "0x1828E08B0")]
	public static void KOLPPPLJOFG(this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28E6C50", Offset = "0x28E5650", VA = "0x1828E6C50")]
	public static void KOLPPPLJOFG(this byte[] OKLLDHNGOMI, int KJPOKAJCMFP, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28E6CD0", Offset = "0x28E56D0", VA = "0x1828E6CD0")]
	public static void KOLPPPLJOFG([In] this Span<byte> OKLLDHNGOMI, int KJPOKAJCMFP, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B58AF0", Offset = "0x3B574F0", VA = "0x183B58AF0")]
	public static void KOLPPPLJOFG<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B58B40", Offset = "0x3B57540", VA = "0x183B58B40")]
	public static void KOLPPPLJOFG<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28E6A60", Offset = "0x28E5460", VA = "0x1828E6A60")]
	public static void CGNEIBOJDLL(this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B58870", Offset = "0x3B57270", VA = "0x183B58870")]
	public static void CGNEIBOJDLL<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B588C0", Offset = "0x3B572C0", VA = "0x183B588C0")]
	public static void CGNEIBOJDLL<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28E6D50", Offset = "0x28E5750", VA = "0x1828E6D50")]
	public static void NGKEHMPDDKM(this KEIHFOCJOJN<byte> OKLLDHNGOMI, int KJPOKAJCMFP, byte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B58B90", Offset = "0x3B57590", VA = "0x183B58B90")]
	public static void NGKEHMPDDKM<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, byte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B58BC0", Offset = "0x3B575C0", VA = "0x183B58BC0")]
	public static void NGKEHMPDDKM<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, byte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10")]
	public static void PLMOECHCAEA<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10")]
	public static void PLMOECHCAEA<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10")]
	public static void BBMACAACMHM<M>(this NMAEHOBGMFM<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, EHLNDDDNIPO<PJODMDDODDF> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D10", Offset = "0x2FF0710", VA = "0x182FF1D10")]
	public static void BBMACAACMHM<M>([In] this GBIPFNAJKFO<M, byte> OKLLDHNGOMI, EHLNDDDNIPO<M> KJPOKAJCMFP, EHLNDDDNIPO<PJODMDDODDF> PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ABLGEAIJJOG
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x28E22C0", Offset = "0x28E0CC0", VA = "0x1828E22C0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) FBBJEEFKAIO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28E3BE0", Offset = "0x28E25E0", VA = "0x1828E3BE0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) INMLDIKLKDD(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28E1390", Offset = "0x28DFD90", VA = "0x1828E1390")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) CHKBGGGNKBG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28E0B60", Offset = "0x28DF560", VA = "0x1828E0B60")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) AMIIFELDAPI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28E1ED0", Offset = "0x28E08D0", VA = "0x1828E1ED0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) EBCHNGEONIA(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28E4770", Offset = "0x28E3170", VA = "0x1828E4770")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KMPKHKEINMC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28E1AB0", Offset = "0x28E04B0", VA = "0x1828E1AB0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) DEELEKIAABE(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28E4EA0", Offset = "0x28E38A0", VA = "0x1828E4EA0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) MKHIAIBOFCN(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28E1160", Offset = "0x28DFB60", VA = "0x1828E1160")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) BJGIKDAABNO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28E53B0", Offset = "0x28E3DB0", VA = "0x1828E53B0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>) NBGDDLJACGC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? PCDAHJCDHHF, [Optional] EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? DNHPAFBONEO)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28E6030", Offset = "0x28E4A30", VA = "0x1828E6030")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>) PONLEFJBBOJ(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? PCDAHJCDHHF, [Optional] EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? DNHPAFBONEO)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28E0F30", Offset = "0x28DF930", VA = "0x1828E0F30")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>) BBOLMLKMCBE(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? PCDAHJCDHHF, [Optional] EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? DNHPAFBONEO)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28E0E10", Offset = "0x28DF810", VA = "0x1828E0E10")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>) ANPJMBGAHDB(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? PCDAHJCDHHF, [Optional] EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? DNHPAFBONEO)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28E1C10", Offset = "0x28E0610", VA = "0x1828E1C10")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NMDBEOHACCF>>) DHIKCIKBFBH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? EALJFLECJEK, [Optional] EHLNDDDNIPO<NMDBEOHACCF>? IDNDDAFIIDI)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NMDBEOHACCF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28E5150", Offset = "0x28E3B50", VA = "0x1828E5150")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<NMDBEOHACCF>>>) MKOEODFAIIO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? EALJFLECJEK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<NMDBEOHACCF>>? IDNDDAFIIDI)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<NMDBEOHACCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E1BA0", VA = "0x1828E31A0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<PJODMDDODDF>>) HMBOEPJFPIK(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? EALJFLECJEK, [Optional] EHLNDDDNIPO<PJODMDDODDF>? IDNDDAFIIDI)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<PJODMDDODDF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28E1280", Offset = "0x28DFC80", VA = "0x1828E1280")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<PJODMDDODDF>>>) BMJELEDGMLP(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? EALJFLECJEK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<PJODMDDODDF>>? IDNDDAFIIDI)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<PJODMDDODDF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF7F0", Offset = "0x2FFE1F0", VA = "0x182FFF7F0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>) JLAKLANBPME<TMarker>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<JGGKNECOACC>? IDNDDAFIIDI, [Optional][In] ReadOnlySpan<byte> HPGIDELCODH)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28E5C50", Offset = "0x28E4650", VA = "0x1828E5C50")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) OLIAFEIEELE(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int PHBACDCOLMA, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NNIEOPCEMIL)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28E55F0", Offset = "0x28E3FF0", VA = "0x1828E55F0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) NGKMDMDBMOM(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? PHBACDCOLMA, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NNIEOPCEMIL)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2FFFB00", Offset = "0x2FFE500", VA = "0x182FFFB00")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>) MHJIFHOLMBP<TMarker>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<TMarker>>? NNIEOPCEMIL, [Optional] int? OPKPFANIILK, [Optional][In] ReadOnlySpan<byte> PHBACDCOLMA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF9E0", Offset = "0x2FFE3E0", VA = "0x182FFF9E0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>) JONELEFPCKE<TMarker>(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<TMarker>>? PHBACDCOLMA, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<TMarker>>? NNIEOPCEMIL, [Optional] int? OPKPFANIILK)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<TMarker>>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28E3670", Offset = "0x28E2070", VA = "0x1828E3670")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) ICAKJPLGLEH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28E2E00", Offset = "0x28E1800", VA = "0x1828E2E00")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) HAMIDLNDFMC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x28E4D80", Offset = "0x28E3780", VA = "0x1828E4D80")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) MGLEDFMCJNO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28E49B0", Offset = "0x28E33B0", VA = "0x1828E49B0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) LJKCOOLJPJN(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28E5260", Offset = "0x28E3C60", VA = "0x1828E5260")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) NAOENOMKNDI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28E4890", Offset = "0x28E3290", VA = "0x1828E4890")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) LGEJLPCHIED(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28E4FF0", Offset = "0x28E39F0", VA = "0x1828E4FF0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) MKNNLAPHMBA(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28E34A0", Offset = "0x28E1EA0", VA = "0x1828E34A0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) IABALHBPKEM(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28E1DB0", Offset = "0x28E07B0", VA = "0x1828E1DB0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) DIAIPCJNJDJ(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28E19C0", Offset = "0x28E03C0", VA = "0x1828E19C0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>) DDPNLMLLABI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? BFOCHNOBPGF)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28E3E90", Offset = "0x28E2890", VA = "0x1828E3E90")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) JDJLDBCCJDC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x28E08F0", Offset = "0x28DF2F0", VA = "0x1828E08F0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) AFIJAKAFAEH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28E42C0", Offset = "0x28E2CC0", VA = "0x1828E42C0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KFPNFCIFPMN(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x28E2CA0", Offset = "0x28E16A0", VA = "0x1828E2CA0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) GMDAKIIOJMI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x28E4B10", Offset = "0x28E3510", VA = "0x1828E4B10")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) MEIBKHECCHC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x28E4540", Offset = "0x28E2F40", VA = "0x1828E4540")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KKAAHCIMBML(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28E5980", Offset = "0x28E4380", VA = "0x1828E5980")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) OBLODHFKKKC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D80", Offset = "0x28E4780", VA = "0x1828E5D80")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) ONJPEKFOHJM(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28E1730", Offset = "0x28E0130", VA = "0x1828E1730")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) CMODIKMPLAC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28E3340", Offset = "0x28E1D40", VA = "0x1828E3340")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) HNOIPHLMEHA(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28E43F0", Offset = "0x28E2DF0", VA = "0x1828E43F0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KGNMLDGBAIH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28E1610", Offset = "0x28E0010", VA = "0x1828E1610")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) CLEOMBECIEH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x28E2B20", Offset = "0x28E1520", VA = "0x1828E2B20")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) GLEPFIAGKIG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x28E14B0", Offset = "0x28DFEB0", VA = "0x1828E14B0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) CKGMCOECAHG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x28E3070", Offset = "0x28E1A70", VA = "0x1828E3070")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) HKNEHHNCDOL(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x28E4160", Offset = "0x28E2B60", VA = "0x1828E4160")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KECGDFPAFON(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x28E29D0", Offset = "0x28E13D0", VA = "0x1828E29D0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) GEENAAGPMJH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28E6150", Offset = "0x28E4B50", VA = "0x1828E6150")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) PPMCAJFGIEG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x28E2020", Offset = "0x28E0A20", VA = "0x1828E2020")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) EGOJEOHPHGF(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x28E3D30", Offset = "0x28E2730", VA = "0x1828E3D30")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) JBAIIIENADE(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x28E54C0", Offset = "0x28E3EC0", VA = "0x1828E54C0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) NFJHBIGNCIA(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x28E1860", Offset = "0x28E0260", VA = "0x1828E1860")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) DDEHDHFENOF(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x28E5EE0", Offset = "0x28E48E0", VA = "0x1828E5EE0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) PIJDHMJIBPI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28E37F0", Offset = "0x28E21F0", VA = "0x1828E37F0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) IECFGIPBNEC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28E25A0", Offset = "0x28E0FA0", VA = "0x1828E25A0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) FLNAFEGEHLE(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28E3910", Offset = "0x28E2310", VA = "0x1828E3910")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) IJCDLPHHPBI(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28E4C60", Offset = "0x28E3660", VA = "0x1828E4C60")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) MGHDBIOAHEC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28E5820", Offset = "0x28E4220", VA = "0x1828E5820")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) NKJLIGHDPFL(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x28E4010", Offset = "0x28E2A10", VA = "0x1828E4010")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) JKELFLJLFAB(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28E2F50", Offset = "0x28E1950", VA = "0x1828E2F50")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) HBAFPOHAIJG(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28E4660", Offset = "0x28E3060", VA = "0x1828E4660")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) KKLNCPKHNPN(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] int? BCOBFNFCJAC, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28E0A50", Offset = "0x28DF450", VA = "0x1828E0A50")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) AKKEDOPPNHO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? BCOBFNFCJAC, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28E35F0", Offset = "0x28E1FF0", VA = "0x1828E35F0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> IBJIGKNMDPG(this KEIHFOCJOJN<byte> NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28E3A60", Offset = "0x28E2460", VA = "0x1828E3A60")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) IMDBJHOPLJJ(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28E5B00", Offset = "0x28E4500", VA = "0x1828E5B00")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) OFEEBDJILHH(this KEIHFOCJOJN<byte> NMEFAPBBOCD, float HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<CNPBEMHJCCG>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28E1040", Offset = "0x28DFA40", VA = "0x1828E1040")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>) BEFJNHKAHOC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<CNPBEMHJCCG>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<CNPBEMHJCCG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28E2440", Offset = "0x28E0E40", VA = "0x1828E2440")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) FCCLJGMGHMJ(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28E2720", Offset = "0x28E1120", VA = "0x1828E2720")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) GCJICCADADA(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28E21A0", Offset = "0x28E0BA0", VA = "0x1828E21A0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) EKADIDJCBKO(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x28E2870", Offset = "0x28E1270", VA = "0x1828E2870")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) GDNGDKJEMGC(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28E0CC0", Offset = "0x28DF6C0", VA = "0x1828E0CC0")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) ANNBKHGIMGF(this KEIHFOCJOJN<byte> NMEFAPBBOCD, int HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28E5700", Offset = "0x28E4100", VA = "0x1828E5700")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>) NJOKPIFAAHK(this KEIHFOCJOJN<byte> NMEFAPBBOCD, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? HPEEBFHHNPH, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? EKNFFHMABLK, [Optional] EHLNDDDNIPO<NKFCLCHDDPH<HHAFOACDJND>>? NFAAILIGODA)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<HHAFOACDJND>>>));
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
