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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2759750", Offset = "0x2757F50", VA = "0x182759750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BDIDKFOHGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF20", Offset = "0x34FE720", VA = "0x1834FFF20")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<M>> NDGILJEBBMF<M>(this int NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2758C10", Offset = "0x2757410", VA = "0x182758C10")]
	public static NLPIAAOFKEO<ODJMAFEADLC> DNIGNFENOIB(this int NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<ODJMAFEADLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF20", Offset = "0x34FE720", VA = "0x1834FFF20")]
	public static NLPIAAOFKEO<GGAILHMBCMN<M>> BGBPCECHLHO<M>(this int NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<GGAILHMBCMN<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OMMDMCCMKFJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IPLFOGHBNMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MJDHOIKNAAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ODJMAFEADLC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EGGBDLJFGCA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class LNGLEGPBALM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum PHNAOPLGEMF
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
public static class PIFBENGFJGG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IEMOEIMBDGC<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr FIFFPJBDNCC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
		public IEMOEIMBDGC(IntPtr JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4B67A60", Offset = "0x4B66260", VA = "0x184B67A60")]
		public int GINPGABDCGP(TDeps ILEBEOADOPL, TContext NKNKDPDDMGK, TCompileState DMGNCDGNMEN, [In] PFLMDAPEOIN<byte> CHBNKONDJHK, int FJLHNHGFGPL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x396B350", Offset = "0x3969B50", VA = "0x18396B350")]
	public static void OPKMOAOAHCA<TDeps, TContext, TCompileState>(TDeps ILEBEOADOPL, TContext NKNKDPDDMGK, TCompileState DMGNCDGNMEN, [In] PFLMDAPEOIN<byte> JEJLJAJCEBB, PFLMDAPEOIN<byte> EBOCOHGCKOF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PHNLLNDCGDB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PFNPCGGOGCD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NEJJBDJLFGC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DJPFMFGEFPN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LNJNEHNECGC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BCIJDJHOCHA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MLMCAFOFBFL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LGBHCPCDNCN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NJCMDONJMNN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DANDDIONKBJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HMIDLNJJEDP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EEEKJOLLDIP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LJMAIHKFEJC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KPIBICACEHE, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? JDNNIBHIIBP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HFEBEDCLLFC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OBHHEKJGJDB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BJNKGDFDINP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GBODBJKJAFA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OMNHEADCPHC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LAMJMEFGPKL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OEOKMJKOAME, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BKBEBEPKKKH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NMHCMHBBGJL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KNKJBNIHIPJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AHBAMOKHJAA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FAKLKMMICJL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PPOJCJLFNLK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GIAHCIBHAEF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EIKDCAFCKHK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EIGGFKOMOLN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OKCHLADFLBG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GEDKMCJNLJI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OCCLMKCJNLF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CNKNIIAJGLL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HGIKIJGPHKG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PPLKHMOFJLJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FMLMLOLKOOO, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KNLNGMMFODC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HDAHEOFGBDM, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? ACCJIGABEKD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LCGGLEJPKJI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HAKEBJADFFD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MMJGCBJIDJP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HINJDKFILHF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PFPIFGJKHLJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GOCKONLIPHF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DPCHMOHPABI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CJLOMKGJAOF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CNJGAJCKDBP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? IGHLIKINLPD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BFLJFFBHOGI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CCOMLEPLGKD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DFEAFDBHPHM, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KDBEPBDFANF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CPDHOHAJJLN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GONLBLIPOFA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MKLNLAEDPEB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HDADIJDPCJC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HFPHMELHICA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EDHBLGPJIJG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FIJJLBEOFBO, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KHPBMJIDKAA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MLGICMNDILJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AMNEEHGMEDK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FHKDMIBIJJB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EMAGAECFKOA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AKKEJOAHOMG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CBNHKPHCELD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LGOEGDNPINH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OMELNINHHEJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EGIJEHDEFMF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KIKPNLJJJLK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MMHFBAGCEBG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FCELNIKJHJO, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FMHAGDBPBCI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? ABOCHOKHJKL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PBFAPAOHNIJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DEPHALPMOCL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GCDMCHFOPGF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BJFDEPNEDKC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AOIHMDLAMIJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OCIEFHPBIKA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GHFEJCJONDD, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BBMNMGEFNKB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KHCODGBJFPG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NMIABAOBGPA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AOAAHOJLBHG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OIGAEFPOBKJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? AIEMFIANGNL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GMDEBMBHFDH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NGAHAEEBJPN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BLEOLBELPPL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PDAPGCNFAPH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OFPCFNAAGOF, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LMAJCBEPPKN, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OOIEIHJBKIB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FCAGMFGOAEH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DEGMPBKJFJH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? CFBFACCAHGG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EAGIBMPBEPB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BKINAHJIICP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LANCELFCBOA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GGCAPINOMCG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? ONPAIJPGJDI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? IBJJACBNJBP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GNEJHHBJOHJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DNEJGDJLLBK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FEMKHMDKDCH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? EBOKDBNGEEL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MEENGFGBMMI, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BDDNLCCFNKP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OPHNNINKJPP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OGOCDCMPDDJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? FLDEIEECJPL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? ADAMDNDCGPB, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? LBGHFMGLFAL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? JFCMABOOLGJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HDBPPPCGPKC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? DKCOCEEHNDP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? NLNOGGODEBG, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BAEJBCDPEMH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? HEKKDNKBGNP, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MOKDGMNAGFH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? GLAJBDMOPFK, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? OAGDBELPBCL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? KALOIJNMFPL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? JOONHAJMHLJ, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PJIFNNMHMFL, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MFBKBGIDIAH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? PMFOKLNHKGH, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? JFCABLHICDC, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BOEIECKIMFE, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? MEPBFOPBMDA, [Optional] IEMOEIMBDGC<TContext, TDeps, TCompileState>? BBHNPKHJOCA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27597D0", Offset = "0x2757FD0", VA = "0x1827597D0")]
	private static int DNHIDDAIAEB([In] PFLMDAPEOIN<byte> MCBIGGDDMJN, PFLMDAPEOIN<byte> FCJOOPHGPGB, int MLFBDFDDHEO, int PCFOAHIEPDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NACMELOECDG
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int CGIMHCDPOGJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39218E0", Offset = "0x39200E0", VA = "0x1839218E0")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<T>> HGJAMOGCHNI<T>([In] this PFLMDAPEOIN<byte> NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3921810", Offset = "0x3920010", VA = "0x183921810")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<T>>> DOLCMDHDEFG<T>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<T>>? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2759630", Offset = "0x2757E30", VA = "0x182759630")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<DPIBNJICMMB>> NKENHGBOIHH(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<DPIBNJICMMB>? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<DPIBNJICMMB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27590B0", Offset = "0x27578B0", VA = "0x1827590B0")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>> DJHPFCELBHJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] float? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2759280", Offset = "0x2757A80", VA = "0x182759280")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>> EGNNEJKCHOI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2759460", Offset = "0x2757C60", VA = "0x182759460")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<NLKMAIFPKGP>> KDNGBBALBEI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<NLKMAIFPKGP>? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<NLKMAIFPKGP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2759360", Offset = "0x2757B60", VA = "0x182759360")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<LNGLEGPBALM>> HOJNFKKOLCD(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] byte? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<LNGLEGPBALM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27591A0", Offset = "0x27579A0", VA = "0x1827591A0")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<ODJMAFEADLC>> DKGLBPECOAI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<ODJMAFEADLC>? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<ODJMAFEADLC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2759540", Offset = "0x2757D40", VA = "0x182759540")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>> NGJIHHJFGFA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] PHNAOPLGEMF? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3921940", Offset = "0x3920140", VA = "0x183921940")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<T>>> NDDGDCJOJGK<T>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<T>>? OPMIAMEJKDH)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27531A0", Offset = "0x27519A0", VA = "0x1827531A0")]
	public static void GKMKBCKADAN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>> DMLOEJODFEO, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39218D0", Offset = "0x39200D0", VA = "0x1839218D0")]
	public static void FBNCFFGLFJE<T>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<T>>> FJLHNHGFGPL, NLPIAAOFKEO<OMMDMCCMKFJ<T>> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39218D0", Offset = "0x39200D0", VA = "0x1839218D0")]
	public static void EODMEOGEMMH<T>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<T>>> EOGEEGLONAC, NLPIAAOFKEO<GGAILHMBCMN<T>> OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HFOCOHKPMPK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2758FA0", Offset = "0x27577A0", VA = "0x182758FA0")]
	public static BJMMIOLMFDK OGKFFAGLCJL([In] this ReadOnlySpan<byte> FLMLKMBDILC, int LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2759010", Offset = "0x2757810", VA = "0x182759010")]
	public static BJMMIOLMFDK OGKFFAGLCJL([In] this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37B0AD0", Offset = "0x37AF2D0", VA = "0x1837B0AD0")]
	public static BJMMIOLMFDK OGKFFAGLCJL<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37B0970", Offset = "0x37AF170", VA = "0x1837B0970")]
	public static BJMMIOLMFDK OGKFFAGLCJL<M>([In] this IIHIILOJPEA<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37B07C0", Offset = "0x37AEFC0", VA = "0x1837B07C0")]
	public static BJMMIOLMFDK OGKFFAGLCJL<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37B0750", Offset = "0x37AEF50", VA = "0x1837B0750")]
	public static BJMMIOLMFDK OGKFFAGLCJL<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37B0C20", Offset = "0x37AF420", VA = "0x1837B0C20")]
	public static BJMMIOLMFDK OGKFFAGLCJL<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2758FA0", Offset = "0x27577A0", VA = "0x182758FA0")]
	public static int IMKFHFIOAPN([In] this ReadOnlySpan<byte> FLMLKMBDILC, int LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27531E0", Offset = "0x27519E0", VA = "0x1827531E0")]
	public static int IMKFHFIOAPN([In] this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x358D340", Offset = "0x358BB40", VA = "0x18358D340")]
	public static int IMKFHFIOAPN<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x358D340", Offset = "0x358BB40", VA = "0x18358D340")]
	public static int IMKFHFIOAPN<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x358D340", Offset = "0x358BB40", VA = "0x18358D340")]
	public static int IMKFHFIOAPN<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x358D340", Offset = "0x358BB40", VA = "0x18358D340")]
	public static int IMKFHFIOAPN<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37B0CE0", Offset = "0x37AF4E0", VA = "0x1837B0CE0")]
	public static float OMEDDIGJFHN<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37B0CE0", Offset = "0x37AF4E0", VA = "0x1837B0CE0")]
	public static float OMEDDIGJFHN<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37B0CE0", Offset = "0x37AF4E0", VA = "0x1837B0CE0")]
	public static float OMEDDIGJFHN<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37B0660", Offset = "0x37AEE60", VA = "0x1837B0660")]
	public static byte HCJFCDKJJFH<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37B0640", Offset = "0x37AEE40", VA = "0x1837B0640")]
	public static byte HCJFCDKJJFH<M>([In] this IIHIILOJPEA<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37B07C0", Offset = "0x37AEFC0", VA = "0x1837B07C0")]
	public static byte HCJFCDKJJFH<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37B0750", Offset = "0x37AEF50", VA = "0x1837B0750")]
	public static byte HCJFCDKJJFH<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37B0690", Offset = "0x37AEE90", VA = "0x1837B0690")]
	public static byte HCJFCDKJJFH<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27531E0", Offset = "0x27519E0", VA = "0x1827531E0")]
	public static PHNAOPLGEMF PCFDMLGBFLM([In] this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA)
	{
		return default(PHNAOPLGEMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x358D340", Offset = "0x358BB40", VA = "0x18358D340")]
	public static PHNAOPLGEMF PCFDMLGBFLM<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(PHNAOPLGEMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37B0480", Offset = "0x37AEC80", VA = "0x1837B0480")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>> ENDBDCEDPPE<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37B0560", Offset = "0x37AED60", VA = "0x1837B0560")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>> ENDBDCEDPPE<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37B04F0", Offset = "0x37AECF0", VA = "0x1837B04F0")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>> ENDBDCEDPPE<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37B0900", Offset = "0x37AF100", VA = "0x1837B0900")]
	public static NLPIAAOFKEO<GGAILHMBCMN<HCECDDAJICM>> MBBIJIOEMIJ<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<GGAILHMBCMN<HCECDDAJICM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37B0410", Offset = "0x37AEC10", VA = "0x1837B0410")]
	public static NLPIAAOFKEO<ODJMAFEADLC> BFOKPLHIOAM<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<ODJMAFEADLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37B03A0", Offset = "0x37AEBA0", VA = "0x1837B03A0")]
	public static NLPIAAOFKEO<ODJMAFEADLC> BFOKPLHIOAM<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<ODJMAFEADLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37B0330", Offset = "0x37AEB30", VA = "0x1837B0330")]
	public static NLPIAAOFKEO<ODJMAFEADLC> BFOKPLHIOAM<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<ODJMAFEADLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37B0890", Offset = "0x37AF090", VA = "0x1837B0890")]
	public static NLPIAAOFKEO<DPIBNJICMMB> JECBHHFLINM<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<DPIBNJICMMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37B0820", Offset = "0x37AF020", VA = "0x1837B0820")]
	public static NLPIAAOFKEO<DPIBNJICMMB> JECBHHFLINM<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<DPIBNJICMMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37B05D0", Offset = "0x37AEDD0", VA = "0x1837B05D0")]
	public static NLPIAAOFKEO<NLKMAIFPKGP> FMLBKAJLHKM<M>(this GKFCELPELJB<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA)
	{
		return default(NLPIAAOFKEO<NLKMAIFPKGP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DDHHCHHBBJO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2758CC0", Offset = "0x27574C0", VA = "0x182758CC0")]
	public static void CGIFJBMMHPA(this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA, BJMMIOLMFDK OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2758D80", Offset = "0x2757580", VA = "0x182758D80")]
	public static void CGIFJBMMHPA(this byte[] FLMLKMBDILC, int LEHJJMPDHIA, BJMMIOLMFDK OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2758C40", Offset = "0x2757440", VA = "0x182758C40")]
	public static void CGIFJBMMHPA([In] this Span<byte> FLMLKMBDILC, int LEHJJMPDHIA, BJMMIOLMFDK OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35D4B20", Offset = "0x35D3320", VA = "0x1835D4B20")]
	public static void CGIFJBMMHPA<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, BJMMIOLMFDK OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35D4980", Offset = "0x35D3180", VA = "0x1835D4980")]
	public static void CGIFJBMMHPA<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, BJMMIOLMFDK OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27531A0", Offset = "0x27519A0", VA = "0x1827531A0")]
	public static void GKMKBCKADAN(this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2758E30", Offset = "0x2757630", VA = "0x182758E30")]
	public static void GKMKBCKADAN(this byte[] FLMLKMBDILC, int LEHJJMPDHIA, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2758EB0", Offset = "0x27576B0", VA = "0x182758EB0")]
	public static void GKMKBCKADAN([In] this Span<byte> FLMLKMBDILC, int LEHJJMPDHIA, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35D4D80", Offset = "0x35D3580", VA = "0x1835D4D80")]
	public static void GKMKBCKADAN<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35D4DE0", Offset = "0x35D35E0", VA = "0x1835D4DE0")]
	public static void GKMKBCKADAN<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2758DF0", Offset = "0x27575F0", VA = "0x182758DF0")]
	public static void DGLFKGOHNPO(this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA, float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35D4CC0", Offset = "0x35D34C0", VA = "0x1835D4CC0")]
	public static void DGLFKGOHNPO<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35D4D20", Offset = "0x35D3520", VA = "0x1835D4D20")]
	public static void DGLFKGOHNPO<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2758F30", Offset = "0x2757730", VA = "0x182758F30")]
	public static void KIPANPOMLIG(this PFLMDAPEOIN<byte> FLMLKMBDILC, int LEHJJMPDHIA, byte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35D4E90", Offset = "0x35D3690", VA = "0x1835D4E90")]
	public static void KIPANPOMLIG<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, byte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35D4E40", Offset = "0x35D3640", VA = "0x1835D4E40")]
	public static void KIPANPOMLIG<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, byte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x358D310", Offset = "0x358BB10", VA = "0x18358D310")]
	public static void FBNCFFGLFJE<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x358D310", Offset = "0x358BB10", VA = "0x18358D310")]
	public static void FBNCFFGLFJE<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, NLPIAAOFKEO<OMMDMCCMKFJ<HCECDDAJICM>> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x358D310", Offset = "0x358BB10", VA = "0x18358D310")]
	public static void MIDHOOJDDJF<M>(this NEEMGKAPJDL<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, NLPIAAOFKEO<ODJMAFEADLC> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x358D310", Offset = "0x358BB10", VA = "0x18358D310")]
	public static void MIDHOOJDDJF<M>([In] this IGLDAEDOIDE<M, byte> FLMLKMBDILC, NLPIAAOFKEO<M> LEHJJMPDHIA, NLPIAAOFKEO<ODJMAFEADLC> OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class APCDEDPDJCD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2753F10", Offset = "0x2752710", VA = "0x182753F10")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) BPPFLBCJHOB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27564E0", Offset = "0x2754CE0", VA = "0x1827564E0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) INBIBENPIFL(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27589D0", Offset = "0x27571D0", VA = "0x1827589D0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) PPDDNBMNDDE(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2754F90", Offset = "0x2753790", VA = "0x182754F90")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) EGMHOOAHLLP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2754900", Offset = "0x2753100", VA = "0x182754900")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) DMKMLBNHLIB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2755DA0", Offset = "0x27545A0", VA = "0x182755DA0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) HJPAOOCBLOP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2755340", Offset = "0x2753B40", VA = "0x182755340")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) EJAPIHFCPGF(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27538D0", Offset = "0x27520D0", VA = "0x1827538D0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BLPDCJJMLKP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2753DF0", Offset = "0x27525F0", VA = "0x182753DF0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BOPADFJPMAJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2754460", Offset = "0x2752C60", VA = "0x182754460")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>) DGIOFBGPFIO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OPMIAMEJKDH, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>? PJPAEEKBMBN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2755EC0", Offset = "0x27546C0", VA = "0x182755EC0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>) HKLFJCMKPFA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? OPMIAMEJKDH, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>? PJPAEEKBMBN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2753660", Offset = "0x2751E60", VA = "0x182753660")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>) BDHJEKKNCAM(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OPMIAMEJKDH, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>? PJPAEEKBMBN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2757DF0", Offset = "0x27565F0", VA = "0x182757DF0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>) OGPDDAJLMOK(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? OPMIAMEJKDH, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>? PJPAEEKBMBN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2757360", Offset = "0x2755B60", VA = "0x182757360")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<DPIBNJICMMB>>) LPOILBKHCIJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OAEJMCCFLMK, [Optional] NLPIAAOFKEO<DPIBNJICMMB>? JPLDGHHMNAI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<DPIBNJICMMB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2756FF0", Offset = "0x27557F0", VA = "0x182756FF0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<DPIBNJICMMB>>>) LFIBBBIMFDF(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OAEJMCCFLMK, [Optional] NLPIAAOFKEO<GGAILHMBCMN<DPIBNJICMMB>>? JPLDGHHMNAI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<DPIBNJICMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2756BA0", Offset = "0x27553A0", VA = "0x182756BA0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<ODJMAFEADLC>>) KLEINKLEMOJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OAEJMCCFLMK, [Optional] NLPIAAOFKEO<ODJMAFEADLC>? JPLDGHHMNAI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<ODJMAFEADLC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2754E80", Offset = "0x2753680", VA = "0x182754E80")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<ODJMAFEADLC>>>) EEOJNJLKLND(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? OAEJMCCFLMK, [Optional] NLPIAAOFKEO<GGAILHMBCMN<ODJMAFEADLC>>? JPLDGHHMNAI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<ODJMAFEADLC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3F0FC90", Offset = "0x3F0E490", VA = "0x183F0FC90")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<NLKMAIFPKGP>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<TMarker>>) LCPPALBFFHA<TMarker>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<NLKMAIFPKGP>? JPLDGHHMNAI, [Optional][In] ReadOnlySpan<byte> NFNBKNAJBPN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<NLKMAIFPKGP>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2756EC0", Offset = "0x27556C0", VA = "0x182756EC0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) KNALHGKMCEP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int MCBIGGDDMJN, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? FCJOOPHGPGB)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2757500", Offset = "0x2755D00", VA = "0x182757500")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) MANHNJENHIC(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? MCBIGGDDMJN, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? FCJOOPHGPGB)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3F0FE90", Offset = "0x3F0E690", VA = "0x183F0FE90")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<TMarker>>) OJINNMOCHNP<TMarker>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<TMarker>>? FCJOOPHGPGB, [Optional] int? LBLAFDELPAC, [Optional][In] ReadOnlySpan<byte> MCBIGGDDMJN)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3F10080", Offset = "0x3F0E880", VA = "0x183F10080")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>) PHDMNAIPADP<TMarker>(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<TMarker>>? MCBIGGDDMJN, [Optional] NLPIAAOFKEO<GGAILHMBCMN<TMarker>>? FCJOOPHGPGB, [Optional] int? LBLAFDELPAC)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<TMarker>>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27554A0", Offset = "0x2753CA0", VA = "0x1827554A0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) ELGDNEMDGMJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2755970", Offset = "0x2754170", VA = "0x182755970")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) GIEKGHNMCIP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27547E0", Offset = "0x2752FE0", VA = "0x1827547E0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) DKNIEAECEKO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2757610", Offset = "0x2755E10", VA = "0x182757610")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) MIDNEPADKNP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2754310", Offset = "0x2752B10", VA = "0x182754310")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) CIOMFONNGCD(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27546C0", Offset = "0x2752EC0", VA = "0x1827546C0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) DHOMJCJIMMM(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2755AC0", Offset = "0x27542C0", VA = "0x182755AC0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) GOIELOBCIJD(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2756260", Offset = "0x2754A60", VA = "0x182756260")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) IHCKEPMBMCN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2754090", Offset = "0x2752890", VA = "0x182754090")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) CAHEFBGEFCL(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27583A0", Offset = "0x2756BA0", VA = "0x1827583A0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>) PELIBOPJDPN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>? PODEOIELEOI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<OMMDMCCMKFJ<EGGBDLJFGCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2755C20", Offset = "0x2754420", VA = "0x182755C20")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) HHOFMFBEEDJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2756100", Offset = "0x2754900", VA = "0x182756100")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) IHCDHLBLNJH(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27550F0", Offset = "0x27538F0", VA = "0x1827550F0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) EIBJJLPLLGB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2753290", Offset = "0x2751A90", VA = "0x182753290")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) ACLFIDNPNCB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27533F0", Offset = "0x2751BF0", VA = "0x1827533F0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) AFNBBBOJNML(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2755730", Offset = "0x2753F30", VA = "0x182755730")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) FLONDCJKFJI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2754A50", Offset = "0x2753250", VA = "0x182754A50")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) DMNALNMJAAP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2756630", Offset = "0x2754E30", VA = "0x182756630")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) JBFBOKBOIJK(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27563B0", Offset = "0x2754BB0", VA = "0x1827563B0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) IMPMNNJLPJO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27579E0", Offset = "0x27561E0", VA = "0x1827579E0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) NKGCOOHCEBA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2754D30", Offset = "0x2753530", VA = "0x182754D30")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) EEGOLKFOJCN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27588B0", Offset = "0x27570B0", VA = "0x1827588B0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) PNNLPMJBCFL(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2756D40", Offset = "0x2755540", VA = "0x182756D40")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) KMHNJMPIIOM(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2753770", Offset = "0x2751F70", VA = "0x182753770")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BGMNMIJNAGH(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2753A20", Offset = "0x2752220", VA = "0x182753A20")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BMHNPGMHNJC(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2757F90", Offset = "0x2756790", VA = "0x182757F90")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) OKACNHNDKBH(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2754570", Offset = "0x2752D70", VA = "0x182754570")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) DHDKOKBICMB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2755850", Offset = "0x2754050", VA = "0x182755850")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) GCBGHLKONPA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27580F0", Offset = "0x27568F0", VA = "0x1827580F0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) OOFMNMPMKPO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2756A40", Offset = "0x2755240", VA = "0x182756A40")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) KIFIDNFIAEI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2758270", Offset = "0x2756A70", VA = "0x182758270")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) PDPIBFBMMMA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2754BD0", Offset = "0x27533D0", VA = "0x182754BD0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) ECHJBOFGGML(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2758490", Offset = "0x2756C90", VA = "0x182758490")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) PKIAHKIHGIN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x27578C0", Offset = "0x27560C0", VA = "0x1827578C0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) NGLGJPIIPEK(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2758730", Offset = "0x2756F30", VA = "0x182758730")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) PMKFJBGJDDK(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27585E0", Offset = "0x2756DE0", VA = "0x1827585E0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) PLFHKIHLEJI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2755FE0", Offset = "0x27547E0", VA = "0x182755FE0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) ICKOPDDFIHI(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x27541B0", Offset = "0x27529B0", VA = "0x1827541B0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) CCNOPILLAGH(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2757100", Offset = "0x2755900", VA = "0x182757100")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) LHAGABBNDGC(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2753540", Offset = "0x2751D40", VA = "0x182753540")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BCHHECLFLHB(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2757250", Offset = "0x2755A50", VA = "0x182757250")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) LNCFAHJHPEM(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] int? CHBILFCJPKJ, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2755620", Offset = "0x2753E20", VA = "0x182755620")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) ENHFGMCIBOO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CHBILFCJPKJ, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2757F10", Offset = "0x2756710", VA = "0x182757F10")]
	public static NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>> OIGEHLHACEJ(this PFLMDAPEOIN<byte> NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2753C70", Offset = "0x2752470", VA = "0x182753C70")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) BOIGFCCGHAD(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, float IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2757B40", Offset = "0x2756340", VA = "0x182757B40")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) NNGDPNBMHPD(this PFLMDAPEOIN<byte> NFOGFJOGLPE, float CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<IPLFOGHBNMC>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2758AF0", Offset = "0x27572F0", VA = "0x182758AF0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>) PPDNEPMLHLN(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<IPLFOGHBNMC>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<IPLFOGHBNMC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2756790", Offset = "0x2754F90", VA = "0x182756790")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) JBKLMOJBAAE(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2757770", Offset = "0x2755F70", VA = "0x182757770")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) NFPGGLMDKGC(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2755220", Offset = "0x2753A20", VA = "0x182755220")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) EIMECJNMBKA(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2757C90", Offset = "0x2756490", VA = "0x182757C90")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) OCOHKODMDHP(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, int IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27568F0", Offset = "0x27550F0", VA = "0x1827568F0")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) JJJHDGAJPPO(this PFLMDAPEOIN<byte> NFOGFJOGLPE, int CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<MJDHOIKNAAD>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2753B50", Offset = "0x2752350", VA = "0x182753B50")]
	public static (NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>) BNAONJNPOJC(this PFLMDAPEOIN<byte> NFOGFJOGLPE, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CMGCFPGCIGC, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? IFMFKAILHFM, [Optional] NLPIAAOFKEO<GGAILHMBCMN<MJDHOIKNAAD>>? CKCDBDPEELI)
	{
		return default((NLPIAAOFKEO<OMMDMCCMKFJ<EGGBDLJFGCA>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>, NLPIAAOFKEO<OMMDMCCMKFJ<GGAILHMBCMN<MJDHOIKNAAD>>>));
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
