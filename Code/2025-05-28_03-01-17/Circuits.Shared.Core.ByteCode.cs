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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x281FBD0", Offset = "0x281E9D0", VA = "0x18281FBD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PPLGNFHHNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36A6380", Offset = "0x36A5180", VA = "0x1836A6380")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<M>> OADHILKDJHI<M>(this int FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x281FC50", Offset = "0x281EA50", VA = "0x18281FC50")]
	public static BIHBDMOHDCK<MMOKPEAHMGL> BGICIAOEANA(this int FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<MMOKPEAHMGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36A6380", Offset = "0x36A5180", VA = "0x1836A6380")]
	public static BIHBDMOHDCK<GMNLJAHBCBI<M>> PGKEDOONMJE<M>(this int FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<GMNLJAHBCBI<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ADGOJNBMGKF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GNDNLMBCEPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GKJLLMDLJCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MMOKPEAHMGL
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NEDINALJBEL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HOLFJIAIAIA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KHDEHODKHGE
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
public static class NPMOIFAGFDP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct EIGCKKJPAJA<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr CKAKNAJCEKE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
		public EIGCKKJPAJA(IntPtr OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x460A8C0", Offset = "0x46096C0", VA = "0x18460A8C0")]
		public int HDKOJPGLKCE(TDeps JCFBNAHPHAO, TContext OHIGDHLLFPD, TCompileState KLOOJMLFHKG, [In] ILLOCPJIIID<byte> AJPCHHOEFMB, int IGIBHMMKJBK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1580", Offset = "0x3AD0380", VA = "0x183AD1580")]
	public static void CLCGFOEKACH<TDeps, TContext, TCompileState>(TDeps JCFBNAHPHAO, TContext OHIGDHLLFPD, TCompileState KLOOJMLFHKG, [In] ILLOCPJIIID<byte> MLKPCDIJMFJ, ILLOCPJIIID<byte> PALKBCPCBEO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NMKHJKKPMCP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FCDMAGIIILM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MLHHHCEDOOM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GKDEDJNAGMP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FGJCBFKONGF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KODACFKABEL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GJLGHFNFNNB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NKMCIPIKNAI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LLILNBCGCNB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OBOHDMCCAMG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LNIJPCDHBFN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BDDCAHELKMC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BBKJACBLIAK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PJJNOCPDPDH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NFMBMKLDGOM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BMFLJKCCEHN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BDDELNKDJKH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PEALJNMMOOH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KKPFNGEJOLA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NEHPNADDLJO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? IPPNAHMJPFD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KCEIMBHIMFL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DPEJBHCMDII, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PMOKBDCOILM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BPNEDLCHMEM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CEAGDKOJCNN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HGNBJEMJDFH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BLPNMEAINOJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LLABKPGNPLA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CPIIIPAINLI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GDCKOKDDJEO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AKCGJPBACAH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MFGHJEFGKCF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CLBIBIDFDEA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DEGFAMIOONC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CEDMAHKDHOH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? COJHGDGLNNC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OLMNODDICIP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OEEGPLCNDBO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BAOFNJLMNKH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DDJBHEANECJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CCODGEFJOJP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FFIFNMIONCC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LOHELFGKNEK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JGPOODHGBJG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MGLFKJPOAML, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NGPHEBEDPBB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OCINGJDHEIK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LBBMEOANBBN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AFLNHGAMEMH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AADHHPADDBD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NPJKGJPMGNK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? IFKCJKKMEOL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BLHKDNHPFDG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BHBHGAHEBJJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DJIJBCEHEJI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MPOCHLCKDCL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MMPPLFHONCN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OPOLFPPNCAA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NCOLBHIBMJG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MAHMDIPPLOA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PALKDBLFLLB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DFOOPDJCCCP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? EAKKCLNIABK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JGGIJOODECI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MHEJGKLMBKI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JOEJEJGBKBB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FBDNKICBIBF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LOMKFHAEAKF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BEBIMGDFFLF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DDIIIDFHBLP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MBNGGABOKON, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? EIHELLJNLOC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KFMAONLKKBO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HAJCFJJCOCC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CPPPOGMKMMP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KDLLJPIGIJN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LICIKPBBMKL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PABFGACHDBJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GIJBAJNOJNO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HGHCPLAGCCC, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DBINKKNBAJN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LDALLGDGAGL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LMBLBMIPONK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PFEFICOJIBL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JNDGLOKDLGA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BOBIKHPHNHM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? EDLNEJGLKMJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KAHKJPCINKA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DCLLMBECPML, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KALKAPKEGHD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OGBBDJACPPH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? EMHKHOJDNJI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FFHAFHAKOJN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GKPADNCKMKD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FDPDDEOJMGP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GFMLDPJHANK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JMBOLOEDIGJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? EDMINLLIIKO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CGMPBIPGIOL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NMHHCOCAPML, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? IDHMFFCOHAG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LGHMEPIBAHN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KAFLNKKFGLD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NHCGKJNGMHK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KGMPPDEEKAL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AJNEEENDBAE, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? PEMHEEIBOAG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OOOAHBJCGPA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KCEMBECPFCI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HCAENMNJGEB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CBBIEFMLFCN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JKBIKBIKMKB, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BEFKDNDNBDF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LMAFLLBHLJK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HBDEDEAFDPO, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? CMOBOOEEKGN, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? HDLCICBMKOD, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AJPJPOBLAMF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JAILDKEKKKM, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? JAJNGKFEFFF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? OOODKNLDJKP, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? AOFHGJAIPNH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NFNMGPEEGHA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? NJNDMAIGLJK, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LFBKIBPLGDH, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? LKIMNPDIPLJ, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MMCDEEFGIND, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BAPKGOHCLDL, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? BLCJAMCPJAI, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? FOOIHFEJKAF, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? DHIOPBECOHE, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? GJGEMAMNGNG, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? KNAJODFEDEA, [Optional] EIGCKKJPAJA<TContext, TDeps, TCompileState>? MHPAMBIEDEA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x281FB30", Offset = "0x281E930", VA = "0x18281FB30")]
	private static int AIPEMNENGAH([In] ILLOCPJIIID<byte> HLHNGKLKCFJ, ILLOCPJIIID<byte> GJCHJCHAFHC, int GNMMLFONKNO, int ALFGNAHPKIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KAPEFIJMNPI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int KMNMCIGEFGO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39C27B0", Offset = "0x39C15B0", VA = "0x1839C27B0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<T>> POCENHNPNCI<T>([In] this ILLOCPJIIID<byte> FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39C26F0", Offset = "0x39C14F0", VA = "0x1839C26F0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<T>>> MGPFEGFEJJA<T>(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<T>>? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x281F2F0", Offset = "0x281E0F0", VA = "0x18281F2F0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<INPOHEFJEKC>> KNDFNAHDCPN(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<INPOHEFJEKC>? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<INPOHEFJEKC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x281F3D0", Offset = "0x281E1D0", VA = "0x18281F3D0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>> NNCIOBNHKPL(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] float? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x281F130", Offset = "0x281DF30", VA = "0x18281F130")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>> GFIGOIMKHHG(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x281F6B0", Offset = "0x281E4B0", VA = "0x18281F6B0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>> PNDPJEHOCKP(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<COMGLGJNOJA>? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x281F5B0", Offset = "0x281E3B0", VA = "0x18281F5B0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<HOLFJIAIAIA>> PKIOKGJNKPP(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] byte? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<HOLFJIAIAIA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x281F210", Offset = "0x281E010", VA = "0x18281F210")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<MMOKPEAHMGL>> JOGAPADFDOL(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<MMOKPEAHMGL>? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<MMOKPEAHMGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x281F4C0", Offset = "0x281E2C0", VA = "0x18281F4C0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> OJLCPLEDKMD(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] KHDEHODKHGE? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x39C2630", Offset = "0x39C1430", VA = "0x1839C2630")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<T>>> DGADMPCHAPE<T>(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<T>>? OAIIHELJHLG)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2819660", Offset = "0x2818460", VA = "0x182819660")]
	public static void HJCHGKFBLJL(this ILLOCPJIIID<byte> FPFHIDBMBMI, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>> MOPBGBMPMIP, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39C2620", Offset = "0x39C1420", VA = "0x1839C2620")]
	public static void ACKDJNJHCPD<T>(this ILLOCPJIIID<byte> FPFHIDBMBMI, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<T>>> IGIBHMMKJBK, BIHBDMOHDCK<ADGOJNBMGKF<T>> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39C2620", Offset = "0x39C1420", VA = "0x1839C2620")]
	public static void EENPJOEEIAI<T>(this ILLOCPJIIID<byte> FPFHIDBMBMI, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<T>>> BFKOHKNHFDP, BIHBDMOHDCK<GMNLJAHBCBI<T>> OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JEDENLKHEDM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x281F020", Offset = "0x281DE20", VA = "0x18281F020")]
	public static JGAKLEJADPA FNJNAMCFFLA([In] this ReadOnlySpan<byte> HNAKMABCJKP, int EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x281F090", Offset = "0x281DE90", VA = "0x18281F090")]
	public static JGAKLEJADPA FNJNAMCFFLA([In] this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3984450", Offset = "0x3983250", VA = "0x183984450")]
	public static JGAKLEJADPA FNJNAMCFFLA<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3984730", Offset = "0x3983530", VA = "0x183984730")]
	public static JGAKLEJADPA FNJNAMCFFLA<M>([In] this GCFODDEFLDJ<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39846D0", Offset = "0x39834D0", VA = "0x1839846D0")]
	public static JGAKLEJADPA FNJNAMCFFLA<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3984660", Offset = "0x3983460", VA = "0x183984660")]
	public static JGAKLEJADPA FNJNAMCFFLA<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39845A0", Offset = "0x39833A0", VA = "0x1839845A0")]
	public static JGAKLEJADPA FNJNAMCFFLA<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x281F020", Offset = "0x281DE20", VA = "0x18281F020")]
	public static int LINIFJIDJMP([In] this ReadOnlySpan<byte> HNAKMABCJKP, int EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2819590", Offset = "0x2818390", VA = "0x182819590")]
	public static int LINIFJIDJMP([In] this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A5030", VA = "0x1836A6230")]
	public static int LINIFJIDJMP<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A5030", VA = "0x1836A6230")]
	public static int LINIFJIDJMP<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A5030", VA = "0x1836A6230")]
	public static int LINIFJIDJMP<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A5030", VA = "0x1836A6230")]
	public static int LINIFJIDJMP<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3984890", Offset = "0x3983690", VA = "0x183984890")]
	public static float IHJJKOKANNI<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3984890", Offset = "0x3983690", VA = "0x183984890")]
	public static float IHJJKOKANNI<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3984890", Offset = "0x3983690", VA = "0x183984890")]
	public static float IHJJKOKANNI<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3984B50", Offset = "0x3983950", VA = "0x183984B50")]
	public static byte OKAPNLNKPOJ<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3984B80", Offset = "0x3983980", VA = "0x183984B80")]
	public static byte OKAPNLNKPOJ<M>([In] this GCFODDEFLDJ<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x39846D0", Offset = "0x39834D0", VA = "0x1839846D0")]
	public static byte OKAPNLNKPOJ<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3984660", Offset = "0x3983460", VA = "0x183984660")]
	public static byte OKAPNLNKPOJ<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3984A90", Offset = "0x3983890", VA = "0x183984A90")]
	public static byte OKAPNLNKPOJ<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2819590", Offset = "0x2818390", VA = "0x182819590")]
	public static KHDEHODKHGE OEGGEPHFKJA([In] this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ)
	{
		return default(KHDEHODKHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A5030", VA = "0x1836A6230")]
	public static KHDEHODKHGE OEGGEPHFKJA<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(KHDEHODKHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39843E0", Offset = "0x39831E0", VA = "0x1839843E0")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BDMMKFCHMFL<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3984300", Offset = "0x3983100", VA = "0x183984300")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BDMMKFCHMFL<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3984370", Offset = "0x3983170", VA = "0x183984370")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> BDMMKFCHMFL<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x39848D0", Offset = "0x39836D0", VA = "0x1839848D0")]
	public static BIHBDMOHDCK<GMNLJAHBCBI<KCJNEKDGPOB>> KGNNOMDEOEO<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<GMNLJAHBCBI<KCJNEKDGPOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3984A20", Offset = "0x3983820", VA = "0x183984A20")]
	public static BIHBDMOHDCK<MMOKPEAHMGL> OAFIOAAHCBI<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<MMOKPEAHMGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39849B0", Offset = "0x39837B0", VA = "0x1839849B0")]
	public static BIHBDMOHDCK<MMOKPEAHMGL> OAFIOAAHCBI<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<MMOKPEAHMGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3984940", Offset = "0x3983740", VA = "0x183984940")]
	public static BIHBDMOHDCK<MMOKPEAHMGL> OAFIOAAHCBI<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<MMOKPEAHMGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3984290", Offset = "0x3983090", VA = "0x183984290")]
	public static BIHBDMOHDCK<INPOHEFJEKC> BADPOILMEEO<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<INPOHEFJEKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3984220", Offset = "0x3983020", VA = "0x183984220")]
	public static BIHBDMOHDCK<INPOHEFJEKC> BADPOILMEEO<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<INPOHEFJEKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x39841B0", Offset = "0x3982FB0", VA = "0x1839841B0")]
	public static BIHBDMOHDCK<COMGLGJNOJA> APNFEDCPLJD<M>(this JIAMCAFPHLG<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ)
	{
		return default(BIHBDMOHDCK<COMGLGJNOJA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LMDGJOEAHAB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x281F900", Offset = "0x281E700", VA = "0x18281F900")]
	public static void DOFOMPEKHJL(this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ, JGAKLEJADPA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x281F810", Offset = "0x281E610", VA = "0x18281F810")]
	public static void DOFOMPEKHJL(this byte[] HNAKMABCJKP, int EIANDFAKKKJ, JGAKLEJADPA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x281F880", Offset = "0x281E680", VA = "0x18281F880")]
	public static void DOFOMPEKHJL([In] this Span<byte> HNAKMABCJKP, int EIANDFAKKKJ, JGAKLEJADPA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39F8F10", Offset = "0x39F7D10", VA = "0x1839F8F10")]
	public static void DOFOMPEKHJL<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, JGAKLEJADPA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39F90B0", Offset = "0x39F7EB0", VA = "0x1839F90B0")]
	public static void DOFOMPEKHJL<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, JGAKLEJADPA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2819660", Offset = "0x2818460", VA = "0x182819660")]
	public static void HJCHGKFBLJL(this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x281F9C0", Offset = "0x281E7C0", VA = "0x18281F9C0")]
	public static void HJCHGKFBLJL(this byte[] HNAKMABCJKP, int EIANDFAKKKJ, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x281FA40", Offset = "0x281E840", VA = "0x18281FA40")]
	public static void HJCHGKFBLJL([In] this Span<byte> HNAKMABCJKP, int EIANDFAKKKJ, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39F92B0", Offset = "0x39F80B0", VA = "0x1839F92B0")]
	public static void HJCHGKFBLJL<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39F9250", Offset = "0x39F8050", VA = "0x1839F9250")]
	public static void HJCHGKFBLJL<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x281F7D0", Offset = "0x281E5D0", VA = "0x18281F7D0")]
	public static void AOJEMCGPECP(this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39F8E50", Offset = "0x39F7C50", VA = "0x1839F8E50")]
	public static void AOJEMCGPECP<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39F8EB0", Offset = "0x39F7CB0", VA = "0x1839F8EB0")]
	public static void AOJEMCGPECP<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x281FAC0", Offset = "0x281E8C0", VA = "0x18281FAC0")]
	public static void IHPFPMIHJIO(this ILLOCPJIIID<byte> HNAKMABCJKP, int EIANDFAKKKJ, byte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39F9360", Offset = "0x39F8160", VA = "0x1839F9360")]
	public static void IHPFPMIHJIO<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, byte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39F9310", Offset = "0x39F8110", VA = "0x1839F9310")]
	public static void IHPFPMIHJIO<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, byte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36A6530", Offset = "0x36A5330", VA = "0x1836A6530")]
	public static void ACKDJNJHCPD<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x36A6530", Offset = "0x36A5330", VA = "0x1836A6530")]
	public static void ACKDJNJHCPD<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, BIHBDMOHDCK<ADGOJNBMGKF<KCJNEKDGPOB>> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36A6530", Offset = "0x36A5330", VA = "0x1836A6530")]
	public static void EKJDMFLDNNG<M>(this APKPAJBCPHM<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, BIHBDMOHDCK<MMOKPEAHMGL> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36A6530", Offset = "0x36A5330", VA = "0x1836A6530")]
	public static void EKJDMFLDNNG<M>([In] this MIGMCPCKDCF<M, byte> HNAKMABCJKP, BIHBDMOHDCK<M> EIANDFAKKKJ, BIHBDMOHDCK<MMOKPEAHMGL> OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AFJHPJLBOFF
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x281DBA0", Offset = "0x281C9A0", VA = "0x18281DBA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) NOEEJOEAKHG(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x281C080", Offset = "0x281AE80", VA = "0x18281C080")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) IKAAPNHJLIP(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x281AC10", Offset = "0x2819A10", VA = "0x18281AC10")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) EIINMKDGOBB(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x281CD20", Offset = "0x281BB20", VA = "0x18281CD20")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) LFNKKKGOFBD(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x281A6F0", Offset = "0x28194F0", VA = "0x18281A6F0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) DEDDKKOKMKG(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2819F60", Offset = "0x2818D60", VA = "0x182819F60")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) CEDKJOMHDPF(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x281A080", Offset = "0x2818E80", VA = "0x18281A080")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) CHHLHGPCOJO(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2819E10", Offset = "0x2818C10", VA = "0x182819E10")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) BMBFLBGHLHL(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x281B280", Offset = "0x281A080", VA = "0x18281B280")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) GJAEKLOMPGB(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x281BD40", Offset = "0x281AB40", VA = "0x18281BD40")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>) ICHNFDNPGKK(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? OAIIHELJHLG, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? MFLCOABHKGM)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x281E340", Offset = "0x281D140", VA = "0x18281E340")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>) OJOOCOEKFAM(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? OAIIHELJHLG, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? MFLCOABHKGM)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x281BF70", Offset = "0x281AD70", VA = "0x18281BF70")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>) IEHPOCMDGNO(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? OAIIHELJHLG, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? MFLCOABHKGM)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x281DA80", Offset = "0x281C880", VA = "0x18281DA80")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>) NHGJCJBFAPI(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? OAIIHELJHLG, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? MFLCOABHKGM)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x281D0C0", Offset = "0x281BEC0", VA = "0x18281D0C0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<INPOHEFJEKC>>) MCONMEPDIHK(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? MKIJAJFADJB, [Optional] BIHBDMOHDCK<INPOHEFJEKC>? HPCIBKDHMEA)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<INPOHEFJEKC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x281B7A0", Offset = "0x281A5A0", VA = "0x18281B7A0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<INPOHEFJEKC>>>) GMHJNKKGCKM(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? MKIJAJFADJB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<INPOHEFJEKC>>? HPCIBKDHMEA)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<INPOHEFJEKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x281D3E0", Offset = "0x281C1E0", VA = "0x18281D3E0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<MMOKPEAHMGL>>) MNCEALEACNC(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? MKIJAJFADJB, [Optional] BIHBDMOHDCK<MMOKPEAHMGL>? HPCIBKDHMEA)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<MMOKPEAHMGL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x281AB00", Offset = "0x2819900", VA = "0x18281AB00")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<MMOKPEAHMGL>>>) EFNKEPEPBNJ(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? MKIJAJFADJB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<MMOKPEAHMGL>>? HPCIBKDHMEA)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<MMOKPEAHMGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4148710", Offset = "0x4147510", VA = "0x184148710")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>) GODNMJJCKNI<TMarker>(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<COMGLGJNOJA>? HPCIBKDHMEA, [Optional][In] ReadOnlySpan<byte> FFEMKICJPKP)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<COMGLGJNOJA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x281D7F0", Offset = "0x281C5F0", VA = "0x18281D7F0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) NGJCAGHELKH(this ILLOCPJIIID<byte> FPFHIDBMBMI, int HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? GJCHJCHAFHC)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28196A0", Offset = "0x28184A0", VA = "0x1828196A0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) ACCJPJFEOGM(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? GJCHJCHAFHC)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4148520", Offset = "0x4147320", VA = "0x184148520")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>) FMGNKJACFDL<TMarker>(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<TMarker>>? GJCHJCHAFHC, [Optional] int? ACINDEOBNPO, [Optional][In] ReadOnlySpan<byte> HLHNGKLKCFJ)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x41483D0", Offset = "0x41471D0", VA = "0x1841483D0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>) FGJOJOJPMMG<TMarker>(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<TMarker>>? HLHNGKLKCFJ, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<TMarker>>? GJCHJCHAFHC, [Optional] int? ACINDEOBNPO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<TMarker>>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x281E460", Offset = "0x281D260", VA = "0x18281E460")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) OLBKFBIADHI(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28197B0", Offset = "0x28185B0", VA = "0x1828197B0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) AMDKFHJHAIE(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x281EC80", Offset = "0x281DA80", VA = "0x18281EC80")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) PNMDMIJCDEM(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x281A9A0", Offset = "0x28197A0", VA = "0x18281A9A0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) DNCBDLECKBC(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x281C6C0", Offset = "0x281B4C0", VA = "0x18281C6C0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) KMHNCPOFOEG(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x281BE50", Offset = "0x281AC50", VA = "0x18281BE50")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) IDDJEIEGNKH(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x281CBC0", Offset = "0x281B9C0", VA = "0x18281CBC0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) LFGMKHLDFOH(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x281E5E0", Offset = "0x281D3E0", VA = "0x18281E5E0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) PCEOEJNPBDF(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2819900", Offset = "0x2818700", VA = "0x182819900")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) APLMEMAOBED(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x281BC50", Offset = "0x281AA50", VA = "0x18281BC50")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>) HNMKJOFPOLD(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>? IANKJMIGKGC)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<ADGOJNBMGKF<NEDINALJBEL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x281A1E0", Offset = "0x2818FE0", VA = "0x18281A1E0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) CLPIDPAKLHO(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x281EA00", Offset = "0x281D800", VA = "0x18281EA00")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) PGLKOMLKFHJ(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x281C440", Offset = "0x281B240", VA = "0x18281C440")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) JANEDHLKBEK(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x281DD20", Offset = "0x281CB20", VA = "0x18281DD20")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) OBJKOEJEDEL(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2819BA0", Offset = "0x28189A0", VA = "0x182819BA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) BCPIDCIAPAI(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x281CAA0", Offset = "0x281B8A0", VA = "0x18281CAA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) LFFOBPFDKBF(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x281DF00", Offset = "0x281CD00", VA = "0x18281DF00")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) OGKGGDMKCLN(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x281AFA0", Offset = "0x2819DA0", VA = "0x18281AFA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) FAPMPCFFAML(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x281A5C0", Offset = "0x28193C0", VA = "0x18281A5C0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) DBBIBHAOGAO(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x281EEC0", Offset = "0x281DCC0", VA = "0x18281EEC0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) POLNOOCKKHB(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x281AD30", Offset = "0x2819B30", VA = "0x18281AD30")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) ELIJLAFKBCE(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x281AE80", Offset = "0x2819C80", VA = "0x18281AE80")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) EPFNJNAGLFH(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x281B100", Offset = "0x2819F00", VA = "0x18281B100")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) FBPHKHOGIHD(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x281D920", Offset = "0x281C720", VA = "0x18281D920")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) NHDGOHEPBKD(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x281B8B0", Offset = "0x281A6B0", VA = "0x18281B8B0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) HEACHBIABJJ(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x281E080", Offset = "0x281CE80", VA = "0x18281E080")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) OGMFNININII(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x281D580", Offset = "0x281C380", VA = "0x18281D580")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) MOMEPLELECO(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x281EB60", Offset = "0x281D960", VA = "0x18281EB60")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) PLNGIDJFPJB(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2819A20", Offset = "0x2818820", VA = "0x182819A20")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) BBMLEODMOAG(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x281C940", Offset = "0x281B740", VA = "0x18281C940")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) LACIPCFKFFK(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x281C810", Offset = "0x281B610", VA = "0x18281C810")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) KNOILEJEOMB(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x281B4F0", Offset = "0x281A2F0", VA = "0x18281B4F0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) GJNODDMJAIP(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x281B650", Offset = "0x281A450", VA = "0x18281B650")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) GLFPLPLAKPM(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x281CE80", Offset = "0x281BC80", VA = "0x18281CE80")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) LHKCJNCMIHL(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x281D260", Offset = "0x281C060", VA = "0x18281D260")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) MJMPMDGGPNJ(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x281B3A0", Offset = "0x281A1A0", VA = "0x18281B3A0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) GJMFIBONKAO(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2819CF0", Offset = "0x2818AF0", VA = "0x182819CF0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) BIFOJOIGAII(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x281E1E0", Offset = "0x281CFE0", VA = "0x18281E1E0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) OJKGKEHKHJA(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x281C570", Offset = "0x281B370", VA = "0x18281C570")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) KJBICCIMHMH(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x281D6D0", Offset = "0x281C4D0", VA = "0x18281D6D0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) NCOLPPHJJNG(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x281A360", Offset = "0x2819160", VA = "0x18281A360")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) CMDOHMAONLN(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] int? DAFILDGANNH, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x281BB40", Offset = "0x281A940", VA = "0x18281BB40")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) HLKHPCMKNII(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? DAFILDGANNH, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x281DE80", Offset = "0x281CC80", VA = "0x18281DE80")]
	public static BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>> OFHBEAOIOJD(this ILLOCPJIIID<byte> FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x281E730", Offset = "0x281D530", VA = "0x18281E730")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) PFDNHIOLODA(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, float INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x281A470", Offset = "0x2819270", VA = "0x18281A470")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) DAFHJEIBCHI(this ILLOCPJIIID<byte> FPFHIDBMBMI, float MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GNDNLMBCEPA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x281CFA0", Offset = "0x281BDA0", VA = "0x18281CFA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>) MBDNMLHDCAI(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GNDNLMBCEPA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GNDNLMBCEPA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x281A840", Offset = "0x2819640", VA = "0x18281A840")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) DLANHGIFEKH(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x281E8B0", Offset = "0x281D6B0", VA = "0x18281E8B0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) PFINEDDFKAO(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x281EDA0", Offset = "0x281DBA0", VA = "0x18281EDA0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) POBKBEGAMCF(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x281B9E0", Offset = "0x281A7E0", VA = "0x18281B9E0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) HICCNJJNINJ(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, int INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x281C2F0", Offset = "0x281B0F0", VA = "0x18281C2F0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) JAIJIDIJOIA(this ILLOCPJIIID<byte> FPFHIDBMBMI, int MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GKJLLMDLJCA>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x281C1D0", Offset = "0x281AFD0", VA = "0x18281C1D0")]
	public static (BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>) INEIKIKGOFK(this ILLOCPJIIID<byte> FPFHIDBMBMI, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? MIKFBKFKEIN, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? INLNMLHPBKB, [Optional] BIHBDMOHDCK<GMNLJAHBCBI<GKJLLMDLJCA>>? NHBDIECIOKO)
	{
		return default((BIHBDMOHDCK<ADGOJNBMGKF<NEDINALJBEL>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>, BIHBDMOHDCK<ADGOJNBMGKF<GMNLJAHBCBI<GKJLLMDLJCA>>>));
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
