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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B9170", Offset = "0x27B8370", VA = "0x1827B9170")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JEBCCEMIFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3662070", Offset = "0x3661270", VA = "0x183662070")]
	public static JFIBBLJIDCN<HAAFGKINDME<M>> IGFACMPBDCD<M>(this int CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27B8D40", Offset = "0x27B7F40", VA = "0x1827B8D40")]
	public static JFIBBLJIDCN<LDMFJMAMADM> AKHAKDJOBNA(this int CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<LDMFJMAMADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3662070", Offset = "0x3661270", VA = "0x183662070")]
	public static JFIBBLJIDCN<KFJDANDCLAB<M>> NFKHICDOBBA<M>(this int CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<KFJDANDCLAB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class HAAFGKINDME<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DCNCJHIOGGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GIGAPMKOANA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LDMFJMAMADM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JANJHCEFKOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DCLJNEKAEOE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DHDAOLLNLAB
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
public static class JKNAACFDMBJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OEODEGHEPEK<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr OMLFBAHOPMM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
		public OEODEGHEPEK(IntPtr AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54C9A40", Offset = "0x54C8C40", VA = "0x1854C9A40")]
		public int ENEDPBAOBKF(TDeps POLANHDJCNH, TContext LEPDDHJAJAH, TCompileState BEIACMCLENJ, [In] PAKIJLEMGBA<byte> LDHHLCKKFBF, int GHGKDFELHCK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x386B140", Offset = "0x386A340", VA = "0x18386B140")]
	public static void PCOPAGFEMGH<TDeps, TContext, TCompileState>(TDeps POLANHDJCNH, TContext LEPDDHJAJAH, TCompileState BEIACMCLENJ, [In] PAKIJLEMGBA<byte> HJDLFJKIOLM, PAKIJLEMGBA<byte> GCBCODOCFDM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KLBLBEGGBBI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MBCJNFIGGDO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CFHHCKPNDNN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JJEPKAOGIHM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CNCFMAIGNKC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FJAIHCDIJIH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EJIKDHPEKGN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IGDHBEIKIFP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IPIBFPADOKF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DNMDCPAAFED, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EDABIEJKOKB, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CLMMAJPINBM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FAOKPNDLEMG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HOIIPHKMHHK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NCEKNLFJBDP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HPEPFMOLNAL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NBPCIHEBMMJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FHJKEAOIPHP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? ONMIACPJGHK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CJKANEEHGHL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BDMCMKNAALA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OBDHAGACLLM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AHGHFGGEGAA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EKFPALLKEFO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CCBKHOBAEJI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? APPBLBMMJDJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CIABHADDEHK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DDDFPHGENMI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DCBFBCLPNPN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IPPDBFBNCJF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GJOFPDGLJDG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EIAIFODALFL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HPNDDDDELEA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NOPJOKBIOHL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NOJEPBFPFEG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HACFAGCFHFA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OEJHDLPNEMA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NOIAEPPAGCM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KBGFKBOJOKN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IGDMJNIKOJL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GCNKDIAKHNP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CMCIMJDAJMG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AELGKLOILPJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FHLHNNPNHLP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OLKBPCFJJBA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LMDDBMJMKHJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AALPJAOAOHG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GHADAPKKJJK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PAFNMBCJFJC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LDHHPDADKHB, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GNLLPGCMKPD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AKICEFOGPOO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GJBJDPBGBPP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CLNDBDOONAC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AMGGFEPCGOC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LCBBCPOHEBL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CKHCDNNGAOJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KDCOJIEFONF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IBBAKEFJACG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JGFIBMNDBIP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LEDAEFPNCMD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GLIMBHBBKIK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JNDKFCOFNEL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EHKCIGLBOAK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PAFLHAHFHNF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MABEKKBHOJI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MOJDGPANLLI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LIBKMFPCNDD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MBKMECOOFNN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CHBGFDIDOJP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? APJLCADFLID, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PFIGKEIOBFN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IILHHLHHCHM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? POIGABJMADC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KPIIOEEBDJL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EAACDLLAAAI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NHNFKFMLMJK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DPDPFABPCJI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DGOJBEIHHEM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DFOOPOAMHOO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? ICBDEMNNGED, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KELLHHFONNP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PJIOCECALOO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LFLLNJBNHHF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PDMEJHBJEBA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OFOFALPMLAF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IJKJPJBCAKO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NDMJGEMCPFO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BNNNPKJDJMI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GAKBODLONLH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FLILILJEGID, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GNDPGKGOJOA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EFHJDKEEMOE, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JPBLMBJNKEJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? IDKKLCHDHPD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? DFAIADGFDEH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MLAJNLIDOML, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MMFOACBMJBF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JNCPLFNFEAD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HDBJLKKPNII, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GPMBNDPMGAK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HLLPCECGGOM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BOGEHLFEFCJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PDOOFICMECO, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AFDLONLOGPH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JKFIOABDPAA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HNJDELOLAML, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BFOKKOCOIFA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? MKNOGCOCCMD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PBLLGKNJPED, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? NNOIEGNELLC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? JFIGEHKAJIL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? ODHHCACHDHL, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BJPMLEINBEA, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PPBCEINNJKH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? FGDPGPLCCHC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? HEJIGBAEPJN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PLDJHMDJGAB, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LKPGKLKLEPE, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GDFODFOFGIK, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OHACKJGEDOG, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? LGBLNCNJMAJ, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? ALDDLLDDBGP, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? OHJPCPDIDGF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EMDMKFEIOPM, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? BJIMMBFGPKC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KCGFNLECAKC, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? ANLKKAGMOLH, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KBOGOGKELCN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? KBKFLOLAMBI, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? AKFGGNKDHCF, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? EMEGIPCLHCD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? CMNNCKAELOD, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? PDGFDKKPJEN, [Optional] OEODEGHEPEK<TContext, TDeps, TCompileState>? GNMHKDHENHL) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27B8D70", Offset = "0x27B7F70", VA = "0x1827B8D70")]
	private static int KGLJCAJIKBG([In] PAKIJLEMGBA<byte> NNAIPNIHBIM, PAKIJLEMGBA<byte> HLCHGMIKLCE, int CAECICLJFEI, int KIFHGDECLNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJCJDIKLHDF
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int GKMJIJJOLIC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35B76D0", Offset = "0x35B68D0", VA = "0x1835B76D0")]
	public static JFIBBLJIDCN<HAAFGKINDME<T>> BJFJHFFKCEP<T>([In] this PAKIJLEMGBA<byte> CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35B7730", Offset = "0x35B6930", VA = "0x1835B7730")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<T>>> EEJGBFFEMPE<T>(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<HAAFGKINDME<T>>? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27B8920", Offset = "0x27B7B20", VA = "0x1827B8920")]
	public static JFIBBLJIDCN<HAAFGKINDME<DJKJBIDFBJO>> MJLDJLCMEDG(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<DJKJBIDFBJO>? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<DJKJBIDFBJO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27B8750", Offset = "0x27B7950", VA = "0x1827B8750")]
	public static JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>> FKIGAJKICIJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] float? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27B8590", Offset = "0x27B7790", VA = "0x1827B8590")]
	public static JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>> DBIICIMDAMO(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27B8840", Offset = "0x27B7A40", VA = "0x1827B8840")]
	public static JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>> GOMNJIEBEAN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<HGLMKHOJKPL>? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A00", Offset = "0x27B7C00", VA = "0x1827B8A00")]
	public static JFIBBLJIDCN<HAAFGKINDME<DCLJNEKAEOE>> NGHCGPAOMIN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] byte? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<DCLJNEKAEOE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27B8670", Offset = "0x27B7870", VA = "0x1827B8670")]
	public static JFIBBLJIDCN<HAAFGKINDME<LDMFJMAMADM>> DDCLNDDOKEN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<LDMFJMAMADM>? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<LDMFJMAMADM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27B8B00", Offset = "0x27B7D00", VA = "0x1827B8B00")]
	public static JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> PDFDNPHKNIC(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] DHDAOLLNLAB? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35B7800", Offset = "0x35B6A00", VA = "0x1835B7800")]
	public static JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<T>>> LEHKEFBOAMB<T>(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<T>>? MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27B8550", Offset = "0x27B7750", VA = "0x1827B8550")]
	public static void PBLKGNLLHKC(this PAKIJLEMGBA<byte> CEENCLMGJAM, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>> BLEJDIKLGBM, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35B77F0", Offset = "0x35B69F0", VA = "0x1835B77F0")]
	public static void OKIDBPFFKBN<T>(this PAKIJLEMGBA<byte> CEENCLMGJAM, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<T>>> GHGKDFELHCK, JFIBBLJIDCN<HAAFGKINDME<T>> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35B77F0", Offset = "0x35B69F0", VA = "0x1835B77F0")]
	public static void GKINJAFHPPJ<T>(this PAKIJLEMGBA<byte> CEENCLMGJAM, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<T>>> AKKFECNPPBH, JFIBBLJIDCN<KFJDANDCLAB<T>> MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HGJBJCBFFPP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27B8C30", Offset = "0x27B7E30", VA = "0x1827B8C30")]
	public static HOMKGHPABMN AFBNLEIMOAH([In] this ReadOnlySpan<byte> FONJAIMABAP, int JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27B8CA0", Offset = "0x27B7EA0", VA = "0x1827B8CA0")]
	public static HOMKGHPABMN AFBNLEIMOAH([In] this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x382C900", Offset = "0x382BB00", VA = "0x18382C900")]
	public static HOMKGHPABMN AFBNLEIMOAH<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x382CAB0", Offset = "0x382BCB0", VA = "0x18382CAB0")]
	public static HOMKGHPABMN AFBNLEIMOAH<M>([In] this IFLGNCCPEFB<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x382CA50", Offset = "0x382BC50", VA = "0x18382CA50")]
	public static HOMKGHPABMN AFBNLEIMOAH<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x382CC10", Offset = "0x382BE10", VA = "0x18382CC10")]
	public static HOMKGHPABMN AFBNLEIMOAH<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x382CC80", Offset = "0x382BE80", VA = "0x18382CC80")]
	public static HOMKGHPABMN AFBNLEIMOAH<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27B8C30", Offset = "0x27B7E30", VA = "0x1827B8C30")]
	public static int GCECBGKAPEC([In] this ReadOnlySpan<byte> FONJAIMABAP, int JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27B8480", Offset = "0x27B7680", VA = "0x1827B8480")]
	public static int GCECBGKAPEC([In] this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37F32B0", Offset = "0x37F24B0", VA = "0x1837F32B0")]
	public static int GCECBGKAPEC<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37F32B0", Offset = "0x37F24B0", VA = "0x1837F32B0")]
	public static int GCECBGKAPEC<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37F32B0", Offset = "0x37F24B0", VA = "0x1837F32B0")]
	public static int GCECBGKAPEC<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37F32B0", Offset = "0x37F24B0", VA = "0x1837F32B0")]
	public static int GCECBGKAPEC<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x382CE20", Offset = "0x382C020", VA = "0x18382CE20")]
	public static float KICPGMDFAKG<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x382CE20", Offset = "0x382C020", VA = "0x18382CE20")]
	public static float KICPGMDFAKG<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x382CE20", Offset = "0x382C020", VA = "0x18382CE20")]
	public static float KICPGMDFAKG<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x382D1E0", Offset = "0x382C3E0", VA = "0x18382D1E0")]
	public static byte OPBEFEEOLDD<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x382D100", Offset = "0x382C300", VA = "0x18382D100")]
	public static byte OPBEFEEOLDD<M>([In] this IFLGNCCPEFB<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x382CA50", Offset = "0x382BC50", VA = "0x18382CA50")]
	public static byte OPBEFEEOLDD<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x382CC10", Offset = "0x382BE10", VA = "0x18382CC10")]
	public static byte OPBEFEEOLDD<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x382D120", Offset = "0x382C320", VA = "0x18382D120")]
	public static byte OPBEFEEOLDD<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27B8480", Offset = "0x27B7680", VA = "0x1827B8480")]
	public static DHDAOLLNLAB MPIPJNEKNOO([In] this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH)
	{
		return default(DHDAOLLNLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x37F32B0", Offset = "0x37F24B0", VA = "0x1837F32B0")]
	public static DHDAOLLNLAB MPIPJNEKNOO<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(DHDAOLLNLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x382CFB0", Offset = "0x382C1B0", VA = "0x18382CFB0")]
	public static JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> NHBDEOJEGCB<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x382D090", Offset = "0x382C290", VA = "0x18382D090")]
	public static JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> NHBDEOJEGCB<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x382D020", Offset = "0x382C220", VA = "0x18382D020")]
	public static JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> NHBDEOJEGCB<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x382CD40", Offset = "0x382BF40", VA = "0x18382CD40")]
	public static JFIBBLJIDCN<KFJDANDCLAB<KMIODFPCFME>> FDCKGJPHGOP<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<KFJDANDCLAB<KMIODFPCFME>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x382CE60", Offset = "0x382C060", VA = "0x18382CE60")]
	public static JFIBBLJIDCN<LDMFJMAMADM> LGGKOJFHJCD<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<LDMFJMAMADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x382CED0", Offset = "0x382C0D0", VA = "0x18382CED0")]
	public static JFIBBLJIDCN<LDMFJMAMADM> LGGKOJFHJCD<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<LDMFJMAMADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x382CF40", Offset = "0x382C140", VA = "0x18382CF40")]
	public static JFIBBLJIDCN<LDMFJMAMADM> LGGKOJFHJCD<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<LDMFJMAMADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x382D210", Offset = "0x382C410", VA = "0x18382D210")]
	public static JFIBBLJIDCN<DJKJBIDFBJO> PMNHMHGBIIA<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<DJKJBIDFBJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x382D280", Offset = "0x382C480", VA = "0x18382D280")]
	public static JFIBBLJIDCN<DJKJBIDFBJO> PMNHMHGBIIA<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<DJKJBIDFBJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x382CDB0", Offset = "0x382BFB0", VA = "0x18382CDB0")]
	public static JFIBBLJIDCN<HGLMKHOJKPL> HFHADAFLKLO<M>(this ONBCILOGPEM<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH)
	{
		return default(JFIBBLJIDCN<HGLMKHOJKPL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NMGHBFJKHII
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27B8E80", Offset = "0x27B8080", VA = "0x1827B8E80")]
	public static void KONPEFMAOEP(this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH, HOMKGHPABMN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27B8F40", Offset = "0x27B8140", VA = "0x1827B8F40")]
	public static void KONPEFMAOEP(this byte[] FONJAIMABAP, int JMDMMDHMCCH, HOMKGHPABMN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27B8FB0", Offset = "0x27B81B0", VA = "0x1827B8FB0")]
	public static void KONPEFMAOEP([In] this Span<byte> FONJAIMABAP, int JMDMMDHMCCH, HOMKGHPABMN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3989D90", Offset = "0x3988F90", VA = "0x183989D90")]
	public static void KONPEFMAOEP<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, HOMKGHPABMN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3989BF0", Offset = "0x3988DF0", VA = "0x183989BF0")]
	public static void KONPEFMAOEP<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, HOMKGHPABMN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27B8550", Offset = "0x27B7750", VA = "0x1827B8550")]
	public static void PBLKGNLLHKC(this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27B90F0", Offset = "0x27B82F0", VA = "0x1827B90F0")]
	public static void PBLKGNLLHKC(this byte[] FONJAIMABAP, int JMDMMDHMCCH, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27B9070", Offset = "0x27B8270", VA = "0x1827B9070")]
	public static void PBLKGNLLHKC([In] this Span<byte> FONJAIMABAP, int JMDMMDHMCCH, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x398A050", Offset = "0x3989250", VA = "0x18398A050")]
	public static void PBLKGNLLHKC<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3989FF0", Offset = "0x39891F0", VA = "0x183989FF0")]
	public static void PBLKGNLLHKC<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27B9030", Offset = "0x27B8230", VA = "0x1827B9030")]
	public static void LNKIFNLBNKN(this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3989F90", Offset = "0x3989190", VA = "0x183989F90")]
	public static void LNKIFNLBNKN<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3989F30", Offset = "0x3989130", VA = "0x183989F30")]
	public static void LNKIFNLBNKN<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x27B8E10", Offset = "0x27B8010", VA = "0x1827B8E10")]
	public static void DOFENHDNELG(this PAKIJLEMGBA<byte> FONJAIMABAP, int JMDMMDHMCCH, byte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3989BA0", Offset = "0x3988DA0", VA = "0x183989BA0")]
	public static void DOFENHDNELG<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, byte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3989B50", Offset = "0x3988D50", VA = "0x183989B50")]
	public static void DOFENHDNELG<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, byte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37F2300", Offset = "0x37F1500", VA = "0x1837F2300")]
	public static void OKIDBPFFKBN<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37F2300", Offset = "0x37F1500", VA = "0x1837F2300")]
	public static void OKIDBPFFKBN<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x37F2300", Offset = "0x37F1500", VA = "0x1837F2300")]
	public static void DHMNBFGCAEN<M>(this CKBGCKMFLGE<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, JFIBBLJIDCN<LDMFJMAMADM> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37F2300", Offset = "0x37F1500", VA = "0x1837F2300")]
	public static void DHMNBFGCAEN<M>([In] this NEFKEHECOOG<M, byte> FONJAIMABAP, JFIBBLJIDCN<M> JMDMMDHMCCH, JFIBBLJIDCN<LDMFJMAMADM> MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PKHDHNDDBBE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27BDAC0", Offset = "0x27BCCC0", VA = "0x1827BDAC0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) MNNCECBAFGC(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27BE370", Offset = "0x27BD570", VA = "0x1827BE370")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) NMFAINEOGMM(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27BA660", Offset = "0x27B9860", VA = "0x1827BA660")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) EHAABIBCMHJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27BB860", Offset = "0x27BAA60", VA = "0x1827BB860")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) IGKPEJMCCKE(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27BA150", Offset = "0x27B9350", VA = "0x1827BA150")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DJBKGHPFDCG(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27BC3E0", Offset = "0x27BB5E0", VA = "0x1827BC3E0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JPBLNKABHEI(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27BCEF0", Offset = "0x27BC0F0", VA = "0x1827BCEF0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) LBKFOFJIDEB(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27BA900", Offset = "0x27B9B00", VA = "0x1827BA900")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) FAOFJNJNFFG(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27BE4C0", Offset = "0x27BD6C0", VA = "0x1827BE4C0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) NNKJBKBIKLL(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27BD9B0", Offset = "0x27BCBB0", VA = "0x1827BD9B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>) MMHBFCAMOEO(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? MLCDCHNOCFI, [Optional] JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? HJLBODDHMGM)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27BE5E0", Offset = "0x27BD7E0", VA = "0x1827BE5E0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>) NOIIANBAEGM(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? MLCDCHNOCFI, [Optional] JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? HJLBODDHMGM)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27BA3D0", Offset = "0x27B95D0", VA = "0x1827BA3D0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>) EENLDNHIJCN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? MLCDCHNOCFI, [Optional] JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? HJLBODDHMGM)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27B9B30", Offset = "0x27B8D30", VA = "0x1827B9B30")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>) CHCIOAFPELF(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? MLCDCHNOCFI, [Optional] JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? HJLBODDHMGM)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27B95B0", Offset = "0x27B87B0", VA = "0x1827B95B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<DJKJBIDFBJO>>) BBMOCMLCINP(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? BJIDIBKLHJG, [Optional] JFIBBLJIDCN<DJKJBIDFBJO>? OOKJGLKPPPN)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<DJKJBIDFBJO>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27BE820", Offset = "0x27BDA20", VA = "0x1827BE820")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DJKJBIDFBJO>>>) OBJGBIIAICK(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? BJIDIBKLHJG, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DJKJBIDFBJO>>? OOKJGLKPPPN)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DJKJBIDFBJO>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27BD1B0", Offset = "0x27BC3B0", VA = "0x1827BD1B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<LDMFJMAMADM>>) LIAGPJCCDEO(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? BJIDIBKLHJG, [Optional] JFIBBLJIDCN<LDMFJMAMADM>? OOKJGLKPPPN)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<LDMFJMAMADM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27BE140", Offset = "0x27BD340", VA = "0x1827BE140")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<LDMFJMAMADM>>>) NHJMABEKNLL(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? BJIDIBKLHJG, [Optional] JFIBBLJIDCN<KFJDANDCLAB<LDMFJMAMADM>>? OOKJGLKPPPN)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<LDMFJMAMADM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A179B0", Offset = "0x3A16BB0", VA = "0x183A179B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>) BKFLOHLFEAK<TMarker>(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<HGLMKHOJKPL>? OOKJGLKPPPN, [Optional][In] ReadOnlySpan<byte> DHAOEHNLNON)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27BC000", Offset = "0x27BB200", VA = "0x1827BC000")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JLEGFJJHMJC(this PAKIJLEMGBA<byte> CEENCLMGJAM, int NNAIPNIHBIM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? HLCHGMIKLCE)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27BB5D0", Offset = "0x27BA7D0", VA = "0x1827BB5D0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) HNILHMGIOMP(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? NNAIPNIHBIM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? HLCHGMIKLCE)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A17D00", Offset = "0x3A16F00", VA = "0x183A17D00")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>) LBEMMIMHKBK<TMarker>(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<TMarker>>? HLCHGMIKLCE, [Optional] int? JAFKPMJIGFL, [Optional][In] ReadOnlySpan<byte> NNAIPNIHBIM)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A17BB0", Offset = "0x3A16DB0", VA = "0x183A17BB0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>) IANIGCJIBCM<TMarker>(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<TMarker>>? NNAIPNIHBIM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<TMarker>>? HLCHGMIKLCE, [Optional] int? JAFKPMJIGFL)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<TMarker>>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27BA4E0", Offset = "0x27B96E0", VA = "0x1827BA4E0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) EFPNIOBPHNM(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27BADE0", Offset = "0x27B9FE0", VA = "0x1827BADE0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) GJHFLIMJANO(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27BC680", Offset = "0x27BB880", VA = "0x1827BC680")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) KGAIKKBMPCF(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27BBB10", Offset = "0x27BAD10", VA = "0x1827BBB10")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) ILOPHNBLCBL(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27BB9C0", Offset = "0x27BABC0", VA = "0x1827BB9C0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) IIPINPDKHLJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27BBEE0", Offset = "0x27BB0E0", VA = "0x1827BBEE0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JHKEJDBHGOJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27BCD90", Offset = "0x27BBF90", VA = "0x1827BCD90")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) KPJBBJCEDFI(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27BB330", Offset = "0x27BA530", VA = "0x1827BB330")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) HDAJGKAAAKO(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27BBC70", Offset = "0x27BAE70", VA = "0x1827BBC70")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) IPAHNDMCOBO(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27BD4B0", Offset = "0x27BC6B0", VA = "0x1827BD4B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>) LLCGFNDDEBF(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? OPDEMFPNJKB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27BC500", Offset = "0x27BB700", VA = "0x1827BC500")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) KBPPEMPBKND(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27BD350", Offset = "0x27BC550", VA = "0x1827BD350")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) LJPEMCMBFIA(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27B91F0", Offset = "0x27B83F0", VA = "0x1827B91F0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) AEGFFIPNILA(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27BD5A0", Offset = "0x27BC7A0", VA = "0x1827BD5A0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) LOLGNLAIOIO(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27B9EE0", Offset = "0x27B90E0", VA = "0x1827B9EE0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DHBIBKBEOBE(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27B9750", Offset = "0x27B8950", VA = "0x1827B9750")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) CALABFPOGOC(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27B9D60", Offset = "0x27B8F60", VA = "0x1827B9D60")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DFLOOACFBEH(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27BD050", Offset = "0x27BC250", VA = "0x1827BD050")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) LFFFNIPNFAD(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27BE010", Offset = "0x27BD210", VA = "0x1827BE010")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) NDNGMGGGNMN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27BAA50", Offset = "0x27B9C50", VA = "0x1827BAA50")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) FHOFFHBFJHO(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27BBD90", Offset = "0x27BAF90", VA = "0x1827BBD90")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JCMOKHJEIEM(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27BEA50", Offset = "0x27BDC50", VA = "0x1827BEA50")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) PEIHJGHOMJF(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27BAF30", Offset = "0x27BA130", VA = "0x1827BAF30")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) GLGPAGINABN(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27BD850", Offset = "0x27BCA50", VA = "0x1827BD850")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) MKDJMFPHDOL(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27BA2A0", Offset = "0x27B94A0", VA = "0x1827BA2A0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DJCPFLBAMIA(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27BDC40", Offset = "0x27BCE40", VA = "0x1827BDC40")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) MOABBMCECFA(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27BC820", Offset = "0x27BBA20", VA = "0x1827BC820")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) KHIPDOJCJME(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27BACC0", Offset = "0x27B9EC0", VA = "0x1827BACC0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) GIHPGMOOLOJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27BB6E0", Offset = "0x27BA8E0", VA = "0x1827BB6E0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) IBMCEPBBJPF(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27B9870", Offset = "0x27B8A70", VA = "0x1827B9870")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) CAMOEHGBCAJ(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x27B9480", Offset = "0x27B8680", VA = "0x1827B9480")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) ANFEPDGELFP(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x27B99D0", Offset = "0x27B8BD0", VA = "0x1827B99D0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) CGBAAPHFGBA(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x27BC130", Offset = "0x27BB330", VA = "0x1827BC130")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JMEPOIDIFLD(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x27BE930", Offset = "0x27BDB30", VA = "0x1827BE930")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) OLCBCIPNCNN(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x27BA780", Offset = "0x27B9980", VA = "0x1827BA780")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) EJHNOKKDHKH(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27BB480", Offset = "0x27BA680", VA = "0x1827BB480")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) HNCGPLEPDDN(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x27BDDA0", Offset = "0x27BCFA0", VA = "0x1827BDDA0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) MOEAFKCJJCO(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x27BB0B0", Offset = "0x27BA2B0", VA = "0x1827BB0B0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) GNPCIPMPMDK(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27BCAF0", Offset = "0x27BBCF0", VA = "0x1827BCAF0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) KMLJBINCKEH(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27BB210", Offset = "0x27BA410", VA = "0x1827BB210")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) GPLPEGPPHHM(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27B9C50", Offset = "0x27B8E50", VA = "0x1827B9C50")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DFBBLCHLOAG(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] int? DIJPIOBJLLE, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x27BABB0", Offset = "0x27B9DB0", VA = "0x1827BABB0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) FMMIMNLGAPL(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? DIJPIOBJLLE, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27BC7A0", Offset = "0x27BB9A0", VA = "0x1827BC7A0")]
	public static JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> KGHOGIDDOBC(this PAKIJLEMGBA<byte> CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27BC970", Offset = "0x27BBB70", VA = "0x1827BC970")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) KIEFNJIJAIH(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC40", Offset = "0x27BBE40", VA = "0x1827BCC40")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) KNKGDOFIPCP(this PAKIJLEMGBA<byte> CEENCLMGJAM, float GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<DCNCJHIOGGH>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27BE700", Offset = "0x27BD900", VA = "0x1827BE700")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>) OBFKNFIBAKP(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<DCNCJHIOGGH>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<DCNCJHIOGGH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27BC280", Offset = "0x27BB480", VA = "0x1827BC280")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) JMNDJOKCFBG(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27BD700", Offset = "0x27BC900", VA = "0x1827BD700")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) MELGKFIABPC(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27BE250", Offset = "0x27BD450", VA = "0x1827BE250")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) NJBJFMMLEAD(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27B9320", Offset = "0x27B8520", VA = "0x1827B9320")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) AHPGCGAILPA(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27BDEC0", Offset = "0x27BD0C0", VA = "0x1827BDEC0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) NALINPDCIGC(this PAKIJLEMGBA<byte> CEENCLMGJAM, int GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27BA030", Offset = "0x27B9230", VA = "0x1827BA030")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>) DHDPJGHMHJP(this PAKIJLEMGBA<byte> CEENCLMGJAM, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? GENFKMCJKPD, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? KAAAPNGENND, [Optional] JFIBBLJIDCN<KFJDANDCLAB<GIGAPMKOANA>>? FKLEADKMMFB)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<GIGAPMKOANA>>>));
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
