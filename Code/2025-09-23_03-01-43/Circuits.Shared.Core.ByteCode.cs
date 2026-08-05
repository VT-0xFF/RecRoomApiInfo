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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B4FA20", Offset = "0x2B4E020", VA = "0x182B4FA20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ACGBOPDACMA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8740", VA = "0x1832DA140")]
	public static AIOJMGEOJFK<FKJOADIJDOP<M>> JFLEGIHMEOJ<M>(this int JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B49B60", Offset = "0x2B48160", VA = "0x182B49B60")]
	public static AIOJMGEOJFK<KGHGPEMKPNJ> CGOFLHJNKMA(this int JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<KGHGPEMKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8740", VA = "0x1832DA140")]
	public static AIOJMGEOJFK<MAFIFIMAKDP<M>> MDEJNECOGJA<M>(this int JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<MAFIFIMAKDP<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FKJOADIJDOP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NJLLOOFODAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AIGEEEJNNHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KGHGPEMKPNJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EMNGKOKIKPO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CMOBIOFNAMG
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OICFEJNKKGH
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
public static class MJILINIGIDN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct BHMHNABJMDK<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr PIEDHHGPLJC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
		public BHMHNABJMDK(IntPtr MFNKIFOCMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF55A0", Offset = "0x6AF3BA0", VA = "0x186AF55A0")]
		public int MJPLNPACNDN(TDeps NBGHBGMICNM, TContext BJEFEGNHMAK, TCompileState DJKECHGAGHM, [In] NHNLFJGMEDN<byte> CBJOCOBKFIE, int LGDFEKPBPCJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5190", Offset = "0x3ED3790", VA = "0x183ED5190")]
	public static void FBCJOJFOAFN<TDeps, TContext, TCompileState>(TDeps NBGHBGMICNM, TContext BJEFEGNHMAK, TCompileState DJKECHGAGHM, [In] NHNLFJGMEDN<byte> NMGJPAOCBGD, NHNLFJGMEDN<byte> KBCBODNMJFN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LPHMIKPCOJI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JEEFNLCGICM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JKOGHBGGPJM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DHCHPHKKLFG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DPIKJEIIIIH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GLEIBGBABBH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GOGJGFLFAHL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JCLFJDAPADD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OGMDBPHKGHN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CDBMPLBDIHM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? EDIEFOKHPBK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AMPLFCBDGKA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? EIONKJEOMFI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KGDAJHMEPAA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OEAMKBLKFCG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CILCIALHCLB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BPPIEKMBCDM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HECNNCMIKBH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PLJDNFKECAD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AKNMJNNAKGO, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OOMMLJBCNAL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PFNCFMKLKKN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MBMCOOOKNLD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MKPPKMFLMKH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NNAMHHCCABJ, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PMJCIKMEFKB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MKIKMIACPBE, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NNNDPOEBFML, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ILMGOPJHKFL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? INEIFNJDBAB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CIOFHHMIJDA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HDGNGLDPCJO, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FKKHDHEHDOL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DKPEEODFGPO, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DFLPIGEADAF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DGEOGKFHKLN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HGIGIKDMNOJ, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JPJCKBINJCA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CCEHPJKIEEK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BKODFEBKKFM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CAFFDJFONNC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JGLHGGEOGHF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DDJCHLHDIGF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MGMJCDDMGPO, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JCEOEDEBDAB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DNIMBGHDHPD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FGGMNCHNALE, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ECEKDEOLACN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LFJNHHEBEBC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PNHPLGENCDP, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ADHHEMLIOML, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FJFNGFAILEM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CAMMHKFNGGD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CDENBJEPMOF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KCCOGLMOIMI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PLNNOEPFBFM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? EJPOFEGBDJD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OJGKADBMOBE, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AMIBDLINAPC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DLGCHNMGLKI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DADCIHPEJDK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GMOEJIPCLGC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AGJDOONPMAD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FIFMIHONCBP, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PDPCOOJHABC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GJOHJIHHAOL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? APJOCEMOEAC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CMCKBPJEEAC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DHHECIHNJOF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FELFMKGFLLC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ALCHMMJAEDH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BELOADBHMHK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JAJNJLHGFNM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? COHBBBGAONK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KOIABEJCENH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PKCEFMCKLGB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KECCGLLLAAO, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PFGCNLDMDNL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MKLFFIEHGIK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NCBEBCPPPPN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NKACDFMOHCF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NHGBJLGHBKD, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HBNJKEPNNJI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AEFLKLOGOCL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LEAKNMNKCMB, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ILOMBBMAIBP, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? IPIFPOMOHCN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GBGMCDEHAGE, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FCJDLNMINAH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KBCHHLIIMMG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GLHDHMBAHIL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? DDFIADDIHLH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HCFPDCOLFKJ, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BFPIBPBDLFC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LFIHJIEBNNK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KANICJEENBM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OHGNMOCKEJC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AOBLFBCDENP, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LLPJHDLGNND, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BAFKFCGMHBM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BAJKHDIMOGH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OGCOOJMHJHJ, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LMGMGOKFOAF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JJELCDPLCJA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? CEFNPMOCKEF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OIJMLEPFDLJ, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JOKIOHGBJGF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GOMFNHDIIPK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HBDEGAMMDLA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LPOAHBFGBCK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? HHDMFMIAFIA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LDECKIHGBOP, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MPMGIMIIJBH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GKBMIKECJAM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JCJFLHANOAA, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? LDFCMNENLPI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JPOFMKJLCJG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ICGACMFCMGF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KJEFOEKOABL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? PKLIJMMPMOF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FOOJDKEOMHM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? BJDMMOPEGAE, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MAIFLMOHBPK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? OMEPFGIEMKN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FAACKGMGHMH, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? FLJCDPJNFJC, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? JLPFIANDNJM, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? AKEIDEADGLG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? MBKNNAJFPMF, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? EAPAOJEEKJG, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? NOIBHKHACFK, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? GFFLIODDGKI, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? ILIDMPAPJEL, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? KPAMGHCHAIN, [Optional] BHMHNABJMDK<TContext, TDeps, TCompileState>? IPKPCFAICMD) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F870", Offset = "0x2B4DE70", VA = "0x182B4F870")]
	private static int IHDLCMLCECM([In] NHNLFJGMEDN<byte> AJBFKHLMPBC, NHNLFJGMEDN<byte> BNIHMOKPGDO, int GHOFJOJMCOI, int LMJBLNOIBOL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OOHJGMNLGKH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int LLAFHLBGBPE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F86120", Offset = "0x3F84720", VA = "0x183F86120")]
	public static AIOJMGEOJFK<FKJOADIJDOP<T>> KHLCNPBBBLJ<T>([In] this NHNLFJGMEDN<byte> JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F86170", Offset = "0x3F84770", VA = "0x183F86170")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<T>>> NLKEOOPPMKI<T>(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<FKJOADIJDOP<T>>? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FC40", Offset = "0x2B4E240", VA = "0x182B4FC40")]
	public static AIOJMGEOJFK<FKJOADIJDOP<AIKJPLOFBEB>> FCBMDOIEOMK(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<AIKJPLOFBEB>? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<AIKJPLOFBEB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FEB0", Offset = "0x2B4E4B0", VA = "0x182B4FEB0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>> PAAAKDOIIOL(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] float? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FD10", Offset = "0x2B4E310", VA = "0x182B4FD10")]
	public static AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>> HMNPAKNMEJC(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FDE0", Offset = "0x2B4E3E0", VA = "0x182B4FDE0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>> IFMOBFKDCGM(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<KPJKCKGFDKH>? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FF80", Offset = "0x2B4E580", VA = "0x182B4FF80")]
	public static AIOJMGEOJFK<FKJOADIJDOP<CMOBIOFNAMG>> PGCGMPMDGLP(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] byte? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<CMOBIOFNAMG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FAA0", Offset = "0x2B4E0A0", VA = "0x182B4FAA0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<KGHGPEMKPNJ>> BIEGKJMKBEL(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<KGHGPEMKPNJ>? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<KGHGPEMKPNJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FB70", Offset = "0x2B4E170", VA = "0x182B4FB70")]
	public static AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> BIHMILOJIJA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] OICFEJNKKGH? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F86060", Offset = "0x3F84660", VA = "0x183F86060")]
	public static AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<T>>> IFIFFBDJFFD<T>(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<T>>? KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B499B0", Offset = "0x2B47FB0", VA = "0x182B499B0")]
	public static void AAJIIGPONJM(this NHNLFJGMEDN<byte> JNMMMBJNOND, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>> AEHKLCKOFLM, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F86050", Offset = "0x3F84650", VA = "0x183F86050")]
	public static void NKOGHGIKIEP<T>(this NHNLFJGMEDN<byte> JNMMMBJNOND, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<T>>> LGDFEKPBPCJ, AIOJMGEOJFK<FKJOADIJDOP<T>> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F86050", Offset = "0x3F84650", VA = "0x183F86050")]
	public static void DHMCNPEBMEP<T>(this NHNLFJGMEDN<byte> JNMMMBJNOND, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<T>>> FOHFHBDEEDI, AIOJMGEOJFK<MAFIFIMAKDP<T>> KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MMKBNEIEMBE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F9B0", Offset = "0x2B4DFB0", VA = "0x182B4F9B0")]
	public static BIEIIMGPOMM LBIBMOFNINE([In] this ReadOnlySpan<byte> EIJIDGHNNNL, int KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F910", Offset = "0x2B4DF10", VA = "0x182B4F910")]
	public static BIEIIMGPOMM LBIBMOFNINE([In] this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB4F0", Offset = "0x3ED9AF0", VA = "0x183EDB4F0")]
	public static BIEIIMGPOMM LBIBMOFNINE<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB670", Offset = "0x3ED9C70", VA = "0x183EDB670")]
	public static BIEIIMGPOMM LBIBMOFNINE<M>([In] this KGDLIPMMNPP<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB320", Offset = "0x3ED9920", VA = "0x183EDB320")]
	public static BIEIIMGPOMM LBIBMOFNINE<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB370", Offset = "0x3ED9970", VA = "0x183EDB370")]
	public static BIEIIMGPOMM LBIBMOFNINE<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB600", Offset = "0x3ED9C00", VA = "0x183EDB600")]
	public static BIEIIMGPOMM LBIBMOFNINE<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F9B0", Offset = "0x2B4DFB0", VA = "0x182B4F9B0")]
	public static int PDIBJOFPNLF([In] this ReadOnlySpan<byte> EIJIDGHNNNL, int KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B49B50", Offset = "0x2B48150", VA = "0x182B49B50")]
	public static int PDIBJOFPNLF([In] this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBC9B0", VA = "0x183DBE3B0")]
	public static int PDIBJOFPNLF<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBC9B0", VA = "0x183DBE3B0")]
	public static int PDIBJOFPNLF<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBC9B0", VA = "0x183DBE3B0")]
	public static int PDIBJOFPNLF<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBC9B0", VA = "0x183DBE3B0")]
	public static int PDIBJOFPNLF<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB7E0", Offset = "0x3ED9DE0", VA = "0x183EDB7E0")]
	public static float PIDPFIGAMPL<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB7E0", Offset = "0x3ED9DE0", VA = "0x183EDB7E0")]
	public static float PIDPFIGAMPL<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB7E0", Offset = "0x3ED9DE0", VA = "0x183EDB7E0")]
	public static float PIDPFIGAMPL<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB2F0", Offset = "0x3ED98F0", VA = "0x183EDB2F0")]
	public static byte HNFIPFFOAAH<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB2D0", Offset = "0x3ED98D0", VA = "0x183EDB2D0")]
	public static byte HNFIPFFOAAH<M>([In] this KGDLIPMMNPP<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB320", Offset = "0x3ED9920", VA = "0x183EDB320")]
	public static byte HNFIPFFOAAH<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB370", Offset = "0x3ED9970", VA = "0x183EDB370")]
	public static byte HNFIPFFOAAH<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB260", Offset = "0x3ED9860", VA = "0x183EDB260")]
	public static byte HNFIPFFOAAH<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B49B50", Offset = "0x2B48150", VA = "0x182B49B50")]
	public static OICFEJNKKGH CHPAJBKEBJD([In] this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE)
	{
		return default(OICFEJNKKGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBC9B0", VA = "0x183DBE3B0")]
	public static OICFEJNKKGH CHPAJBKEBJD<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(OICFEJNKKGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB430", Offset = "0x3ED9A30", VA = "0x183EDB430")]
	public static AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> JDEDFOPHEBH<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB490", Offset = "0x3ED9A90", VA = "0x183EDB490")]
	public static AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> JDEDFOPHEBH<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB3D0", Offset = "0x3ED99D0", VA = "0x183EDB3D0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> JDEDFOPHEBH<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB780", Offset = "0x3ED9D80", VA = "0x183EDB780")]
	public static AIOJMGEOJFK<MAFIFIMAKDP<HIGOLCKHIEO>> OBFFJFAFCBG<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<MAFIFIMAKDP<HIGOLCKHIEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB140", Offset = "0x3ED9740", VA = "0x183EDB140")]
	public static AIOJMGEOJFK<KGHGPEMKPNJ> CHDAANNJFLJ<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<KGHGPEMKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB1A0", Offset = "0x3ED97A0", VA = "0x183EDB1A0")]
	public static AIOJMGEOJFK<KGHGPEMKPNJ> CHDAANNJFLJ<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<KGHGPEMKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB0E0", Offset = "0x3ED96E0", VA = "0x183EDB0E0")]
	public static AIOJMGEOJFK<KGHGPEMKPNJ> CHDAANNJFLJ<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<KGHGPEMKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB080", Offset = "0x3ED9680", VA = "0x183EDB080")]
	public static AIOJMGEOJFK<AIKJPLOFBEB> BFFMCGLNLKL<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<AIKJPLOFBEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB020", Offset = "0x3ED9620", VA = "0x183EDB020")]
	public static AIOJMGEOJFK<AIKJPLOFBEB> BFFMCGLNLKL<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<AIKJPLOFBEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB200", Offset = "0x3ED9800", VA = "0x183EDB200")]
	public static AIOJMGEOJFK<KPJKCKGFDKH> GFLIMHMOHEJ<M>(this ECIKEEECPGI<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE)
	{
		return default(AIOJMGEOJFK<KPJKCKGFDKH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BJLMLCBLLKF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B49D80", Offset = "0x2B48380", VA = "0x182B49D80")]
	public static void FGIOCMOCICB(this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE, BIEIIMGPOMM KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B49C90", Offset = "0x2B48290", VA = "0x182B49C90")]
	public static void FGIOCMOCICB(this byte[] EIJIDGHNNNL, int KBIGEJLMJNE, BIEIIMGPOMM KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B49D00", Offset = "0x2B48300", VA = "0x182B49D00")]
	public static void FGIOCMOCICB([In] this Span<byte> EIJIDGHNNNL, int KBIGEJLMJNE, BIEIIMGPOMM KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B616E0", Offset = "0x3B5FCE0", VA = "0x183B616E0")]
	public static void FGIOCMOCICB<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, BIEIIMGPOMM KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B615F0", Offset = "0x3B5FBF0", VA = "0x183B615F0")]
	public static void FGIOCMOCICB<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, BIEIIMGPOMM KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B499B0", Offset = "0x2B47FB0", VA = "0x182B499B0")]
	public static void AAJIIGPONJM(this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B49B90", Offset = "0x2B48190", VA = "0x182B49B90")]
	public static void AAJIIGPONJM(this byte[] EIJIDGHNNNL, int KBIGEJLMJNE, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B49C10", Offset = "0x2B48210", VA = "0x182B49C10")]
	public static void AAJIIGPONJM([In] this Span<byte> EIJIDGHNNNL, int KBIGEJLMJNE, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B61550", Offset = "0x3B5FB50", VA = "0x183B61550")]
	public static void AAJIIGPONJM<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B615A0", Offset = "0x3B5FBA0", VA = "0x183B615A0")]
	public static void AAJIIGPONJM<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B49EB0", Offset = "0x2B484B0", VA = "0x182B49EB0")]
	public static void OEPEGNFAMOK(this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B61890", Offset = "0x3B5FE90", VA = "0x183B61890")]
	public static void OEPEGNFAMOK<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B61840", Offset = "0x3B5FE40", VA = "0x183B61840")]
	public static void OEPEGNFAMOK<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B49E40", Offset = "0x2B48440", VA = "0x182B49E40")]
	public static void LHIPEOKMIGG(this NHNLFJGMEDN<byte> EIJIDGHNNNL, int KBIGEJLMJNE, byte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B61810", Offset = "0x3B5FE10", VA = "0x183B61810")]
	public static void LHIPEOKMIGG<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, byte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B617E0", Offset = "0x3B5FDE0", VA = "0x183B617E0")]
	public static void LHIPEOKMIGG<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, byte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B617D0", Offset = "0x3B5FDD0", VA = "0x183B617D0")]
	public static void NKOGHGIKIEP<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B617D0", Offset = "0x3B5FDD0", VA = "0x183B617D0")]
	public static void NKOGHGIKIEP<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B617D0", Offset = "0x3B5FDD0", VA = "0x183B617D0")]
	public static void HFNOHLNPOLF<M>(this EKCGLHJCFEL<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, AIOJMGEOJFK<KGHGPEMKPNJ> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B617D0", Offset = "0x3B5FDD0", VA = "0x183B617D0")]
	public static void HFNOHLNPOLF<M>([In] this CKBOBLENNDN<M, byte> EIJIDGHNNNL, AIOJMGEOJFK<M> KBIGEJLMJNE, AIOJMGEOJFK<KGHGPEMKPNJ> KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJIAAEFCBKI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C550", Offset = "0x2B4AB50", VA = "0x182B4C550")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) GJMOGLNDHGP(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CE60", Offset = "0x2B4B460", VA = "0x182B4CE60")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) IAINONFJCNO(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B590", Offset = "0x2B49B90", VA = "0x182B4B590")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) ECEEKFAPIAA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A850", Offset = "0x2B48E50", VA = "0x182B4A850")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) CINDGPDIJBC(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DB70", Offset = "0x2B4C170", VA = "0x182B4DB70")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JOOLFPGIOAO(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C430", Offset = "0x2B4AA30", VA = "0x182B4C430")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) GIPPDDCKOLO(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F330", Offset = "0x2B4D930", VA = "0x182B4F330")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) OCBCCLOJNAA(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AFF0", Offset = "0x2B495F0", VA = "0x182B4AFF0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) DIDKPANMKKP(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A010", Offset = "0x2B48610", VA = "0x182B4A010")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) BCBFEAEKALE(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CD50", Offset = "0x2B4B350", VA = "0x182B4CD50")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>) HDNIGHCBGHH(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? KOPHBHGIACG, [Optional] AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? IKCHLNCMJEM)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E610", Offset = "0x2B4CC10", VA = "0x182B4E610")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>) MEFODIDDLOK(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KOPHBHGIACG, [Optional] AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? IKCHLNCMJEM)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AEE0", Offset = "0x2B494E0", VA = "0x182B4AEE0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>) DDMPALCCLOI(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? KOPHBHGIACG, [Optional] AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? IKCHLNCMJEM)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E270", Offset = "0x2B4C870", VA = "0x182B4E270")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>) KNBIANFNKLH(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KOPHBHGIACG, [Optional] AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? IKCHLNCMJEM)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AB00", Offset = "0x2B49100", VA = "0x182B4AB00")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIKJPLOFBEB>>) COEHHDDJGFK(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? IPPHEAILMPI, [Optional] AIOJMGEOJFK<AIKJPLOFBEB>? OFMFDPOLEGO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIKJPLOFBEB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F100", Offset = "0x2B4D700", VA = "0x182B4F100")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIKJPLOFBEB>>>) NIOILIMENHB(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? IPPHEAILMPI, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIKJPLOFBEB>>? OFMFDPOLEGO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIKJPLOFBEB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C130", Offset = "0x2B4A730", VA = "0x182B4C130")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<KGHGPEMKPNJ>>) GFMDMAECHPC(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? IPPHEAILMPI, [Optional] AIOJMGEOJFK<KGHGPEMKPNJ>? OFMFDPOLEGO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<KGHGPEMKPNJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E890", Offset = "0x2B4CE90", VA = "0x182B4E890")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<KGHGPEMKPNJ>>>) MFPNFCMLAPB(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? IPPHEAILMPI, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<KGHGPEMKPNJ>>? OFMFDPOLEGO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<KGHGPEMKPNJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EA45A0", Offset = "0x3EA2BA0", VA = "0x183EA45A0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>) LMKPJDPJNDJ<TMarker>(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<KPJKCKGFDKH>? OFMFDPOLEGO, [Optional][In] ReadOnlySpan<byte> CDDIADBJAOB)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B4ADB0", Offset = "0x2B493B0", VA = "0x182B4ADB0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) DCFOPIDNLPL(this NHNLFJGMEDN<byte> JNMMMBJNOND, int AJBFKHLMPBC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? BNIHMOKPGDO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B4ACA0", Offset = "0x2B492A0", VA = "0x182B4ACA0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) DBDKEMHJBAI(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? AJBFKHLMPBC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? BNIHMOKPGDO)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3EA42A0", Offset = "0x3EA28A0", VA = "0x183EA42A0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>) FDKHEKPOEOF<TMarker>(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<TMarker>>? BNIHMOKPGDO, [Optional] int? KCJLCGFEBMJ, [Optional][In] ReadOnlySpan<byte> AJBFKHLMPBC)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4480", Offset = "0x3EA2A80", VA = "0x183EA4480")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>) HJJOAOHPAFE<TMarker>(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<TMarker>>? AJBFKHLMPBC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<TMarker>>? BNIHMOKPGDO, [Optional] int? KCJLCGFEBMJ)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<TMarker>>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D3B0", Offset = "0x2B4B9B0", VA = "0x182B4D3B0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) IINNLHHDGBC(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A9B0", Offset = "0x2B48FB0", VA = "0x182B4A9B0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) CLFBMLDKHKF(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A730", Offset = "0x2B48D30", VA = "0x182B4A730")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) CAKIGDMHJBN(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C2D0", Offset = "0x2B4A8D0", VA = "0x182B4C2D0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) GHBEDOMOHHP(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EC80", Offset = "0x2B4D280", VA = "0x182B4EC80")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) MMAEBOAFKDK(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B800", Offset = "0x2B49E00", VA = "0x182B4B800")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) EFPBPPOIBNO(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BFD0", Offset = "0x2B4A5D0", VA = "0x182B4BFD0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) GFIEGGIBIJD(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B2C0", Offset = "0x2B498C0", VA = "0x182B4B2C0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) DJLNKHGJDOD(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B49EF0", Offset = "0x2B484F0", VA = "0x182B49EF0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) ABALBMOFNMG(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DDF0", Offset = "0x2B4C3F0", VA = "0x182B4DDF0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>) KECOPAGBBAA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? ELONMBHBFFL)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F5C0", Offset = "0x2B4DBC0", VA = "0x182B4F5C0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) PIIFPFLBMAA(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EB20", Offset = "0x2B4D120", VA = "0x182B4EB20")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) MKDMBKNIJPI(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DCC0", Offset = "0x2B4C2C0", VA = "0x182B4DCC0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) KDOGMLKOCPA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B920", Offset = "0x2B49F20", VA = "0x182B4B920")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) EOKFDIGPPIF(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CFB0", Offset = "0x2B4B5B0", VA = "0x182B4CFB0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) IBCBJJLKGIK(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E030", Offset = "0x2B4C630", VA = "0x182B4E030")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) KIPHCABBLHG(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D9F0", Offset = "0x2B4BFF0", VA = "0x182B4D9F0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JIODOLDHHNP(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E4B0", Offset = "0x2B4CAB0", VA = "0x182B4E4B0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) MEEAMGFAEHP(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F740", Offset = "0x2B4DD40", VA = "0x182B4F740")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) POBEOGPMJAB(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E730", Offset = "0x2B4CD30", VA = "0x182B4E730")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) MELNDAMPICJ(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D260", Offset = "0x2B4B860", VA = "0x182B4D260")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) IHGPOKIDALJ(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A130", Offset = "0x2B48730", VA = "0x182B4A130")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) BDHINMGPIDO(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BE50", Offset = "0x2B4A450", VA = "0x182B4BE50")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) FKADBJKDFAD(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BCF0", Offset = "0x2B4A2F0", VA = "0x182B4BCF0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) FJLOBMJPKHA(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CAC0", Offset = "0x2B4B0C0", VA = "0x182B4CAC0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) HCOJPIIGFEE(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D100", Offset = "0x2B4B700", VA = "0x182B4D100")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) IHFHEIHFIML(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C970", Offset = "0x2B4AF70", VA = "0x182B4C970")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) GPGHBNNMBEO(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D8D0", Offset = "0x2B4BED0", VA = "0x182B4D8D0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JGHNCAEJOON(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E9A0", Offset = "0x2B4CFA0", VA = "0x182B4E9A0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) MGKIOOEPIPE(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BB90", Offset = "0x2B4A190", VA = "0x182B4BB90")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) FIEIIFIOHNM(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F490", Offset = "0x2B4DA90", VA = "0x182B4F490")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) PBCMCDIGGIP(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D770", Offset = "0x2B4BD70", VA = "0x182B4D770")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JEEJBAHAMME(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DEE0", Offset = "0x2B4C4E0", VA = "0x182B4DEE0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) KIMNNANAFHK(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D530", Offset = "0x2B4BB30", VA = "0x182B4D530")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JCCFNCEJDMH(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B410", Offset = "0x2B49A10", VA = "0x182B4B410")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) DLFDPHDJOBE(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C820", Offset = "0x2B4AE20", VA = "0x182B4C820")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) GOJFBGJHIFP(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E390", Offset = "0x2B4C990", VA = "0x182B4E390")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) LDNDHOHGDEA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CBF0", Offset = "0x2B4B1F0", VA = "0x182B4CBF0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) HDDCMKAEDDH(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C6D0", Offset = "0x2B4ACD0", VA = "0x182B4C6D0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) GLLCDABLGHK(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F210", Offset = "0x2B4D810", VA = "0x182B4F210")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) NLOAGCMGKCL(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A3B0", Offset = "0x2B489B0", VA = "0x182B4A3B0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) BEKJKJICGHI(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] int? MABLGMHAJHD, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B4BA80", Offset = "0x2B4A080", VA = "0x182B4BA80")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) FBGNPJFOJHN(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? MABLGMHAJHD, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4F080", Offset = "0x2B4D680", VA = "0x182B4F080")]
	public static AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> NINBCCIGPPC(this NHNLFJGMEDN<byte> JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B140", Offset = "0x2B49740", VA = "0x182B4B140")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) DJKEPNNCMFF(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B6B0", Offset = "0x2B49CB0", VA = "0x182B4B6B0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) ECGKIAANPKM(this NHNLFJGMEDN<byte> JNMMMBJNOND, float KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<NJLLOOFODAG>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A610", Offset = "0x2B48C10", VA = "0x182B4A610")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>) BPJDAMKJLCP(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<NJLLOOFODAG>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<NJLLOOFODAG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A250", Offset = "0x2B48850", VA = "0x182B4A250")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) BEDBMONACNB(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EF30", Offset = "0x2B4D530", VA = "0x182B4EF30")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) NHNDACPIDBL(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E150", Offset = "0x2B4C750", VA = "0x182B4E150")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) KJBAENCNFEG(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B4EDD0", Offset = "0x2B4D3D0", VA = "0x182B4EDD0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) NENCBFJANCC(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A4C0", Offset = "0x2B48AC0", VA = "0x182B4A4C0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) BEMJDIBPBJO(this NHNLFJGMEDN<byte> JNMMMBJNOND, int KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D650", Offset = "0x2B4BC50", VA = "0x182B4D650")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>) JCCJEJLJOFA(this NHNLFJGMEDN<byte> JNMMMBJNOND, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? KDEJNGMKJHJ, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? HLNDACBMLAC, [Optional] AIOJMGEOJFK<MAFIFIMAKDP<AIGEEEJNNHA>>? LLJCNKIOABG)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<AIGEEEJNNHA>>>));
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
