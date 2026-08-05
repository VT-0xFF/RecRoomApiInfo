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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E40520", Offset = "0x1E3F720", VA = "0x181E40520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HFCMGKKIHFC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<M>> GJNGNOJPLMJ<M>(this int KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AAD0", Offset = "0x1E39CD0", VA = "0x181E3AAD0")]
	public static EIPPGFCFCGI<BGAMOELFEOB> FBHKLEABOAG(this int KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<BGAMOELFEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static EIPPGFCFCGI<DGMFFODHHCI<M>> COEPMPPKJCG<M>(this int KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<DGMFFODHHCI<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class LPGDGOFEIPD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GBFKBFKDNEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FDNMKMOBOAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BGAMOELFEOB
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KMIDLPHNLBA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HAKHKJNAJJL
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JJPEHILGEHI
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
public static class IIHELBEAIBC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IFIFABBHBJL<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr PIPHLMIAIEA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
		public IFIFABBHBJL(IntPtr PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E5B0", Offset = "0x3A3D7B0", VA = "0x183A3E5B0")]
		public int DPCEAIGMMMP(TDeps NMAKCOKENKA, TContext EPAEKHCAPHF, TCompileState KKAGEBCELIP, [In] FNBPBCOGKJO<byte> ENPNCKNJEKP, int ENAEIJLNKLP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29248B0", Offset = "0x2923AB0", VA = "0x1829248B0")]
	public static void OCGMEBBOPJF<TDeps, TContext, TCompileState>(TDeps NMAKCOKENKA, TContext EPAEKHCAPHF, TCompileState KKAGEBCELIP, [In] FNBPBCOGKJO<byte> INDBKONNJHG, FNBPBCOGKJO<byte> EDKBEENEJIE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HIAKGBMHLON, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LOJMEKEBHIP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KFKIPPHNDDP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MCBHAGAEIMC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HNGAOHCONEJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LDDLIDHOMOD, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BOFIEIIOFMJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DJGBBAAHONM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FPEPPBELNGO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PMBCADMJCOM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? CLGGLCLIEMJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? GNMPDHODBLM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? ODIGABPHNGL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? OJJIFPACBLA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? IHHEEEIAAGN, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? CHDOMHIPONG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BJHJFHMLKDN, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KMIDHNGMMCG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? IICKPEKNOPI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AFPFIKGFGIK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LMHAOHKBLCK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HGKGKJMBGFB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? GCHGLJGBKGK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LMJGIKAOLDO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KLAFCIIECBE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? ODAIGFFDAIJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FAAMNJONJEK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? CJMIHHCJPLO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MHEOEGFJLOG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KHBGBFNFMDC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BJBHBHMHAOI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LDEKGIMLLPF, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MDBDGEKKNMF, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LOKACICHBCL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PJFEPBAPBFI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DDGIFBIACJD, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? NOCNBGJLABB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JNEMEGGBAFI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? EHLNGLEOPOI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? ONGPAIPEFJP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DGGPDMJJBMB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PGMPIGJAGHK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KOGHMGKMEMB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? OEEEFFBCGPP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? POFHFOEHCOD, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FNEMJLGDMKO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DHFENPLJJDI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DADFPBMEJJC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DMDKEEPCIIE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BHKCLCIHMBI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DCNHDHBFOPA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JAIMHGOKFEE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? INIKHJOHCHH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HEOJCHPFKEJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HFMDFELFFEE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DEIJDPENNNL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JMFKODAAIHC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MJFEEGMGGNL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HNLHBKDJHCG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? NPMGNNHLOLL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DBAKCFCMJCM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MHPGKCKKJAK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BNKNLKIPBPM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MEBMMGLAJJD, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? DEFNPJJJBAE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MIJJDKMPNFP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HOPEPMBGPPL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KGILODFHFEH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AFIGNDONKLG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? OEAGIFMFNBK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? POGEOGJCMOA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? CNAPDCMAMBA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LJPOKIJKDMH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? ODEPJCAJAHC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? EKALLKKPMMH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LIPOKENCPPK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FPNMOJIJJGP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LHILKBFMNMJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FFIOLLJPFDO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LNBEKBIFBCI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? APDCKIBDKBG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MNMLEDPILII, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MBPBDICKEML, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BBMNGLNBDOH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? NMLJFFFMBMC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? IOBBMJDANCJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JDNGFDNDDGG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? CANGMODCNFL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? IFJPDKEHHMA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BIKHDEKHEOI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JBPABBMPFEP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? EGACOABKHAL, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PHJCADKFDEP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? NBNIEOACGAP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JEHIMECGIPD, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JLFHJNFHAIJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MGJAOAJNMMH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PHBOGFBPJEE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KPEFEADJLAE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AJGAGHEMJDB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BPEFMBBDACO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FOBAJGEGDMA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? PPEOHKFGECJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? ADFFPBAKIKH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MLIDNBCGEGM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LKAFFMIAANB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AEPFLCJMOKI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LLFKPJICFFC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JJOPFCLBNFF, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? IHEMAKJEENN, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HFKJKFECOCG, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MMHLBMDBCAA, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? APMJEAOBGCB, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JHFOEAAAEDM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AFLMBJLIMNJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? GFNGHOFOPLH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FKELAFLCHLM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AHIFNCMAJOF, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? KFMAKMIAHAK, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JPEKCOOJCFI, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FLFIJNOBEPO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JMNMEJHKCBO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? LCJJGHELPOM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? GHADPCEMFDJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? MAAPJCKJAOF, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JLPFGCBGAJM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? FIEPENLOPDE, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? GBIMNPCJANO, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? APCAFCLKOOM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JKPDCBHMENM, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? AMGNPDGGIDP, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? EGEMHEJLEAC, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? HIDHOOIAKEH, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? BHJOIHGCEGJ, [Optional] IFIFABBHBJL<TContext, TDeps, TCompileState>? JIFEDBENMOB) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AB00", Offset = "0x1E39D00", VA = "0x181E3AB00")]
	private static int KHKGNOKCEGJ([In] FNBPBCOGKJO<byte> AGNBNOOMFNG, FNBPBCOGKJO<byte> LKEJHNGNLDG, int PFGKDMDHLBN, int KIGJDGACGDD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FNGBDPBICFD
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int NNFBGOLCFGE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28CBF10", Offset = "0x28CB110", VA = "0x1828CBF10")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<T>> ECEAFAACJFF<T>([In] this FNBPBCOGKJO<byte> KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28CBF60", Offset = "0x28CB160", VA = "0x1828CBF60")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<T>>> EGEGCOEJHBI<T>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<T>>? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A9C0", Offset = "0x1E39BC0", VA = "0x181E3A9C0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<FAGPAEKFAEG>> PNHKHIPLHHA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<FAGPAEKFAEG>? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<FAGPAEKFAEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A4C0", Offset = "0x1E396C0", VA = "0x181E3A4C0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>> AHJPAOBJPFG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] float? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A8F0", Offset = "0x1E39AF0", VA = "0x181E3A8F0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>> PHMNDPHNILG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A820", Offset = "0x1E39A20", VA = "0x181E3A820")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>> PDIABJGJMLN(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<KHGPBHCJALI>? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A590", Offset = "0x1E39790", VA = "0x181E3A590")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<HAKHKJNAJJL>> IIOBFICJEIC(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] byte? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<HAKHKJNAJJL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A750", Offset = "0x1E39950", VA = "0x181E3A750")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<BGAMOELFEOB>> NPDCCGHPIPB(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<BGAMOELFEOB>? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<BGAMOELFEOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A680", Offset = "0x1E39880", VA = "0x181E3A680")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> JPKMIDINFKJ(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] JJPEHILGEHI? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28CC030", Offset = "0x28CB230", VA = "0x1828CC030")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<T>>> JMEMDLHGBKN<T>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<T>>? NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A2B0", Offset = "0x1E394B0", VA = "0x181E3A2B0")]
	public static void DFGEGDOLEMP(this FNBPBCOGKJO<byte> KNKOEEEKHDK, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>> JBDMDONFHLL, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28CC020", Offset = "0x28CB220", VA = "0x1828CC020")]
	public static void FENLPLHNMOC<T>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<T>>> ENAEIJLNKLP, EIPPGFCFCGI<LPGDGOFEIPD<T>> NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28CC020", Offset = "0x28CB220", VA = "0x1828CC020")]
	public static void OOFHJIMLOFJ<T>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<T>>> GFOADJDKDHD, EIPPGFCFCGI<DGMFFODHHCI<T>> NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BGLBNHEPKCI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A3B0", Offset = "0x1E395B0", VA = "0x181E3A3B0")]
	public static JGPKAMILINE DLCKECKPPOO([In] this ReadOnlySpan<byte> CGAHJPHALBC, int LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A420", Offset = "0x1E39620", VA = "0x181E3A420")]
	public static JGPKAMILINE DLCKECKPPOO([In] this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26A6DD0", Offset = "0x26A5FD0", VA = "0x1826A6DD0")]
	public static JGPKAMILINE DLCKECKPPOO<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A6C10", Offset = "0x26A5E10", VA = "0x1826A6C10")]
	public static JGPKAMILINE DLCKECKPPOO<M>([In] this ENNHJGHABPP<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D20", Offset = "0x26A5F20", VA = "0x1826A6D20")]
	public static JGPKAMILINE DLCKECKPPOO<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D70", Offset = "0x26A5F70", VA = "0x1826A6D70")]
	public static JGPKAMILINE DLCKECKPPOO<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26A6BA0", Offset = "0x26A5DA0", VA = "0x1826A6BA0")]
	public static JGPKAMILINE DLCKECKPPOO<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A3B0", Offset = "0x1E395B0", VA = "0x181E3A3B0")]
	public static int NAKCNPMEJNK([In] this ReadOnlySpan<byte> CGAHJPHALBC, int LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A2A0", Offset = "0x1E394A0", VA = "0x181E3A2A0")]
	public static int NAKCNPMEJNK([In] this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static int NAKCNPMEJNK<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static int NAKCNPMEJNK<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static int NAKCNPMEJNK<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static int NAKCNPMEJNK<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26A7020", Offset = "0x26A6220", VA = "0x1826A7020")]
	public static float IFBBNJNECNM<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26A7020", Offset = "0x26A6220", VA = "0x1826A7020")]
	public static float IFBBNJNECNM<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26A7020", Offset = "0x26A6220", VA = "0x1826A7020")]
	public static float IFBBNJNECNM<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26A71E0", Offset = "0x26A63E0", VA = "0x1826A71E0")]
	public static byte MFCALEOGKCK<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26A71C0", Offset = "0x26A63C0", VA = "0x1826A71C0")]
	public static byte MFCALEOGKCK<M>([In] this ENNHJGHABPP<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D20", Offset = "0x26A5F20", VA = "0x1826A6D20")]
	public static byte MFCALEOGKCK<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D70", Offset = "0x26A5F70", VA = "0x1826A6D70")]
	public static byte MFCALEOGKCK<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26A7210", Offset = "0x26A6410", VA = "0x1826A7210")]
	public static byte MFCALEOGKCK<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A2A0", Offset = "0x1E394A0", VA = "0x181E3A2A0")]
	public static JJPEHILGEHI FLJALDAFOAE([In] this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD)
	{
		return default(JJPEHILGEHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static JJPEHILGEHI FLJALDAFOAE<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(JJPEHILGEHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26A7100", Offset = "0x26A6300", VA = "0x1826A7100")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> JCMPDPCCDHK<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26A7160", Offset = "0x26A6360", VA = "0x1826A7160")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> JCMPDPCCDHK<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26A70A0", Offset = "0x26A62A0", VA = "0x1826A70A0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> JCMPDPCCDHK<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26A7040", Offset = "0x26A6240", VA = "0x1826A7040")]
	public static EIPPGFCFCGI<DGMFFODHHCI<LLKKIPNOJAP>> IPIDGOMKPHI<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<DGMFFODHHCI<LLKKIPNOJAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26A6FC0", Offset = "0x26A61C0", VA = "0x1826A6FC0")]
	public static EIPPGFCFCGI<BGAMOELFEOB> HCHHBCHOOPI<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<BGAMOELFEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F60", Offset = "0x26A6160", VA = "0x1826A6F60")]
	public static EIPPGFCFCGI<BGAMOELFEOB> HCHHBCHOOPI<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<BGAMOELFEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F00", Offset = "0x26A6100", VA = "0x1826A6F00")]
	public static EIPPGFCFCGI<BGAMOELFEOB> HCHHBCHOOPI<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<BGAMOELFEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26A72E0", Offset = "0x26A64E0", VA = "0x1826A72E0")]
	public static EIPPGFCFCGI<FAGPAEKFAEG> NGNAACGBAJD<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<FAGPAEKFAEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26A7340", Offset = "0x26A6540", VA = "0x1826A7340")]
	public static EIPPGFCFCGI<FAGPAEKFAEG> NGNAACGBAJD<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<FAGPAEKFAEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26A7280", Offset = "0x26A6480", VA = "0x1826A7280")]
	public static EIPPGFCFCGI<KHGPBHCJALI> NCMDFCMFAGP<M>(this HDCLKODNOCA<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD)
	{
		return default(EIPPGFCFCGI<KHGPBHCJALI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PANKFCPLFKP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E40750", Offset = "0x1E3F950", VA = "0x181E40750")]
	public static void JKODLLPEOMC(this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD, JGPKAMILINE NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E406E0", Offset = "0x1E3F8E0", VA = "0x181E406E0")]
	public static void JKODLLPEOMC(this byte[] CGAHJPHALBC, int LEEOLPPCLJD, JGPKAMILINE NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E40810", Offset = "0x1E3FA10", VA = "0x181E40810")]
	public static void JKODLLPEOMC([In] this Span<byte> CGAHJPHALBC, int LEEOLPPCLJD, JGPKAMILINE NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A52390", Offset = "0x2A51590", VA = "0x182A52390")]
	public static void JKODLLPEOMC<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, JGPKAMILINE NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A522A0", Offset = "0x2A514A0", VA = "0x182A522A0")]
	public static void JKODLLPEOMC<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, JGPKAMILINE NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A2B0", Offset = "0x1E394B0", VA = "0x181E3A2B0")]
	public static void DFGEGDOLEMP(this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1E405E0", Offset = "0x1E3F7E0", VA = "0x181E405E0")]
	public static void DFGEGDOLEMP(this byte[] CGAHJPHALBC, int LEEOLPPCLJD, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E40660", Offset = "0x1E3F860", VA = "0x181E40660")]
	public static void DFGEGDOLEMP([In] this Span<byte> CGAHJPHALBC, int LEEOLPPCLJD, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A52250", Offset = "0x2A51450", VA = "0x182A52250")]
	public static void DFGEGDOLEMP<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A52200", Offset = "0x2A51400", VA = "0x182A52200")]
	public static void DFGEGDOLEMP<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E405A0", Offset = "0x1E3F7A0", VA = "0x181E405A0")]
	public static void AJFKMJBFGBM(this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD, float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A521B0", Offset = "0x2A513B0", VA = "0x182A521B0")]
	public static void AJFKMJBFGBM<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A52160", Offset = "0x2A51360", VA = "0x182A52160")]
	public static void AJFKMJBFGBM<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E40890", Offset = "0x1E3FA90", VA = "0x181E40890")]
	public static void LHGHDGJOPBN(this FNBPBCOGKJO<byte> CGAHJPHALBC, int LEEOLPPCLJD, byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A52480", Offset = "0x2A51680", VA = "0x182A52480")]
	public static void LHGHDGJOPBN<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A524B0", Offset = "0x2A516B0", VA = "0x182A524B0")]
	public static void LHGHDGJOPBN<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28F3550", Offset = "0x28F2750", VA = "0x1828F3550")]
	public static void FENLPLHNMOC<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28F3550", Offset = "0x28F2750", VA = "0x1828F3550")]
	public static void FENLPLHNMOC<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28F3550", Offset = "0x28F2750", VA = "0x1828F3550")]
	public static void DLOCNCOBJKB<M>(this ACAILBEAMDF<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, EIPPGFCFCGI<BGAMOELFEOB> NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28F3550", Offset = "0x28F2750", VA = "0x1828F3550")]
	public static void DLOCNCOBJKB<M>([In] this MOLKFMENINJ<M, byte> CGAHJPHALBC, EIPPGFCFCGI<M> LEEOLPPCLJD, EIPPGFCFCGI<BGAMOELFEOB> NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NDMPJKIACDP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F420", Offset = "0x1E3E620", VA = "0x181E3F420")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) LIABAADOJEG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FB40", Offset = "0x1E3ED40", VA = "0x181E3FB40")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) NNLFOGIGLJB(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EE00", Offset = "0x1E3E000", VA = "0x181E3EE00")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) KDEBJIOBLIO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FC90", Offset = "0x1E3EE90", VA = "0x181E3FC90")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) NPFELHBOGPG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E40250", Offset = "0x1E3F450", VA = "0x181E40250")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) PIKAGAMKMKE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E030", Offset = "0x1E3D230", VA = "0x181E3E030")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IJNGPKLPFEK(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D0F0", Offset = "0x1E3C2F0", VA = "0x181E3D0F0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GPLLINMGIKB(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AD00", Offset = "0x1E39F00", VA = "0x181E3AD00")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AFCOJMLOALA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D980", Offset = "0x1E3CB80", VA = "0x181E3D980")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IDBOOLEJCPF(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FA30", Offset = "0x1E3EC30", VA = "0x181E3FA30")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>) NGLCJOGMFDE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? NICEPFIEJED, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? PANALGNLIJP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C080", Offset = "0x1E3B280", VA = "0x181E3C080")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>) DONINFMDBON(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NICEPFIEJED, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? PANALGNLIJP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B8E0", Offset = "0x1E3AAE0", VA = "0x181E3B8E0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>) BJNJCENDHKO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? NICEPFIEJED, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? PANALGNLIJP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CAE0", Offset = "0x1E3BCE0", VA = "0x181E3CAE0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>) GFJBACGGLGC(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NICEPFIEJED, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? PANALGNLIJP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D3B0", Offset = "0x1E3C5B0", VA = "0x181E3D3B0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FAGPAEKFAEG>>) HIDPOCCCNID(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? IPBPNPAABBP, [Optional] EIPPGFCFCGI<FAGPAEKFAEG>? MGNENKLDBLN)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FAGPAEKFAEG>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C8A0", Offset = "0x1E3BAA0", VA = "0x181E3C8A0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FAGPAEKFAEG>>>) GFEGKAHJKAF(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? IPBPNPAABBP, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FAGPAEKFAEG>>? MGNENKLDBLN)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FAGPAEKFAEG>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F810", Offset = "0x1E3EA10", VA = "0x181E3F810")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<BGAMOELFEOB>>) MMFLHNJNIAL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? IPBPNPAABBP, [Optional] EIPPGFCFCGI<BGAMOELFEOB>? MGNENKLDBLN)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<BGAMOELFEOB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B240", Offset = "0x1E3A440", VA = "0x181E3B240")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<BGAMOELFEOB>>>) AHLICNAEKEL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? IPBPNPAABBP, [Optional] EIPPGFCFCGI<DGMFFODHHCI<BGAMOELFEOB>>? MGNENKLDBLN)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<BGAMOELFEOB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E950", Offset = "0x2A0DB50", VA = "0x182A0E950")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>) EMMMBBEJBKG<TMarker>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<KHGPBHCJALI>? MGNENKLDBLN, [Optional][In] ReadOnlySpan<byte> FODGEDCJIDC)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DF00", Offset = "0x1E3D100", VA = "0x181E3DF00")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IJKCJENIEKE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int AGNBNOOMFNG, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LKEJHNGNLDG)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F070", Offset = "0x1E3E270", VA = "0x181E3F070")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) KMIJCPMDINO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? AGNBNOOMFNG, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LKEJHNGNLDG)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EC60", Offset = "0x2A0DE60", VA = "0x182A0EC60")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>) KFLJIAIJOBP<TMarker>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<TMarker>>? LKEJHNGNLDG, [Optional] int? MKJBDDDPMKM, [Optional][In] ReadOnlySpan<byte> AGNBNOOMFNG)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EB40", Offset = "0x2A0DD40", VA = "0x182A0EB40")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>) GCJNPMELDPG<TMarker>(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<TMarker>>? AGNBNOOMFNG, [Optional] EIPPGFCFCGI<DGMFFODHHCI<TMarker>>? LKEJHNGNLDG, [Optional] int? MKJBDDDPMKM)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<TMarker>>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E403A0", Offset = "0x1E3F5A0", VA = "0x181E403A0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) PJMEGIJEAAP(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BF30", Offset = "0x1E3B130", VA = "0x181E3BF30")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) DKEKIAIJDHL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F5A0", Offset = "0x1E3E7A0", VA = "0x181E3F5A0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) LKPIJJBBMAK(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BB50", Offset = "0x1E3AD50", VA = "0x181E3BB50")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) CDKKJCJCLNA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B0F0", Offset = "0x1E3A2F0", VA = "0x181E3B0F0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AHFKMBGGFCM(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CEA0", Offset = "0x1E3C0A0", VA = "0x181E3CEA0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GKIBJIKFIDA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EB70", Offset = "0x1E3DD70", VA = "0x181E3EB70")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) KBKNNKOFIPC(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C300", Offset = "0x1E3B500", VA = "0x181E3C300")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) EMGLKCFEFJH(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C780", Offset = "0x1E3B980", VA = "0x181E3C780")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GBNMKFJEGBE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C570", Offset = "0x1E3B770", VA = "0x181E3C570")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>) GBKLPJCEHAI(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? GIABLLGLJKJ)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D800", Offset = "0x1E3CA00", VA = "0x181E3D800")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IADKNLNCMHL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ABA0", Offset = "0x1E39DA0", VA = "0x181E3ABA0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AAMCIBEKFOL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ECD0", Offset = "0x1E3DED0", VA = "0x181E3ECD0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) KCLIBAGFIOH(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BDD0", Offset = "0x1E3AFD0", VA = "0x181E3BDD0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) DICEIOOLMAG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AE50", Offset = "0x1E3A050", VA = "0x181E3AE50")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AFKOILLCBHE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1E40020", Offset = "0x1E3F220", VA = "0x181E40020")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) PALJCONAKKK(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B760", Offset = "0x1E3A960", VA = "0x181E3B760")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) BDEJAJNODIL(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D250", Offset = "0x1E3C450", VA = "0x181E3D250")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) HFHPHKMFJHE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B350", Offset = "0x1E3A550", VA = "0x181E3B350")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AJJCMJIMONG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B600", Offset = "0x1E3A800", VA = "0x181E3B600")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) APFKNACIADH(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F2D0", Offset = "0x1E3E4D0", VA = "0x181E3F2D0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) KONKJPGHACB(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CD80", Offset = "0x1E3BF80", VA = "0x181E3CD80")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GJAIBBFODEI(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DC20", Offset = "0x1E3CE20", VA = "0x181E3DC20")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IFAMFGDPFND(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E520", Offset = "0x1E3D720", VA = "0x181E3E520")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JHNGOGBPIJO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C9B0", Offset = "0x1E3BBB0", VA = "0x181E3C9B0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GFHDANGAHIG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DDA0", Offset = "0x1E3CFA0", VA = "0x181E3DDA0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IFJLFNLOCAO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AFA0", Offset = "0x1E3A1A0", VA = "0x181E3AFA0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) AGCMKEAPNEP(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E2B0", Offset = "0x1E3D4B0", VA = "0x181E3E2B0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JFCBGNELCOP(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B480", Offset = "0x1E3A680", VA = "0x181E3B480")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) APDBJOGCJDP(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D550", Offset = "0x1E3C750", VA = "0x181E3D550")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) HINBKGILAJH(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CFC0", Offset = "0x1E3C1C0", VA = "0x181E3CFC0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GNAHNIPLPOE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EA10", Offset = "0x1E3DC10", VA = "0x181E3EA10")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JOLCHNBBEJB(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E3D0", Offset = "0x1E3D5D0", VA = "0x181E3E3D0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JFNOLHPJPAE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C660", Offset = "0x1E3B860", VA = "0x181E3C660")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) GBNENLIOLIK(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CC00", Offset = "0x1E3BE00", VA = "0x181E3CC00")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) GIFJPBJFBLO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EF20", Offset = "0x1E3E120", VA = "0x181E3EF20")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) KGBCDLMAGBD(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E8F0", Offset = "0x1E3DAF0", VA = "0x181E3E8F0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) JOIPABJACKM(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B9F0", Offset = "0x1E3ABF0", VA = "0x181E3B9F0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) BPEKGGFMMOA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E680", Offset = "0x1E3D880", VA = "0x181E3E680")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JHPFHEABCMG(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BCB0", Offset = "0x1E3AEB0", VA = "0x181E3BCB0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) DFNBMNFDLAC(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FF10", Offset = "0x1E3F110", VA = "0x181E3FF10")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) OKGMNDDCJGC(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] int? CKICEOPALKO, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1E40140", Offset = "0x1E3F340", VA = "0x181E40140")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) PCAGHOMEFOJ(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? CKICEOPALKO, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F9B0", Offset = "0x1E3EBB0", VA = "0x181E3F9B0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> NAJLMEMAEBP(this FNBPBCOGKJO<byte> KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DAA0", Offset = "0x1E3CCA0", VA = "0x181E3DAA0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) IEGCNFCPOGJ(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D6B0", Offset = "0x1E3C8B0", VA = "0x181E3D6B0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) HNAKKBBMHJN(this FNBPBCOGKJO<byte> KNKOEEEKHDK, float HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<GBFKBFKDNEF>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C450", Offset = "0x1E3B650", VA = "0x181E3C450")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>) FLNCIDKNDMH(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<GBFKBFKDNEF>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<GBFKBFKDNEF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C1A0", Offset = "0x1E3B3A0", VA = "0x181E3C1A0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) EHNEFALDABO(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F180", Offset = "0x1E3E380", VA = "0x181E3F180")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) KNCGOLGOOFA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E7D0", Offset = "0x1E3D9D0", VA = "0x181E3E7D0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) JNKFDPIMNJA(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E150", Offset = "0x1E3D350", VA = "0x181E3E150")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) IPGPHMLHIEE(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F6C0", Offset = "0x1E3E8C0", VA = "0x181E3F6C0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) LNICENKLMNF(this FNBPBCOGKJO<byte> KNKOEEEKHDK, int HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FDF0", Offset = "0x1E3EFF0", VA = "0x181E3FDF0")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>) OEOLJIEGELK(this FNBPBCOGKJO<byte> KNKOEEEKHDK, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? HAOMGFAPNPN, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? LBCEJKGAOCA, [Optional] EIPPGFCFCGI<DGMFFODHHCI<FDNMKMOBOAM>>? NLALHKJFEHP)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<FDNMKMOBOAM>>>));
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
