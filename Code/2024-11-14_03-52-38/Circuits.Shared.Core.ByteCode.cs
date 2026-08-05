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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x2269C40", Offset = "0x2269040", VA = "0x182269C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CJEFBPJAMAM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9420", Offset = "0x2CA8820", VA = "0x182CA9420")]
	public static KENIFKLGBBB<COLHAMFKPNC<M>> EPBOCNGKPMH<M>(this int EAFEIEDNLNL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22693C0", Offset = "0x22687C0", VA = "0x1822693C0")]
	public static KENIFKLGBBB<FMCGGIEBIOL> BJGCDKDDPDA(this int EAFEIEDNLNL)
	{
		return default(KENIFKLGBBB<FMCGGIEBIOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9420", Offset = "0x2CA8820", VA = "0x182CA9420")]
	public static KENIFKLGBBB<CMDKJDPNNIH<M>> PIFFCOBCFPC<M>(this int EAFEIEDNLNL)
	{
		return default(KENIFKLGBBB<CMDKJDPNNIH<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class COLHAMFKPNC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JMAIEBPHLII
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CBLHJEKHGLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FMCGGIEBIOL
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AFEOKBKKIEF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KIFEOEAGNFE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DMEDKJKKACF
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
public static class EGJFCPKBBPD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct GBCMLHODDNH<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr KNIELIDNDEI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
		public GBCMLHODDNH(IntPtr KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4000850", Offset = "0x3FFFC50", VA = "0x184000850")]
		public int IIFNBMCHKOM(TDeps PJBENGOCCDF, TContext BNMNAILDILO, TCompileState LHBDLHPAAOG, [In] AOEDEFLENLN<byte> ONBBCAFCDML, int CECHBDDIEEC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D2FDE0", Offset = "0x2D2F1E0", VA = "0x182D2FDE0")]
	public static void BPOOKNIHICJ<TDeps, TContext, TCompileState>(TDeps PJBENGOCCDF, TContext BNMNAILDILO, TCompileState LHBDLHPAAOG, [In] AOEDEFLENLN<byte> NACDGGGGLAK, AOEDEFLENLN<byte> INEBGFLFOOC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GNJOLDOAIEF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? POLDFDJIFOK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PJIAFLCCODE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DKCBDJGKBGC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NELOHICPPMF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CBGDPAIGBOB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? KOCBEGCJDIC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MKMLONCKMIC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FBOHECPHNFL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MAHHJBPHPIF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NKFBEJAGGBN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IPPAPCHIEPK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? OFGLDDINMBM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NIDDMAIGHBM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BGAIDGIKJGH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BPFIGAMMJAC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IEPPEPLGJOF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NFGLACEAMIC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LKNLKPMLDIO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MMNCHCIEOCE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NACJNDBKGAO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HNKBEIKFJPB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? KAJIFHPJKNA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FNOIDNHLILH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PEHKPHIPJNP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? OBNHBBMDIGH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PPADEBPGPDC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MIIGFPBFOAG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EDDNHMFHEND, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LDMKGHBPPJM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GINBIPHPAPL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LFJJMKIFFOL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ADDHOELHGLN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? AHKCDPJEEFP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BLKPHOBOENK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CIEDEMPFMPA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JOKBDFBFCMO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LBGHINMACID, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JFHNIACDEND, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HJLFJLGEEJO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IGEOBJOEHKB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BECJCILEDDJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EDENKNKIBBA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CMOEHLMKMEP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NMLFJONEKGL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JGAMNMJDNAG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DIPCILFMCHE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NDEJMOIDBMA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DBHFLCJILAO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CJOEGLKFJNP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NDEGABCLPOG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? INOGFLNJEJM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? KIHCPOAGCKF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NFJMEKBPFHF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DLFGDCGGMEJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IBGDBHHBOAM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? KFMMDAGJMLK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CMOLGLPGFPM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? AOFDGLFOLPD, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JBJBLJPLCCK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EIDMBJCBJHG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FIOAIFLPDIH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HKMJGJLCJDG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HAOMOPAGJKF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BFJCNGCBLMD, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DJCILKLFLOB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HHDEGIKIJPF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IODHMBDOPMO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MLJAJJENPPJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DMBKCDKNILN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ABPNJNILFNL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FLEGEMIBJNF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ILFCPJPAOMD, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PPLFAGEFGCF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DDLGJKEHMND, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ECLGCPDMMMA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? OBHHIOPJPLB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? KPMHCOFFNLI, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FBMBIKDNAFE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CJNINNCBPMJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MHPFDICAGHM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FBEPHFLBAML, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CIGJLAFABHK, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EOMICNEDEIE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EJCPKMOCOEJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? OCODBKGHPMP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JLKJPKPLOAA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? AHKCDJBJKGP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JFNNNOEOLJH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PKPHAODAHBF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MHGLIDOHOEJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NNDNCMKODJH, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DMEMJIKGDPF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MMJOEAMGHIP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DOIIGFAPHJA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? AACDMAJAMJE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HFIOCLIBGAO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CEADALDMMKG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ECPHLCALIHJ, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ADCHFDEPDBC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? OPMADBPPCMI, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? MNHOHNCDIKB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EIKGKJAJLIN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JKAPMCFGDOP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? EINJNKJPDPP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DMGLBNOBFJG, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ABOAPHKBOAM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BAKEDFJDGLA, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BCJGMLHIFPP, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LICJNOMOBPD, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DKCIPGGHLEE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? IGDDGPAHAPE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FMGCEOPGFME, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GODEBPECAIL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GKHLIMLOFBC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DBFOEFOGBPM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JMFABFPFOED, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FIDJLFMAOHI, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GJMAGKIFLIF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? JOLIEALMNAB, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? GODEAJBGLAI, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? FKCBFGCBIOL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NPAGFGHJODM, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CBLLPCHJBGC, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HALKNDILJON, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? LDJJLCMNDDI, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NBHEMJPPENL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? BDCIDPPLPLE, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? CDEOECPGMFO, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? HPCHNKIGCIN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PKIMNNLAGLN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? ILHJLMLEAEN, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? PEPPFCCABHL, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? DHPGIMJGGEF, [Optional] GBCMLHODDNH<TContext, TDeps, TCompileState>? NFLDMOFNAFD) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22693F0", Offset = "0x22687F0", VA = "0x1822693F0")]
	private static int BHILNDBFPDF([In] AOEDEFLENLN<byte> DDHIPMFIJHI, AOEDEFLENLN<byte> FMMMPENKMMF, int ICLFANODKJK, int GMOPHNCDIJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IAINMLCILDE
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int PBAAJOFNMDF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC220", Offset = "0x2EDB620", VA = "0x182EDC220")]
	public static KENIFKLGBBB<COLHAMFKPNC<T>> IGJFPEMBJOB<T>([In] this AOEDEFLENLN<byte> EAFEIEDNLNL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC160", Offset = "0x2EDB560", VA = "0x182EDC160")]
	public static KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<T>>> HBPHKJKPBEB<T>(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<COLHAMFKPNC<T>>? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2269660", Offset = "0x2268A60", VA = "0x182269660")]
	public static KENIFKLGBBB<COLHAMFKPNC<HCFPEDLOFDD>> FEDJJPLADKA(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<HCFPEDLOFDD>? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<HCFPEDLOFDD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2269570", Offset = "0x2268970", VA = "0x182269570")]
	public static KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>> EFDCCPEHPOM(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] float? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2269490", Offset = "0x2268890", VA = "0x182269490")]
	public static KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>> DLONNLHILPN(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2269A10", Offset = "0x2268E10", VA = "0x182269A10")]
	public static KENIFKLGBBB<COLHAMFKPNC<MIOJPEDADND>> NOLNPBLHKGP(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<MIOJPEDADND>? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<MIOJPEDADND>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2269830", Offset = "0x2268C30", VA = "0x182269830")]
	public static KENIFKLGBBB<COLHAMFKPNC<KIFEOEAGNFE>> IJMOBJNIIAG(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] byte? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<KIFEOEAGNFE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2269930", Offset = "0x2268D30", VA = "0x182269930")]
	public static KENIFKLGBBB<COLHAMFKPNC<FMCGGIEBIOL>> MIBBNIBMBCF(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<FMCGGIEBIOL>? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<FMCGGIEBIOL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2269740", Offset = "0x2268B40", VA = "0x182269740")]
	public static KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>> HHCNAFPGGKO(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] DMEDKJKKACF? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC290", Offset = "0x2EDB690", VA = "0x182EDC290")]
	public static KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<T>>> MANEIEAKMHE<T>(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<T>>? PFKKDHPJFEH)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2269380", Offset = "0x2268780", VA = "0x182269380")]
	public static void MHEBNHABFFH(this AOEDEFLENLN<byte> EAFEIEDNLNL, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>> CIBJGPBGCNO, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC280", Offset = "0x2EDB680", VA = "0x182EDC280")]
	public static void MBLAKBDGNCE<T>(this AOEDEFLENLN<byte> EAFEIEDNLNL, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<T>>> CECHBDDIEEC, KENIFKLGBBB<COLHAMFKPNC<T>> PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC280", Offset = "0x2EDB680", VA = "0x182EDC280")]
	public static void ILADDKLFNAI<T>(this AOEDEFLENLN<byte> EAFEIEDNLNL, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<T>>> NIGBIOIPDIM, KENIFKLGBBB<CMDKJDPNNIH<T>> PFKKDHPJFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IJHJPCLDJKM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2269B30", Offset = "0x2268F30", VA = "0x182269B30")]
	public static GOIMCPNPDHP OPIPOBPMBPP([In] this ReadOnlySpan<byte> HFBIMFCNCFE, int HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2269BA0", Offset = "0x2268FA0", VA = "0x182269BA0")]
	public static GOIMCPNPDHP OPIPOBPMBPP([In] this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3730", Offset = "0x2EE2B30", VA = "0x182EE3730")]
	public static GOIMCPNPDHP OPIPOBPMBPP<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE35D0", Offset = "0x2EE29D0", VA = "0x182EE35D0")]
	public static GOIMCPNPDHP OPIPOBPMBPP<M>([In] this LIKLOGHICMO<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3490", Offset = "0x2EE2890", VA = "0x182EE3490")]
	public static GOIMCPNPDHP OPIPOBPMBPP<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3360", Offset = "0x2EE2760", VA = "0x182EE3360")]
	public static GOIMCPNPDHP OPIPOBPMBPP<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3880", Offset = "0x2EE2C80", VA = "0x182EE3880")]
	public static GOIMCPNPDHP OPIPOBPMBPP<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2269B30", Offset = "0x2268F30", VA = "0x182269B30")]
	public static int AFOHCOHJGMA([In] this ReadOnlySpan<byte> HFBIMFCNCFE, int HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2269210", Offset = "0x2268610", VA = "0x182269210")]
	public static int AFOHCOHJGMA([In] this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F20", Offset = "0x2EE2320", VA = "0x182EE2F20")]
	public static int AFOHCOHJGMA<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F20", Offset = "0x2EE2320", VA = "0x182EE2F20")]
	public static int AFOHCOHJGMA<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F20", Offset = "0x2EE2320", VA = "0x182EE2F20")]
	public static int AFOHCOHJGMA<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F20", Offset = "0x2EE2320", VA = "0x182EE2F20")]
	public static int AFOHCOHJGMA<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F50", Offset = "0x2EE2350", VA = "0x182EE2F50")]
	public static float BPDGGLOICAA<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F50", Offset = "0x2EE2350", VA = "0x182EE2F50")]
	public static float BPDGGLOICAA<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F50", Offset = "0x2EE2350", VA = "0x182EE2F50")]
	public static float BPDGGLOICAA<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3330", Offset = "0x2EE2730", VA = "0x182EE3330")]
	public static byte NIOJJEGCNNG<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3310", Offset = "0x2EE2710", VA = "0x182EE3310")]
	public static byte NIOJJEGCNNG<M>([In] this LIKLOGHICMO<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3490", Offset = "0x2EE2890", VA = "0x182EE3490")]
	public static byte NIOJJEGCNNG<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3360", Offset = "0x2EE2760", VA = "0x182EE3360")]
	public static byte NIOJJEGCNNG<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE33D0", Offset = "0x2EE27D0", VA = "0x182EE33D0")]
	public static byte NIOJJEGCNNG<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2269210", Offset = "0x2268610", VA = "0x182269210")]
	public static DMEDKJKKACF FAEPGFEIGEK([In] this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL)
	{
		return default(DMEDKJKKACF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F20", Offset = "0x2EE2320", VA = "0x182EE2F20")]
	public static DMEDKJKKACF FAEPGFEIGEK<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(DMEDKJKKACF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3070", Offset = "0x2EE2470", VA = "0x182EE3070")]
	public static KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>> LDNFALLDGPN<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3150", Offset = "0x2EE2550", VA = "0x182EE3150")]
	public static KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>> LDNFALLDGPN<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EE30E0", Offset = "0x2EE24E0", VA = "0x182EE30E0")]
	public static KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>> LDNFALLDGPN<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F90", Offset = "0x2EE2390", VA = "0x182EE2F90")]
	public static KENIFKLGBBB<CMDKJDPNNIH<CPKABOJGDDM>> FPHENABHHOK<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<CMDKJDPNNIH<CPKABOJGDDM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EE31C0", Offset = "0x2EE25C0", VA = "0x182EE31C0")]
	public static KENIFKLGBBB<FMCGGIEBIOL> NGPGGNFDIKH<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<FMCGGIEBIOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3230", Offset = "0x2EE2630", VA = "0x182EE3230")]
	public static KENIFKLGBBB<FMCGGIEBIOL> NGPGGNFDIKH<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<FMCGGIEBIOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EE32A0", Offset = "0x2EE26A0", VA = "0x182EE32A0")]
	public static KENIFKLGBBB<FMCGGIEBIOL> NGPGGNFDIKH<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<FMCGGIEBIOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EE34F0", Offset = "0x2EE28F0", VA = "0x182EE34F0")]
	public static KENIFKLGBBB<HCFPEDLOFDD> OMJIBGHPMOE<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<HCFPEDLOFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3560", Offset = "0x2EE2960", VA = "0x182EE3560")]
	public static KENIFKLGBBB<HCFPEDLOFDD> OMJIBGHPMOE<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<HCFPEDLOFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3000", Offset = "0x2EE2400", VA = "0x182EE3000")]
	public static KENIFKLGBBB<MIOJPEDADND> KBCBBJEHOBB<M>(this BGMIADDEGIF<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL)
	{
		return default(KENIFKLGBBB<MIOJPEDADND>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PCPIHCLODIL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x226F7A0", Offset = "0x226EBA0", VA = "0x18226F7A0")]
	public static void GGGMCJMGJLC(this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL, GOIMCPNPDHP PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x226F730", Offset = "0x226EB30", VA = "0x18226F730")]
	public static void GGGMCJMGJLC(this byte[] HFBIMFCNCFE, int HMGPCAGLHGL, GOIMCPNPDHP PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x226F6B0", Offset = "0x226EAB0", VA = "0x18226F6B0")]
	public static void GGGMCJMGJLC([In] this Span<byte> HFBIMFCNCFE, int HMGPCAGLHGL, GOIMCPNPDHP PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x309B330", Offset = "0x309A730", VA = "0x18309B330")]
	public static void GGGMCJMGJLC<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, GOIMCPNPDHP PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x309B190", Offset = "0x309A590", VA = "0x18309B190")]
	public static void GGGMCJMGJLC<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, GOIMCPNPDHP PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2269380", Offset = "0x2268780", VA = "0x182269380")]
	public static void MHEBNHABFFH(this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x226F8A0", Offset = "0x226ECA0", VA = "0x18226F8A0")]
	public static void MHEBNHABFFH(this byte[] HFBIMFCNCFE, int HMGPCAGLHGL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x226F920", Offset = "0x226ED20", VA = "0x18226F920")]
	public static void MHEBNHABFFH([In] this Span<byte> HFBIMFCNCFE, int HMGPCAGLHGL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x309B5F0", Offset = "0x309A9F0", VA = "0x18309B5F0")]
	public static void MHEBNHABFFH<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x309B590", Offset = "0x309A990", VA = "0x18309B590")]
	public static void MHEBNHABFFH<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x226F860", Offset = "0x226EC60", VA = "0x18226F860")]
	public static void LHODJDIHGIM(this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x309B4D0", Offset = "0x309A8D0", VA = "0x18309B4D0")]
	public static void LHODJDIHGIM<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x309B530", Offset = "0x309A930", VA = "0x18309B530")]
	public static void LHODJDIHGIM<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x226F640", Offset = "0x226EA40", VA = "0x18226F640")]
	public static void AMPLNLNINLN(this AOEDEFLENLN<byte> HFBIMFCNCFE, int HMGPCAGLHGL, byte PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x309B140", Offset = "0x309A540", VA = "0x18309B140")]
	public static void AMPLNLNINLN<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, byte PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x309B0F0", Offset = "0x309A4F0", VA = "0x18309B0F0")]
	public static void AMPLNLNINLN<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, byte PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F08020", Offset = "0x2F07420", VA = "0x182F08020")]
	public static void MBLAKBDGNCE<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>> PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2F08020", Offset = "0x2F07420", VA = "0x182F08020")]
	public static void MBLAKBDGNCE<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, KENIFKLGBBB<COLHAMFKPNC<CPKABOJGDDM>> PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F08020", Offset = "0x2F07420", VA = "0x182F08020")]
	public static void CHOJOGEMCNM<M>(this NFAHJJHODAG<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, KENIFKLGBBB<FMCGGIEBIOL> PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F08020", Offset = "0x2F07420", VA = "0x182F08020")]
	public static void CHOJOGEMCNM<M>([In] this AOGEDDGJEGH<M, byte> HFBIMFCNCFE, KENIFKLGBBB<M> HMGPCAGLHGL, KENIFKLGBBB<FMCGGIEBIOL> PFKKDHPJFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OJBBFHFIBON
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x226B990", Offset = "0x226AD90", VA = "0x18226B990")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) GMPJLDEHGEE(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x226BB10", Offset = "0x226AF10", VA = "0x18226BB10")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) GNFCEKBDALI(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x226A6E0", Offset = "0x2269AE0", VA = "0x18226A6E0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) DEJDHLJPAPF(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x226CA90", Offset = "0x226BE90", VA = "0x18226CA90")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) IBFIOHEEBKL(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x226C7A0", Offset = "0x226BBA0", VA = "0x18226C7A0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HPPHOBEPPJK(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x226C2A0", Offset = "0x226B6A0", VA = "0x18226C2A0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HIECFGACGKJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2269CC0", Offset = "0x22690C0", VA = "0x182269CC0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) AIIBKOMOACN(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x226EC20", Offset = "0x226E020", VA = "0x18226EC20")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) OFBKMPINDGM(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x226E5E0", Offset = "0x226D9E0", VA = "0x18226E5E0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) MODACLEOBOD(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x226A480", Offset = "0x2269880", VA = "0x18226A480")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>) CHJENCHPPBB(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PFKKDHPJFEH, [Optional] KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>? NANKEAAHFOL)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x226F290", Offset = "0x226E690", VA = "0x18226F290")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>) PCCCBEOAGPH(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? PFKKDHPJFEH, [Optional] KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>? NANKEAAHFOL)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x226F530", Offset = "0x226E930", VA = "0x18226F530")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>) PECHCAKKHPL(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PFKKDHPJFEH, [Optional] KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>? NANKEAAHFOL)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x226A960", Offset = "0x2269D60", VA = "0x18226A960")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>) DKKCFCHILDC(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? PFKKDHPJFEH, [Optional] KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>? NANKEAAHFOL)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x226E330", Offset = "0x226D730", VA = "0x18226E330")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<HCFPEDLOFDD>>) MMAAKLHMGII(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PBABCMCJJCG, [Optional] KENIFKLGBBB<HCFPEDLOFDD>? FDHGHLDCDAN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<HCFPEDLOFDD>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x226E4D0", Offset = "0x226D8D0", VA = "0x18226E4D0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<HCFPEDLOFDD>>>) MNCFFDNFKJH(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PBABCMCJJCG, [Optional] KENIFKLGBBB<CMDKJDPNNIH<HCFPEDLOFDD>>? FDHGHLDCDAN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<HCFPEDLOFDD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x226C8F0", Offset = "0x226BCF0", VA = "0x18226C8F0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<FMCGGIEBIOL>>) IAFAOEHGHFD(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PBABCMCJJCG, [Optional] KENIFKLGBBB<FMCGGIEBIOL>? FDHGHLDCDAN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<FMCGGIEBIOL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x226C510", Offset = "0x226B910", VA = "0x18226C510")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<FMCGGIEBIOL>>>) HNGMDEBCAMP(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? PBABCMCJJCG, [Optional] KENIFKLGBBB<CMDKJDPNNIH<FMCGGIEBIOL>>? FDHGHLDCDAN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<FMCGGIEBIOL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30952B0", Offset = "0x30946B0", VA = "0x1830952B0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<MIOJPEDADND>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<TMarker>>) KBKGACPHDFA<TMarker>(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<MIOJPEDADND>? FDHGHLDCDAN, [Optional][In] ReadOnlySpan<byte> EIFGKHNPLEK)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<MIOJPEDADND>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x226B080", Offset = "0x226A480", VA = "0x18226B080")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) EOBBOLCCMFJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, int DDHIPMFIJHI, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? FMMMPENKMMF)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x226C190", Offset = "0x226B590", VA = "0x18226C190")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HHGFMIMOIDI(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? DDHIPMFIJHI, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? FMMMPENKMMF)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30954B0", Offset = "0x30948B0", VA = "0x1830954B0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<TMarker>>) NPFHPIFPJBC<TMarker>(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<TMarker>>? FMMMPENKMMF, [Optional] int? JKIIGJDNBMO, [Optional][In] ReadOnlySpan<byte> DDHIPMFIJHI)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3095160", Offset = "0x3094560", VA = "0x183095160")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>) EJEMFLMKDBD<TMarker>(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<TMarker>>? DDHIPMFIJHI, [Optional] KENIFKLGBBB<CMDKJDPNNIH<TMarker>>? FMMMPENKMMF, [Optional] int? JKIIGJDNBMO)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<TMarker>>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x226E0A0", Offset = "0x226D4A0", VA = "0x18226E0A0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) LPDGLMNKBOB(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x226A590", Offset = "0x2269990", VA = "0x18226A590")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) CIMJBIEEIJJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2269E20", Offset = "0x2269220", VA = "0x182269E20")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) AKMPDKAKHIC(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x226C030", Offset = "0x226B430", VA = "0x18226C030")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HGIBJMDNFKD(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x226DF50", Offset = "0x226D350", VA = "0x18226DF50")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) LNIKHPFBCGI(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x226D8F0", Offset = "0x226CCF0", VA = "0x18226D8F0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) KLCBGNJECAI(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x226B1B0", Offset = "0x226A5B0", VA = "0x18226B1B0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) FBGBJPPIDEO(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x226CD10", Offset = "0x226C110", VA = "0x18226CD10")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) IIGLJPCDFIN(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x226AF60", Offset = "0x226A360", VA = "0x18226AF60")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) EINBDFNDOLF(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x226BDC0", Offset = "0x226B1C0", VA = "0x18226BDC0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>) HDDLAMAKFPK(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>? COEKELBCOGG)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<COLHAMFKPNC<AFEOKBKKIEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x226BEB0", Offset = "0x226B2B0", VA = "0x18226BEB0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HGFOHEOOLKF(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x226EFD0", Offset = "0x226E3D0", VA = "0x18226EFD0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) OJHDLKPOIBC(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x226B310", Offset = "0x226A710", VA = "0x18226B310")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) FDEKECMMDLD(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x226A180", Offset = "0x2269580", VA = "0x18226A180")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) BGPPGIAOIGM(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x226AA80", Offset = "0x2269E80", VA = "0x18226AA80")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) EBGDPELMKDA(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2269F40", Offset = "0x2269340", VA = "0x182269F40")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) AOPDNCDLCGM(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x226C620", Offset = "0x226BA20", VA = "0x18226C620")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HOOGIBGLMPB(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x226B6D0", Offset = "0x226AAD0", VA = "0x18226B6D0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) GKFNCFJCFIG(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x226B5A0", Offset = "0x226A9A0", VA = "0x18226B5A0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) FNFFNAFBFFD(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x226F130", Offset = "0x226E530", VA = "0x18226F130")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) PANDNHHIDHP(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x226AE10", Offset = "0x226A210", VA = "0x18226AE10")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) EFIGPPGDJPH(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x226D7D0", Offset = "0x226CBD0", VA = "0x18226D7D0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) KFBMMLEKIHK(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x226D400", Offset = "0x226C800", VA = "0x18226D400")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) KCPHMGIOLIK(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x226DA10", Offset = "0x226CE10", VA = "0x18226DA10")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) KOEKOPONFGD(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x226D6A0", Offset = "0x226CAA0", VA = "0x18226D6A0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) KEKGHOPIGBG(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x226E700", Offset = "0x226DB00", VA = "0x18226E700")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) NELDLLDIIEP(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x226D130", Offset = "0x226C530", VA = "0x18226D130")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) JPFGALIFAFB(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x226ABD0", Offset = "0x2269FD0", VA = "0x18226ABD0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) ECKMDABFEFN(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x226CFB0", Offset = "0x226C3B0", VA = "0x18226CFB0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) JCMBKAMCFPF(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x226A800", Offset = "0x2269C00", VA = "0x18226A800")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) DEMGLAJMFKA(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x226DE20", Offset = "0x226D220", VA = "0x18226DE20")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) LMJDCPLLPGE(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x226B440", Offset = "0x226A840", VA = "0x18226B440")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) FMDCAHJAOKL(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x226DCD0", Offset = "0x226D0D0", VA = "0x18226DCD0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) LINJHAIGBIK(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x226CBF0", Offset = "0x226BFF0", VA = "0x18226CBF0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) IIACGOCEBJD(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x226F3B0", Offset = "0x226E7B0", VA = "0x18226F3B0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) PEBIFBKPHCC(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x226CE60", Offset = "0x226C260", VA = "0x18226CE60")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) IKEGLFJGJIP(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x226A2E0", Offset = "0x22696E0", VA = "0x18226A2E0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) BJJCNEGPGMF(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x226BC60", Offset = "0x226B060", VA = "0x18226BC60")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) HAMEFAOKNJC(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x226EAD0", Offset = "0x226DED0", VA = "0x18226EAD0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) ODONFEAMHDL(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x226E9B0", Offset = "0x226DDB0", VA = "0x18226E9B0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) OBGAEMJGOAM(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x226E220", Offset = "0x226D620", VA = "0x18226E220")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) MHLJOOMGMKH(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] int? NEFOAKKBEJJ, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x226ED70", Offset = "0x226E170", VA = "0x18226ED70")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) OFILIPBHDLI(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? NEFOAKKBEJJ, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x226A400", Offset = "0x2269800", VA = "0x18226A400")]
	public static KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>> BNCJNCCFBGG(this AOEDEFLENLN<byte> EAFEIEDNLNL)
	{
		return default(KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x226D280", Offset = "0x226C680", VA = "0x18226D280")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) KBMBAIPGJFJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, float BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x226C3C0", Offset = "0x226B7C0", VA = "0x18226C3C0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) HKOPJLIMAPJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, float EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<JMAIEBPHLII>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x226D580", Offset = "0x226C980", VA = "0x18226D580")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>) KDGPPCAINLH(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<JMAIEBPHLII>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<JMAIEBPHLII>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x226B830", Offset = "0x226AC30", VA = "0x18226B830")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) GLPEMPMJHPG(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x226EE80", Offset = "0x226E280", VA = "0x18226EE80")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) OGNBCFCMMEN(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x226A060", Offset = "0x2269460", VA = "0x18226A060")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) BDNMPIOBJMJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x226DB70", Offset = "0x226CF70", VA = "0x18226DB70")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) LAJJIPFNFLI(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, int BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x226E860", Offset = "0x226DC60", VA = "0x18226E860")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) NJNGLCKABJJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, int EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CBLHJEKHGLP>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x226ACF0", Offset = "0x226A0F0", VA = "0x18226ACF0")]
	public static (KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>) EDHNDHKKBEJ(this AOEDEFLENLN<byte> EAFEIEDNLNL, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? EBJHHOEFAKE, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? BPGHACFGOJM, [Optional] KENIFKLGBBB<CMDKJDPNNIH<CBLHJEKHGLP>>? KMPBFAIOGFN)
	{
		return default((KENIFKLGBBB<COLHAMFKPNC<AFEOKBKKIEF>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>, KENIFKLGBBB<COLHAMFKPNC<CMDKJDPNNIH<CBLHJEKHGLP>>>));
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
