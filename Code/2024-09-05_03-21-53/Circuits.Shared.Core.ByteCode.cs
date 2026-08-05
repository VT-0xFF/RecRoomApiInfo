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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x20AA7D0", Offset = "0x20A91D0", VA = "0x1820AA7D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIAJOBDBKKH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A104F0", Offset = "0x2A0EEF0", VA = "0x182A104F0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<M>> FFINFEPKIFA<M>(this int PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20A4E20", Offset = "0x20A3820", VA = "0x1820A4E20")]
	public static MLGFJIHMDCD<MDEOHEADBEE> MJNDBLLCNPP(this int PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<MDEOHEADBEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A104F0", Offset = "0x2A0EEF0", VA = "0x182A104F0")]
	public static MLGFJIHMDCD<FIAEKMGGFMC<M>> HHIMALLEBDL<M>(this int PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<FIAEKMGGFMC<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IEEJBCOLPEF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NMLGMJBPOHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GPLOIDPOBED
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MDEOHEADBEE
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JPOKFMIFKLO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KNCOJMCICAC
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HOCDHKGHDAM
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
public static class BOGMLIKCDOM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct EDFOFBFPDOJ<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr LOHBKDJBPLO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
		public EDFOFBFPDOJ(IntPtr BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39570E0", Offset = "0x3955AE0", VA = "0x1839570E0")]
		public int NPIHGHHDKCM(TDeps JPDKLLDNBGD, TContext GDMNEIEFKPA, TCompileState PAAJAFMIFAA, [In] CBGFCAOFHCN<byte> CCHEJOKNLMP, int GFAGIEEMGHL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B0A0", Offset = "0x2A29AA0", VA = "0x182A2B0A0")]
	public static void CPKJGHMFIEF<TDeps, TContext, TCompileState>(TDeps JPDKLLDNBGD, TContext GDMNEIEFKPA, TCompileState PAAJAFMIFAA, [In] CBGFCAOFHCN<byte> IEKIDBLHEKM, CBGFCAOFHCN<byte> JGGKFHPAKCM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DFNLHLOJFOE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FNDKAOMEOHN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JPOMMCIKKKB, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IDGPOMHNKFH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JACNOEPMJLI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OGPLDBDOFEO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FOIKFGKPGFF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? INDCMNBDOAB, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ONOFOMCGLPG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MBCALMEOEIN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ANJECDCAKPG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LBBLDBGDCFL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IDFBOMALNOL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DHNCGIGNGPF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IBNPPGCOODD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NAFAEELNKIF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DGDAOBDBNJF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HKBEEADKKCJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LIGDLJHGMCI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? CNBJHKCPFFE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FIPDPMKDMPI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LPMOICMNMON, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KLBDBIAGINO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BDCKBMGNLIE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BMPNKBFCELL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EFMCDJGGFOO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MCELBMLJMPL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IAADFCFFMOM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NKBIPGELIDC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ENDFIFHALKE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NHPNBFFLHEC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KFKPBPEHGCI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LLFOBGJIDMK, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EGLBLICEDKC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ENILAEDODAH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AABGAMIIMJD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PPDAFMPJLJC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JAHDNGNOHJG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DEFLCGOLFAD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AHMCLJLBPMN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PLGKCIKNAJO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PLKIIPBBIHK, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JHBHCPEBMAI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BFHEBMJAANA, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IGFGPODBIPO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NEBNEEBNCIK, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OLJKGABAHHA, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BKMGKFOFPIG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MGMMPFKPBLC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IMAMIIKFPMI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DKFAJMIPCAJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MCHAOAEBLLJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LEEOBGFNFNM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NBENPJNPLJM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JBMCGLBCDLN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AIBHDLFBOFJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EGNMJEAEBMO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ALLKJAEFFNM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KOJEPNKJAPF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PEBEPIGFCEA, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HEAJNMKIJCJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NDNIMDOCKPB, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AGHJIMKFCED, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MJIOCLDOKGI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NHBEEFJHJML, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EBDNKINDFEK, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JPKCAIBHCDH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PCPBADIMFAD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PLJAGEFBPOJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PDMCHFJKFJG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MJCEANIHMOP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PADKLMKNIGH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FCMNOGDIKEL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PBECKIILJPF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MGDLBGIKDIE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NPADPHOPJDC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DIHHLFGIGLE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HLJHIFJOBDP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? CHAKKMCANBI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LPAEKIIAIEO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? GBMLFLOKGNE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NCJLNJJGNGG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DLOGGAELKDJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LNJIMLFDPBN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NCGOHBKADKN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BOIHLKEILHH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KIIIAJOEICD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DBJMFKHONKJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BMKFJPHNADN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PDMJHOKNKFD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NBMBHBJOPLO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JFJLCFAMAPN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IEFKFBPDFNH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? ICHMFHILBHB, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LAJNACIIJCC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KGNIPAMLBPI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BFKGNDAOPIK, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FBICGFMBFPM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BIPLACBFPNI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? GHFNLKHNMGD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IPLNKBIFEMC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? PAHMKPAJGNP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JNPLKBOCBJM, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OIFNILAHJBP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FNEJOIPCPHC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AIAGBFBINKJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? LMPHJAJHNNO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OPOHBEJEKMO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? JPNKIFDPKEF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? AFJNPIHLALG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? BCJDNHMHODL, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FNLNHJHCBJH, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OLGGJKPJFDB, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HOMGACAEKFO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FLGNEDILLAJ, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DNDPFAJPNFN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? MCABLHMEBPF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EADCOBMGGGP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HBDHIEHOFNO, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? CHHHFFAAEPD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? CGLHJLJCDLP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? FOKCHBKGELI, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DFKELFMDGBG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OPIPLBANFEP, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? IGGDNPBHLJA, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NALDKBCJFKC, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EJPOCNBGBLG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? CLAKBLCHKII, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? HLDDIGKMIKG, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? KODKHKFHKFD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DFNBOCMJOKN, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? EMFDDEJFCAD, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? OJDMPLOPOJF, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? NBBOEDCGDBE, [Optional] EDFOFBFPDOJ<TContext, TDeps, TCompileState>? DODIAIEHFMP) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20A45D0", Offset = "0x20A2FD0", VA = "0x1820A45D0")]
	private static int GCHFLOMJGCK([In] CBGFCAOFHCN<byte> ACEPIENHFHI, CBGFCAOFHCN<byte> GPOGEIBDPAB, int PJOMFOPGCGL, int KFBJHPBJLOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DEAINAIBGPI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int OGKJLOKNKNO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCD00", Offset = "0x2AFB700", VA = "0x182AFCD00")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<T>> PACICKNGILJ<T>([In] this CBGFCAOFHCN<byte> PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCD60", Offset = "0x2AFB760", VA = "0x182AFCD60")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<T>>> PMNKCCNPHEO<T>(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<T>>? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4880", Offset = "0x20A3280", VA = "0x1820A4880")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<GJEGPHJEIMP>> CGMPIKPLEIK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<GJEGPHJEIMP>? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<GJEGPHJEIMP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20A4960", Offset = "0x20A3360", VA = "0x1820A4960")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>> DJBBIKNHKCO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] float? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20A4D00", Offset = "0x20A3700", VA = "0x1820A4D00")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>> PJLANMPAKMD(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20A4A50", Offset = "0x20A3450", VA = "0x1820A4A50")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>> EJPMAPOFLHO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<KBPLJEDPMGK>? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x20A4780", Offset = "0x20A3180", VA = "0x1820A4780")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<KNCOJMCICAC>> BHFGNGONFLO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] byte? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<KNCOJMCICAC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C20", Offset = "0x20A3620", VA = "0x1820A4C20")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<MDEOHEADBEE>> NMAIPOGPOBG(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<MDEOHEADBEE>? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<MDEOHEADBEE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20A4B30", Offset = "0x20A3530", VA = "0x1820A4B30")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> NHMGKBKPPMK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] HOCDHKGHDAM? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCC30", Offset = "0x2AFB630", VA = "0x182AFCC30")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<T>>> AEOOIGIFJKI<T>(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<T>>? CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20A4590", Offset = "0x20A2F90", VA = "0x1820A4590")]
	public static void JCJNEEGLMEF(this CBGFCAOFHCN<byte> PECHDAFMNOO, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>> CCBFGOAPLKP, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCCF0", Offset = "0x2AFB6F0", VA = "0x182AFCCF0")]
	public static void AFLJFPANHGM<T>(this CBGFCAOFHCN<byte> PECHDAFMNOO, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<T>>> GFAGIEEMGHL, MLGFJIHMDCD<IEEJBCOLPEF<T>> CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCCF0", Offset = "0x2AFB6F0", VA = "0x182AFCCF0")]
	public static void OOKHHIDGECN<T>(this CBGFCAOFHCN<byte> PECHDAFMNOO, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<T>>> LMAFMPBFJON, MLGFJIHMDCD<FIAEKMGGFMC<T>> CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DACGHEGIJOC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20A4670", Offset = "0x20A3070", VA = "0x1820A4670")]
	public static GFDAFGLFBDL HOPGHIHKCEB([In] this ReadOnlySpan<byte> OPJILLDCBJI, int CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20A46E0", Offset = "0x20A30E0", VA = "0x1820A46E0")]
	public static GFDAFGLFBDL HOPGHIHKCEB([In] this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF30F0", Offset = "0x2AF1AF0", VA = "0x182AF30F0")]
	public static GFDAFGLFBDL HOPGHIHKCEB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3240", Offset = "0x2AF1C40", VA = "0x182AF3240")]
	public static GFDAFGLFBDL HOPGHIHKCEB<M>([In] this ODAPDNDELEB<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2FF0", Offset = "0x2AF19F0", VA = "0x182AF2FF0")]
	public static GFDAFGLFBDL HOPGHIHKCEB<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3080", Offset = "0x2AF1A80", VA = "0x182AF3080")]
	public static GFDAFGLFBDL HOPGHIHKCEB<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AF33A0", Offset = "0x2AF1DA0", VA = "0x182AF33A0")]
	public static GFDAFGLFBDL HOPGHIHKCEB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x20A4670", Offset = "0x20A3070", VA = "0x1820A4670")]
	public static int NPFIHKMKAMB([In] this ReadOnlySpan<byte> OPJILLDCBJI, int CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20A44C0", Offset = "0x20A2EC0", VA = "0x1820A44C0")]
	public static int NPFIHKMKAMB([In] this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static int NPFIHKMKAMB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static int NPFIHKMKAMB<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static int NPFIHKMKAMB<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static int NPFIHKMKAMB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2E60", Offset = "0x2AF1860", VA = "0x182AF2E60")]
	public static float BDKMNMIIOIK<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2E60", Offset = "0x2AF1860", VA = "0x182AF2E60")]
	public static float BDKMNMIIOIK<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2E60", Offset = "0x2AF1860", VA = "0x182AF2E60")]
	public static float BDKMNMIIOIK<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3050", Offset = "0x2AF1A50", VA = "0x182AF3050")]
	public static byte HMJDKMKGIMB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2F10", Offset = "0x2AF1910", VA = "0x182AF2F10")]
	public static byte HMJDKMKGIMB<M>([In] this ODAPDNDELEB<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2FF0", Offset = "0x2AF19F0", VA = "0x182AF2FF0")]
	public static byte HMJDKMKGIMB<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3080", Offset = "0x2AF1A80", VA = "0x182AF3080")]
	public static byte HMJDKMKGIMB<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2F30", Offset = "0x2AF1930", VA = "0x182AF2F30")]
	public static byte HMJDKMKGIMB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20A44C0", Offset = "0x20A2EC0", VA = "0x1820A44C0")]
	public static HOCDHKGHDAM KEIDFONCOEB([In] this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF)
	{
		return default(HOCDHKGHDAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static HOCDHKGHDAM KEIDFONCOEB<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(HOCDHKGHDAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3770", Offset = "0x2AF2170", VA = "0x182AF3770")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OGCGMBBNCEF<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3700", Offset = "0x2AF2100", VA = "0x182AF3700")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OGCGMBBNCEF<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AF37E0", Offset = "0x2AF21E0", VA = "0x182AF37E0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OGCGMBBNCEF<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3540", Offset = "0x2AF1F40", VA = "0x182AF3540")]
	public static MLGFJIHMDCD<FIAEKMGGFMC<JCILPIOHADJ>> KJFNGEPMGPJ<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<FIAEKMGGFMC<JCILPIOHADJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AF35B0", Offset = "0x2AF1FB0", VA = "0x182AF35B0")]
	public static MLGFJIHMDCD<MDEOHEADBEE> MGEHIBMBDJL<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<MDEOHEADBEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3620", Offset = "0x2AF2020", VA = "0x182AF3620")]
	public static MLGFJIHMDCD<MDEOHEADBEE> MGEHIBMBDJL<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<MDEOHEADBEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3690", Offset = "0x2AF2090", VA = "0x182AF3690")]
	public static MLGFJIHMDCD<MDEOHEADBEE> MGEHIBMBDJL<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<MDEOHEADBEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AF34D0", Offset = "0x2AF1ED0", VA = "0x182AF34D0")]
	public static MLGFJIHMDCD<GJEGPHJEIMP> IFLCJHAEMOC<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<GJEGPHJEIMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3460", Offset = "0x2AF1E60", VA = "0x182AF3460")]
	public static MLGFJIHMDCD<GJEGPHJEIMP> IFLCJHAEMOC<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<GJEGPHJEIMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2EA0", Offset = "0x2AF18A0", VA = "0x182AF2EA0")]
	public static MLGFJIHMDCD<KBPLJEDPMGK> COFKIAHKMPC<M>(this EKPODPHDKAD<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF)
	{
		return default(MLGFJIHMDCD<KBPLJEDPMGK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PEJNGHMMLFO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20AA910", Offset = "0x20A9310", VA = "0x1820AA910")]
	public static void FICLFLEKLGK(this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF, GFDAFGLFBDL CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20AA9D0", Offset = "0x20A93D0", VA = "0x1820AA9D0")]
	public static void FICLFLEKLGK(this byte[] OPJILLDCBJI, int CALGHEJMIMF, GFDAFGLFBDL CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20AA890", Offset = "0x20A9290", VA = "0x1820AA890")]
	public static void FICLFLEKLGK([In] this Span<byte> OPJILLDCBJI, int CALGHEJMIMF, GFDAFGLFBDL CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E39500", Offset = "0x2E37F00", VA = "0x182E39500")]
	public static void FICLFLEKLGK<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, GFDAFGLFBDL CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E396A0", Offset = "0x2E380A0", VA = "0x182E396A0")]
	public static void FICLFLEKLGK<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, GFDAFGLFBDL CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20A4590", Offset = "0x20A2F90", VA = "0x1820A4590")]
	public static void JCJNEEGLMEF(this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x20AAAC0", Offset = "0x20A94C0", VA = "0x1820AAAC0")]
	public static void JCJNEEGLMEF(this byte[] OPJILLDCBJI, int CALGHEJMIMF, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x20AAA40", Offset = "0x20A9440", VA = "0x1820AAA40")]
	public static void JCJNEEGLMEF([In] this Span<byte> OPJILLDCBJI, int CALGHEJMIMF, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E398A0", Offset = "0x2E382A0", VA = "0x182E398A0")]
	public static void JCJNEEGLMEF<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E39840", Offset = "0x2E38240", VA = "0x182E39840")]
	public static void JCJNEEGLMEF<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x20AA850", Offset = "0x20A9250", VA = "0x1820AA850")]
	public static void AMDPGMMLDEF(this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF, float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E39440", Offset = "0x2E37E40", VA = "0x182E39440")]
	public static void AMDPGMMLDEF<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E394A0", Offset = "0x2E37EA0", VA = "0x182E394A0")]
	public static void AMDPGMMLDEF<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x20AAB40", Offset = "0x20A9540", VA = "0x1820AAB40")]
	public static void KCBHHIDECMP(this CBGFCAOFHCN<byte> OPJILLDCBJI, int CALGHEJMIMF, byte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E39950", Offset = "0x2E38350", VA = "0x182E39950")]
	public static void KCBHHIDECMP<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, byte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E39900", Offset = "0x2E38300", VA = "0x182E39900")]
	public static void KCBHHIDECMP<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, byte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A106F0", Offset = "0x2A0F0F0", VA = "0x182A106F0")]
	public static void AFLJFPANHGM<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A106F0", Offset = "0x2A0F0F0", VA = "0x182A106F0")]
	public static void AFLJFPANHGM<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A106F0", Offset = "0x2A0F0F0", VA = "0x182A106F0")]
	public static void CMEKENOJLOB<M>(this LOFGLBPFPME<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, MLGFJIHMDCD<MDEOHEADBEE> CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A106F0", Offset = "0x2A0F0F0", VA = "0x182A106F0")]
	public static void CMEKENOJLOB<M>([In] this JIMLPNFGFOH<M, byte> OPJILLDCBJI, MLGFJIHMDCD<M> CALGHEJMIMF, MLGFJIHMDCD<MDEOHEADBEE> CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JHNBBMLNKCH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x20A4E50", Offset = "0x20A3850", VA = "0x1820A4E50")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) ABKHAMDKMBG(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20A9620", Offset = "0x20A8020", VA = "0x1820A9620")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) NFGCHCJDAJK(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x20A5230", Offset = "0x20A3C30", VA = "0x1820A5230")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) AGHKJNOGOLF(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20A8A10", Offset = "0x20A7410", VA = "0x1820A8A10")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) LDODEIKDEEM(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20A5C50", Offset = "0x20A4650", VA = "0x1820A5C50")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) DHAOPFJFCFI(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20A8030", Offset = "0x20A6A30", VA = "0x1820A8030")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) ICNMJGHNGMK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20A8640", Offset = "0x20A7040", VA = "0x1820A8640")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KNPNEPHFLEP(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20A88C0", Offset = "0x20A72C0", VA = "0x1820A88C0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KPAJDIFGDHA(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20A93E0", Offset = "0x20A7DE0", VA = "0x1820A93E0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) NDCGAPAFLCI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20A9770", Offset = "0x20A8170", VA = "0x1820A9770")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>) NHIIAELOGAH(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? CLMKDBDPNNH, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? MOBCKEJIBCF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20A67B0", Offset = "0x20A51B0", VA = "0x1820A67B0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>) ELNFOMGEPEP(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? CLMKDBDPNNH, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? MOBCKEJIBCF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20A7200", Offset = "0x20A5C00", VA = "0x1820A7200")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>) GDDOCNKNLGC(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? CLMKDBDPNNH, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? MOBCKEJIBCF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x20A6BB0", Offset = "0x20A55B0", VA = "0x1820A6BB0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>) EPEFKIBEGNA(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? CLMKDBDPNNH, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? MOBCKEJIBCF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x20A8B70", Offset = "0x20A7570", VA = "0x1820A8B70")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GJEGPHJEIMP>>) LGOIAGKLNDO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? PEINBOIAEGA, [Optional] MLGFJIHMDCD<GJEGPHJEIMP>? MIDOKEPAEFF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GJEGPHJEIMP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x20AA450", Offset = "0x20A8E50", VA = "0x1820AA450")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GJEGPHJEIMP>>>) OPKFPOHMINO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? PEINBOIAEGA, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GJEGPHJEIMP>>? MIDOKEPAEFF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GJEGPHJEIMP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20A9240", Offset = "0x20A7C40", VA = "0x1820A9240")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<MDEOHEADBEE>>) MKJPONIOLNA(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? PEINBOIAEGA, [Optional] MLGFJIHMDCD<MDEOHEADBEE>? MIDOKEPAEFF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<MDEOHEADBEE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x20A99D0", Offset = "0x20A83D0", VA = "0x1820A99D0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<MDEOHEADBEE>>>) NIHLLHLHPND(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? PEINBOIAEGA, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<MDEOHEADBEE>>? MIDOKEPAEFF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<MDEOHEADBEE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC440", Offset = "0x2CFAE40", VA = "0x182CFC440")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>) BHHLIJAKDFP<TMarker>(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<KBPLJEDPMGK>? MIDOKEPAEFF, [Optional][In] ReadOnlySpan<byte> OIGMDCDEKEG)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x20A62F0", Offset = "0x20A4CF0", VA = "0x1820A62F0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) EALHEEOPNGI(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ACEPIENHFHI, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? GPOGEIBDPAB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x20A8530", Offset = "0x20A6F30", VA = "0x1820A8530")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KLGIAAEMFDK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ACEPIENHFHI, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? GPOGEIBDPAB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC640", Offset = "0x2CFB040", VA = "0x182CFC640")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>) CKIFAEDDABI<TMarker>(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<TMarker>>? GPOGEIBDPAB, [Optional] int? MPLHLKNKHIM, [Optional][In] ReadOnlySpan<byte> ACEPIENHFHI)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC2F0", Offset = "0x2CFACF0", VA = "0x182CFC2F0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>) AAMCEJCDGNA<TMarker>(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<TMarker>>? ACEPIENHFHI, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<TMarker>>? GPOGEIBDPAB, [Optional] int? MPLHLKNKHIM)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<TMarker>>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x20AA2D0", Offset = "0x20A8CD0", VA = "0x1820AA2D0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) OOLNHMGIKKK(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20AA560", Offset = "0x20A8F60", VA = "0x1820AA560")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) PLLLDEECKCN(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x20A6F80", Offset = "0x20A5980", VA = "0x1820A6F80")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) FJOGPJLLEEI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x20A83D0", Offset = "0x20A6DD0", VA = "0x1820A83D0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KHKIGPCNECC(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x20A61A0", Offset = "0x20A4BA0", VA = "0x1820A61A0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) EAEGDEDFLDK(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x20A7470", Offset = "0x20A5E70", VA = "0x1820A7470")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) GFCKCOPECFD(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x20A68D0", Offset = "0x20A52D0", VA = "0x1820A68D0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) ENBLCLGBIFE(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x20A4FD0", Offset = "0x20A39D0", VA = "0x1820A4FD0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) AFCJDCEHMDO(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20A56F0", Offset = "0x20A40F0", VA = "0x1820A56F0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) BNCNFBIBBBI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x20A66C0", Offset = "0x20A50C0", VA = "0x1820A66C0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>) EGAKHEIHMCF(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? KBLNNIPBAJF)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20A9D80", Offset = "0x20A8780", VA = "0x1820A9D80")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) OIIOHPCGDFH(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x20A7310", Offset = "0x20A5D10", VA = "0x1820A7310")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) GDKKGMJDPIA(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x20A5DA0", Offset = "0x20A47A0", VA = "0x1820A5DA0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) DIHGEFHOJNI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x20A8F80", Offset = "0x20A7980", VA = "0x1820A8F80")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) LNNJCMAPKJK(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20A7D80", Offset = "0x20A6780", VA = "0x1820A7D80")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) HLJIDLOBHAG(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x20AA6B0", Offset = "0x20A90B0", VA = "0x1820AA6B0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) PMLIFPBBAKK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20A6020", Offset = "0x20A4A20", VA = "0x1820A6020")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) DMIEMBDGAPA(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20A7800", Offset = "0x20A6200", VA = "0x1820A7800")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) HBMFGKJJMFP(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20A5350", Offset = "0x20A3D50", VA = "0x1820A5350")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) AGPELDCBNLP(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x20A6CD0", Offset = "0x20A56D0", VA = "0x1820A6CD0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) FEFFMIIBEAH(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x20A7A80", Offset = "0x20A6480", VA = "0x1820A7A80")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) HFHFJEBJGLE(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x20A9AE0", Offset = "0x20A84E0", VA = "0x1820A9AE0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) NJHCNIJJAEO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x20A6A30", Offset = "0x20A5430", VA = "0x1820A6A30")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) EOANHCLIFFF(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x20A7ED0", Offset = "0x20A68D0", VA = "0x1820A7ED0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) IBALOJLMGHI(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x20A7C50", Offset = "0x20A6650", VA = "0x1820A7C50")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) HJCMKNOLDJK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x20A5AF0", Offset = "0x20A44F0", VA = "0x1820A5AF0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) CLJABDGGOME(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20A5ED0", Offset = "0x20A48D0", VA = "0x1820A5ED0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) DLHKJDNCPJO(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x20A76E0", Offset = "0x20A60E0", VA = "0x1820A76E0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) GPCCJHLBAGP(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20A6420", Offset = "0x20A4E20", VA = "0x1820A6420")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) EBIGDDLNBBK(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x20A9F00", Offset = "0x20A8900", VA = "0x1820A9F00")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) OKCHAOBJEDL(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20A8150", Offset = "0x20A6B50", VA = "0x1820A8150")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) JPEFFPFGOGF(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x20A70A0", Offset = "0x20A5AA0", VA = "0x1820A70A0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) GBCCDFLMDFN(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x20A8D10", Offset = "0x20A7710", VA = "0x1820A8D10")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) LICCOGMBKIH(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x20AA060", Offset = "0x20A8A60", VA = "0x1820AA060")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) OLMFFEKLDGO(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x20A9C00", Offset = "0x20A8600", VA = "0x1820A9C00")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) OFGMKBCOIFA(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x20A9880", Offset = "0x20A8280", VA = "0x1820A9880")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) NHNJHBLKMNK(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x20A7960", Offset = "0x20A6360", VA = "0x1820A7960")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) HDJEAIPAJMK(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20A5590", Offset = "0x20A3F90", VA = "0x1820A5590")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) BENJJBDGPPI(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x20A8280", Offset = "0x20A6C80", VA = "0x1820A8280")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KGNCCCACCFF(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20A9500", Offset = "0x20A7F00", VA = "0x1820A9500")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) NEFFMIDKCAA(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20A5480", Offset = "0x20A3E80", VA = "0x1820A5480")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) BEGPOMOBNCI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] int? NMNKKHEFPCP, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20A5120", Offset = "0x20A3B20", VA = "0x1820A5120")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) AFHJLIFNMAP(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NMNKKHEFPCP, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x20A7BD0", Offset = "0x20A65D0", VA = "0x1820A7BD0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> HGALAIMMAMM(this CBGFCAOFHCN<byte> PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x20A5970", Offset = "0x20A4370", VA = "0x1820A5970")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) CHKLEONJBIK(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x20A6E30", Offset = "0x20A5830", VA = "0x1820A6E30")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) FJCLOHDONJN(this CBGFCAOFHCN<byte> PECHDAFMNOO, float ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<NMLGMJBPOHM>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x20A65A0", Offset = "0x20A4FA0", VA = "0x1820A65A0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>) EFJLCOHANFG(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<NMLGMJBPOHM>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<NMLGMJBPOHM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x20A5810", Offset = "0x20A4210", VA = "0x1820A5810")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) CDBAEMIOHMA(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20A7590", Offset = "0x20A5F90", VA = "0x1820A7590")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) GOCJOJIPLII(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20A87A0", Offset = "0x20A71A0", VA = "0x1820A87A0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) KOAEIMCFHKH(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20A90E0", Offset = "0x20A7AE0", VA = "0x1820A90E0")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) MDPPCJDCEDN(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x20AA180", Offset = "0x20A8B80", VA = "0x1820AA180")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) ONFKAIAALIB(this CBGFCAOFHCN<byte> PECHDAFMNOO, int ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x20A8E60", Offset = "0x20A7860", VA = "0x1820A8E60")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>) LMEKJJMHNHI(this CBGFCAOFHCN<byte> PECHDAFMNOO, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? ONHAKDJFOLN, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? DKEADGGNEJJ, [Optional] MLGFJIHMDCD<FIAEKMGGFMC<GPLOIDPOBED>>? NIECAOIBCLB)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<GPLOIDPOBED>>>));
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
