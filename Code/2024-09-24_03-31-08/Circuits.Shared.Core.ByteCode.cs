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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x2133BD0", Offset = "0x21325D0", VA = "0x182133BD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GIIPLINEHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9150", Offset = "0x2AC7B50", VA = "0x182AC9150")]
	public static OPGJAFEOJCM<IGJFABAJMBK<M>> LCODGNADFIF<M>(this int NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2133840", Offset = "0x2132240", VA = "0x182133840")]
	public static OPGJAFEOJCM<DANLPKAAPFE> IHFFHCCBADC(this int NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<DANLPKAAPFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9150", Offset = "0x2AC7B50", VA = "0x182AC9150")]
	public static OPGJAFEOJCM<NHEBBFAJBPG<M>> DDIDPLBFCDL<M>(this int NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<NHEBBFAJBPG<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IGJFABAJMBK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GJLDBEKGAJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AEGLIOJDBGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DANLPKAAPFE
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AONLOJJKNMD
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HNLAKFOIAJK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BDFIKBBPAFJ
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
public static class CNLFCNCEALJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HNPDAKABEMG<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr JNBNLEMDFMF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
		public HNPDAKABEMG(IntPtr KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3FD29F0", Offset = "0x3FD13F0", VA = "0x183FD29F0")]
		public int CPLCIOOIDJC(TDeps HBFCALFCDLO, TContext KKDHCJGLKPO, TCompileState AGLBDIECLFP, [In] LPKDJPNEIBH<byte> CNGFGCACKLE, int LDMLHFOGHJB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B5C380", Offset = "0x2B5AD80", VA = "0x182B5C380")]
	public static void JHMJENDOMPM<TDeps, TContext, TCompileState>(TDeps HBFCALFCDLO, TContext KKDHCJGLKPO, TCompileState AGLBDIECLFP, [In] LPKDJPNEIBH<byte> MOBNHJLEKLD, LPKDJPNEIBH<byte> PGKBFAMHCEJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NLBHBFLIBKM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DPPLCNCFMEH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HOAHODEGMIA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PALJKFNFHFD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IJAALAPIBGF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? INNEAJNDMKJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OCCBNEDLDMJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HNLBKGHNLJJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LGPBHLMJAHG, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NBKOECGJKPA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BFKBPKJJANH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KNFLGCCCFME, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ECLLECOIGIF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NDONBNHDGBD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? GDMPAHCLGDK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MCPGLHFJGFO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HNFNHPFMFJA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PODGGCJINNK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OAEAPIKDBFM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ILDPHFPOHBN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PAKJNMPJIHB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DCDLNLJCLBF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OGPFFBILOKH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HMHBBCBDNDO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EEFIDCCJLKF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OHBNNENBCPN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LCMIBFKOBMP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IIDONHNAAMP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BAAEMEBDGAK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PCFFPDPLEKI, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DCLHCAOOBPO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IOMPCELBFOK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NDFPJHJIIKG, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KBHOOMPCACG, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EJJMMDLJJGP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EHKENJCOGAG, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KJJJPHCKCHE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KLFHHFEBNEB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PEDKDCHFIGD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DAOCDHGKCDM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DIHCADKOBBD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MOLJMEJJKEL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OEJLIABEIOF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PMLHONJKIBK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MMIMHKJHGKL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IIIMEOICMEF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? AAELLJMCBLC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KCLEPJNLOIE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NDMACKKFGDO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HAAAALDLHIC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PNPLOKJMGKE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? FKGNNIAIENM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IKJIFIMILIM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ABNBJKIHHFB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PNBMPNFDEDB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LGKDAMAPNPJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? CKPENGLNODB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LBAPCHCBGMK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PHGBGPHFKMN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NEEEPEBJKCD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LKODMPAGGHA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BKOIKDEBOFO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? FBOMNOJMKME, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? AIDPLOIKEJN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LJGEAOIIFJP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BOIOOLIMCBC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HMODPIOPHOL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MONHNMCLLDF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KDHHEOKNBGN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OMLLEKKFGGN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? GINBFHNKNEP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ABIBJNHGAPP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? APHPKLCBHBL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ECLMLGGINPO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? CAOCEMKMIOP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NOAIJCHKNID, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KAKAOGEOOGF, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EOFMCBIKJNJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? CGBGOOCIPPM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OLALCGFPNMN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DJHHHDIONHD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? AEJPNAHPDLM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IGKBHCMANJN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NHBOBFBNFMP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? POIPJPHDOOC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HHBENLLLNJK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IPPJIGBKFDC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KGMAFCEGGDP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? JLFGKMNKMJO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BMJJCHGKCGK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HCNDLNPMING, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? GBJNPFOAHOM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? FBMGDFENHKE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? JLBIBFBEFEG, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BBGJLPCAGHO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? JCLGFBMOJHA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? ENDLEOJNKEL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? FJCMIJEJMJM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LCEGMHCNDAE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EDFCPNELOMH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LJLICDOJBIP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? KENAPDGLMCC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? GFMDKGFDFKD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DAPAJBCJMAE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? CFEAANKBDHC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MAENFIPOBCH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EJMJGDACAMB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BLFHCDCMDND, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BNCCEJAJDDM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MHGHIAJBBEC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? CJDBHGACFCL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? FIFJABKGHCK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IJKPKILAOGP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? NGKPAJPMJNB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EPDNMJPPNBP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? COCKKHCFOFE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? HLNIGIAKAFH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? APJJODOLAFJ, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DLFMCDKNNPA, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MDJLHMANLNN, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? JDLFAPFEBFI, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OMNNPMNCPBL, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? DDOLIPGGJLP, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EMBEMEIOHGD, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PKFEMADCBIC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BCKFEGMFHCK, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? AHLIIKBJFMM, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IGENAGHNNIH, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? EIBIKNALHEI, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? IFILCLLOKNB, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? MBIEOGEIIME, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? PIKGNBDFEBO, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? LJGKIIDBNIC, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? BHLOJAOJFPE, [Optional] HNPDAKABEMG<TContext, TDeps, TCompileState>? OLILOFGJJML) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x21337A0", Offset = "0x21321A0", VA = "0x1821337A0")]
	private static int IHFJCGLJGIL([In] LPKDJPNEIBH<byte> CFBNLICAJEE, LPKDJPNEIBH<byte> HPOPBHJPBJH, int ICLEKBDIINO, int CMNDBGDABDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ODEJIDONHKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int LMJKDODOEPE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7580", Offset = "0x2EF5F80", VA = "0x182EF7580")]
	public static OPGJAFEOJCM<IGJFABAJMBK<T>> HABGFDCMFAH<T>([In] this LPKDJPNEIBH<byte> NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF73F0", Offset = "0x2EF5DF0", VA = "0x182EF73F0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<T>>> BMMMENELJAL<T>(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<IGJFABAJMBK<T>>? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2133E20", Offset = "0x2132820", VA = "0x182133E20")]
	public static OPGJAFEOJCM<IGJFABAJMBK<FGMDLGKIGON>> CGEBPIADJPF(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<FGMDLGKIGON>? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<FGMDLGKIGON>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2133C50", Offset = "0x2132650", VA = "0x182133C50")]
	public static OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>> BGOEHODEPDC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] float? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21340F0", Offset = "0x2132AF0", VA = "0x1821340F0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>> HLBKKFGIGHE(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2133D40", Offset = "0x2132740", VA = "0x182133D40")]
	public static OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>> BOBBIPBMJGE(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<MCIIOIKPKCA>? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2133F00", Offset = "0x2132900", VA = "0x182133F00")]
	public static OPGJAFEOJCM<IGJFABAJMBK<HNLAKFOIAJK>> EKBHAFLGIBC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] byte? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<HNLAKFOIAJK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21341D0", Offset = "0x2132BD0", VA = "0x1821341D0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<DANLPKAAPFE>> JODGPLHIODK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<DANLPKAAPFE>? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<DANLPKAAPFE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2134000", Offset = "0x2132A00", VA = "0x182134000")]
	public static OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> HBEGKGJIPAK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] BDFIKBBPAFJ? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2EF74B0", Offset = "0x2EF5EB0", VA = "0x182EF74B0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<T>>> CGCEGAMNFAN<T>(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<T>>? IPHMAHBENGI)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2133650", Offset = "0x2132050", VA = "0x182133650")]
	public static void JKABOJFAOEN(this LPKDJPNEIBH<byte> NKCEKILMAAM, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>> OECENCONJHD, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7570", Offset = "0x2EF5F70", VA = "0x182EF7570")]
	public static void GAKFKHFPKDI<T>(this LPKDJPNEIBH<byte> NKCEKILMAAM, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<T>>> LDMLHFOGHJB, OPGJAFEOJCM<IGJFABAJMBK<T>> IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7570", Offset = "0x2EF5F70", VA = "0x182EF7570")]
	public static void FHAIFKCAPKP<T>(this LPKDJPNEIBH<byte> NKCEKILMAAM, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<T>>> AKKMLKOKGLD, OPGJAFEOJCM<NHEBBFAJBPG<T>> IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BKILPOFGHLM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2133690", Offset = "0x2132090", VA = "0x182133690")]
	public static CPPMLHJKLEH DOOMENIPPNM([In] this ReadOnlySpan<byte> MGCOGNAKONH, int FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2133700", Offset = "0x2132100", VA = "0x182133700")]
	public static CPPMLHJKLEH DOOMENIPPNM([In] this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2A70", Offset = "0x2AF1470", VA = "0x182AF2A70")]
	public static CPPMLHJKLEH DOOMENIPPNM<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2CE0", Offset = "0x2AF16E0", VA = "0x182AF2CE0")]
	public static CPPMLHJKLEH DOOMENIPPNM<M>([In] this AINEHBOCFPJ<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2C80", Offset = "0x2AF1680", VA = "0x182AF2C80")]
	public static CPPMLHJKLEH DOOMENIPPNM<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2A00", Offset = "0x2AF1400", VA = "0x182AF2A00")]
	public static CPPMLHJKLEH DOOMENIPPNM<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2BC0", Offset = "0x2AF15C0", VA = "0x182AF2BC0")]
	public static CPPMLHJKLEH DOOMENIPPNM<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2133690", Offset = "0x2132090", VA = "0x182133690")]
	public static int CNKLCGGKKGB([In] this ReadOnlySpan<byte> MGCOGNAKONH, int FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21334E0", Offset = "0x2131EE0", VA = "0x1821334E0")]
	public static int CNKLCGGKKGB([In] this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static int CNKLCGGKKGB<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static int CNKLCGGKKGB<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static int CNKLCGGKKGB<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static int CNKLCGGKKGB<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2AF28E0", Offset = "0x2AF12E0", VA = "0x182AF28E0")]
	public static float BHMKIEOBAPK<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2AF28E0", Offset = "0x2AF12E0", VA = "0x182AF28E0")]
	public static float BHMKIEOBAPK<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2AF28E0", Offset = "0x2AF12E0", VA = "0x182AF28E0")]
	public static float BHMKIEOBAPK<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3000", Offset = "0x2AF1A00", VA = "0x182AF3000")]
	public static byte HGHGKCJHIDG<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2FE0", Offset = "0x2AF19E0", VA = "0x182AF2FE0")]
	public static byte HGHGKCJHIDG<M>([In] this AINEHBOCFPJ<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2C80", Offset = "0x2AF1680", VA = "0x182AF2C80")]
	public static byte HGHGKCJHIDG<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2A00", Offset = "0x2AF1400", VA = "0x182AF2A00")]
	public static byte HGHGKCJHIDG<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2F20", Offset = "0x2AF1920", VA = "0x182AF2F20")]
	public static byte HGHGKCJHIDG<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x21334E0", Offset = "0x2131EE0", VA = "0x1821334E0")]
	public static BDFIKBBPAFJ IBALIFIHMPE([In] this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM)
	{
		return default(BDFIKBBPAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static BDFIKBBPAFJ IBALIFIHMPE<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(BDFIKBBPAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AF30A0", Offset = "0x2AF1AA0", VA = "0x182AF30A0")]
	public static OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> LDFNMKNNCKK<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3030", Offset = "0x2AF1A30", VA = "0x182AF3030")]
	public static OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> LDFNMKNNCKK<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3110", Offset = "0x2AF1B10", VA = "0x182AF3110")]
	public static OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> LDFNMKNNCKK<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2E40", Offset = "0x2AF1840", VA = "0x182AF2E40")]
	public static OPGJAFEOJCM<NHEBBFAJBPG<EOKPLNLLEKB>> GDIAFEIHOEG<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<NHEBBFAJBPG<EOKPLNLLEKB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3180", Offset = "0x2AF1B80", VA = "0x182AF3180")]
	public static OPGJAFEOJCM<DANLPKAAPFE> OCGHOHMMNOP<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<DANLPKAAPFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AF31F0", Offset = "0x2AF1BF0", VA = "0x182AF31F0")]
	public static OPGJAFEOJCM<DANLPKAAPFE> OCGHOHMMNOP<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<DANLPKAAPFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3260", Offset = "0x2AF1C60", VA = "0x182AF3260")]
	public static OPGJAFEOJCM<DANLPKAAPFE> OCGHOHMMNOP<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<DANLPKAAPFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2920", Offset = "0x2AF1320", VA = "0x182AF2920")]
	public static OPGJAFEOJCM<FGMDLGKIGON> CAMMEHMMOGE<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<FGMDLGKIGON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2990", Offset = "0x2AF1390", VA = "0x182AF2990")]
	public static OPGJAFEOJCM<FGMDLGKIGON> CAMMEHMMOGE<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<FGMDLGKIGON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2EB0", Offset = "0x2AF18B0", VA = "0x182AF2EB0")]
	public static OPGJAFEOJCM<MCIIOIKPKCA> HEDNNOOMKOG<M>(this GNGCBGLJKKH<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM)
	{
		return default(OPGJAFEOJCM<MCIIOIKPKCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GLFIFEDFALL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2133870", Offset = "0x2132270", VA = "0x182133870")]
	public static void BIIIIENBNCL(this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM, CPPMLHJKLEH IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2133930", Offset = "0x2132330", VA = "0x182133930")]
	public static void BIIIIENBNCL(this byte[] MGCOGNAKONH, int FAIAABCCDGM, CPPMLHJKLEH IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x21339A0", Offset = "0x21323A0", VA = "0x1821339A0")]
	public static void BIIIIENBNCL([In] this Span<byte> MGCOGNAKONH, int FAIAABCCDGM, CPPMLHJKLEH IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D6FE80", Offset = "0x2D6E880", VA = "0x182D6FE80")]
	public static void BIIIIENBNCL<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, CPPMLHJKLEH IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D6FCE0", Offset = "0x2D6E6E0", VA = "0x182D6FCE0")]
	public static void BIIIIENBNCL<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, CPPMLHJKLEH IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2133650", Offset = "0x2132050", VA = "0x182133650")]
	public static void JKABOJFAOEN(this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2133A90", Offset = "0x2132490", VA = "0x182133A90")]
	public static void JKABOJFAOEN(this byte[] MGCOGNAKONH, int FAIAABCCDGM, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2133B10", Offset = "0x2132510", VA = "0x182133B10")]
	public static void JKABOJFAOEN([In] this Span<byte> MGCOGNAKONH, int FAIAABCCDGM, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D700C0", Offset = "0x2D6EAC0", VA = "0x182D700C0")]
	public static void JKABOJFAOEN<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D70120", Offset = "0x2D6EB20", VA = "0x182D70120")]
	public static void JKABOJFAOEN<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2133B90", Offset = "0x2132590", VA = "0x182133B90")]
	public static void ONJNNKGBFMI(this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D701E0", Offset = "0x2D6EBE0", VA = "0x182D701E0")]
	public static void ONJNNKGBFMI<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D70180", Offset = "0x2D6EB80", VA = "0x182D70180")]
	public static void ONJNNKGBFMI<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2133A20", Offset = "0x2132420", VA = "0x182133A20")]
	public static void FJKKDONLGJA(this LPKDJPNEIBH<byte> MGCOGNAKONH, int FAIAABCCDGM, byte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D70020", Offset = "0x2D6EA20", VA = "0x182D70020")]
	public static void FJKKDONLGJA<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, byte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D70070", Offset = "0x2D6EA70", VA = "0x182D70070")]
	public static void FJKKDONLGJA<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, byte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA240", Offset = "0x2AC8C40", VA = "0x182ACA240")]
	public static void GAKFKHFPKDI<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA240", Offset = "0x2AC8C40", VA = "0x182ACA240")]
	public static void GAKFKHFPKDI<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, OPGJAFEOJCM<IGJFABAJMBK<EOKPLNLLEKB>> IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA240", Offset = "0x2AC8C40", VA = "0x182ACA240")]
	public static void PHAKNMFGKHL<M>(this LONKLMLKJDA<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, OPGJAFEOJCM<DANLPKAAPFE> IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA240", Offset = "0x2AC8C40", VA = "0x182ACA240")]
	public static void PHAKNMFGKHL<M>([In] this EDCLADEAIAE<M, byte> MGCOGNAKONH, OPGJAFEOJCM<M> FAIAABCCDGM, OPGJAFEOJCM<DANLPKAAPFE> IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PCPPEOABLJD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2138A60", Offset = "0x2137460", VA = "0x182138A60")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) NKIDJCPEBGI(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2137D50", Offset = "0x2136750", VA = "0x182137D50")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) LHHDODNCFPD(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2139160", Offset = "0x2137B60", VA = "0x182139160")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) PBEFGOCKGNL(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2137980", Offset = "0x2136380", VA = "0x182137980")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) KDFBJIBBJGI(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x21347C0", Offset = "0x21331C0", VA = "0x1821347C0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) BHNPLOJPBJH(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21365A0", Offset = "0x2134FA0", VA = "0x1821365A0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) GNAFKFILEMM(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2138BE0", Offset = "0x21375E0", VA = "0x182138BE0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) NNFNOFONMGF(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2136F40", Offset = "0x2135940", VA = "0x182136F40")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) JDLAFIKELJD(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2134BC0", Offset = "0x21335C0", VA = "0x182134BC0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) CKINMEBNNFK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21366C0", Offset = "0x21350C0", VA = "0x1821366C0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>) GOBALMHNFHD(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? IPHMAHBENGI, [Optional] OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? NALFFKIEGPE)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2136070", Offset = "0x2134A70", VA = "0x182136070")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>) GBDHDPOJAPC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? IPHMAHBENGI, [Optional] OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? NALFFKIEGPE)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2135A60", Offset = "0x2134460", VA = "0x182135A60")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>) FEHHNBPAHIN(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? IPHMAHBENGI, [Optional] OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? NALFFKIEGPE)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2137420", Offset = "0x2135E20", VA = "0x182137420")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>) JKJLDKLBOAD(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? IPHMAHBENGI, [Optional] OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? NALFFKIEGPE)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2137540", Offset = "0x2135F40", VA = "0x182137540")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<FGMDLGKIGON>>) JKPEHBHIIFC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? HKFADMEMMAC, [Optional] OPGJAFEOJCM<FGMDLGKIGON>? EDFBCBDPOLM)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<FGMDLGKIGON>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2139A10", Offset = "0x2138410", VA = "0x182139A10")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<FGMDLGKIGON>>>) PLOMEMBJHJK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? HKFADMEMMAC, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<FGMDLGKIGON>>? EDFBCBDPOLM)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<FGMDLGKIGON>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21393B0", Offset = "0x2137DB0", VA = "0x1821393B0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<DANLPKAAPFE>>) PJCAELEBEOK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? HKFADMEMMAC, [Optional] OPGJAFEOJCM<DANLPKAAPFE>? EDFBCBDPOLM)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<DANLPKAAPFE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2134410", Offset = "0x2132E10", VA = "0x182134410")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<DANLPKAAPFE>>>) AKEEKHJFNIF(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? HKFADMEMMAC, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<DANLPKAAPFE>>? EDFBCBDPOLM)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<DANLPKAAPFE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F08A80", Offset = "0x2F07480", VA = "0x182F08A80")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>) BKABNEONAKJ<TMarker>(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<MCIIOIKPKCA>? EDFBCBDPOLM, [Optional][In] ReadOnlySpan<byte> LNCKNHNHHDF)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<MCIIOIKPKCA>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21367D0", Offset = "0x21351D0", VA = "0x1821367D0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) HHJKFLAFCGC(this LPKDJPNEIBH<byte> NKCEKILMAAM, int CFBNLICAJEE, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? HPOPBHJPBJH)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2134E30", Offset = "0x2133830", VA = "0x182134E30")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) DAFDDFIKOKK(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CFBNLICAJEE, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? HPOPBHJPBJH)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F08C80", Offset = "0x2F07680", VA = "0x182F08C80")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>) DCDGBKBMFGP<TMarker>(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<TMarker>>? HPOPBHJPBJH, [Optional] int? ECFPAOHDFEB, [Optional][In] ReadOnlySpan<byte> CFBNLICAJEE)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F08E70", Offset = "0x2F07870", VA = "0x182F08E70")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>) HACNCGPGLOL<TMarker>(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<TMarker>>? CFBNLICAJEE, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<TMarker>>? HPOPBHJPBJH, [Optional] int? ECFPAOHDFEB)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<TMarker>>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2137800", Offset = "0x2136200", VA = "0x182137800")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) JPIOAJPFNFJ(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2137090", Offset = "0x2135A90", VA = "0x182137090")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) JFBFBMIEHAH(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2134520", Offset = "0x2132F20", VA = "0x182134520")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) BBPLGMLLICH(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2136190", Offset = "0x2134B90", VA = "0x182136190")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) GGKPCKFEDNI(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2139B20", Offset = "0x2138520", VA = "0x182139B20")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) PPIDBBBIDDL(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x21357C0", Offset = "0x21341C0", VA = "0x1821357C0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) EHBKOGFNPHC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x21362F0", Offset = "0x2134CF0", VA = "0x1821362F0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) GJHDKBIOIMG(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2134A70", Offset = "0x2133470", VA = "0x182134A70")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) CDPAAFPNCEM(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2139790", Offset = "0x2138190", VA = "0x182139790")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) PKCBIEMJMDE(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2139550", Offset = "0x2137F50", VA = "0x182139550")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>) PJIHPANBPBL(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>? CDPPHMODNEP)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<IGJFABAJMBK<AONLOJJKNMD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2138FE0", Offset = "0x21379E0", VA = "0x182138FE0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) ONAOAALBMMK(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2135660", Offset = "0x2134060", VA = "0x182135660")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) ECLBDJFOCGG(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2138000", Offset = "0x2136A00", VA = "0x182138000")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) LNKCLIMAABI(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2135500", Offset = "0x2133F00", VA = "0x182135500")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) EAEPNMLGANC(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2138D40", Offset = "0x2137740", VA = "0x182138D40")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) NOKPEEGCNJB(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21371E0", Offset = "0x2135BE0", VA = "0x1821371E0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) JFDOCFGAKLN(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2136B90", Offset = "0x2135590", VA = "0x182136B90")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) IEOHGPFCIFL(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2137EA0", Offset = "0x21368A0", VA = "0x182137EA0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) LKLJKHFECDI(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2135CD0", Offset = "0x21346D0", VA = "0x182135CD0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) FIHAHKLGIAD(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2138900", Offset = "0x2137300", VA = "0x182138900")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) NGAAHANPIED(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2138E90", Offset = "0x2137890", VA = "0x182138E90")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) OMJHJFINBKJ(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x21376E0", Offset = "0x21360E0", VA = "0x1821376E0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) JLKJOGINHNP(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2134640", Offset = "0x2133040", VA = "0x182134640")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) BCHMOMGLMJD(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x21398B0", Offset = "0x21382B0", VA = "0x1821398B0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) PLHPOFHLEDM(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2135120", Offset = "0x2133B20", VA = "0x182135120")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) DHJFDGPNMPL(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2134FC0", Offset = "0x21339C0", VA = "0x182134FC0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) DFGHENICLPD(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2139640", Offset = "0x2138040", VA = "0x182139640")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) PJMGFFKBAIP(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2137AE0", Offset = "0x21364E0", VA = "0x182137AE0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) KFKKFJKCGJP(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21358E0", Offset = "0x21342E0", VA = "0x1821358E0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) ENEECBMAALM(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x21383A0", Offset = "0x2136DA0", VA = "0x1821383A0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) MFGJBNELFOE(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2139280", Offset = "0x2137C80", VA = "0x182139280")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) PHMGAKDKECG(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2135250", Offset = "0x2133C50", VA = "0x182135250")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) DIEBOKCNBCD(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2134CE0", Offset = "0x21336E0", VA = "0x182134CE0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) CPOLELNKJEB(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x21342F0", Offset = "0x2132CF0", VA = "0x1821342F0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) AFPMPGBBLBC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2136A10", Offset = "0x2135410", VA = "0x182136A10")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) HMACOBDIPGP(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2136450", Offset = "0x2134E50", VA = "0x182136450")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) GMMIJIOJHKG(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2135E00", Offset = "0x2134800", VA = "0x182135E00")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) FJNAILGENPN(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x21387A0", Offset = "0x21371A0", VA = "0x1821387A0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) NCLBIOCGOBH(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2135F20", Offset = "0x2134920", VA = "0x182135F20")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) FNECLLNLBBH(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2137300", Offset = "0x2135D00", VA = "0x182137300")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) JIJNBBKMLPA(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2136D10", Offset = "0x2135710", VA = "0x182136D10")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) IHAENKNIDPC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] int? JBGBNMNJCFB, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2136900", Offset = "0x2135300", VA = "0x182136900")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) HJLOFKAHGGG(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? JBGBNMNJCFB, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2134F40", Offset = "0x2133940", VA = "0x182134F40")]
	public static OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>> DCIDEPOCHKK(this LPKDJPNEIBH<byte> NKCEKILMAAM)
	{
		return default(OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2138620", Offset = "0x2137020", VA = "0x182138620")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) MKMABNPJLCI(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, float KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21353B0", Offset = "0x2133DB0", VA = "0x1821353B0")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) DMGEJLNKLCG(this LPKDJPNEIBH<byte> NKCEKILMAAM, float MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<GJLDBEKGAJO>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2138500", Offset = "0x2136F00", VA = "0x182138500")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>) MGBEBNGIKIF(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<GJLDBEKGAJO>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<GJLDBEKGAJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2134910", Offset = "0x2133310", VA = "0x182134910")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) BIEIKEFMBFM(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2137C00", Offset = "0x2136600", VA = "0x182137C00")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) LABNNCHIPDF(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2136E20", Offset = "0x2135820", VA = "0x182136E20")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) IPLPBLDCODC(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2135B70", Offset = "0x2134570", VA = "0x182135B70")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) FEJKPMALPJB(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, int KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2138250", Offset = "0x2136C50", VA = "0x182138250")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) MEFEACKEPKE(this LPKDJPNEIBH<byte> NKCEKILMAAM, int MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<AEGLIOJDBGL>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2138130", Offset = "0x2136B30", VA = "0x182138130")]
	public static (OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>) MDHLLALIEEG(this LPKDJPNEIBH<byte> NKCEKILMAAM, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? MNLAHNFDLLH, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? KLEJJNEPDEF, [Optional] OPGJAFEOJCM<NHEBBFAJBPG<AEGLIOJDBGL>>? CALFCOGJOLL)
	{
		return default((OPGJAFEOJCM<IGJFABAJMBK<AONLOJJKNMD>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>, OPGJAFEOJCM<IGJFABAJMBK<NHEBBFAJBPG<AEGLIOJDBGL>>>));
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
