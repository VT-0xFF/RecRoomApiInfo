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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x2151660", Offset = "0x2150060", VA = "0x182151660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CDAPGLFACEP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B02AF0", Offset = "0x2B014F0", VA = "0x182B02AF0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<M>> PELMBOPAHFC<M>(this int BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x214B8B0", Offset = "0x214A2B0", VA = "0x18214B8B0")]
	public static MJGAEDNBJIL<KNKIADDLFII> FOJKEIFKNJL(this int BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<KNKIADDLFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B02AF0", Offset = "0x2B014F0", VA = "0x182B02AF0")]
	public static MJGAEDNBJIL<EBDEMPHJNGG<M>> DHIGIMKOEDL<M>(this int BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<EBDEMPHJNGG<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JEBGKIHAOOI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ADHNIDPBJCB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AIKPPCNEKMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KNKIADDLFII
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GNMBBGKMBGH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JEPMHMDACMJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KHGAJKCCEGJ
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
public static class LKKCGAGIDAI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FEDPCOCFBDP<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr EKFNPIOLJCE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
		public FEDPCOCFBDP(IntPtr BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD740", Offset = "0x3DDC140", VA = "0x183DDD740")]
		public int FJEDBGMGJGG(TDeps LAKCFHGOLJA, TContext KOFICKKDIEG, TCompileState IHDPPPBCPPN, [In] JEJGNFFBHBC<byte> LBHMBOGFIOB, int OGPKFMCBIAC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A390", Offset = "0x2E58D90", VA = "0x182E5A390")]
	public static void PHELKLLJKBC<TDeps, TContext, TCompileState>(TDeps LAKCFHGOLJA, TContext KOFICKKDIEG, TCompileState IHDPPPBCPPN, [In] JEJGNFFBHBC<byte> LLKNGDNJPHM, JEJGNFFBHBC<byte> PINPKBONMEN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MMHNIHCNDPD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NKNGANLIONF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BNGBAOBPDAG, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? KNIEJDIENEB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? KKHCLMBKCKD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OAEENAEEAGK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MKCBLIKIBBB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NCJOIELLPKG, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PDGEGGNNJHP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DPBCLILFDDF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IPEODNOHNEK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MKLPAOKCMKE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BNPEFHCHJCI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DHIGNDCCPCH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OOENJOCPHGP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GPOOHOMNIHD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FPCMJHKNPJH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? AIGJMLCEFJE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? JLLJGDJAFBO, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BGOFMAMOOAJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FKGFFBMFMPL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DCFOLEMNKBF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GPGOPFLFEAH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PPMHBIGHIBI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HKDOLGLEHAJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? JPBFBJFFDIA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OENKFDFFNEM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MJALODEAHHA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? CBANBKPELIF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HENPBAEEDKK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DHBBMDEGEHJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PFMLPADNBPO, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FJJDELLMPKM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BLOEFLDIELB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? KJLGIOENHBF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ICJALBDFGNH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IENLIANDJLC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GOLMINDANMB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ADDJPMOAFLN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HPGIJLGBPEF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? AACCHBMNLCJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ONIJFAHKJKO, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FPAMDBIODBJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DIAADPIDGEF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FKOJPPKODHK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MHBCACKAIHL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NGEKOGBOMGF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PABMIDNFNJD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OAEGLDNFAEE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OLLKIFCIICC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? CKCOFHFJMOD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GCMNJHBABJI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IGCNJMEMCEA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FMBBKFEPFKA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MJNBCKCKKNJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GKPCOOFEOLL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ODBCCLPHJIE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ANIJDMCLEBL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NOLNHBHOKNI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? JFOHBNIGGKP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HIPFMBLHNKO, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OGAFICGNCAI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NOJBOKELMID, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BKDPICJNKBL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OMBDLMNIPFE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OCMHDIFHGFK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OODKMIDCHBM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MAGAHOCIMJN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IKOHPBPGEEM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GHLBLMNOIPN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? KIJMGCAPAFH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? CDOGKAAAKNA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? EDBJGJKMGNL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OFGIEBNINBK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LNLHNKBCAME, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ALAIFIDDDGK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PIPNGIJCEGI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MNCPOCGCJKF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LPIIIDBOPKE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BBAHDFOPDMB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? AGDLFOCOMDC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DDODJBJCILE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FADCDMEDLBM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GHHJKDHFCMF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NCIGBIGALIC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FLPLKFEEHNM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GEHIKNIKGDI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LOPCHGIAHFF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IHPJIOIHGGI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MDFPJKPIOIP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BHGCAGCDGML, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LLKAHOMHMCE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LHHDIIHNNFH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DPENMFKMFGH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LEBEGBPLPNH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? AOPGAJMKMBD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MEEOBKBABGK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DMKELGLLCPH, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GLGFMLKCECL, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FGCIOENJLOD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? JAEKCKOIPCM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OAFFKHCIHIE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BMEEGKAGNCJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MJFEDJIDAFK, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DLBDEHBDJFI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DHGMDDPBBPP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PKBGFBPJBHB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? EGCEELPDLMD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DKPFOOPGIAM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OBJOMKGLCLD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OALECEAJAKP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? MMAECIEBNJA, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HPPNAGJCODC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PPOBDFALHGE, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? BBEKFHPKAPB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? IHJBALMCBKN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? HICKJLAHAOM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? JNLKHKCBONB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? PDFAEBMAIMG, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ODCCPBEFGIC, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? FKNNDKEMKMI, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DAFALMCAFFM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? LGMOKPKPGCM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? AHDBAGBIGCB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? GHHPADBGGGM, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OBDDEPEFLFF, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? EOMACACOCHG, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? KPJLEKCOPHP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? NCHGAGLPMEO, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DKAJHJKDAOB, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? ODKMIJLLONP, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DFNBHBHAEFD, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? OCMHOMHGCAJ, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? DGKLOKMICHN, [Optional] FEDPCOCFBDP<TContext, TDeps, TCompileState>? CKEHAGOCJCH) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x21515C0", Offset = "0x214FFC0", VA = "0x1821515C0")]
	private static int DGAGMHFDGNM([In] JEJGNFFBHBC<byte> NEDJODMJOFF, JEJGNFFBHBC<byte> OHIICHJPFBL, int OENMMCMOJOM, int FIGHABPEBPG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PBLJHFBELIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int OANKELOHELO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F36A10", Offset = "0x2F35410", VA = "0x182F36A10")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<T>> DCJADHIBJFI<T>([In] this JEJGNFFBHBC<byte> BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F36A80", Offset = "0x2F35480", VA = "0x182F36A80")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<T>>> GKNIPOHICCL<T>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<T>>? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21516E0", Offset = "0x21500E0", VA = "0x1821516E0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<GAPKMCGHPMH>> AACPOKFHEBN(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<GAPKMCGHPMH>? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<GAPKMCGHPMH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21518A0", Offset = "0x21502A0", VA = "0x1821518A0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>> EAFLACPNGDM(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] float? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21517C0", Offset = "0x21501C0", VA = "0x1821517C0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>> CBNLANKPJEP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2151B60", Offset = "0x2150560", VA = "0x182151B60")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>> NEBOBFOMLEL(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<PGDNFPGMBLK>? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2151C40", Offset = "0x2150640", VA = "0x182151C40")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEPMHMDACMJ>> NIJDAOBMKFP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] byte? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEPMHMDACMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2151990", Offset = "0x2150390", VA = "0x182151990")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<KNKIADDLFII>> FNOIHMKFNKM(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<KNKIADDLFII>? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<KNKIADDLFII>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2151A70", Offset = "0x2150470", VA = "0x182151A70")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> GCEEBHKJDDK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] KHGAJKCCEGJ? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F36B40", Offset = "0x2F35540", VA = "0x182F36B40")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<T>>> LHCKIEILPOF<T>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<T>>? KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x214B760", Offset = "0x214A160", VA = "0x18214B760")]
	public static void IHIIKFBDGPP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>> CPIIGJDHDLH, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F36A70", Offset = "0x2F35470", VA = "0x182F36A70")]
	public static void KDOJLFJBMJJ<T>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<T>>> OGPKFMCBIAC, MJGAEDNBJIL<JEBGKIHAOOI<T>> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F36A70", Offset = "0x2F35470", VA = "0x182F36A70")]
	public static void FAPCEFNPAIM<T>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<T>>> KKCBAJFOCIP, MJGAEDNBJIL<EBDEMPHJNGG<T>> KLABJGGMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ANJBJGLEOFE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x214B840", Offset = "0x214A240", VA = "0x18214B840")]
	public static POJKEEADMGJ EDDMCKEPOBM([In] this ReadOnlySpan<byte> CNGBPDKMHBB, int LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x214B7A0", Offset = "0x214A1A0", VA = "0x18214B7A0")]
	public static POJKEEADMGJ EDDMCKEPOBM([In] this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x344E720", Offset = "0x344D120", VA = "0x18344E720")]
	public static POJKEEADMGJ EDDMCKEPOBM<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x344E930", Offset = "0x344D330", VA = "0x18344E930")]
	public static POJKEEADMGJ EDDMCKEPOBM<M>([In] this DGMLJFEPJHP<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x344E540", Offset = "0x344CF40", VA = "0x18344E540")]
	public static POJKEEADMGJ EDDMCKEPOBM<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x344E6B0", Offset = "0x344D0B0", VA = "0x18344E6B0")]
	public static POJKEEADMGJ EDDMCKEPOBM<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x344E870", Offset = "0x344D270", VA = "0x18344E870")]
	public static POJKEEADMGJ EDDMCKEPOBM<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x214B840", Offset = "0x214A240", VA = "0x18214B840")]
	public static int EDFOLNCDMIH([In] this ReadOnlySpan<byte> CNGBPDKMHBB, int LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x214B690", Offset = "0x214A090", VA = "0x18214B690")]
	public static int EDFOLNCDMIH([In] this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DD0", Offset = "0x2E067D0", VA = "0x182E07DD0")]
	public static int EDFOLNCDMIH<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DD0", Offset = "0x2E067D0", VA = "0x182E07DD0")]
	public static int EDFOLNCDMIH<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DD0", Offset = "0x2E067D0", VA = "0x182E07DD0")]
	public static int EDFOLNCDMIH<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DD0", Offset = "0x2E067D0", VA = "0x182E07DD0")]
	public static int EDFOLNCDMIH<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x344EB70", Offset = "0x344D570", VA = "0x18344EB70")]
	public static float FJPDCCHPFEH<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x344EB70", Offset = "0x344D570", VA = "0x18344EB70")]
	public static float FJPDCCHPFEH<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x344EB70", Offset = "0x344D570", VA = "0x18344EB70")]
	public static float FJPDCCHPFEH<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x344E680", Offset = "0x344D080", VA = "0x18344E680")]
	public static byte DOLAJOHMLIC<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x344E5A0", Offset = "0x344CFA0", VA = "0x18344E5A0")]
	public static byte DOLAJOHMLIC<M>([In] this DGMLJFEPJHP<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x344E540", Offset = "0x344CF40", VA = "0x18344E540")]
	public static byte DOLAJOHMLIC<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x344E6B0", Offset = "0x344D0B0", VA = "0x18344E6B0")]
	public static byte DOLAJOHMLIC<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x344E5C0", Offset = "0x344CFC0", VA = "0x18344E5C0")]
	public static byte DOLAJOHMLIC<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x214B690", Offset = "0x214A090", VA = "0x18214B690")]
	public static KHGAJKCCEGJ HNIIFPJFMNB([In] this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC)
	{
		return default(KHGAJKCCEGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DD0", Offset = "0x2E067D0", VA = "0x182E07DD0")]
	public static KHGAJKCCEGJ HNIIFPJFMNB<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(KHGAJKCCEGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x344ED00", Offset = "0x344D700", VA = "0x18344ED00")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> OPLMDGMKIJN<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x344EC20", Offset = "0x344D620", VA = "0x18344EC20")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> OPLMDGMKIJN<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x344EC90", Offset = "0x344D690", VA = "0x18344EC90")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> OPLMDGMKIJN<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x344E4D0", Offset = "0x344CED0", VA = "0x18344E4D0")]
	public static MJGAEDNBJIL<EBDEMPHJNGG<DDFNPDLLDDI>> DLLCMABFEJD<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<EBDEMPHJNGG<DDFNPDLLDDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x344E3F0", Offset = "0x344CDF0", VA = "0x18344E3F0")]
	public static MJGAEDNBJIL<KNKIADDLFII> CFKDGHGBGOD<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<KNKIADDLFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x344E380", Offset = "0x344CD80", VA = "0x18344E380")]
	public static MJGAEDNBJIL<KNKIADDLFII> CFKDGHGBGOD<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<KNKIADDLFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x344E460", Offset = "0x344CE60", VA = "0x18344E460")]
	public static MJGAEDNBJIL<KNKIADDLFII> CFKDGHGBGOD<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<KNKIADDLFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x344EA90", Offset = "0x344D490", VA = "0x18344EA90")]
	public static MJGAEDNBJIL<GAPKMCGHPMH> EPMOIGCEFLK<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<GAPKMCGHPMH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x344EB00", Offset = "0x344D500", VA = "0x18344EB00")]
	public static MJGAEDNBJIL<GAPKMCGHPMH> EPMOIGCEFLK<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<GAPKMCGHPMH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x344EBB0", Offset = "0x344D5B0", VA = "0x18344EBB0")]
	public static MJGAEDNBJIL<PGDNFPGMBLK> HNDFHHNHPKA<M>(this PMPIHPEBLFA<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC)
	{
		return default(MJGAEDNBJIL<PGDNFPGMBLK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JCDFFMEFJKI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21512E0", Offset = "0x214FCE0", VA = "0x1821512E0")]
	public static void EKBCCODEBCL(this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC, POJKEEADMGJ KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21513A0", Offset = "0x214FDA0", VA = "0x1821513A0")]
	public static void EKBCCODEBCL(this byte[] CNGBPDKMHBB, int LKGIJLGOFHC, POJKEEADMGJ KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2151260", Offset = "0x214FC60", VA = "0x182151260")]
	public static void EKBCCODEBCL([In] this Span<byte> CNGBPDKMHBB, int LKGIJLGOFHC, POJKEEADMGJ KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CBF0", Offset = "0x2E1B5F0", VA = "0x182E1CBF0")]
	public static void EKBCCODEBCL<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, POJKEEADMGJ KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CA50", Offset = "0x2E1B450", VA = "0x182E1CA50")]
	public static void EKBCCODEBCL<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, POJKEEADMGJ KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x214B760", Offset = "0x214A160", VA = "0x18214B760")]
	public static void IHIIKFBDGPP(this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2151490", Offset = "0x214FE90", VA = "0x182151490")]
	public static void IHIIKFBDGPP(this byte[] CNGBPDKMHBB, int LKGIJLGOFHC, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2151410", Offset = "0x214FE10", VA = "0x182151410")]
	public static void IHIIKFBDGPP([In] this Span<byte> CNGBPDKMHBB, int LKGIJLGOFHC, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CDF0", Offset = "0x2E1B7F0", VA = "0x182E1CDF0")]
	public static void IHIIKFBDGPP<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CD90", Offset = "0x2E1B790", VA = "0x182E1CD90")]
	public static void IHIIKFBDGPP<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2151580", Offset = "0x214FF80", VA = "0x182151580")]
	public static void LIJMCCFGLCP(this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC, float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CF50", Offset = "0x2E1B950", VA = "0x182E1CF50")]
	public static void LIJMCCFGLCP<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CEF0", Offset = "0x2E1B8F0", VA = "0x182E1CEF0")]
	public static void LIJMCCFGLCP<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2151510", Offset = "0x214FF10", VA = "0x182151510")]
	public static void IPMJODAMHDN(this JEJGNFFBHBC<byte> CNGBPDKMHBB, int LKGIJLGOFHC, byte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CEA0", Offset = "0x2E1B8A0", VA = "0x182E1CEA0")]
	public static void IPMJODAMHDN<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, byte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CE50", Offset = "0x2E1B850", VA = "0x182E1CE50")]
	public static void IPMJODAMHDN<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, byte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E07F10", Offset = "0x2E06910", VA = "0x182E07F10")]
	public static void KDOJLFJBMJJ<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2E07F10", Offset = "0x2E06910", VA = "0x182E07F10")]
	public static void KDOJLFJBMJJ<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E07F10", Offset = "0x2E06910", VA = "0x182E07F10")]
	public static void ECAIKBLENKC<M>(this FJAMCDMCAND<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, MJGAEDNBJIL<KNKIADDLFII> KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E07F10", Offset = "0x2E06910", VA = "0x182E07F10")]
	public static void ECAIKBLENKC<M>([In] this HPMPNGIELBH<M, byte> CNGBPDKMHBB, MJGAEDNBJIL<M> LKGIJLGOFHC, MJGAEDNBJIL<KNKIADDLFII> KLABJGGMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IAJFLJAGNIE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x214D840", Offset = "0x214C240", VA = "0x18214D840")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) GFJKFKBFMLH(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x214C950", Offset = "0x214B350", VA = "0x18214C950")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) CLMBLEHADAI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x214F9B0", Offset = "0x214E3B0", VA = "0x18214F9B0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) KILEOGIPHJB(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x214E140", Offset = "0x214CB40", VA = "0x18214E140")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HGKHFMFHBNO(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x214FE40", Offset = "0x214E840", VA = "0x18214FE40")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) MAKOMFKDHOF(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x214F5F0", Offset = "0x214DFF0", VA = "0x18214F5F0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) KFAACMAHKGE(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x214C6D0", Offset = "0x214B0D0", VA = "0x18214C6D0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) CIMNOLKHLLE(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21505A0", Offset = "0x214EFA0", VA = "0x1821505A0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) OHFKBNENPJI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x214FAD0", Offset = "0x214E4D0", VA = "0x18214FAD0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) KMMKOEGKNCD(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2150B30", Offset = "0x214F530", VA = "0x182150B30")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>) PFFGPPPKCCA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? KLABJGGMBGH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? GLGLAPBLGNN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2151020", Offset = "0x214FA20", VA = "0x182151020")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>) PNOLFKEJIAG(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? KLABJGGMBGH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? GLGLAPBLGNN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x214D610", Offset = "0x214C010", VA = "0x18214D610")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>) FLBGKNEKGPH(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? KLABJGGMBGH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? GLGLAPBLGNN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x214FBF0", Offset = "0x214E5F0", VA = "0x18214FBF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>) LKFALFJJHFB(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? KLABJGGMBGH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? GLGLAPBLGNN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21506F0", Offset = "0x214F0F0", VA = "0x1821506F0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<GAPKMCGHPMH>>) PAGOIEDDHMH(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? NEAOMGLFLHO, [Optional] MJGAEDNBJIL<GAPKMCGHPMH>? OADEFMMDNAN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<GAPKMCGHPMH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x214F0F0", Offset = "0x214DAF0", VA = "0x18214F0F0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<GAPKMCGHPMH>>>) JIEAIHLHJGP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? NEAOMGLFLHO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<GAPKMCGHPMH>>? OADEFMMDNAN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<GAPKMCGHPMH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x214EB80", Offset = "0x214D580", VA = "0x18214EB80")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<KNKIADDLFII>>) IKHKHGBOLJG(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? NEAOMGLFLHO, [Optional] MJGAEDNBJIL<KNKIADDLFII>? OADEFMMDNAN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<KNKIADDLFII>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x214E700", Offset = "0x214D100", VA = "0x18214E700")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<KNKIADDLFII>>>) HKFKKIHIBHA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? NEAOMGLFLHO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<KNKIADDLFII>>? OADEFMMDNAN)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<KNKIADDLFII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDE30", Offset = "0x2DEC830", VA = "0x182DEDE30")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>) NBHPKGDFIJL<TMarker>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<PGDNFPGMBLK>? OADEFMMDNAN, [Optional][In] ReadOnlySpan<byte> JGCMECODHDI)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x214E960", Offset = "0x214D360", VA = "0x18214E960")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HOOGOPENJGA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int NEDJODMJOFF, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? OHIICHJPFBL)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x214F200", Offset = "0x214DC00", VA = "0x18214F200")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) JMLBJNFMGEK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NEDJODMJOFF, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? OHIICHJPFBL)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDAF0", Offset = "0x2DEC4F0", VA = "0x182DEDAF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>) CNJIFKMGCML<TMarker>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<TMarker>>? OHIICHJPFBL, [Optional] int? BHEAFIOEIAD, [Optional][In] ReadOnlySpan<byte> NEDJODMJOFF)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDCE0", Offset = "0x2DEC6E0", VA = "0x182DEDCE0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>) MEBHCOPMNNF<TMarker>(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<TMarker>>? NEDJODMJOFF, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<TMarker>>? OHIICHJPFBL, [Optional] int? BHEAFIOEIAD)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<TMarker>>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x21509B0", Offset = "0x214F3B0", VA = "0x1821509B0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) PBNGJDEAKFL(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x214F860", Offset = "0x214E260", VA = "0x18214F860")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) KHMKHAMCJJH(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2150350", Offset = "0x214ED50", VA = "0x182150350")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) NPEBBJAGMIB(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x214BB90", Offset = "0x214A590", VA = "0x18214BB90")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) AHGIKKKDKMF(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x214CEA0", Offset = "0x214B8A0", VA = "0x18214CEA0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) DNIDIMOJJIA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x214C020", Offset = "0x214AA20", VA = "0x18214C020")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) BGAMODIFMPJ(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x214C2A0", Offset = "0x214ACA0", VA = "0x18214C2A0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) BPOCOFFAMHP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x214D2A0", Offset = "0x214BCA0", VA = "0x18214D2A0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) FBAMKKAPBDL(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x214D9C0", Offset = "0x214C3C0", VA = "0x18214D9C0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) GGPEDNFOOBC(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x214EA90", Offset = "0x214D490", VA = "0x18214EA90")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>) ICNHGCDHKBI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? GNLCKEGIGIB)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x214E2A0", Offset = "0x214CCA0", VA = "0x18214E2A0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HHLPGANEPMB(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2150EC0", Offset = "0x214F8C0", VA = "0x182150EC0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) PKKGLANNNPP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2150470", Offset = "0x214EE70", VA = "0x182150470")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) OEDKEDJLFFC(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x214BE40", Offset = "0x214A840", VA = "0x18214BE40")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) AKHDGLEGGGL(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x214FF90", Offset = "0x214E990", VA = "0x18214FF90")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) MCPJOCKEFDJ(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21500E0", Offset = "0x214EAE0", VA = "0x1821500E0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) MOGOBKAKCMN(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x214F470", Offset = "0x214DE70", VA = "0x18214F470")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) KAAFPIJONJI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x214DE90", Offset = "0x214C890", VA = "0x18214DE90")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HFDEGCONBMI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x214DAE0", Offset = "0x214C4E0", VA = "0x18214DAE0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) GJEOGDFFJNC(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x214ED20", Offset = "0x214D720", VA = "0x18214ED20")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) IPJFFADCNGD(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2150200", Offset = "0x214EC00", VA = "0x182150200")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) NMJJDAEIBHI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x214DD70", Offset = "0x214C770", VA = "0x18214DD70")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HCAFNDAINMI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x214CFF0", Offset = "0x214B9F0", VA = "0x18214CFF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) EKEDMKJJJHC(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x214CAA0", Offset = "0x214B4A0", VA = "0x18214CAA0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) COFNBNNICKE(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x214D170", Offset = "0x214BB70", VA = "0x18214D170")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) EMCOMIHBDCN(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x214C140", Offset = "0x214AB40", VA = "0x18214C140")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) BOEMHLKFBOK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x214BCF0", Offset = "0x214A6F0", VA = "0x18214BCF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) AIENNKDNIJK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x214D720", Offset = "0x214C120", VA = "0x18214D720")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) FPILLMKOHID(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x214E420", Offset = "0x214CE20", VA = "0x18214E420")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HIOHMBMDBGK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x214B8E0", Offset = "0x214A2E0", VA = "0x18214B8E0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) ADMJMHIINAK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x214FD10", Offset = "0x214E710", VA = "0x18214FD10")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) LLKILJHOOOO(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x214E5A0", Offset = "0x214CFA0", VA = "0x18214E5A0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HJLENCHEGFC(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x214DFF0", Offset = "0x214C9F0", VA = "0x18214DFF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HFNHBIMGOFK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2150890", Offset = "0x214F290", VA = "0x182150890")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) PBGNAJMDHHE(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x214C550", Offset = "0x214AF50", VA = "0x18214C550")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) CIKAGGHKPIP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x214BA40", Offset = "0x214A440", VA = "0x18214BA40")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) AGDIMBLGPJF(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x214CD80", Offset = "0x214B780", VA = "0x18214CD80")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) DMHKLJDFOOJ(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2150D60", Offset = "0x214F760", VA = "0x182150D60")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) PICNDEPMCOI(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x214E810", Offset = "0x214D210", VA = "0x18214E810")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) HLCCGAGEBDP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x214EE80", Offset = "0x214D880", VA = "0x18214EE80")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) JCGNHNIINPP(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x214D500", Offset = "0x214BF00", VA = "0x18214D500")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) FIMEJFILBMH(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] int? CKLNAPFFIEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x214D3F0", Offset = "0x214BDF0", VA = "0x18214D3F0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) FGBBDFOCBKB(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? CKLNAPFFIEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x214BFA0", Offset = "0x214A9A0", VA = "0x18214BFA0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> APFEAPAJCCH(this JEJGNFFBHBC<byte> BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x214CC00", Offset = "0x214B600", VA = "0x18214CC00")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) DLLDKLMDAGG(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x214F710", Offset = "0x214E110", VA = "0x18214F710")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) KGDNPNLHNED(this JEJGNFFBHBC<byte> BJNJBGHPMEH, float APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<ADHNIDPBJCB>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2150C40", Offset = "0x214F640", VA = "0x182150C40")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>) PHCPLAGMPNK(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<ADHNIDPBJCB>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<ADHNIDPBJCB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x214F310", Offset = "0x214DD10", VA = "0x18214F310")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) JOHIGIGPDMA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x214C400", Offset = "0x214AE00", VA = "0x18214C400")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) CGBCEMAIPJO(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x214C830", Offset = "0x214B230", VA = "0x18214C830")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) CKOOMIHMKLA(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x214DC10", Offset = "0x214C610", VA = "0x18214DC10")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) GNJOADKLFDD(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x214EFA0", Offset = "0x214D9A0", VA = "0x18214EFA0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) JGFNMMEJGFF(this JEJGNFFBHBC<byte> BJNJBGHPMEH, int APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2151140", Offset = "0x214FB40", VA = "0x182151140")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>) PPIEOLJGIAL(this JEJGNFFBHBC<byte> BJNJBGHPMEH, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? APHLHEGNKOO, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? NALJIKBHJBG, [Optional] MJGAEDNBJIL<EBDEMPHJNGG<AIKPPCNEKMJ>>? ICFMFKADHLG)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<AIKPPCNEKMJ>>>));
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
