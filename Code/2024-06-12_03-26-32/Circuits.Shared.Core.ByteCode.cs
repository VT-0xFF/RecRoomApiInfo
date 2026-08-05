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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F8C6C0", Offset = "0x1F8B2C0", VA = "0x181F8C6C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NKFODMBNPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static DCECDLKENED<AADDKPGCELF<M>> MAOEAIHIKOP<M>(this int HNFMOHFACKF)
	{
		return default(DCECDLKENED<AADDKPGCELF<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C690", Offset = "0x1F8B290", VA = "0x181F8C690")]
	public static DCECDLKENED<HJKDMECBPGM> CACCOHIFGME(this int HNFMOHFACKF)
	{
		return default(DCECDLKENED<HJKDMECBPGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static DCECDLKENED<HBEBPHNMJKB<M>> PDAGADNCEKH<M>(this int HNFMOHFACKF)
	{
		return default(DCECDLKENED<HBEBPHNMJKB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class AADDKPGCELF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HNJPJIHFBBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JDJEBLCOKFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HJKDMECBPGM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NNEHCMPOKFL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HIPFGLLFJOP
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum LIPBIFCAKKL
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
public static class GFOJCGDNEEP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MJAFNIHPABK<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr DFDBHJFKEDI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
		public MJAFNIHPABK(IntPtr NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x43FAAF0", Offset = "0x43F96F0", VA = "0x1843FAAF0")]
		public int DOBCDLDNJAI(TDeps CFCALMONEJL, TContext CCHBOMPCDMN, TCompileState KOKNNEAOJPH, [In] BDDFKGHGNDI<byte> LFFKGPEEPAM, int MOPFGIKDMOL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CD30", Offset = "0x2B0B930", VA = "0x182B0CD30")]
	public static void HKMJNHMODAB<TDeps, TContext, TCompileState>(TDeps CFCALMONEJL, TContext CCHBOMPCDMN, TCompileState KOKNNEAOJPH, [In] BDDFKGHGNDI<byte> DGJGNDFGBJN, BDDFKGHGNDI<byte> CDKHKDMPPMD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KJFAINPDKJF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GICEPJJIBFH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KEHKLMLAEKD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OMGMLLCOCKP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? AKCJDHEAOOB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GOHKBLLGLPF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PCFLLAOKAMG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? COFNPCAAODG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? HLLLGEJFJJE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IAEFBGDMGNP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OGKPJMIGABC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LCNOLBHJFIN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FDBFEIAOJIE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GGGILNFDCEP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MHJMKDIFMDO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? CEGHLOEIKHO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FJFAPDPMPHD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LOLOMHHFCOE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GINBOFIBHBL, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BOJNIKHKKJC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KLCHFBKJAFD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? AFOFLLGINEH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NNDPDLPMNIG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DOGGAAFHBEB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KBKEJHBMGMD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ABHHOBILBIG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FOLPAMDABEP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OMPNFECBJDN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IPLPKBECPDC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OOGJPCMEJJB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PHCCLIMIKLE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? AFJHHLMLGFO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IKIBFHPEIIM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PPDHKEGMBAA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FBLLCIMJGLD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? HEKFHBIHAPF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PGGGNIFCLNE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GGIMKBHAODP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OHHOJDMDGJK, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LCPOOHFFAGC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PDFENANHAAP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? HNCCLLOPNBL, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NLHKCGNPHBF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GNLDIBAPGOA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ACILDPFEDBF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? CMNDLECBDGB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MLAJAOADJDG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PGFHOIDKHND, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GHPAAFABJDJ, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NPDOEFDJNLG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? HNJEJGHCPFP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PEEFGNBEEAC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PDOBJEMIFKM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IOIKJDKFADF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ABCHKODOPID, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MJDLOOGNCPD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? CHBOKKBCIHJ, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LPOOKLPAHGB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? GEFEINPPGDA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MNEOBKBNLIM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NDAKHBCBDBD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MIFFLCECHKK, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OLILAGBHBPP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PADOMENHAOF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PJJJPJHNCAG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? AEPLLECGOEE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FNJBCNGPEHN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OHILEJHLIGP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ECONMJCAMID, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IEHDNECNAEB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OHLBJKMMAJB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ECOOCBLACPC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DGDKDEALIPM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OBCBBJJNDJC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? ENAMIGHBPBA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OAGNHHNMAOA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DOEPHPPIHCH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? EPKANNLAFCB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LOEKHJHGAJE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BLLPJMHBOGK, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KCNLKGDEKLN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DFCKMKHHOMI, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DOFGAKGADAD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BFBBKOGGDCC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LMHKIJGDFOC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IGLHCEHMNAL, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MOGKKMCJHAH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IIPKNMMGCEG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OMIAOGLDIGC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DPFHBHDCHIK, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IIOGHFJPILG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NJIPGENIFBE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DCCPGLHFKKA, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MIFDCGJNOLM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LEANDLDHGLO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DHLFAGDKAPP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? EDHFGBBADOH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FODGOHHACDE, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LHOAGNDEMFB, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FFHOAPCCOKP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? OMHAIHGEOIJ, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FBOHHEDMLDM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LAHLOPIJHMH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IENGINEHHDF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IBKAJAECCPN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LLDLPLPOBMD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? DJBBJAIKGIF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BAJHGDFDOFN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? HOONIGBMNMH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? JEPHNJIGLFC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? CKEEJDEMJGJ, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BBEPJPLBHEO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MJBHHAFBJHG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? MFLBOACOFMI, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FOHNOCIPLJM, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NHAGJIHGNCN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? EPOGIDFKFIH, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PPIAKGOCIJN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BPGBEAEMIBD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PEENGLAOFJD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? JFMOIBMKKFG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PJNOINBKJID, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? AAFEOPELAKD, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? FBLAIPDMLBF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? BGONOLCOPNF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? NPLPDGGOODI, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? EDDCBAPLPGO, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? INPOMDJELAG, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? LNBNFOPIHKN, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? IHLLBOHKKLF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KDCFIFHJEFP, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? KAPHPNMNCKF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? JBDLBJEHFEF, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? JCOJEDIIIFC, [Optional] MJAFNIHPABK<TContext, TDeps, TCompileState>? PNFBMONDDHL) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F86C70", Offset = "0x1F85870", VA = "0x181F86C70")]
	private static int DBGOGNABJIB([In] BDDFKGHGNDI<byte> FODGPLAKPJP, BDDFKGHGNDI<byte> PJFHHDPNDJM, int BGCAJHMJIFE, int HDFABDCMCAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BDMDKJCADMH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int GKOOCCMMCNP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2881AB0", Offset = "0x28806B0", VA = "0x182881AB0")]
	public static DCECDLKENED<AADDKPGCELF<T>> DNMOFPFNHIB<T>([In] this BDDFKGHGNDI<byte> HNFMOHFACKF)
	{
		return default(DCECDLKENED<AADDKPGCELF<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2881BD0", Offset = "0x28807D0", VA = "0x182881BD0")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<T>>> PNLGAJBCIOI<T>(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<AADDKPGCELF<T>>? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F86610", Offset = "0x1F85210", VA = "0x181F86610")]
	public static DCECDLKENED<AADDKPGCELF<JFDLLLDCMPM>> MIJIIONNFCF(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<JFDLLLDCMPM>? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<JFDLLLDCMPM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F86440", Offset = "0x1F85040", VA = "0x181F86440")]
	public static DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>> KICEFJNAFIB(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] float? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F86530", Offset = "0x1F85130", VA = "0x181F86530")]
	public static DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>> LCLJIPBFKPB(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F867F0", Offset = "0x1F853F0", VA = "0x181F867F0")]
	public static DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>> PGPJLCKIDJM(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HHAKONKLIPE>? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F866F0", Offset = "0x1F852F0", VA = "0x181F866F0")]
	public static DCECDLKENED<AADDKPGCELF<HIPFGLLFJOP>> NBCEAFBEALG(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] byte? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<HIPFGLLFJOP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F86360", Offset = "0x1F84F60", VA = "0x181F86360")]
	public static DCECDLKENED<AADDKPGCELF<HJKDMECBPGM>> HKCHKIMIGDK(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HJKDMECBPGM>? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<HJKDMECBPGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F86270", Offset = "0x1F84E70", VA = "0x181F86270")]
	public static DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> HIBAPKGJMNC(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] LIPBIFCAKKL? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2881B10", Offset = "0x2880710", VA = "0x182881B10")]
	public static DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<T>>> PGFPKAJBEJE<T>(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<T>>? GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F860C0", Offset = "0x1F84CC0", VA = "0x181F860C0")]
	public static void CLDAPDGMPLJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>> GELNNNELPCC, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2881AA0", Offset = "0x28806A0", VA = "0x182881AA0")]
	public static void BEDDEBBKHKB<T>(this BDDFKGHGNDI<byte> HNFMOHFACKF, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<T>>> MOPFGIKDMOL, DCECDLKENED<AADDKPGCELF<T>> GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2881AA0", Offset = "0x28806A0", VA = "0x182881AA0")]
	public static void BMEHMIOKHLD<T>(this BDDFKGHGNDI<byte> HNFMOHFACKF, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<T>>> HIHJKLAMIKB, DCECDLKENED<HBEBPHNMJKB<T>> GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PDPPOEHGEOA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C740", Offset = "0x1F8B340", VA = "0x181F8C740")]
	public static IOAFEKLHBKI ENGJFIFEMIB([In] this ReadOnlySpan<byte> HNGDLLNOPEB, int FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C7B0", Offset = "0x1F8B3B0", VA = "0x181F8C7B0")]
	public static IOAFEKLHBKI ENGJFIFEMIB([In] this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7B60", Offset = "0x2CE6760", VA = "0x182CE7B60")]
	public static IOAFEKLHBKI ENGJFIFEMIB<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7A00", Offset = "0x2CE6600", VA = "0x182CE7A00")]
	public static IOAFEKLHBKI ENGJFIFEMIB<M>([In] this OGGKAMLKLFG<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7820", Offset = "0x2CE6420", VA = "0x182CE7820")]
	public static IOAFEKLHBKI ENGJFIFEMIB<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7880", Offset = "0x2CE6480", VA = "0x182CE7880")]
	public static IOAFEKLHBKI ENGJFIFEMIB<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7CB0", Offset = "0x2CE68B0", VA = "0x182CE7CB0")]
	public static IOAFEKLHBKI ENGJFIFEMIB<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C740", Offset = "0x1F8B340", VA = "0x181F8C740")]
	public static int IDOJGBAOLHD([In] this ReadOnlySpan<byte> HNGDLLNOPEB, int FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F86260", Offset = "0x1F84E60", VA = "0x181F86260")]
	public static int IDOJGBAOLHD([In] this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static int IDOJGBAOLHD<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static int IDOJGBAOLHD<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static int IDOJGBAOLHD<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static int IDOJGBAOLHD<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7DE0", Offset = "0x2CE69E0", VA = "0x182CE7DE0")]
	public static float JKOBDPMCJLM<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7DE0", Offset = "0x2CE69E0", VA = "0x182CE7DE0")]
	public static float JKOBDPMCJLM<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7DE0", Offset = "0x2CE69E0", VA = "0x182CE7DE0")]
	public static float JKOBDPMCJLM<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE78F0", Offset = "0x2CE64F0", VA = "0x182CE78F0")]
	public static byte ECLEHGDHBCJ<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE79E0", Offset = "0x2CE65E0", VA = "0x182CE79E0")]
	public static byte ECLEHGDHBCJ<M>([In] this OGGKAMLKLFG<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7820", Offset = "0x2CE6420", VA = "0x182CE7820")]
	public static byte ECLEHGDHBCJ<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7880", Offset = "0x2CE6480", VA = "0x182CE7880")]
	public static byte ECLEHGDHBCJ<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7920", Offset = "0x2CE6520", VA = "0x182CE7920")]
	public static byte ECLEHGDHBCJ<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F86260", Offset = "0x1F84E60", VA = "0x181F86260")]
	public static LIPBIFCAKKL HAPIOLFJHML([In] this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD)
	{
		return default(LIPBIFCAKKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static LIPBIFCAKKL HAPIOLFJHML<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(LIPBIFCAKKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8050", Offset = "0x2CE6C50", VA = "0x182CE8050")]
	public static DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> PHLGJEJLOEP<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2CE80C0", Offset = "0x2CE6CC0", VA = "0x182CE80C0")]
	public static DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> PHLGJEJLOEP<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8130", Offset = "0x2CE6D30", VA = "0x182CE8130")]
	public static DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> PHLGJEJLOEP<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D70", Offset = "0x2CE6970", VA = "0x182CE7D70")]
	public static DCECDLKENED<HBEBPHNMJKB<CEEKBHBAKNH>> GHGMKGHEGCI<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<HBEBPHNMJKB<CEEKBHBAKNH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7E20", Offset = "0x2CE6A20", VA = "0x182CE7E20")]
	public static DCECDLKENED<HJKDMECBPGM> PBLOEHMNENO<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<HJKDMECBPGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7E90", Offset = "0x2CE6A90", VA = "0x182CE7E90")]
	public static DCECDLKENED<HJKDMECBPGM> PBLOEHMNENO<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<HJKDMECBPGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7F00", Offset = "0x2CE6B00", VA = "0x182CE7F00")]
	public static DCECDLKENED<HJKDMECBPGM> PBLOEHMNENO<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<HJKDMECBPGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7F70", Offset = "0x2CE6B70", VA = "0x182CE7F70")]
	public static DCECDLKENED<JFDLLLDCMPM> PHDPPMHPAGI<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<JFDLLLDCMPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7FE0", Offset = "0x2CE6BE0", VA = "0x182CE7FE0")]
	public static DCECDLKENED<JFDLLLDCMPM> PHDPPMHPAGI<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<JFDLLLDCMPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE77B0", Offset = "0x2CE63B0", VA = "0x182CE77B0")]
	public static DCECDLKENED<HHAKONKLIPE> BKJILMGKPEM<M>(this OKMJBKIIOIE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD)
	{
		return default(DCECDLKENED<HHAKONKLIPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FMDINJADIIG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F86BB0", Offset = "0x1F857B0", VA = "0x181F86BB0")]
	public static void NFJBFBELIDF(this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD, IOAFEKLHBKI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F86AC0", Offset = "0x1F856C0", VA = "0x181F86AC0")]
	public static void NFJBFBELIDF(this byte[] HNGDLLNOPEB, int FJCEHPOBJJD, IOAFEKLHBKI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F86B30", Offset = "0x1F85730", VA = "0x181F86B30")]
	public static void NFJBFBELIDF([In] this Span<byte> HNGDLLNOPEB, int FJCEHPOBJJD, IOAFEKLHBKI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4030", Offset = "0x2AF2C30", VA = "0x182AF4030")]
	public static void NFJBFBELIDF<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, IOAFEKLHBKI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3E90", Offset = "0x2AF2A90", VA = "0x182AF3E90")]
	public static void NFJBFBELIDF<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, IOAFEKLHBKI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F860C0", Offset = "0x1F84CC0", VA = "0x181F860C0")]
	public static void CLDAPDGMPLJ(this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F86990", Offset = "0x1F85590", VA = "0x181F86990")]
	public static void CLDAPDGMPLJ(this byte[] HNGDLLNOPEB, int FJCEHPOBJJD, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F86910", Offset = "0x1F85510", VA = "0x181F86910")]
	public static void CLDAPDGMPLJ([In] this Span<byte> HNGDLLNOPEB, int FJCEHPOBJJD, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3CD0", Offset = "0x2AF28D0", VA = "0x182AF3CD0")]
	public static void CLDAPDGMPLJ<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3C70", Offset = "0x2AF2870", VA = "0x182AF3C70")]
	public static void CLDAPDGMPLJ<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F86A80", Offset = "0x1F85680", VA = "0x181F86A80")]
	public static void KENIAPCDMPC(this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3E30", Offset = "0x2AF2A30", VA = "0x182AF3E30")]
	public static void KENIAPCDMPC<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3DD0", Offset = "0x2AF29D0", VA = "0x182AF3DD0")]
	public static void KENIAPCDMPC<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F86A10", Offset = "0x1F85610", VA = "0x181F86A10")]
	public static void IMFKLNDCMBA(this BDDFKGHGNDI<byte> HNGDLLNOPEB, int FJCEHPOBJJD, byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3D80", Offset = "0x2AF2980", VA = "0x182AF3D80")]
	public static void IMFKLNDCMBA<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3D30", Offset = "0x2AF2930", VA = "0x182AF3D30")]
	public static void IMFKLNDCMBA<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x295A410", Offset = "0x2959010", VA = "0x18295A410")]
	public static void BEDDEBBKHKB<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x295A410", Offset = "0x2959010", VA = "0x18295A410")]
	public static void BEDDEBBKHKB<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x295A410", Offset = "0x2959010", VA = "0x18295A410")]
	public static void ANLGKIGPIGK<M>(this FOBGKDMAFIM<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, DCECDLKENED<HJKDMECBPGM> GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x295A410", Offset = "0x2959010", VA = "0x18295A410")]
	public static void ANLGKIGPIGK<M>([In] this PPGJIGLELJE<M, byte> HNGDLLNOPEB, DCECDLKENED<M> FJCEHPOBJJD, DCECDLKENED<HJKDMECBPGM> GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LOPACNIIDFN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F88810", Offset = "0x1F87410", VA = "0x181F88810")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) EINMEINIBEB(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F89400", Offset = "0x1F88000", VA = "0x181F89400")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) HDDKIBAKLLI(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A860", Offset = "0x1F89460", VA = "0x181F8A860")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) KPCMKAOGDNG(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BED0", Offset = "0x1F8AAD0", VA = "0x181F8BED0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) OMNDAEHCFFH(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F87780", Offset = "0x1F86380", VA = "0x181F87780")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) BKBJEBDENNN(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BDB0", Offset = "0x1F8A9B0", VA = "0x181F8BDB0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) OICGPFLELGJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F88530", Offset = "0x1F87130", VA = "0x181F88530")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) EEGGKLPHDKO(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A480", Offset = "0x1F89080", VA = "0x181F8A480")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) KJNAKKHMHLO(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F88150", Offset = "0x1F86D50", VA = "0x181F88150")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) DOHMPKLAKDL(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F87E10", Offset = "0x1F86A10", VA = "0x181F87E10")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>) DCLPPOKDMIA(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? GLMEMJNJKAN, [Optional] DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? OCICMGLPEKD)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B3C0", Offset = "0x1F89FC0", VA = "0x181F8B3C0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>) MELOCCBBANA(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? GLMEMJNJKAN, [Optional] DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? OCICMGLPEKD)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F88DF0", Offset = "0x1F879F0", VA = "0x181F88DF0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>) FGOCIJEOAMM(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? GLMEMJNJKAN, [Optional] DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? OCICMGLPEKD)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F87510", Offset = "0x1F86110", VA = "0x181F87510")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>) BEBHFFBCKKM(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? GLMEMJNJKAN, [Optional] DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? OCICMGLPEKD)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F88C50", Offset = "0x1F87850", VA = "0x181F88C50")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JFDLLLDCMPM>>) FBGMLHFDIOP(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? PCDKHLPCMNN, [Optional] DCECDLKENED<JFDLLLDCMPM>? DFEAGIPALPH)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JFDLLLDCMPM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F87400", Offset = "0x1F86000", VA = "0x181F87400")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JFDLLLDCMPM>>>) BDPCOAMEEHB(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? PCDKHLPCMNN, [Optional] DCECDLKENED<HBEBPHNMJKB<JFDLLLDCMPM>>? DFEAGIPALPH)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JFDLLLDCMPM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A1C0", Offset = "0x1F88DC0", VA = "0x181F8A1C0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HJKDMECBPGM>>) KFNCBEIKGPP(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? PCDKHLPCMNN, [Optional] DCECDLKENED<HJKDMECBPGM>? DFEAGIPALPH)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HJKDMECBPGM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A5D0", Offset = "0x1F891D0", VA = "0x181F8A5D0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HJKDMECBPGM>>>) KMCDOIDABKD(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? PCDKHLPCMNN, [Optional] DCECDLKENED<HBEBPHNMJKB<HJKDMECBPGM>>? DFEAGIPALPH)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HJKDMECBPGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C034F0", Offset = "0x2C020F0", VA = "0x182C034F0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>) MDNMDPBBPKM<TMarker>(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HHAKONKLIPE>? DFEAGIPALPH, [Optional][In] ReadOnlySpan<byte> IMCLGJBJJKP)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B630", Offset = "0x1F8A230", VA = "0x181F8B630")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NEJPMBGMEBC(this BDDFKGHGNDI<byte> HNFMOHFACKF, int FODGPLAKPJP, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? PJFHHDPNDJM)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F87AB0", Offset = "0x1F866B0", VA = "0x181F87AB0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) CFHFLJMEIFF(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? FODGPLAKPJP, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? PJFHHDPNDJM)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C031B0", Offset = "0x2C01DB0", VA = "0x182C031B0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>) CPGPCHCNCKP<TMarker>(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<TMarker>>? PJFHHDPNDJM, [Optional] int? AEOJMEBJNPD, [Optional][In] ReadOnlySpan<byte> FODGPLAKPJP)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C033A0", Offset = "0x2C01FA0", VA = "0x182C033A0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>) GFGJCMILDLA<TMarker>(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<TMarker>>? FODGPLAKPJP, [Optional] DCECDLKENED<HBEBPHNMJKB<TMarker>>? PJFHHDPNDJM, [Optional] int? AEOJMEBJNPD)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<TMarker>>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F87280", Offset = "0x1F85E80", VA = "0x181F87280")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) BDINNJOMPJP(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F87630", Offset = "0x1F86230", VA = "0x181F87630")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) BFJIGBIGKEJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A360", Offset = "0x1F88F60", VA = "0x181F8A360")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) KHFBPAGPGPF(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F87950", Offset = "0x1F86550", VA = "0x181F87950")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) CEIAIIEBMNJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B110", Offset = "0x1F89D10", VA = "0x181F8B110")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LKIGKHFIIEO(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BB10", Offset = "0x1F8A710", VA = "0x181F8BB10")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NOONCJMEBMI(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1F88270", Offset = "0x1F86E70", VA = "0x181F88270")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) EBAOAHNDCHN(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F892B0", Offset = "0x1F87EB0", VA = "0x181F892B0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) GLENKJKEFFI(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AFF0", Offset = "0x1F89BF0", VA = "0x181F8AFF0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LILPDMAPNDC(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C5A0", Offset = "0x1F8B1A0", VA = "0x181F8C5A0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>) PMFFIPLNCGL(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? BLKEKMJOPOM)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F86E40", Offset = "0x1F85A40", VA = "0x181F86E40")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) AHGECEJEJLF(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A060", Offset = "0x1F88C60", VA = "0x181F8A060")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) JNDAPCAOHPB(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1F86D10", Offset = "0x1F85910", VA = "0x181F86D10")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) AHEOGOONCOC(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B260", Offset = "0x1F89E60", VA = "0x181F8B260")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LOHAFAJNBFB(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B4E0", Offset = "0x1F8A0E0", VA = "0x181F8B4E0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NDKODLBKOAA(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F89030", Offset = "0x1F87C30", VA = "0x181F89030")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) GGAMDBPNPNJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A6E0", Offset = "0x1F892E0", VA = "0x181F8A6E0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) KPCEODHHECJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F883D0", Offset = "0x1F86FD0", VA = "0x181F883D0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) EBMBEDELCBB(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F88F00", Offset = "0x1F87B00", VA = "0x181F88F00")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) FONBGCKPCMM(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F88AF0", Offset = "0x1F876F0", VA = "0x181F88AF0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) FAFADECPNEO(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F89550", Offset = "0x1F88150", VA = "0x181F89550")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) HDICCOMOHFK(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F89920", Offset = "0x1F88520", VA = "0x181F89920")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) IEIJPMNGEEG(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AAA0", Offset = "0x1F896A0", VA = "0x181F8AAA0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LBPODEJDLOO(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F897C0", Offset = "0x1F883C0", VA = "0x181F897C0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) HMNKEOFDEHN(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B760", Offset = "0x1F8A360", VA = "0x181F8B760")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NFGAHCJOMFD(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F89150", Offset = "0x1F87D50", VA = "0x181F89150")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) GKJMFJLCGDC(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F89E00", Offset = "0x1F88A00", VA = "0x181F89E00")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) JIBIJNBMCKM(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F87F20", Offset = "0x1F86B20", VA = "0x181F87F20")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) DIFEFAFKAGL(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BC30", Offset = "0x1F8A830", VA = "0x181F8BC30")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) OFKJJDLEILI(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1F87120", Offset = "0x1F85D20", VA = "0x181F87120")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) BAJIELIDONO(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F87CE0", Offset = "0x1F868E0", VA = "0x181F87CE0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) CNDIKGBPOLC(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B9B0", Offset = "0x1F8A5B0", VA = "0x181F8B9B0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NKJBLEPCLND(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F89CB0", Offset = "0x1F888B0", VA = "0x181F89CB0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) IJLDFKHBNKF(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F89A40", Offset = "0x1F88640", VA = "0x181F89A40")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) IFBDEJKOMOD(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C030", Offset = "0x1F8AC30", VA = "0x181F8C030")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) PAMDDPHCJFF(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C1B0", Offset = "0x1F8ADB0", VA = "0x181F8C1B0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) PEOJCNKJCIL(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F87BC0", Offset = "0x1F867C0", VA = "0x181F87BC0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) CGAAONJIAJE(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F86FC0", Offset = "0x1F85BC0", VA = "0x181F86FC0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) AJEDKPPPDJD(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1F89B60", Offset = "0x1F88760", VA = "0x181F89B60")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) IHIJEHMNEJF(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A980", Offset = "0x1F89580", VA = "0x181F8A980")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LBADKFCAIHE(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1F89F50", Offset = "0x1F88B50", VA = "0x181F89F50")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) JKDJGAMIPNE(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] int? HAKNFFJKJBC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1F88040", Offset = "0x1F86C40", VA = "0x181F88040")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) DJKHKINNGIG(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? HAKNFFJKJBC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F878D0", Offset = "0x1F864D0", VA = "0x181F878D0")]
	public static DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> CEADFNBAKCJ(this BDDFKGHGNDI<byte> HNFMOHFACKF)
	{
		return default(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F88690", Offset = "0x1F87290", VA = "0x181F88690")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) EFHCKELIKOH(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AEA0", Offset = "0x1F89AA0", VA = "0x181F8AEA0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) LDONHMCGJPG(this BDDFKGHGNDI<byte> HNFMOHFACKF, float NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HNJPJIHFBBJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AD80", Offset = "0x1F89980", VA = "0x181F8AD80")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>) LDMPFHEBGEB(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<HNJPJIHFBBJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<HNJPJIHFBBJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F88990", Offset = "0x1F87590", VA = "0x181F88990")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) ELALFICGAKI(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C450", Offset = "0x1F8B050", VA = "0x181F8C450")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) PLPDGDPPDCJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F896A0", Offset = "0x1F882A0", VA = "0x181F896A0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) HIOJFKOJFAF(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AC20", Offset = "0x1F89820", VA = "0x181F8AC20")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) LCOPPKGGOHJ(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C300", Offset = "0x1F8AF00", VA = "0x181F8C300")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) PKHNOCDANFD(this BDDFKGHGNDI<byte> HNFMOHFACKF, int NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B890", Offset = "0x1F8A490", VA = "0x181F8B890")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>) NKICPJODFKF(this BDDFKGHGNDI<byte> HNFMOHFACKF, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NBGKBNFPFCC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? BANMHJGBLPC, [Optional] DCECDLKENED<HBEBPHNMJKB<JDJEBLCOKFJ>>? NJAMJJFEBJG)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<JDJEBLCOKFJ>>>));
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
