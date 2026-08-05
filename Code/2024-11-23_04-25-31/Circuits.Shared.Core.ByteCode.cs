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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x2289BF0", Offset = "0x22885F0", VA = "0x182289BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PBBBPDBDJGH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF23F0", Offset = "0x2CF0DF0", VA = "0x182CF23F0")]
	public static NOPFJADADBI<ACFBJOPIBOB<M>> JACMIKPJDII<M>(this int PCBICLOONMH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2289C70", Offset = "0x2288670", VA = "0x182289C70")]
	public static NOPFJADADBI<ADFOFFNBIKO> KGPABPOEOMN(this int PCBICLOONMH)
	{
		return default(NOPFJADADBI<ADFOFFNBIKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CF23F0", Offset = "0x2CF0DF0", VA = "0x182CF23F0")]
	public static NOPFJADADBI<OPDCBLEDMIE<M>> IOGIEOEJDHH<M>(this int PCBICLOONMH)
	{
		return default(NOPFJADADBI<OPDCBLEDMIE<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ACFBJOPIBOB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NOIHKCFBDOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NBENDKHIFGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ADFOFFNBIKO
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class IABLFHALDHN
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BAFAMAEEEIG
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GFEANCFOECJ
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
public static class PKKODELJFMA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct COHBFLNHEGN<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr DLOAANIEKCO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
		public COHBFLNHEGN(IntPtr OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56FC470", Offset = "0x56FAE70", VA = "0x1856FC470")]
		public int GHJBKJMLHEK(TDeps JOIGIEDFOGO, TContext LOPOPGPCNHD, TCompileState DOCBOBCOFOI, [In] BAOLKDDJFBI<byte> MFHPCPIGCIM, int HGDGHJBCDHN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3092E70", Offset = "0x3091870", VA = "0x183092E70")]
	public static void EJNNCJBKAHD<TDeps, TContext, TCompileState>(TDeps JOIGIEDFOGO, TContext LOPOPGPCNHD, TCompileState DOCBOBCOFOI, [In] BAOLKDDJFBI<byte> FHIEMFFLKEB, BAOLKDDJFBI<byte> KABEOGBNIKB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FNJBJMOCEAP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LDJHKEHBCNL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MLKAMELCJJF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KBJBBELJBNF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NMFEJGGCNCJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DDCEOIDFMHG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JDHBCDDBAEP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FKPKPEGPBII, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OFBKJKELAMB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GJIFOKLJLHN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GDMEPGIJOMF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KLEDFJONNOM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IICJLPPIMPA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DEEEFJOEMFB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AJNCCEIIIIE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LCJHKJEICGK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IDABMJPNACE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HHCPMCDIMDL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AEGGFOGPGMG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ABBGANPHCGP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CDEHMLDLPAI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ACAOFALIIBA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GMFAGDPIFIB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IPMDMBKIGGD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PAIEJNFJAOK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PMODLJNOKFL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FNAPLGDCKCP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IBDNDJONNOJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ADDKOPAKBOK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JFPCIGNHKJK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LIAMCOBDHLA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DLEGAFHNOFH, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ICJBHOJIJMC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GOGDKBMEFHG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HNBBHLKNNHO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IPFLODKHCJL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GONGBEBPAKP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FBPDLDBEKKN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CHCAAKGDMGO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LIBIJOPDAKP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ODAECEENHCM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ABPCPOMCJFL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GPIOJDMCOBI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? EFFGDJDNLMD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? EABHILANFBJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HNGOOOAMADP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BLIBKFDMHCG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OFFHLOEPODN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IOHPJNOCNKE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HEKJJNGHGOB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AEJHFMNCBFL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LIFNHDNBBCO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JBMCOHBDDFG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HOBBJAMDHIG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PLPPCEBMAPB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NAKBDOFAKHD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? INGGDHIBPCL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IMKFHPFJOCJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PLODLJNNJHD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PHLOKPJCGMP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DLJOGEGAINN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OGABDLHBHPN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IGPLPDENOAG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PAJPEGEGPLO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MAJKACOMFJC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MBPBLMNJHKP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IFMKJNMLLJL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LGJBNBALHDM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IFKOKOANAHC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CAFBBENIIJL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GFOCOHAGLGA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DIDJEHMJEHG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NMKIHJEGONG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ELKHICNPFPP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BIBPBNGFCLG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LFPPMOINFJC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JMJCGMMMPCM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AAODDOOGNMP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HCOCDKFCEMH, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LNMEINMEHJA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NKJDNNDECLF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IMCNBBAPABC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HCEHGHALNIF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JMNPLPEMJEJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LACAJHAHDLC, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BBODNFLBLCN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? COIOOOPLLPK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JHHKAHIFPDI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OCPHHCHLKAO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KPKDIPCMGKP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KHEHEAEJPIP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KFJBNANAEHF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ICBLODLGKOP, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ALFADLNNLEE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NBJKEPHLADB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NIOBNPCFKLD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MIJGMAGMICG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PBPMHPPMHMF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HKMPOKHNGGN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BMCKCBAEAHL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? HAIOIFJIHCB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PONGHBOIKCA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NBFMFNMAAJL, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CAFIFCJFPAE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DNNGKHNGFLM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MOCFACJGBLI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ONPAEJFCIHI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DOOEKKELEIB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BCHPEFEFMME, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JCAKOLDHOLF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AHEELGFGHIO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IHJOOIMJMMO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LIHFIGEGPOD, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? PBLNGDCAEOA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? GINMPEDGFOE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? AKBIJPDOHMM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? KNIEDNMAKMI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NBLKJLPNDLM, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DDBKDAEEPND, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CDKPELDPGBJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? MMLGFBNAIIG, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ENDHDACPHKI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FAMGKBJEELI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? BEDKBHFHNAB, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OEKFJEBAGOO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? FJGPGJOMEDH, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? JOPJHMKBOHN, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? OFGLMBNDNKF, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? DKNPIBNIMBK, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? ACDOKEBCOPI, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? CMPHBIIGEMO, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LOHHONOIMKA, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? NELHHMDALPE, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? IHFBFCECNJJ, [Optional] COHBFLNHEGN<TContext, TDeps, TCompileState>? LGNACIDIFPA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2289CA0", Offset = "0x22886A0", VA = "0x182289CA0")]
	private static int HEANPPHEEGJ([In] BAOLKDDJFBI<byte> LFAPGGMCBIK, BAOLKDDJFBI<byte> DIJABOFBAKO, int CIFAFIDMMAE, int FPDJICFHLGM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NNOMBLMNNOM
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int FIHPDCLAEAF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x30577E0", Offset = "0x30561E0", VA = "0x1830577E0")]
	public static NOPFJADADBI<ACFBJOPIBOB<T>> DHBNCOCLGFD<T>([In] this BAOLKDDJFBI<byte> PCBICLOONMH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3057720", Offset = "0x3056120", VA = "0x183057720")]
	public static NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<T>>> CMOBBBIGCCA<T>(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<ACFBJOPIBOB<T>>? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2289720", Offset = "0x2288120", VA = "0x182289720")]
	public static NOPFJADADBI<ACFBJOPIBOB<ICMHLEAALBM>> JPICIOMFIJL(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<ICMHLEAALBM>? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<ICMHLEAALBM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2289550", Offset = "0x2287F50", VA = "0x182289550")]
	public static NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>> BDBIBCPPJOM(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] float? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22899F0", Offset = "0x22883F0", VA = "0x1822899F0")]
	public static NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>> NOAGJHLHPEB(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2289640", Offset = "0x2288040", VA = "0x182289640")]
	public static NOPFJADADBI<ACFBJOPIBOB<MBPEAGGMMEG>> HHKJECHHBAD(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<MBPEAGGMMEG>? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<MBPEAGGMMEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2289800", Offset = "0x2288200", VA = "0x182289800")]
	public static NOPFJADADBI<ACFBJOPIBOB<BAFAMAEEEIG>> KDBJKFMLFHI(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] byte? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<BAFAMAEEEIG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2289AD0", Offset = "0x22884D0", VA = "0x182289AD0")]
	public static NOPFJADADBI<ACFBJOPIBOB<ADFOFFNBIKO>> NOJHNCJPPIN(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<ADFOFFNBIKO>? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<ADFOFFNBIKO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2289900", Offset = "0x2288300", VA = "0x182289900")]
	public static NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>> MAPLNDLEFGP(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] GFEANCFOECJ? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3057840", Offset = "0x3056240", VA = "0x183057840")]
	public static NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<T>>> GDKCAIKIFOG<T>(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<T>>? PKCLPFEIPFH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2283720", Offset = "0x2282120", VA = "0x182283720")]
	public static void NFDODIFGDOI(this BAOLKDDJFBI<byte> PCBICLOONMH, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>> FNJIDGMLGNJ, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3057900", Offset = "0x3056300", VA = "0x183057900")]
	public static void JMNNBOKHPKE<T>(this BAOLKDDJFBI<byte> PCBICLOONMH, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<T>>> HGDGHJBCDHN, NOPFJADADBI<ACFBJOPIBOB<T>> PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3057900", Offset = "0x3056300", VA = "0x183057900")]
	public static void GMMCAEIPGAM<T>(this BAOLKDDJFBI<byte> PCBICLOONMH, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<T>>> NBFHHIGLLNG, NOPFJADADBI<OPDCBLEDMIE<T>> PKCLPFEIPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GIADEKOPLFH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2283760", Offset = "0x2282160", VA = "0x182283760")]
	public static IGKJGOKFFBO HAMJIAPDLNI([In] this ReadOnlySpan<byte> FFGGPAIGPAA, int DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22837D0", Offset = "0x22821D0", VA = "0x1822837D0")]
	public static IGKJGOKFFBO HAMJIAPDLNI([In] this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2EED940", Offset = "0x2EEC340", VA = "0x182EED940")]
	public static IGKJGOKFFBO HAMJIAPDLNI<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDA90", Offset = "0x2EEC490", VA = "0x182EEDA90")]
	public static IGKJGOKFFBO HAMJIAPDLNI<M>([In] this NJHIOKELBPI<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2EED770", Offset = "0x2EEC170", VA = "0x182EED770")]
	public static IGKJGOKFFBO HAMJIAPDLNI<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2EED620", Offset = "0x2EEC020", VA = "0x182EED620")]
	public static IGKJGOKFFBO HAMJIAPDLNI<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2EED880", Offset = "0x2EEC280", VA = "0x182EED880")]
	public static IGKJGOKFFBO HAMJIAPDLNI<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2283760", Offset = "0x2282160", VA = "0x182283760")]
	public static int LHOHJMENDFE([In] this ReadOnlySpan<byte> FFGGPAIGPAA, int DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2283650", Offset = "0x2282050", VA = "0x182283650")]
	public static int LHOHJMENDFE([In] this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D292D0", Offset = "0x2D27CD0", VA = "0x182D292D0")]
	public static int LHOHJMENDFE<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2D292D0", Offset = "0x2D27CD0", VA = "0x182D292D0")]
	public static int LHOHJMENDFE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2D292D0", Offset = "0x2D27CD0", VA = "0x182D292D0")]
	public static int LHOHJMENDFE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2D292D0", Offset = "0x2D27CD0", VA = "0x182D292D0")]
	public static int LHOHJMENDFE<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2EED840", Offset = "0x2EEC240", VA = "0x182EED840")]
	public static float FGDKPCFIOPA<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2EED840", Offset = "0x2EEC240", VA = "0x182EED840")]
	public static float FGDKPCFIOPA<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EED840", Offset = "0x2EEC240", VA = "0x182EED840")]
	public static float FGDKPCFIOPA<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2EED5F0", Offset = "0x2EEBFF0", VA = "0x182EED5F0")]
	public static byte DEKIMNMIEAE<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2EED750", Offset = "0x2EEC150", VA = "0x182EED750")]
	public static byte DEKIMNMIEAE<M>([In] this NJHIOKELBPI<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2EED770", Offset = "0x2EEC170", VA = "0x182EED770")]
	public static byte DEKIMNMIEAE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2EED620", Offset = "0x2EEC020", VA = "0x182EED620")]
	public static byte DEKIMNMIEAE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2EED690", Offset = "0x2EEC090", VA = "0x182EED690")]
	public static byte DEKIMNMIEAE<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2283650", Offset = "0x2282050", VA = "0x182283650")]
	public static GFEANCFOECJ LHOLFJLCCOP([In] this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL)
	{
		return default(GFEANCFOECJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D292D0", Offset = "0x2D27CD0", VA = "0x182D292D0")]
	public static GFEANCFOECJ LHOLFJLCCOP<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(GFEANCFOECJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDE20", Offset = "0x2EEC820", VA = "0x182EEDE20")]
	public static NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>> OHPOPPMECGP<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDE90", Offset = "0x2EEC890", VA = "0x182EEDE90")]
	public static NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>> OHPOPPMECGP<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDF00", Offset = "0x2EEC900", VA = "0x182EEDF00")]
	public static NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>> OHPOPPMECGP<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDF70", Offset = "0x2EEC970", VA = "0x182EEDF70")]
	public static NOPFJADADBI<OPDCBLEDMIE<GEDLMAFMEHG>> PLLPFNMBKDF<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<OPDCBLEDMIE<GEDLMAFMEHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDCD0", Offset = "0x2EEC6D0", VA = "0x182EEDCD0")]
	public static NOPFJADADBI<ADFOFFNBIKO> LBPGOFNOKIG<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ADFOFFNBIKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDBF0", Offset = "0x2EEC5F0", VA = "0x182EEDBF0")]
	public static NOPFJADADBI<ADFOFFNBIKO> LBPGOFNOKIG<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ADFOFFNBIKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDC60", Offset = "0x2EEC660", VA = "0x182EEDC60")]
	public static NOPFJADADBI<ADFOFFNBIKO> LBPGOFNOKIG<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ADFOFFNBIKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDDB0", Offset = "0x2EEC7B0", VA = "0x182EEDDB0")]
	public static NOPFJADADBI<ICMHLEAALBM> LPOJEJIPDAG<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ICMHLEAALBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDD40", Offset = "0x2EEC740", VA = "0x182EEDD40")]
	public static NOPFJADADBI<ICMHLEAALBM> LPOJEJIPDAG<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<ICMHLEAALBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EED7D0", Offset = "0x2EEC1D0", VA = "0x182EED7D0")]
	public static NOPFJADADBI<MBPEAGGMMEG> DHOEOEOJPBN<M>(this INBOFADIBMC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL)
	{
		return default(NOPFJADADBI<MBPEAGGMMEG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFNHABJDNGB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2289310", Offset = "0x2287D10", VA = "0x182289310")]
	public static void LHHEDKPDPOE(this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL, IGKJGOKFFBO PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22892A0", Offset = "0x2287CA0", VA = "0x1822892A0")]
	public static void LHHEDKPDPOE(this byte[] FFGGPAIGPAA, int DOLPOJJLONL, IGKJGOKFFBO PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22893D0", Offset = "0x2287DD0", VA = "0x1822893D0")]
	public static void LHHEDKPDPOE([In] this Span<byte> FFGGPAIGPAA, int DOLPOJJLONL, IGKJGOKFFBO PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBE40", Offset = "0x2FDA840", VA = "0x182FDBE40")]
	public static void LHHEDKPDPOE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, IGKJGOKFFBO PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBCA0", Offset = "0x2FDA6A0", VA = "0x182FDBCA0")]
	public static void LHHEDKPDPOE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, IGKJGOKFFBO PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2283720", Offset = "0x2282120", VA = "0x182283720")]
	public static void NFDODIFGDOI(this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22894D0", Offset = "0x2287ED0", VA = "0x1822894D0")]
	public static void NFDODIFGDOI(this byte[] FFGGPAIGPAA, int DOLPOJJLONL, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2289450", Offset = "0x2287E50", VA = "0x182289450")]
	public static void NFDODIFGDOI([In] this Span<byte> FFGGPAIGPAA, int DOLPOJJLONL, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC040", Offset = "0x2FDAA40", VA = "0x182FDC040")]
	public static void NFDODIFGDOI<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBFE0", Offset = "0x2FDA9E0", VA = "0x182FDBFE0")]
	public static void NFDODIFGDOI<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2289260", Offset = "0x2287C60", VA = "0x182289260")]
	public static void JOFHHOMOMND(this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBC40", Offset = "0x2FDA640", VA = "0x182FDBC40")]
	public static void JOFHHOMOMND<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBBE0", Offset = "0x2FDA5E0", VA = "0x182FDBBE0")]
	public static void JOFHHOMOMND<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22891F0", Offset = "0x2287BF0", VA = "0x1822891F0")]
	public static void JHJBDEJCNBE(this BAOLKDDJFBI<byte> FFGGPAIGPAA, int DOLPOJJLONL, byte PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBB40", Offset = "0x2FDA540", VA = "0x182FDBB40")]
	public static void JHJBDEJCNBE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, byte PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDBB90", Offset = "0x2FDA590", VA = "0x182FDBB90")]
	public static void JHJBDEJCNBE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, byte PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D27EB0", VA = "0x182D294B0")]
	public static void JMNNBOKHPKE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>> PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D27EB0", VA = "0x182D294B0")]
	public static void JMNNBOKHPKE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, NOPFJADADBI<ACFBJOPIBOB<GEDLMAFMEHG>> PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D27EB0", VA = "0x182D294B0")]
	public static void PEIODHAFADE<M>(this MJLNGMPMENC<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, NOPFJADADBI<ADFOFFNBIKO> PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D27EB0", VA = "0x182D294B0")]
	public static void PEIODHAFADE<M>([In] this AEEOMFKLFGN<M, byte> FFGGPAIGPAA, NOPFJADADBI<M> DOLPOJJLONL, NOPFJADADBI<ADFOFFNBIKO> PKCLPFEIPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JFMGHGLBPKM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2287230", Offset = "0x2285C30", VA = "0x182287230")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) LHDGJOHKMAG(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2286CE0", Offset = "0x22856E0", VA = "0x182286CE0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) KAKNIJNIJIJ(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2287110", Offset = "0x2285B10", VA = "0x182287110")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) LGOLFNHGNMA(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2286930", Offset = "0x2285330", VA = "0x182286930")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) JFLEHLKGIHN(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2284640", Offset = "0x2283040", VA = "0x182284640")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) BPJPKJFIFNL(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2287A00", Offset = "0x2286400", VA = "0x182287A00")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) MLHFIDENCCP(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2288A20", Offset = "0x2287420", VA = "0x182288A20")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) PDPLOLNPJOJ(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2285CD0", Offset = "0x22846D0", VA = "0x182285CD0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FOLEBGIKFOB(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22890D0", Offset = "0x2287AD0", VA = "0x1822890D0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) PPPCCNDJEME(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2285290", Offset = "0x2283C90", VA = "0x182285290")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>) DOKIFMAIDCC(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? PKCLPFEIPFH, [Optional] NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>? GNOHFGANIIG)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2286BC0", Offset = "0x22855C0", VA = "0x182286BC0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>) JOLFGIHNNGD(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? PKCLPFEIPFH, [Optional] NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>? GNOHFGANIIG)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2284170", Offset = "0x2282B70", VA = "0x182284170")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>) ANMBFEJOJFE(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? PKCLPFEIPFH, [Optional] NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>? GNOHFGANIIG)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22865A0", Offset = "0x2284FA0", VA = "0x1822865A0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>) IIACEOEJIJB(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? PKCLPFEIPFH, [Optional] NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>? GNOHFGANIIG)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2287F80", Offset = "0x2286980", VA = "0x182287F80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ICMHLEAALBM>>) OGBPDDJKLJJ(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? KEBMDIIGPFN, [Optional] NOPFJADADBI<ICMHLEAALBM>? KAMLMGFPOBL)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ICMHLEAALBM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x22856E0", Offset = "0x22840E0", VA = "0x1822856E0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<ICMHLEAALBM>>>) FDGHLPJBEPP(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? KEBMDIIGPFN, [Optional] NOPFJADADBI<OPDCBLEDMIE<ICMHLEAALBM>>? KAMLMGFPOBL)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<ICMHLEAALBM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2288B80", Offset = "0x2287580", VA = "0x182288B80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ADFOFFNBIKO>>) PHACPKJKOJJ(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? KEBMDIIGPFN, [Optional] NOPFJADADBI<ADFOFFNBIKO>? KAMLMGFPOBL)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<ADFOFFNBIKO>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2284530", Offset = "0x2282F30", VA = "0x182284530")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<ADFOFFNBIKO>>>) BOKDDDJEIIL(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? KEBMDIIGPFN, [Optional] NOPFJADADBI<OPDCBLEDMIE<ADFOFFNBIKO>>? KAMLMGFPOBL)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<ADFOFFNBIKO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F41BD0", Offset = "0x2F405D0", VA = "0x182F41BD0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<MBPEAGGMMEG>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<TMarker>>) MNGLJDBIGOB<TMarker>(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<MBPEAGGMMEG>? KAMLMGFPOBL, [Optional][In] ReadOnlySpan<byte> GGEMPJLCHFC)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<MBPEAGGMMEG>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2284790", Offset = "0x2283190", VA = "0x182284790")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) CEJIPDNDBPK(this BAOLKDDJFBI<byte> PCBICLOONMH, int LFAPGGMCBIK, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? DIJABOFBAKO)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2288D20", Offset = "0x2287720", VA = "0x182288D20")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) PMBKJPLONAK(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? LFAPGGMCBIK, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? DIJABOFBAKO)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F419E0", Offset = "0x2F403E0", VA = "0x182F419E0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<TMarker>>) FKKMJALMHNB<TMarker>(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<TMarker>>? DIJABOFBAKO, [Optional] int? LEGDMNLNDAK, [Optional][In] ReadOnlySpan<byte> LFAPGGMCBIK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F41890", Offset = "0x2F40290", VA = "0x182F41890")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>) DIPMDLGFGFA<TMarker>(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<TMarker>>? LFAPGGMCBIK, [Optional] NOPFJADADBI<OPDCBLEDMIE<TMarker>>? DIJABOFBAKO, [Optional] int? LEGDMNLNDAK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<TMarker>>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2286E30", Offset = "0x2285830", VA = "0x182286E30")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) KOABJPNIDKM(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2288E30", Offset = "0x2287830", VA = "0x182288E30")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) POGEAIJHMLI(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2286480", Offset = "0x2284E80", VA = "0x182286480")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) IFEGCDCKFCP(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22873B0", Offset = "0x2285DB0", VA = "0x1822873B0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) LHKGGJOJJPI(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2287670", Offset = "0x2286070", VA = "0x182287670")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) MJKIKOPLGEJ(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22878E0", Offset = "0x22862E0", VA = "0x1822878E0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) MLAPLOGOEOG(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2284FE0", Offset = "0x22839E0", VA = "0x182284FE0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) DMNEFJNKBFH(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22867E0", Offset = "0x22851E0", VA = "0x1822867E0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) JEJLNDIOIFG(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22887B0", Offset = "0x22871B0", VA = "0x1822887B0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) OPLFKIECOBD(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2287E90", Offset = "0x2286890", VA = "0x182287E90")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>) NPBCNCBNGFO(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>? JPBNHADILDN)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<ACFBJOPIBOB<IABLFHALDHN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2288120", Offset = "0x2286B20", VA = "0x182288120")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) OHJLKPFKMKN(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2283870", Offset = "0x2282270", VA = "0x182283870")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) AAEFMGHLDAJ(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2286A90", Offset = "0x2285490", VA = "0x182286A90")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) JMMMIMIBELC(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2285580", Offset = "0x2283F80", VA = "0x182285580")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FBDNEFDBKFO(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22857F0", Offset = "0x22841F0", VA = "0x1822857F0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FEAGHPIKNBG(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2283C60", Offset = "0x2282660", VA = "0x182283C60")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) AKAOPHECGOD(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22882A0", Offset = "0x2286CA0", VA = "0x1822882A0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) OMHHLJMJCJP(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2286FB0", Offset = "0x22859B0", VA = "0x182286FB0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) LDBMHNDNADC(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2287B20", Offset = "0x2286520", VA = "0x182287B20")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) NIOJGLGBONB(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22843D0", Offset = "0x2282DD0", VA = "0x1822843D0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) BJJJAAHOEHG(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2285A60", Offset = "0x2284460", VA = "0x182285A60")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FIHPPOIHIGO(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22877C0", Offset = "0x22861C0", VA = "0x1822877C0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) MJLLMMEJPII(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2284D00", Offset = "0x2283700", VA = "0x182284D00")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) DBDAOGPFLEC(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2284A40", Offset = "0x2283440", VA = "0x182284A40")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) CKEIMNLKMAI(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x22839D0", Offset = "0x22823D0", VA = "0x1822839D0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) AHNDFLPOFMH(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x22853A0", Offset = "0x2283DA0", VA = "0x1822853A0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) DPGEMGEIOFO(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2283D80", Offset = "0x2282780", VA = "0x182283D80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) ALKAEGHOAPK(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2287C50", Offset = "0x2286650", VA = "0x182287C50")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) NKJCPGHAEKG(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x22848C0", Offset = "0x22832C0", VA = "0x1822848C0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) CGPJIFKHBCF(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2285E20", Offset = "0x2284820", VA = "0x182285E20")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) GJGPFOEEOOH(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2288570", Offset = "0x2286F70", VA = "0x182288570")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) ONENLPOLEAN(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2283B00", Offset = "0x2282500", VA = "0x182283B00")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) AIKBDMKPKLK(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2288F80", Offset = "0x2287980", VA = "0x182288F80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) PPIGMNCBDBE(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x22866C0", Offset = "0x22850C0", VA = "0x1822866C0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) JECFJPONFNE(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2285F80", Offset = "0x2284980", VA = "0x182285F80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) GKINCADKKOP(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2285140", Offset = "0x2283B40", VA = "0x182285140")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) DODABGLIOEC(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2287D70", Offset = "0x2286770", VA = "0x182287D70")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) NLKMLOFANFC(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2284BA0", Offset = "0x22835A0", VA = "0x182284BA0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) CLMFJCNJOIN(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2288420", Offset = "0x2286E20", VA = "0x182288420")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) ONEFMDBDJPL(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2283ED0", Offset = "0x22828D0", VA = "0x182283ED0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) AMJBHFFBNDP(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2286100", Offset = "0x2284B00", VA = "0x182286100")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) HKNONHFLBDL(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] int? HIFJCDLGNMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22886A0", Offset = "0x22870A0", VA = "0x1822886A0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) OPAKADDILNA(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? HIFJCDLGNMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2285500", Offset = "0x2283F00", VA = "0x182285500")]
	public static NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>> EKIADMAMIII(this BAOLKDDJFBI<byte> PCBICLOONMH)
	{
		return default(NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2283FF0", Offset = "0x22829F0", VA = "0x182283FF0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) AMJFKJLDPNI(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, float ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2286210", Offset = "0x2284C10", VA = "0x182286210")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) HNJMHIHEINM(this BAOLKDDJFBI<byte> PCBICLOONMH, float EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NOIHKCFBDOJ>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2286360", Offset = "0x2284D60", VA = "0x182286360")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>) ICIHBCKBCMM(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NOIHKCFBDOJ>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NOIHKCFBDOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2287510", Offset = "0x2285F10", VA = "0x182287510")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) LINFGJMGNLC(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x22888D0", Offset = "0x22872D0", VA = "0x1822888D0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) PAFHCMKPEPO(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2285BB0", Offset = "0x22845B0", VA = "0x182285BB0")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FNHIHKNMCPN(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2284E80", Offset = "0x2283880", VA = "0x182284E80")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) DFLLFENKICO(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, int ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2284280", Offset = "0x2282C80", VA = "0x182284280")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) BGKFEFGBOLJ(this BAOLKDDJFBI<byte> PCBICLOONMH, int EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<NBENDKHIFGB>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2285940", Offset = "0x2284340", VA = "0x182285940")]
	public static (NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>) FIEHIBKNDLK(this BAOLKDDJFBI<byte> PCBICLOONMH, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EFMOLKHHGGA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? ABKBJLBOKPA, [Optional] NOPFJADADBI<OPDCBLEDMIE<NBENDKHIFGB>>? EKHBBPGKFMK)
	{
		return default((NOPFJADADBI<ACFBJOPIBOB<IABLFHALDHN>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>, NOPFJADADBI<ACFBJOPIBOB<OPDCBLEDMIE<NBENDKHIFGB>>>));
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
