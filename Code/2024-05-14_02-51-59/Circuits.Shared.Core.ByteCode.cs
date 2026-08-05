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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E71460", Offset = "0x1E6FE60", VA = "0x181E71460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NHNLBFINICC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static BOLDNJBHEHG<KLDFNFODCNL<M>> IGBLIGHIIFK<M>(this int CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E71430", Offset = "0x1E6FE30", VA = "0x181E71430")]
	public static BOLDNJBHEHG<DFPGDNDPJDA> PPJMAFGBKPF(this int CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<DFPGDNDPJDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static BOLDNJBHEHG<FNGLKGIAICN<M>> OELAOHHJNOM<M>(this int CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<FNGLKGIAICN<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class KLDFNFODCNL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FPMCAFHPOIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CBOOHJGNMNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DFPGDNDPJDA
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NFHJAAFJMDN
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HMHHLHGGFAH
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ENOMIHDECGB
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
public static class APIEPLGKGKN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KPOKGLJLHMO<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr IGFGDBIIGID;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
		public KPOKGLJLHMO(IntPtr KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B350", Offset = "0x3D99D50", VA = "0x183D9B350")]
		public int BCLHLDBBMGO(TDeps COBDDACEALE, TContext GGMIPCKCOKA, TCompileState AEAPHAKOFMN, [In] IBNIMOLHAKB<byte> MILOALEHGKJ, int PCPGCFPIINO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F7ABE0", Offset = "0x2F795E0", VA = "0x182F7ABE0")]
	public static void KHBOAPMGDAM<TDeps, TContext, TCompileState>(TDeps COBDDACEALE, TContext GGMIPCKCOKA, TCompileState AEAPHAKOFMN, [In] IBNIMOLHAKB<byte> BLFAKKEMPNO, IBNIMOLHAKB<byte> DBHMLANLLCK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? MEPHJPIBMJH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PLBHCBNDMPE, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HBDJHNHDBCO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CDMHJNPLHII, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ILMLMMEIIAP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ALCHBPACNMD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JFMDDDENFFK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? MIGOHLDNAKD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? EAPGBCMNHHI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CCBMGEPJEHJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BFLEBCLKBLC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? DAMIBDLDDNB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JEDNDNFKEOD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? DAFFCKPEBFD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FDKGDLAOLIK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NCCMAIACLII, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IAOLAKBONJG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PKLAGINPENB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OPFLGNMLINP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? EBOMKPNJIND, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LPJHBCGDAAF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LPADAJJEDEC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IOLHJCHODKM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OPGKNEMMHNA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OCMKNBAAFPD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? EEAOCJNBJFJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CGOHFIDNCCA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JOHBGPABOMC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? DAEBKPMAGLB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JBFDCONMOFF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JABNANJEJCI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BIAKIHINBOC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GNILEJKJMKD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GBCJMPLEHHM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AFABFMPPHPC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IAAAHFKMINA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? MHCFEKJCOCI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NMNFLKADEDC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? EHKGFEKFOBL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IOKHPHJGHDJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CJPBBAKPLJN, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ADLBGAFDFCP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PHBIEKAAFPH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NJJCJJECDHA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HBIDHFNBDPM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GLLNDGLHGHJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JKJDHLAHLCG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AKEOBPDKLLC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? KNBDKECDNJC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PDJEHNDEDFH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BKJLOAOCDIG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GGBPNHFACNM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CDDMBONCDDL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FGFDGJNPBOB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IEHJOIFKKJB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CMKGPMMEOJA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IEGHCBIGDLM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JPGIBNIMPBF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AJLKNLMHPAG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NGKCDHCODLH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GHEMJDADAOF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BOFLDGOPLPP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ALMJCGELNPJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GHGDHIHDGNF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? MHJIFLALDKB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GKGMIIDOHOL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PPNABFPIAJH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? DNLNFGIGJIE, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PNDENEONJOB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PHFIFHIKHHN, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PEAKMMLPOOO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AGCMFBCODEO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OBFPOBLHLJN, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LDPCBEJGFCO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LBODHNDOKDH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NAKFCGOEJFB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FGKKEEHFEBA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FOPMLJLOLJO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HEKHPDBFPFJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GDFFOMKHABB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PHOIMNOGEBK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AAMCCDEILFF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LHKDOKMINGC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LNODAEMEAJE, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LFDFFOMJCMH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? KGCJBCCLOPG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FMKIDPNEEKA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? DDAICLFJJAL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ANCGFDBPOHL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LNMBLLPMFFL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NAOELLPKBFB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? AMPBMMAFADM, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BDKDCILLOPH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? KFFKGOFFHMF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CNNHPIPJGMA, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LDOAAJCGFDH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FGDMKCFNIMF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OBAOOGAACHO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PKNGNJGEPMC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? NAOLNPLHKOP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GDCHOHJBLED, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? KBPHINGPLHH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FJBBHBNDGOB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PJEAGHAAGDI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JAKMNFEALLP, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IFIEHLFEPCK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? FKGKEOEHHMK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JNOJDOJFELL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? APBOJDNCMFB, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OGPGLJNOPLK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JONBKPNINKI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HNLBIEBHHDF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JHPDIPENLNJ, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LPBMEKNOBGK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? ILABGCEBNHL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OFDEEDCBHGF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GJOKKAFEOCE, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HNGPEENPJMG, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CEPMCNLDLOF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BMMDGBMOIOD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PBBBIAFCJMD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? GHMMNBJEEMI, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JCGDOOHBIID, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? HLKHIANDPNC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? IDMILHOPFOD, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LBDCPGCOMEC, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? LDKDBGCGFJF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OMJMGBBEMAH, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? CECBDIMHIPF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? JAHAGCADBNL, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? PCNMHONOIHN, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? OOIPJFIODBK, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? EPPKNHACBOF, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BEILNANMLPO, [Optional] KPOKGLJLHMO<TContext, TDeps, TCompileState>? BGOHAGOAPEA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E6AF90", Offset = "0x1E69990", VA = "0x181E6AF90")]
	private static int GHEONKEHPAJ([In] IBNIMOLHAKB<byte> FMPPIMHNCEG, IBNIMOLHAKB<byte> MGANAFDPCCF, int HDAPKPHIPPD, int GBACAOOHJGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BBHGHKMEFNK
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int MODBFAMIOBN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2714E40", Offset = "0x2713840", VA = "0x182714E40")]
	public static BOLDNJBHEHG<KLDFNFODCNL<T>> BFMDJIBFCJK<T>([In] this IBNIMOLHAKB<byte> CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2714F60", Offset = "0x2713960", VA = "0x182714F60")]
	public static BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<T>>> PDFNPKCONPF<T>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<KLDFNFODCNL<T>>? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B1D0", Offset = "0x1E69BD0", VA = "0x181E6B1D0")]
	public static BOLDNJBHEHG<KLDFNFODCNL<HPGMCAHGHJC>> CGGJKCJCKBL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<HPGMCAHGHJC>? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<HPGMCAHGHJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B030", Offset = "0x1E69A30", VA = "0x181E6B030")]
	public static BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>> AKDDJIOFLPD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] float? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B460", Offset = "0x1E69E60", VA = "0x181E6B460")]
	public static BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>> JMCHOPDDLND(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B100", Offset = "0x1E69B00", VA = "0x181E6B100")]
	public static BOLDNJBHEHG<KLDFNFODCNL<KCBNNNDJNPN>> APDMEJDODIA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<KCBNNNDJNPN>? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<KCBNNNDJNPN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B2A0", Offset = "0x1E69CA0", VA = "0x181E6B2A0")]
	public static BOLDNJBHEHG<KLDFNFODCNL<HMHHLHGGFAH>> IENGKOFMAND(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] byte? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<HMHHLHGGFAH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B530", Offset = "0x1E69F30", VA = "0x181E6B530")]
	public static BOLDNJBHEHG<KLDFNFODCNL<DFPGDNDPJDA>> KFPNGIDLOJE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<DFPGDNDPJDA>? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<DFPGDNDPJDA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B390", Offset = "0x1E69D90", VA = "0x181E6B390")]
	public static BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>> IPPCLFJNOLH(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] ENOMIHDECGB? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2714E90", Offset = "0x2713890", VA = "0x182714E90")]
	public static BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<T>>> KAGDDNBELMM<T>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<T>>? AEJBOLFACJC)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E6ADE0", Offset = "0x1E697E0", VA = "0x181E6ADE0")]
	public static void HMPJHPEBNMK(this IBNIMOLHAKB<byte> CMJEIEIDHIK, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>> KMEBEBONOPD, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2714F50", Offset = "0x2713950", VA = "0x182714F50")]
	public static void MEPBNKEKKPA<T>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<T>>> PCPGCFPIINO, BOLDNJBHEHG<KLDFNFODCNL<T>> AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2714F50", Offset = "0x2713950", VA = "0x182714F50")]
	public static void LBPOGCLDBPN<T>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<T>>> IKOMNONBBCB, BOLDNJBHEHG<FNGLKGIAICN<T>> AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGLLINPHIDD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E71320", Offset = "0x1E6FD20", VA = "0x181E71320")]
	public static DMEJEMLFNMI HEOKMHINIPH([In] this ReadOnlySpan<byte> OIKPPLLAJOB, int ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E71390", Offset = "0x1E6FD90", VA = "0x181E71390")]
	public static DMEJEMLFNMI HEOKMHINIPH([In] this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x29E6CB0", Offset = "0x29E56B0", VA = "0x1829E6CB0")]
	public static DMEJEMLFNMI HEOKMHINIPH<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x29E6BA0", Offset = "0x29E55A0", VA = "0x1829E6BA0")]
	public static DMEJEMLFNMI HEOKMHINIPH<M>([In] this EFPKHBKENJL<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29E6940", Offset = "0x29E5340", VA = "0x1829E6940")]
	public static DMEJEMLFNMI HEOKMHINIPH<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29E6990", Offset = "0x29E5390", VA = "0x1829E6990")]
	public static DMEJEMLFNMI HEOKMHINIPH<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29E6DC0", Offset = "0x29E57C0", VA = "0x1829E6DC0")]
	public static DMEJEMLFNMI HEOKMHINIPH<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E71320", Offset = "0x1E6FD20", VA = "0x181E71320")]
	public static int HOCGJKLPGOD([In] this ReadOnlySpan<byte> OIKPPLLAJOB, int ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E6AF80", Offset = "0x1E69980", VA = "0x181E6AF80")]
	public static int HOCGJKLPGOD([In] this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static int HOCGJKLPGOD<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static int HOCGJKLPGOD<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static int HOCGJKLPGOD<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static int HOCGJKLPGOD<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29E6E30", Offset = "0x29E5830", VA = "0x1829E6E30")]
	public static float IIDDGIDBGBH<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29E6E30", Offset = "0x29E5830", VA = "0x1829E6E30")]
	public static float IIDDGIDBGBH<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29E6E30", Offset = "0x29E5830", VA = "0x1829E6E30")]
	public static float IIDDGIDBGBH<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29E6910", Offset = "0x29E5310", VA = "0x1829E6910")]
	public static byte AEOGNPBBMLA<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x29E6A60", Offset = "0x29E5460", VA = "0x1829E6A60")]
	public static byte AEOGNPBBMLA<M>([In] this EFPKHBKENJL<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29E6940", Offset = "0x29E5340", VA = "0x1829E6940")]
	public static byte AEOGNPBBMLA<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29E6990", Offset = "0x29E5390", VA = "0x1829E6990")]
	public static byte AEOGNPBBMLA<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29E69F0", Offset = "0x29E53F0", VA = "0x1829E69F0")]
	public static byte AEOGNPBBMLA<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6AF80", Offset = "0x1E69980", VA = "0x181E6AF80")]
	public static ENOMIHDECGB DEBJIAAPJNF([In] this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA)
	{
		return default(ENOMIHDECGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static ENOMIHDECGB DEBJIAAPJNF<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(ENOMIHDECGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29E7030", Offset = "0x29E5A30", VA = "0x1829E7030")]
	public static BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>> LLIOPPAPPFD<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29E7090", Offset = "0x29E5A90", VA = "0x1829E7090")]
	public static BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>> LLIOPPAPPFD<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29E6FD0", Offset = "0x29E59D0", VA = "0x1829E6FD0")]
	public static BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>> LLIOPPAPPFD<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29E6E50", Offset = "0x29E5850", VA = "0x1829E6E50")]
	public static BOLDNJBHEHG<FNGLKGIAICN<OPILKJKFJBH>> JLHLLODLGJF<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<FNGLKGIAICN<OPILKJKFJBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29E6A80", Offset = "0x29E5480", VA = "0x1829E6A80")]
	public static BOLDNJBHEHG<DFPGDNDPJDA> HDOCLLCIOCG<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<DFPGDNDPJDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29E6AE0", Offset = "0x29E54E0", VA = "0x1829E6AE0")]
	public static BOLDNJBHEHG<DFPGDNDPJDA> HDOCLLCIOCG<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<DFPGDNDPJDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29E6B40", Offset = "0x29E5540", VA = "0x1829E6B40")]
	public static BOLDNJBHEHG<DFPGDNDPJDA> HDOCLLCIOCG<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<DFPGDNDPJDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29E6F10", Offset = "0x29E5910", VA = "0x1829E6F10")]
	public static BOLDNJBHEHG<HPGMCAHGHJC> LJDKNOADNFO<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<HPGMCAHGHJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29E6F70", Offset = "0x29E5970", VA = "0x1829E6F70")]
	public static BOLDNJBHEHG<HPGMCAHGHJC> LJDKNOADNFO<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<HPGMCAHGHJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29E6EB0", Offset = "0x29E58B0", VA = "0x1829E6EB0")]
	public static BOLDNJBHEHG<KCBNNNDJNPN> LEMHMHODGLB<M>(this BEDLNHHKGNB<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA)
	{
		return default(BOLDNJBHEHG<KCBNNNDJNPN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BLHJBAMICIK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B7F0", Offset = "0x1E6A1F0", VA = "0x181E6B7F0")]
	public static void MDFLKBMKIBC(this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA, DMEJEMLFNMI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B930", Offset = "0x1E6A330", VA = "0x181E6B930")]
	public static void MDFLKBMKIBC(this byte[] OIKPPLLAJOB, int ACDAPODGMCA, DMEJEMLFNMI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B8B0", Offset = "0x1E6A2B0", VA = "0x181E6B8B0")]
	public static void MDFLKBMKIBC([In] this Span<byte> OIKPPLLAJOB, int ACDAPODGMCA, DMEJEMLFNMI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x271D550", Offset = "0x271BF50", VA = "0x18271D550")]
	public static void MDFLKBMKIBC<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, DMEJEMLFNMI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x271D640", Offset = "0x271C040", VA = "0x18271D640")]
	public static void MDFLKBMKIBC<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, DMEJEMLFNMI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E6ADE0", Offset = "0x1E697E0", VA = "0x181E6ADE0")]
	public static void HMPJHPEBNMK(this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B6F0", Offset = "0x1E6A0F0", VA = "0x181E6B6F0")]
	public static void HMPJHPEBNMK(this byte[] OIKPPLLAJOB, int ACDAPODGMCA, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B770", Offset = "0x1E6A170", VA = "0x181E6B770")]
	public static void HMPJHPEBNMK([In] this Span<byte> OIKPPLLAJOB, int ACDAPODGMCA, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x271D500", Offset = "0x271BF00", VA = "0x18271D500")]
	public static void HMPJHPEBNMK<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x271D4B0", Offset = "0x271BEB0", VA = "0x18271D4B0")]
	public static void HMPJHPEBNMK<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B6B0", Offset = "0x1E6A0B0", VA = "0x181E6B6B0")]
	public static void CPDHDCBDEOI(this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA, float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x271D410", Offset = "0x271BE10", VA = "0x18271D410")]
	public static void CPDHDCBDEOI<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x271D460", Offset = "0x271BE60", VA = "0x18271D460")]
	public static void CPDHDCBDEOI<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B640", Offset = "0x1E6A040", VA = "0x181E6B640")]
	public static void BGEGABOAOGO(this IBNIMOLHAKB<byte> OIKPPLLAJOB, int ACDAPODGMCA, byte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x271D3E0", Offset = "0x271BDE0", VA = "0x18271D3E0")]
	public static void BGEGABOAOGO<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, byte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x271D3B0", Offset = "0x271BDB0", VA = "0x18271D3B0")]
	public static void BGEGABOAOGO<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, byte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x271D730", Offset = "0x271C130", VA = "0x18271D730")]
	public static void MEPBNKEKKPA<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>> AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x271D730", Offset = "0x271C130", VA = "0x18271D730")]
	public static void MEPBNKEKKPA<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, BOLDNJBHEHG<KLDFNFODCNL<OPILKJKFJBH>> AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x271D730", Offset = "0x271C130", VA = "0x18271D730")]
	public static void OPIBEDENFMD<M>(this OKKMLGACIBJ<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, BOLDNJBHEHG<DFPGDNDPJDA> AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x271D730", Offset = "0x271C130", VA = "0x18271D730")]
	public static void OPIBEDENFMD<M>([In] this OCLDDFNNJNP<M, byte> OIKPPLLAJOB, BOLDNJBHEHG<M> ACDAPODGMCA, BOLDNJBHEHG<DFPGDNDPJDA> AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CFJKEAMJALC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F7A0", Offset = "0x1E6E1A0", VA = "0x181E6F7A0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) KNOKOIHAGGM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EED0", Offset = "0x1E6D8D0", VA = "0x181E6EED0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) JKOBCHAGILD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E6BD60", Offset = "0x1E6A760", VA = "0x181E6BD60")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) ANJNPGFLELA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E70A10", Offset = "0x1E6F410", VA = "0x181E70A10")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) OELLFHDGGPH(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D590", Offset = "0x1E6BF90", VA = "0x181E6D590")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) FCCMBBFKKCF(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D360", Offset = "0x1E6BD60", VA = "0x181E6D360")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) EJBLLLKBFIG(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D0E0", Offset = "0x1E6BAE0", VA = "0x181E6D0E0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) DPAOBLPPNBJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F920", Offset = "0x1E6E320", VA = "0x181E6F920")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) LFIHOFECNNI(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E70770", Offset = "0x1E6F170", VA = "0x181E70770")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) NJMADDNOCJE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C4F0", Offset = "0x1E6AEF0", VA = "0x181E6C4F0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>) BOKMOBNPPIE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? AEJBOLFACJC, [Optional] BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>? OAOMAPJNBGJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E990", Offset = "0x1E6D390", VA = "0x181E6E990")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>) IBOIJNHFGGG(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AEJBOLFACJC, [Optional] BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>? OAOMAPJNBGJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D480", Offset = "0x1E6BE80", VA = "0x181E6D480")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>) EKMBJBDEEEN(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? AEJBOLFACJC, [Optional] BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>? OAOMAPJNBGJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F60", Offset = "0x1E6F960", VA = "0x181E70F60")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>) PCGEONECJOL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AEJBOLFACJC, [Optional] BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>? OAOMAPJNBGJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FE70", Offset = "0x1E6E870", VA = "0x181E6FE70")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<HPGMCAHGHJC>>) MDDJMPNHPEA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? FALHAADBMOB, [Optional] BOLDNJBHEHG<HPGMCAHGHJC>? KNCKABMPAIJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<HPGMCAHGHJC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DA30", Offset = "0x1E6C430", VA = "0x181E6DA30")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<HPGMCAHGHJC>>>) GADNOLMHEAF(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? FALHAADBMOB, [Optional] BOLDNJBHEHG<FNGLKGIAICN<HPGMCAHGHJC>>? KNCKABMPAIJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<HPGMCAHGHJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F600", Offset = "0x1E6E000", VA = "0x181E6F600")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<DFPGDNDPJDA>>) KFKEHKMMICN(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? FALHAADBMOB, [Optional] BOLDNJBHEHG<DFPGDNDPJDA>? KNCKABMPAIJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<DFPGDNDPJDA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F170", Offset = "0x1E6DB70", VA = "0x181E6F170")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<DFPGDNDPJDA>>>) JPJCOGECNOD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? FALHAADBMOB, [Optional] BOLDNJBHEHG<FNGLKGIAICN<DFPGDNDPJDA>>? KNCKABMPAIJ)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<DFPGDNDPJDA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2796830", Offset = "0x2795230", VA = "0x182796830")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<KCBNNNDJNPN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<TMarker>>) KMKAIKPKGKN<TMarker>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<KCBNNNDJNPN>? KNCKABMPAIJ, [Optional][In] ReadOnlySpan<byte> ABDLEBPKDKC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<KCBNNNDJNPN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DF40", Offset = "0x1E6C940", VA = "0x181E6DF40")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) GLJJOODIFIP(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int FMPPIMHNCEG, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? MGANAFDPCCF)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EBE0", Offset = "0x1E6D5E0", VA = "0x181E6EBE0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) IOOCKIFJDLM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? FMPPIMHNCEG, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? MGANAFDPCCF)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2796B40", Offset = "0x2795540", VA = "0x182796B40")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<TMarker>>) NHEEAGDAMJO<TMarker>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<TMarker>>? MGANAFDPCCF, [Optional] int? CBAOPDHODHO, [Optional][In] ReadOnlySpan<byte> FMPPIMHNCEG)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2796A20", Offset = "0x2795420", VA = "0x182796A20")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>) KPDBDCMMMBE<TMarker>(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<TMarker>>? FMPPIMHNCEG, [Optional] BOLDNJBHEHG<FNGLKGIAICN<TMarker>>? MGANAFDPCCF, [Optional] int? CBAOPDHODHO)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<TMarker>>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E6CF60", Offset = "0x1E6B960", VA = "0x181E6CF60")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) DMOLPEOEPAE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E70CF0", Offset = "0x1E6F6F0", VA = "0x181E70CF0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) ONBCBNCHCDB(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D910", Offset = "0x1E6C310", VA = "0x181E6D910")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) FPLIKMKHJNF(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E580", Offset = "0x1E6CF80", VA = "0x181E6E580")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HKCKKGDMKJA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C600", Offset = "0x1E6B000", VA = "0x181E6C600")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CAIGCCMGMEO(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F4E0", Offset = "0x1E6DEE0", VA = "0x181E6F4E0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) KEFLIEJMLGD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E6ED70", Offset = "0x1E6D770", VA = "0x181E6ED70")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) JGBEICLGNEC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6CE10", Offset = "0x1E6B810", VA = "0x181E6CE10")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) DEMGBDCBOHJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FD50", Offset = "0x1E6E750", VA = "0x181E6FD50")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) LMKACNDFFPE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E70010", Offset = "0x1E6EA10", VA = "0x181E70010")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>) MDEPNKKDJDI(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>? INLPFKPLBAH)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<KLDFNFODCNL<NFHJAAFJMDN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DB40", Offset = "0x1E6C540", VA = "0x181E6DB40")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) GFMAOMMJFNJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E6E0", Offset = "0x1E6D0E0", VA = "0x181E6E6E0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HPCAEHFCIPH(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E190", Offset = "0x1E6CB90", VA = "0x181E6E190")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HCPICANDGGD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E2C0", Offset = "0x1E6CCC0", VA = "0x181E6E2C0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HFDBNHIJIKB(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E71080", Offset = "0x1E6FA80", VA = "0x181E71080")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) PFFDEIIPJMA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1E704F0", Offset = "0x1E6EEF0", VA = "0x181E704F0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) NGELJJBOHJL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C750", Offset = "0x1E6B150", VA = "0x181E6C750")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CBKBCEKEOCC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E6CCB0", Offset = "0x1E6B6B0", VA = "0x181E6CCB0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CLIPJNEKCHC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C3C0", Offset = "0x1E6ADC0", VA = "0x181E6C3C0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) BIFIIKPGPIO(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E6CB50", Offset = "0x1E6B550", VA = "0x181E6CB50")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CICIDFLGEBG(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DCC0", Offset = "0x1E6C6C0", VA = "0x181E6DCC0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) GGOEOPKCPEI(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6CA30", Offset = "0x1E6B430", VA = "0x181E6CA30")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CGHELEIIEFC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FBD0", Offset = "0x1E6E5D0", VA = "0x181E6FBD0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) LLLEEDICCOM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C100", Offset = "0x1E6AB00", VA = "0x181E6C100")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) BELHGFBDGGD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DE10", Offset = "0x1E6C810", VA = "0x181E6DE10")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) GLCJIOJPNFC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E420", Offset = "0x1E6CE20", VA = "0x181E6E420")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HIINLJNPMDL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E840", Offset = "0x1E6D240", VA = "0x181E6E840")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) HPCHGAILGFE(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E70E40", Offset = "0x1E6F840", VA = "0x181E70E40")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) OOEEKFGOIGC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E70890", Offset = "0x1E6F290", VA = "0x181E70890")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) OAIKGKAOKOH(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FA70", Offset = "0x1E6E470", VA = "0x181E6FA70")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) LFLGBBFBFFF(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EAB0", Offset = "0x1E6D4B0", VA = "0x181E6EAB0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) IGPMMBMPCNJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C8D0", Offset = "0x1E6B2D0", VA = "0x181E6C8D0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) CCOEBKCDAMH(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B9A0", Offset = "0x1E6A3A0", VA = "0x181E6B9A0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) AAEPEPMHKCM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1E70100", Offset = "0x1E6EB00", VA = "0x181E70100")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) MGANFHBPLNC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1E70B70", Offset = "0x1E6F570", VA = "0x181E70B70")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) OIMBNBBEAID(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F020", Offset = "0x1E6DA20", VA = "0x181E6F020")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) JODCJKAHJHJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1E6BE80", Offset = "0x1E6A880", VA = "0x181E6BE80")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) BDEGOHMPHKI(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6BFA0", Offset = "0x1E6A9A0", VA = "0x181E6BFA0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) BDOKBJIGGOA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F390", Offset = "0x1E6DD90", VA = "0x181E6F390")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) KEAIAGOBDOJ(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D6E0", Offset = "0x1E6C0E0", VA = "0x181E6D6E0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) FDHBJENDJFA(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D800", Offset = "0x1E6C200", VA = "0x181E6D800")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) FPIBPHEMEGL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] int? NFFBLFFFPFB, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1E6F280", Offset = "0x1E6DC80", VA = "0x181E6F280")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) KAAPJNDKCEC(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? NFFBLFFFPFB, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6ECF0", Offset = "0x1E6D6F0", VA = "0x181E6ECF0")]
	public static BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>> JFOGIFJGEOA(this IBNIMOLHAKB<byte> CMJEIEIDHIK)
	{
		return default(BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1E70370", Offset = "0x1E6ED70", VA = "0x181E70370")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) NAGOLICOCDD(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, float AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1E6BAF0", Offset = "0x1E6A4F0", VA = "0x181E6BAF0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) ACBNMFJENFM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, float AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FPMCAFHPOIE>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D240", Offset = "0x1E6BC40", VA = "0x181E6D240")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>) EDPCLPFJFLK(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<FPMCAFHPOIE>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<FPMCAFHPOIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C260", Offset = "0x1E6AC60", VA = "0x181E6C260")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) BGMKPLKKPJN(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E711D0", Offset = "0x1E6FBD0", VA = "0x181E711D0")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) PGHJKPGFPDF(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E070", Offset = "0x1E6CA70", VA = "0x181E6E070")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) GLPJENFFCEO(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E70610", Offset = "0x1E6F010", VA = "0x181E70610")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) NHJNLKGIICN(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, int AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E70220", Offset = "0x1E6EC20", VA = "0x181E70220")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) MOOOMBKEJIM(this IBNIMOLHAKB<byte> CMJEIEIDHIK, int AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<CBOOHJGNMNP>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1E6BC40", Offset = "0x1E6A640", VA = "0x181E6BC40")]
	public static (BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>) ADGELLFGNNL(this IBNIMOLHAKB<byte> CMJEIEIDHIK, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AAHPHNGALGH, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? AMEMFLECAAM, [Optional] BOLDNJBHEHG<FNGLKGIAICN<CBOOHJGNMNP>>? DNEEAABOBBC)
	{
		return default((BOLDNJBHEHG<KLDFNFODCNL<NFHJAAFJMDN>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>, BOLDNJBHEHG<KLDFNFODCNL<FNGLKGIAICN<CBOOHJGNMNP>>>));
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
