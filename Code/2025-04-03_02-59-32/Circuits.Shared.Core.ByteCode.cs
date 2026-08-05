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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x26768E0", Offset = "0x2675CE0", VA = "0x1826768E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLIMKPCDCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3376400", Offset = "0x3375800", VA = "0x183376400")]
	public static IJOGBJOFPED<JAHELGAGFCI<M>> MLDLLKAJCMP<M>(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26768B0", Offset = "0x2675CB0", VA = "0x1826768B0")]
	public static IJOGBJOFPED<DCGBFPGIBOL> KDFFLIFIPAI(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3376400", Offset = "0x3375800", VA = "0x183376400")]
	public static IJOGBJOFPED<KGFODMDJAKK<M>> EKOFBCGJCKN<M>(this int JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<KGFODMDJAKK<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JAHELGAGFCI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NIIKNDFOBBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NEBCLJMKMGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DCGBFPGIBOL
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MIEINCILBCI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HLINKEPHAEC
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum MMOIHINOCDC
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
public static class HMLNGAMGFEK
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct DNAKNDHOFLA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr FOBLOMCENPC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
		public DNAKNDHOFLA(IntPtr BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66943B0", Offset = "0x66937B0", VA = "0x1866943B0")]
		public int HKANHPMMIAO(TDeps OHJFEHDLOHB, TContext PDBOIKJNMKA, TCompileState CIBBJHMCOIJ, [In] AJFCGHOLDCP<byte> BEAIPLNCIOD, int NAFKDGMKBON)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x35F9590", Offset = "0x35F8990", VA = "0x1835F9590")]
	public static void PANFCFJMOHO<TDeps, TContext, TCompileState>(TDeps OHJFEHDLOHB, TContext PDBOIKJNMKA, TCompileState CIBBJHMCOIJ, [In] AJFCGHOLDCP<byte> DPBGHLMBKLC, AJFCGHOLDCP<byte> PFKOJELINBA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FHCFIJEJHGF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KCKEEEIIBGB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NLJCOGIADOG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? JOPOMNEEDCC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CEGHLGOPPCF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GGGFJNNIILJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLMJDNOEBCH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EBNFLAIGJPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AELHOLNBNNA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KMFMJHKIJFD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FEGOOFIHGFK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LCDKIJBJPGM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NINFCOOPKBO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BOODNHGKLKO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KHPDEFAAIFH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KMMCHHPKHJF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HDAKDICCEDI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IBNOIGOKJHN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CEJFIMEJFGB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MFJGNPOICLG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LEOFDECFCJG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HOGPPFLFNHC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PNGGBNDPGCN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OPHFMMHDGFD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EFOFBCNNMPH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PFEDKHPEBFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CHECIKAANCK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NGDHJDCKAOE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KCAAOKBAIML, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CGPHGPMEJDA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HGKNIPBMHLD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DHHBPHLGMFF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BNBPEGDCNGD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EHLLHLLCMCG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AKBMBEABAGJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PPOFGFLMIMP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GLEPBGKAECC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AFFEBMGHHAA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PCIKCBOABDB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? INBKNOOMBLD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PFOOILABILL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IKDABBMKMEL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KOEJHCFHKJD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EIELNBJFHAE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ANOPHMBKJDB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DKMFNIGMNOE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EEPICJKKBOL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AHIIDMJCIMC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CKFDDHCAHMO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MBAKMDNEGKJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GFLJEKIABGE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MHFDECFDOGG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MPBIKOAILAG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KEDEMPMDJDC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MMCELBHJLNL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KHOIFIHHGCG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OABPDBOCFFO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EFHHDEOEMPB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NACMICKKJOA, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NMDHLNIANMG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MIPKIFFICAJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DCOPCLEFALD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PJOMIGCPBII, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OGAKOHLLIDO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FDGIACADFMG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MEIFPDDCEAH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OJMNOKJMEOK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HDFGAFMICGM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KJAHHLLLGOO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FGEGGFJKAOK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? AEKBIIECMDF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LLKPJBPHFCO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BJEKABNAKAB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BNPCBDGMDFL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OIGCADIKLDC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? COBEGPHCIJM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HCNCFGGDDKD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FFJKNNEFCFF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FLAPPLLPBED, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DHPOFILIEMM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HGABLPLMEHD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DFKKLBNFIBI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MEPOMJEHMBO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IFBIKCCOGAE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BJFPBHKAPAK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BFNJAADEHHL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LMLJADMCECI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LEEBGINBOFN, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EEBIBAMKILG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ENEPOLJLKEI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EPECADBBDLK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MPPPDGEFHBC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IFMCMGALLEG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DNBMDOABDNH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CKBLKHPMDJH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HPOFLINFHJM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HKKCLJBINJD, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ENJJEEMEHKG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GHBAMHBKPPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PMEEFGKEGGK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? COFCIFLBHPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? EJHPIDBOGML, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLHMNLDHAPL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HMBPEKBOJDE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OADFGADDKBM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FDFFFGHOBKL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MMAKJMPAOFH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? BIMHFFENIJJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? ONPACNACKFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IOGIEAAEDHM, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CCLHLCCOBLI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LCODMCKKIIJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OILFCCILKOI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FABCHLPGKPL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? KFELNOJOFLC, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IBHIONJBFDG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? PLDMCJCDEDH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LGEMAOCBAJH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? HMAFOEPAEJF, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GCHKCOOFNPG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OJPKMCCKAFE, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MNMAPOKEPGL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? APMMAEFFBBP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? CJLHPBJLFAO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MIIJEBHAAMI, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? NDIDLLDIKKH, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MNJFHPDPJEL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? GBFKKJJIMFB, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? MHLKMIKMBFK, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IMGHLPDIPOG, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? DLDPNHOAPJL, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? IGJFPGILGAO, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? LDJLLAHIPHP, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? FIAPMLEACOJ, [Optional] DNAKNDHOFLA<TContext, TDeps, TCompileState>? OLIOGFHIEJA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2670490", Offset = "0x266F890", VA = "0x182670490")]
	private static int PGGEMKNCLFF([In] AJFCGHOLDCP<byte> FJONCPGPEAA, AJFCGHOLDCP<byte> DECLPGCFODA, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JKCMJPLICBA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int BNKHPLKFJAM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x367C230", Offset = "0x367B630", VA = "0x18367C230")]
	public static IJOGBJOFPED<JAHELGAGFCI<T>> MKHHGOFPDDB<T>([In] this AJFCGHOLDCP<byte> JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x367C170", Offset = "0x367B570", VA = "0x18367C170")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>> DNOCBFCIDAJ<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<JAHELGAGFCI<T>>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2670620", Offset = "0x266FA20", VA = "0x182670620")]
	public static IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>> BKHIFFPJMFM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<GFMPOBJPFLN>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26709C0", Offset = "0x266FDC0", VA = "0x1826709C0")]
	public static IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>> KBIBHOLNNPK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] float? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2670AB0", Offset = "0x266FEB0", VA = "0x182670AB0")]
	public static IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> PPLHJLBPAID(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26708E0", Offset = "0x266FCE0", VA = "0x1826708E0")]
	public static IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>> JLODKFIGCAG(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<FNOIGLEFPAM>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2670700", Offset = "0x266FB00", VA = "0x182670700")]
	public static IJOGBJOFPED<JAHELGAGFCI<HLINKEPHAEC>> CFFPKDCOPKO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] byte? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<HLINKEPHAEC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2670800", Offset = "0x266FC00", VA = "0x182670800")]
	public static IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>> GIMMJFJIMPL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<DCGBFPGIBOL>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2670530", Offset = "0x266F930", VA = "0x182670530")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> AJDBFKFDEPE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] MMOIHINOCDC? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x367C290", Offset = "0x367B690", VA = "0x18367C290")]
	public static IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>> PEJICIFNOLK<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<T>>? FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2670340", Offset = "0x266F740", VA = "0x182670340")]
	public static void MNDHDKKOOFK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> GHEEEKBPNJN, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x367C160", Offset = "0x367B560", VA = "0x18367C160")]
	public static void CBOLANDLOIB<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<T>>> NAFKDGMKBON, IJOGBJOFPED<JAHELGAGFCI<T>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x367C160", Offset = "0x367B560", VA = "0x18367C160")]
	public static void NLIHOGDCAPK<T>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<T>>> FIOJHHMNFOB, IJOGBJOFPED<KGFODMDJAKK<T>> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EMMMMGPKIGO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2670380", Offset = "0x266F780", VA = "0x182670380")]
	public static AKBOPDOBDEE ALPCFNMOJFB([In] this ReadOnlySpan<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26703F0", Offset = "0x266F7F0", VA = "0x1826703F0")]
	public static AKBOPDOBDEE ALPCFNMOJFB([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3472E70", Offset = "0x3472270", VA = "0x183472E70")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3472D10", Offset = "0x3472110", VA = "0x183472D10")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>([In] this LMHBKDKBDNL<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3473080", Offset = "0x3472480", VA = "0x183473080")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34730E0", Offset = "0x34724E0", VA = "0x1834730E0")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3472FC0", Offset = "0x34723C0", VA = "0x183472FC0")]
	public static AKBOPDOBDEE ALPCFNMOJFB<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2670380", Offset = "0x266F780", VA = "0x182670380")]
	public static int JACLBCCGBGP([In] this ReadOnlySpan<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2670270", Offset = "0x266F670", VA = "0x182670270")]
	public static int JACLBCCGBGP([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33ED220", Offset = "0x33EC620", VA = "0x1833ED220")]
	public static int JACLBCCGBGP<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x33ED220", Offset = "0x33EC620", VA = "0x1833ED220")]
	public static int JACLBCCGBGP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x33ED220", Offset = "0x33EC620", VA = "0x1833ED220")]
	public static int JACLBCCGBGP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33ED220", Offset = "0x33EC620", VA = "0x1833ED220")]
	public static int JACLBCCGBGP<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34735B0", Offset = "0x34729B0", VA = "0x1834735B0")]
	public static float MIHKIMGPIJE<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34735B0", Offset = "0x34729B0", VA = "0x1834735B0")]
	public static float MIHKIMGPIJE<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34735B0", Offset = "0x34729B0", VA = "0x1834735B0")]
	public static float MIHKIMGPIJE<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34736D0", Offset = "0x3472AD0", VA = "0x1834736D0")]
	public static byte PGIDMAPDEFF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34735F0", Offset = "0x34729F0", VA = "0x1834735F0")]
	public static byte PGIDMAPDEFF<M>([In] this LMHBKDKBDNL<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3473080", Offset = "0x3472480", VA = "0x183473080")]
	public static byte PGIDMAPDEFF<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34730E0", Offset = "0x34724E0", VA = "0x1834730E0")]
	public static byte PGIDMAPDEFF<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3473610", Offset = "0x3472A10", VA = "0x183473610")]
	public static byte PGIDMAPDEFF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2670270", Offset = "0x266F670", VA = "0x182670270")]
	public static MMOIHINOCDC JDFCGIMLONH([In] this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA)
	{
		return default(MMOIHINOCDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x33ED220", Offset = "0x33EC620", VA = "0x1833ED220")]
	public static MMOIHINOCDC JDFCGIMLONH<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(MMOIHINOCDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34733F0", Offset = "0x34727F0", VA = "0x1834733F0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34734D0", Offset = "0x34728D0", VA = "0x1834734D0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3473460", Offset = "0x3472860", VA = "0x183473460")]
	public static IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> KEKKLBPIJAL<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3473150", Offset = "0x3472550", VA = "0x183473150")]
	public static IJOGBJOFPED<KGFODMDJAKK<JCKHHCNOCBD>> BEJAHFCKDGF<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<KGFODMDJAKK<JCKHHCNOCBD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3473380", Offset = "0x3472780", VA = "0x183473380")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3473310", Offset = "0x3472710", VA = "0x183473310")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34732A0", Offset = "0x34726A0", VA = "0x1834732A0")]
	public static IJOGBJOFPED<DCGBFPGIBOL> CNECAEKGIEM<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<DCGBFPGIBOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34731C0", Offset = "0x34725C0", VA = "0x1834731C0")]
	public static IJOGBJOFPED<GFMPOBJPFLN> BOFAFDDGPIG<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<GFMPOBJPFLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3473230", Offset = "0x3472630", VA = "0x183473230")]
	public static IJOGBJOFPED<GFMPOBJPFLN> BOFAFDDGPIG<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<GFMPOBJPFLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3473540", Offset = "0x3472940", VA = "0x183473540")]
	public static IJOGBJOFPED<FNOIGLEFPAM> KHMIAEJNOPE<M>(this OEEMOMGNMIG<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA)
	{
		return default(IJOGBJOFPED<FNOIGLEFPAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFIEINBENKK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2670D30", Offset = "0x2670130", VA = "0x182670D30")]
	public static void FMDEOFFPGIP(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2670CC0", Offset = "0x26700C0", VA = "0x182670CC0")]
	public static void FMDEOFFPGIP(this byte[] DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2670C40", Offset = "0x2670040", VA = "0x182670C40")]
	public static void FMDEOFFPGIP([In] this Span<byte> DHHEGLJJIIE, int KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x371A730", Offset = "0x3719B30", VA = "0x18371A730")]
	public static void FMDEOFFPGIP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x371A8D0", Offset = "0x3719CD0", VA = "0x18371A8D0")]
	public static void FMDEOFFPGIP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, AKBOPDOBDEE FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2670340", Offset = "0x266F740", VA = "0x182670340")]
	public static void MNDHDKKOOFK(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2670EB0", Offset = "0x26702B0", VA = "0x182670EB0")]
	public static void MNDHDKKOOFK(this byte[] DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2670E30", Offset = "0x2670230", VA = "0x182670E30")]
	public static void MNDHDKKOOFK([In] this Span<byte> DHHEGLJJIIE, int KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x371AB30", Offset = "0x3719F30", VA = "0x18371AB30")]
	public static void MNDHDKKOOFK<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x371AB90", Offset = "0x3719F90", VA = "0x18371AB90")]
	public static void MNDHDKKOOFK<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2670DF0", Offset = "0x26701F0", VA = "0x182670DF0")]
	public static void IPBOAGFJABP(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x371AA70", Offset = "0x3719E70", VA = "0x18371AA70")]
	public static void IPBOAGFJABP<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x371AAD0", Offset = "0x3719ED0", VA = "0x18371AAD0")]
	public static void IPBOAGFJABP<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2670BD0", Offset = "0x266FFD0", VA = "0x182670BD0")]
	public static void ACBPPLJIEGE(this AJFCGHOLDCP<byte> DHHEGLJJIIE, int KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x371A690", Offset = "0x3719A90", VA = "0x18371A690")]
	public static void ACBPPLJIEGE<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x371A6E0", Offset = "0x3719AE0", VA = "0x18371A6E0")]
	public static void ACBPPLJIEGE<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33ED280", Offset = "0x33EC680", VA = "0x1833ED280")]
	public static void CBOLANDLOIB<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x33ED280", Offset = "0x33EC680", VA = "0x1833ED280")]
	public static void CBOLANDLOIB<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33ED280", Offset = "0x33EC680", VA = "0x1833ED280")]
	public static void PJCODPKFNEK<M>(this CHEBGGCGGEB<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<DCGBFPGIBOL> FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x33ED280", Offset = "0x33EC680", VA = "0x1833ED280")]
	public static void PJCODPKFNEK<M>([In] this LCJGNBMKFIF<M, byte> DHHEGLJJIIE, IJOGBJOFPED<M> KHGADHNAFJA, IJOGBJOFPED<DCGBFPGIBOL> FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MJGNEJEHNHH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2671F90", Offset = "0x2671390", VA = "0x182671F90")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) DAMNAACPOMB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26739D0", Offset = "0x2672DD0", VA = "0x1826739D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) HHEAMEACOIL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2671D40", Offset = "0x2671140", VA = "0x182671D40")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) CJDMJALBHAN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2671700", Offset = "0x2670B00", VA = "0x182671700")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) BMBCDNIIJNC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2676030", Offset = "0x2675430", VA = "0x182676030")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OOCMMMFLOGP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2673B20", Offset = "0x2672F20", VA = "0x182673B20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) IBOJHJLHODP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2674AC0", Offset = "0x2673EC0", VA = "0x182674AC0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) LBNCDPNBMDB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2676520", Offset = "0x2675920", VA = "0x182676520")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PHOEJBOPBNE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2675290", Offset = "0x2674690", VA = "0x182675290")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NGJAGLIBCOC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26719B0", Offset = "0x2670DB0", VA = "0x1826719B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) CELJLDADEBA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26724A0", Offset = "0x26718A0", VA = "0x1826724A0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) ECAPPNGKHHA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26738C0", Offset = "0x2672CC0", VA = "0x1826738C0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HGKFGNEDGCO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26736B0", Offset = "0x2672AB0", VA = "0x1826736B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HDNJCICJGAH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FFOEEMKIKJO, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? MHNMJHBLJNF)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2672EA0", Offset = "0x26722A0", VA = "0x182672EA0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>) FKHICOOPDPN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<GFMPOBJPFLN>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<GFMPOBJPFLN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2671080", Offset = "0x2670480", VA = "0x182671080")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<GFMPOBJPFLN>>>) ALBMGJILBNC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<GFMPOBJPFLN>>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<GFMPOBJPFLN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2675E90", Offset = "0x2675290", VA = "0x182675E90")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>) OMMGLKFNBPL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<DCGBFPGIBOL>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<DCGBFPGIBOL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2672990", Offset = "0x2671D90", VA = "0x182672990")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<DCGBFPGIBOL>>>) FBJHAMKCAAL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? JIOJGMLCCPJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<DCGBFPGIBOL>>? MOIIPMBKBLO)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<DCGBFPGIBOL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3725360", Offset = "0x3724760", VA = "0x183725360")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>) GONHHDDEJDE<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<FNOIGLEFPAM>? MOIIPMBKBLO, [Optional][In] ReadOnlySpan<byte> HPMNBNLACCC)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2672BF0", Offset = "0x2671FF0", VA = "0x182672BF0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FKFLNCICGLC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DECLPGCFODA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2675180", Offset = "0x2674580", VA = "0x182675180")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NBPIGBPECID(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DECLPGCFODA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37256B0", Offset = "0x3724AB0", VA = "0x1837256B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>) NOMHEBBIEKA<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? DECLPGCFODA, [Optional] int? MNDMOIHIBEI, [Optional][In] ReadOnlySpan<byte> FJONCPGPEAA)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3725560", Offset = "0x3724960", VA = "0x183725560")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>) HDOGJCJALJC<TMarker>(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? FJONCPGPEAA, [Optional] IJOGBJOFPED<KGFODMDJAKK<TMarker>>? DECLPGCFODA, [Optional] int? MNDMOIHIBEI)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<TMarker>>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2671580", Offset = "0x2670980", VA = "0x182671580")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) BDFEOPEADBK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2672AA0", Offset = "0x2671EA0", VA = "0x182672AA0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) FDLHNNIHBAA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2674840", Offset = "0x2673C40", VA = "0x182674840")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KMAOIEBEECH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2673150", Offset = "0x2672550", VA = "0x182673150")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FMKHIOIKNFL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26712E0", Offset = "0x26706E0", VA = "0x1826712E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) AOIOKJOBMFM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2674F00", Offset = "0x2674300", VA = "0x182674F00")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MIIDIMJCILL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26753B0", Offset = "0x26747B0", VA = "0x1826753B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NIFADNPFPEJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2671430", Offset = "0x2670830", VA = "0x182671430")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) APOCGKJELEN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2676180", Offset = "0x2675580", VA = "0x182676180")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PBFMOKJFHEA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26737D0", Offset = "0x2672BD0", VA = "0x1826737D0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>) HFOOOBIKGDI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? KCECGLFNMNJ)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2674570", Offset = "0x2673970", VA = "0x182674570")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KFLHFOJCNBE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2674DA0", Offset = "0x26741A0", VA = "0x182674DA0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MIHNBGLOCDO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2676670", Offset = "0x2675A70", VA = "0x182676670")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PILINANMNFC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2674140", Offset = "0x2673540", VA = "0x182674140")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JLEMNGPNFCB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2671190", Offset = "0x2670590", VA = "0x182671190")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) AMAMPDPCCKK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2672110", Offset = "0x2671510", VA = "0x182672110")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DCDIPCLEOPJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2673FC0", Offset = "0x26733C0", VA = "0x182673FC0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JKLAKODMOAC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2671AC0", Offset = "0x2670EC0", VA = "0x182671AC0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CHBEJOLGKCA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2671E60", Offset = "0x2671260", VA = "0x182671E60")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CLCKBBDGDIF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2675020", Offset = "0x2674420", VA = "0x182675020")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) MPLIELCDNDF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2673560", Offset = "0x2672960", VA = "0x182673560")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GLLGGKFNCCA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26725C0", Offset = "0x26719C0", VA = "0x1826725C0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) EELAAEFLNMK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26759B0", Offset = "0x2674DB0", VA = "0x1826759B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGIIFIPFNDF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26763C0", Offset = "0x26757C0", VA = "0x1826763C0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PEOMNIDFMEC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2673C40", Offset = "0x2673040", VA = "0x182673C40")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) IEGIMHFAMHL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2675590", Offset = "0x2674990", VA = "0x182675590")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NMDNAMAEGPJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2671860", Offset = "0x2670C60", VA = "0x182671860")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) BMKEJHMDHAL(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2675B30", Offset = "0x2674F30", VA = "0x182675B30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGIILFMNLFP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2672D20", Offset = "0x2672120", VA = "0x182672D20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FKGNJNOMOEP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2672830", Offset = "0x2671C30", VA = "0x182672830")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) ELKJMOBNDKA(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2673E90", Offset = "0x2673290", VA = "0x182673E90")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JEKCIAKAJFC(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26732B0", Offset = "0x26726B0", VA = "0x1826732B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GGFMAOCNPGE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2674420", Offset = "0x2673820", VA = "0x182674420")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KEEALCFEBPI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2672380", Offset = "0x2671780", VA = "0x182672380")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DOEDGMDJEGF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2674C20", Offset = "0x2674020", VA = "0x182674C20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) LPKJLCGPLMP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26746F0", Offset = "0x2673AF0", VA = "0x1826746F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KLGHOPHCBCF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2675C50", Offset = "0x2675050", VA = "0x182675C50")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) OHFACKLMLEN(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2674960", Offset = "0x2673D60", VA = "0x182674960")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) KOEEFDPKMNH(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2672230", Offset = "0x2671630", VA = "0x182672230")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) DKMCINFOKKG(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2673D70", Offset = "0x2673170", VA = "0x182673D70")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) JCIAGDIDPMF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26767A0", Offset = "0x2675BA0", VA = "0x1826767A0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PKOPGHAEJLI(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] int? KINLKKILGMJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2673040", Offset = "0x2672440", VA = "0x182673040")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) FLLLFGDPNFF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? KINLKKILGMJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2675510", Offset = "0x2674910", VA = "0x182675510")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> NJDOCPNPPIO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26742A0", Offset = "0x26736A0", VA = "0x1826742A0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) KBAALKCLKGP(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2670F30", Offset = "0x2670330", VA = "0x182670F30")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) ACEKPMDNCCE(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, float DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NIIKNDFOBBN>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2675D70", Offset = "0x2675170", VA = "0x182675D70")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>) OMKGMDDIEPK(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NIIKNDFOBBN>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NIIKNDFOBBN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2675850", Offset = "0x2674C50", VA = "0x182675850")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) OGAIGFDCDBM(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x26726E0", Offset = "0x2671AE0", VA = "0x1826726E0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) EJJBPAACIAJ(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x26762A0", Offset = "0x26756A0", VA = "0x1826762A0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) PBLNKCALNMF(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26756F0", Offset = "0x2674AF0", VA = "0x1826756F0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) NOALDOFHLGO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2673410", Offset = "0x2672810", VA = "0x182673410")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) GJCHODJKFJO(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, int DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2671C20", Offset = "0x2671020", VA = "0x182671C20")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>) CIPDEIHPELB(this AJFCGHOLDCP<byte> JOCJBPPJMJJ, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? DEMCJNIKPJH, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? BDBPBKINMFE, [Optional] IJOGBJOFPED<KGFODMDJAKK<NEBCLJMKMGM>>? HLCADODJLCN)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<NEBCLJMKMGM>>>));
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
