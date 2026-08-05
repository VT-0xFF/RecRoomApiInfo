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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2918570", Offset = "0x2917170", VA = "0x182918570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLNJKNPCDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A58220", Offset = "0x3A56E20", VA = "0x183A58220")]
	public static IKLALLBKLKC<FBBBJKHBBDB<M>> NGFGHDINOMP<M>(this int LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2918540", Offset = "0x2917140", VA = "0x182918540")]
	public static IKLALLBKLKC<GHCHPNLGLBH> FIBMMJGOEFH(this int LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<GHCHPNLGLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A58220", Offset = "0x3A56E20", VA = "0x183A58220")]
	public static IKLALLBKLKC<DGDDJKDGKMF<M>> LFFBMAMJMFI<M>(this int LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<DGDDJKDGKMF<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FBBBJKHBBDB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NJNBEBOBIJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AHBNIAOBGCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GHCHPNLGLBH
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CHFJELKDJEN
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CBOCDEIFMCJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GGNABIDPJBO
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
public static class OOBPDECGFBB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct NBHODGLOGPN<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr BIDLIDINMLF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
		public NBHODGLOGPN(IntPtr JCPBJCFMJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55188F0", Offset = "0x55174F0", VA = "0x1855188F0")]
		public int JMCDHFFLEOJ(TDeps FCHJEFGMLNE, TContext GEKAHFAOKFB, TCompileState PBHHLGFCKAL, [In] MJLLGLFJCNK<byte> IGHMHBLOJAN, int KAJPEMGLPLH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C77F80", Offset = "0x3C76B80", VA = "0x183C77F80")]
	public static void AELCNFOCBGD<TDeps, TContext, TCompileState>(TDeps FCHJEFGMLNE, TContext GEKAHFAOKFB, TCompileState PBHHLGFCKAL, [In] MJLLGLFJCNK<byte> PGBNFOCKBHN, MJLLGLFJCNK<byte> BLJGLGOCNNN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GKLMELNEPAJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? DHKIIDEBHHC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HAOAANFJLJA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HIHAILCCHCN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OGOIKFPLCOH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FDDGGLNPGKD, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OKKHFLEOCNC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IBMAKIHCMIG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KJGHBIFNJEN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? POLCOHEKOEC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? DDCCLHBJHFA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JLAKBBNCBKC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? PONGFBOMODO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? AFDJGDGCIPM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MJEJNGKEFAG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HLEBONLJDPA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JDPHELBOEDH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OKGGBOFCBLE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? PGKGPBPDBGF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KMFPPPLDOBH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IPHHLJMBBHB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? LMHNBFJLKAL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JHHOPCMNJJA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OPLDLKFPCNF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KBLDFOBPGCA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JPIDHJNNGOK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IPGFMGNFNIK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MGGIGODJAJD, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GCODCANKOIJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MJIKGDEAAHF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? AEEFADEBEMF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OKKOLALHIPE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GEOEMLOMLEB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GNLEBLHMEJB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GFLJMAAKHEM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NJLIEBAHFMJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FHPBLABGGHM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OLBHFLAKFDO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CGKMEEKCJDJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IKANKOIKJDO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ELBAMLMEBGN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ANHEDAPFKJL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NNMOJKHGBOG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OAAGBMKHLKN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IKPOLHEKLIH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CDMBLPLCHCK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BCFCDBIHPCD, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KDKEACANCEL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GPAIOJCIHNH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KBNIHGNPGCC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EKNOBHOEPDH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EGGHOBLECDO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? LALIMHJEJPH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? APENHILJDAE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EGMNCNBPGLA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CIGFBGBGKHB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? DIAMJCBBLOH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EGHBECBLNHO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CCAICEHINKG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HIAABGIFCMJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MGFGCIPKLJP, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OEKKFLPCNLG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KPPIOAJAAGG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? AEBJHFEODEK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HANDOLENCJO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FNHGKIMGAGO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HDMPMBOGELF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? PBHKOEPLKMI, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JAMMHHCBDEA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CPNEGKDDGLE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NMBNOABNIDN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MMPGJLBLJCO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KHKOKAGPPLI, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? APMMEKAANOK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? AIMMEMHNGCP, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MJCJFCBLNOM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CECAHHMINJH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EBPBOBBHBGO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? COAEFJCBILL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CJAAMENCNCD, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NKHBLANOOEP, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MLDJKDFGNMG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FJGGBHMKHOE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GGHMCJMEEMB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BHNNIDIADMN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ONJMDLMGHJJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? COJHEFDIPNO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ANPLBIJDBMJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CFNFEFHLHDL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NHHEGGBNFLL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CGLCJHCHJJO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HGKAMEHBKPO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MHGIECLPJFI, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JJOPFDJPCFF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ABNNAGDLHNL, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HGHPOBPFFKB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OBBAMEJIGNC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MONGGPEPAKN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CIPBMNBFDEJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BGHHLECEABM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OABDCAGHNPA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MBJOGKPAHNM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JKBNDHGLPDO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MBAGLPHBGHA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? DIHGBBKGCKA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? GPFCNBOMJHB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BGIMEDBHLIH, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ILMONNJMDCB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BKNLOHKBAPP, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CJNNMMLPBHI, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? MEMPDCCGCJK, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HMPIPMHNDFO, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IFCOLEFPBNF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? DFHLKNEGONB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? PHLGDKDHFIA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? JOLBPKLIDEN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OLCKJNPPBNJ, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EOILPJLEAAI, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OCMICJKJPBC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? AJHJNMIHBKE, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? ACEMOJDDHBB, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EGJMFCAIABA, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? KELKCKJMLIG, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HMBBFANHBGC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? IMJKACNOBIP, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? CPBJGPPNDGM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HGBLDGNNCHC, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? NOICDCMMHHM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FFIIBMMCKJF, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? OFEHHDNLONN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EHOEOFCCKJM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? BCANNACFHBN, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? EBOEEJOLHFM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? FLNPKJFIPBM, [Optional] NBHODGLOGPN<TContext, TDeps, TCompileState>? HKPOANNDMLO) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x291E580", Offset = "0x291D180", VA = "0x18291E580")]
	private static int FBAHIPKACFD([In] MJLLGLFJCNK<byte> BBKPJEIDMDD, MJLLGLFJCNK<byte> HKLMEDDFFBN, int EILAIOEPAPK, int DPOOEAFKIHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OMMFNFHKKKO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int ICGNAOCGGEE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C77990", Offset = "0x3C76590", VA = "0x183C77990")]
	public static IKLALLBKLKC<FBBBJKHBBDB<T>> GBDHKECFDIE<T>([In] this MJLLGLFJCNK<byte> LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C778C0", Offset = "0x3C764C0", VA = "0x183C778C0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<T>>> DOPJMCFGEFE<T>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<FBBBJKHBBDB<T>>? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x291E200", Offset = "0x291CE00", VA = "0x18291E200")]
	public static IKLALLBKLKC<FBBBJKHBBDB<OIFGIPCOJFI>> BIJOCOJICAA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<OIFGIPCOJFI>? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<OIFGIPCOJFI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x291E130", Offset = "0x291CD30", VA = "0x18291E130")]
	public static IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>> BEAIEPGMHEG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] float? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x291E470", Offset = "0x291D070", VA = "0x18291E470")]
	public static IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>> MKFALODIBNA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x291E2D0", Offset = "0x291CED0", VA = "0x18291E2D0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>> BMMIFDPKFCO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<EALKCLEEIPA>? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x291DF70", Offset = "0x291CB70", VA = "0x18291DF70")]
	public static IKLALLBKLKC<FBBBJKHBBDB<CBOCDEIFMCJ>> ANEBDMKDECI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] byte? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<CBOCDEIFMCJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x291E060", Offset = "0x291CC60", VA = "0x18291E060")]
	public static IKLALLBKLKC<FBBBJKHBBDB<GHCHPNLGLBH>> BAIOPMJKIGO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<GHCHPNLGLBH>? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<GHCHPNLGLBH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x291E3A0", Offset = "0x291CFA0", VA = "0x18291E3A0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> LGMCLEKELNH(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] GGNABIDPJBO? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C779E0", Offset = "0x3C765E0", VA = "0x183C779E0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<T>>> PLINMHHDGPN<T>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<T>>? OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29180F0", Offset = "0x2916CF0", VA = "0x1829180F0")]
	public static void GOLPKPHGDHC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>> CMPINPOJOHA, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C77980", Offset = "0x3C76580", VA = "0x183C77980")]
	public static void JMLOAJEECHI<T>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<T>>> KAJPEMGLPLH, IKLALLBKLKC<FBBBJKHBBDB<T>> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C77980", Offset = "0x3C76580", VA = "0x183C77980")]
	public static void FOCKDBLOFFN<T>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<T>>> KOIAMNMAGJP, IKLALLBKLKC<DGDDJKDGKMF<T>> OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PMPIGGAAMAA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x291E620", Offset = "0x291D220", VA = "0x18291E620")]
	public static KAMJILGICKA OMBMEKPLEKO([In] this ReadOnlySpan<byte> OEOOBGJGDIH, int JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x291E690", Offset = "0x291D290", VA = "0x18291E690")]
	public static KAMJILGICKA OMBMEKPLEKO([In] this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C867F0", Offset = "0x3C853F0", VA = "0x183C867F0")]
	public static KAMJILGICKA OMBMEKPLEKO<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C86670", Offset = "0x3C85270", VA = "0x183C86670")]
	public static KAMJILGICKA OMBMEKPLEKO<M>([In] this CONKCBINAIO<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C86180", Offset = "0x3C84D80", VA = "0x183C86180")]
	public static KAMJILGICKA OMBMEKPLEKO<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C86120", Offset = "0x3C84D20", VA = "0x183C86120")]
	public static KAMJILGICKA OMBMEKPLEKO<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C86780", Offset = "0x3C85380", VA = "0x183C86780")]
	public static KAMJILGICKA OMBMEKPLEKO<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x291E620", Offset = "0x291D220", VA = "0x18291E620")]
	public static int OFLBJCAPPPE([In] this ReadOnlySpan<byte> OEOOBGJGDIH, int JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2918130", Offset = "0x2916D30", VA = "0x182918130")]
	public static int OFLBJCAPPPE([In] this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B20", Offset = "0x3AB8720", VA = "0x183AB9B20")]
	public static int OFLBJCAPPPE<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B20", Offset = "0x3AB8720", VA = "0x183AB9B20")]
	public static int OFLBJCAPPPE<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B20", Offset = "0x3AB8720", VA = "0x183AB9B20")]
	public static int OFLBJCAPPPE<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B20", Offset = "0x3AB8720", VA = "0x183AB9B20")]
	public static int OFLBJCAPPPE<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C86590", Offset = "0x3C85190", VA = "0x183C86590")]
	public static float MEFJMLBHFGI<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C86590", Offset = "0x3C85190", VA = "0x183C86590")]
	public static float MEFJMLBHFGI<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C86590", Offset = "0x3C85190", VA = "0x183C86590")]
	public static float MEFJMLBHFGI<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C86240", Offset = "0x3C84E40", VA = "0x183C86240")]
	public static byte CJBLAOCMDIM<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C86270", Offset = "0x3C84E70", VA = "0x183C86270")]
	public static byte CJBLAOCMDIM<M>([In] this CONKCBINAIO<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C86180", Offset = "0x3C84D80", VA = "0x183C86180")]
	public static byte CJBLAOCMDIM<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C86120", Offset = "0x3C84D20", VA = "0x183C86120")]
	public static byte CJBLAOCMDIM<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C861D0", Offset = "0x3C84DD0", VA = "0x183C861D0")]
	public static byte CJBLAOCMDIM<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2918130", Offset = "0x2916D30", VA = "0x182918130")]
	public static GGNABIDPJBO NGGAGEIDEKM([In] this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG)
	{
		return default(GGNABIDPJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B20", Offset = "0x3AB8720", VA = "0x183AB9B20")]
	public static GGNABIDPJBO NGGAGEIDEKM<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(GGNABIDPJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C864D0", Offset = "0x3C850D0", VA = "0x183C864D0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MCBKOLFMHPE<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C86530", Offset = "0x3C85130", VA = "0x183C86530")]
	public static IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MCBKOLFMHPE<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3C86470", Offset = "0x3C85070", VA = "0x183C86470")]
	public static IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MCBKOLFMHPE<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C86290", Offset = "0x3C84E90", VA = "0x183C86290")]
	public static IKLALLBKLKC<DGDDJKDGKMF<OICBEJIKPDD>> DKAJMMJGAMI<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<DGDDJKDGKMF<OICBEJIKPDD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C863B0", Offset = "0x3C84FB0", VA = "0x183C863B0")]
	public static IKLALLBKLKC<GHCHPNLGLBH> ILLBCPLKKOI<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<GHCHPNLGLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C86350", Offset = "0x3C84F50", VA = "0x183C86350")]
	public static IKLALLBKLKC<GHCHPNLGLBH> ILLBCPLKKOI<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<GHCHPNLGLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C86410", Offset = "0x3C85010", VA = "0x183C86410")]
	public static IKLALLBKLKC<GHCHPNLGLBH> ILLBCPLKKOI<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<GHCHPNLGLBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C865B0", Offset = "0x3C851B0", VA = "0x183C865B0")]
	public static IKLALLBKLKC<OIFGIPCOJFI> MFPCNLCFNAJ<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<OIFGIPCOJFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C86610", Offset = "0x3C85210", VA = "0x183C86610")]
	public static IKLALLBKLKC<OIFGIPCOJFI> MFPCNLCFNAJ<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<OIFGIPCOJFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3C862F0", Offset = "0x3C84EF0", VA = "0x183C862F0")]
	public static IKLALLBKLKC<EALKCLEEIPA> GFPEBNFHFEF<M>(this JBAFCMMBKLF<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG)
	{
		return default(IKLALLBKLKC<EALKCLEEIPA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BNKFFFDPMFL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2918250", Offset = "0x2916E50", VA = "0x182918250")]
	public static void GHBGJCHFMKB(this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG, KAMJILGICKA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29181E0", Offset = "0x2916DE0", VA = "0x1829181E0")]
	public static void GHBGJCHFMKB(this byte[] OEOOBGJGDIH, int JOABIEDGONG, KAMJILGICKA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2918310", Offset = "0x2916F10", VA = "0x182918310")]
	public static void GHBGJCHFMKB([In] this Span<byte> OEOOBGJGDIH, int JOABIEDGONG, KAMJILGICKA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3839A70", Offset = "0x3838670", VA = "0x183839A70")]
	public static void GHBGJCHFMKB<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, KAMJILGICKA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3839B60", Offset = "0x3838760", VA = "0x183839B60")]
	public static void GHBGJCHFMKB<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, KAMJILGICKA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29180F0", Offset = "0x2916CF0", VA = "0x1829180F0")]
	public static void GOLPKPHGDHC(this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2918410", Offset = "0x2917010", VA = "0x182918410")]
	public static void GOLPKPHGDHC(this byte[] OEOOBGJGDIH, int JOABIEDGONG, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2918390", Offset = "0x2916F90", VA = "0x182918390")]
	public static void GOLPKPHGDHC([In] this Span<byte> OEOOBGJGDIH, int JOABIEDGONG, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3839C50", Offset = "0x3838850", VA = "0x183839C50")]
	public static void GOLPKPHGDHC<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3839CA0", Offset = "0x38388A0", VA = "0x183839CA0")]
	public static void GOLPKPHGDHC<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2918500", Offset = "0x2917100", VA = "0x182918500")]
	public static void NOBIHDPNEOB(this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3839D60", Offset = "0x3838960", VA = "0x183839D60")]
	public static void NOBIHDPNEOB<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3839DB0", Offset = "0x38389B0", VA = "0x183839DB0")]
	public static void NOBIHDPNEOB<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2918490", Offset = "0x2917090", VA = "0x182918490")]
	public static void KKICALHNHBM(this MJLLGLFJCNK<byte> OEOOBGJGDIH, int JOABIEDGONG, byte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3839D30", Offset = "0x3838930", VA = "0x183839D30")]
	public static void KKICALHNHBM<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, byte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3839D00", Offset = "0x3838900", VA = "0x183839D00")]
	public static void KKICALHNHBM<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, byte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3839CF0", Offset = "0x38388F0", VA = "0x183839CF0")]
	public static void JMLOAJEECHI<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3839CF0", Offset = "0x38388F0", VA = "0x183839CF0")]
	public static void JMLOAJEECHI<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3839CF0", Offset = "0x38388F0", VA = "0x183839CF0")]
	public static void NDMFEONLJKG<M>(this OCPNFEIIAGN<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, IKLALLBKLKC<GHCHPNLGLBH> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3839CF0", Offset = "0x38388F0", VA = "0x183839CF0")]
	public static void NDMFEONLJKG<M>([In] this BIKAGNBMPEA<M, byte> OEOOBGJGDIH, IKLALLBKLKC<M> JOABIEDGONG, IKLALLBKLKC<GHCHPNLGLBH> OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OBBPNLJHJLB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29199E0", Offset = "0x29185E0", VA = "0x1829199E0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) DBJPDFKGAJE(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x291BE20", Offset = "0x291AA20", VA = "0x18291BE20")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) KGHHJJLPBAL(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x291BB60", Offset = "0x291A760", VA = "0x18291BB60")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) JPHIHKOEJGM(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2919720", Offset = "0x2918320", VA = "0x182919720")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) COEDJLBGLGE(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x291C860", Offset = "0x291B460", VA = "0x18291C860")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) LOCGINLKDKM(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x291B670", Offset = "0x291A270", VA = "0x18291B670")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) JCFFKHDNKGG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x291D140", Offset = "0x291BD40", VA = "0x18291D140")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) NMNOGPFNGCK(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x291A670", Offset = "0x2919270", VA = "0x18291A670")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) EHIEGLFFDKA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x291D400", Offset = "0x291C000", VA = "0x18291D400")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OALJMCJMABP(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x291DE60", Offset = "0x291CA60", VA = "0x18291DE60")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>) PODIJDFCPPL(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? OOHGFGHCOAJ, [Optional] IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? GMHHLLJGHFJ)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x291AC30", Offset = "0x2919830", VA = "0x18291AC30")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>) FKIMHCBLPLN(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? OOHGFGHCOAJ, [Optional] IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? GMHHLLJGHFJ)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2919330", Offset = "0x2917F30", VA = "0x182919330")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>) CFJJCIMAONO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? OOHGFGHCOAJ, [Optional] IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? GMHHLLJGHFJ)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29185F0", Offset = "0x29171F0", VA = "0x1829185F0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>) ACPPBIGNDCF(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? OOHGFGHCOAJ, [Optional] IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? GMHHLLJGHFJ)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x291BC80", Offset = "0x291A880", VA = "0x18291BC80")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<OIFGIPCOJFI>>) KDNNCHAMENC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? HCGMAGDKMML, [Optional] IKLALLBKLKC<OIFGIPCOJFI>? PAGHHLHAGEE)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<OIFGIPCOJFI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x291C750", Offset = "0x291B350", VA = "0x18291C750")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OIFGIPCOJFI>>>) LOBIOEIDJNA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? HCGMAGDKMML, [Optional] IKLALLBKLKC<DGDDJKDGKMF<OIFGIPCOJFI>>? PAGHHLHAGEE)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OIFGIPCOJFI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2918E10", Offset = "0x2917A10", VA = "0x182918E10")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<GHCHPNLGLBH>>) BNCOCGNLKDN(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? HCGMAGDKMML, [Optional] IKLALLBKLKC<GHCHPNLGLBH>? PAGHHLHAGEE)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<GHCHPNLGLBH>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29190C0", Offset = "0x2917CC0", VA = "0x1829190C0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<GHCHPNLGLBH>>>) CFCOHFDAGBE(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? HCGMAGDKMML, [Optional] IKLALLBKLKC<DGDDJKDGKMF<GHCHPNLGLBH>>? PAGHHLHAGEE)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<GHCHPNLGLBH>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3C681F0", Offset = "0x3C66DF0", VA = "0x183C681F0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>) PLFINBEGDGM<TMarker>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<EALKCLEEIPA>? PAGHHLHAGEE, [Optional][In] ReadOnlySpan<byte> PEDMEJIDLNB)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x291B540", Offset = "0x291A140", VA = "0x18291B540")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) IOLGBJKIMPC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int BBKPJEIDMDD, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HKLMEDDFFBN)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2918FB0", Offset = "0x2917BB0", VA = "0x182918FB0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) CEMIKCNIENK(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? BBKPJEIDMDD, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HKLMEDDFFBN)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C67EF0", Offset = "0x3C66AF0", VA = "0x183C67EF0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>) CLAFCENLIDG<TMarker>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<TMarker>>? HKLMEDDFFBN, [Optional] int? DKFJGBGJGBG, [Optional][In] ReadOnlySpan<byte> BBKPJEIDMDD)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C680D0", Offset = "0x3C66CD0", VA = "0x183C680D0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>) JGGBJKKFIMK<TMarker>(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<TMarker>>? BBKPJEIDMDD, [Optional] IKLALLBKLKC<DGDDJKDGKMF<TMarker>>? HKLMEDDFFBN, [Optional] int? DKFJGBGJGBG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<TMarker>>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x291C4B0", Offset = "0x291B0B0", VA = "0x18291C4B0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) LEAFAGIMLOL(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2918890", Offset = "0x2917490", VA = "0x182918890")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) BCAALMJAMKO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x291C0F0", Offset = "0x291ACF0", VA = "0x18291C0F0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) KNIKONAIMIM(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2919F30", Offset = "0x2918B30", VA = "0x182919F30")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DLGOBJOKLJK(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x291BA10", Offset = "0x291A610", VA = "0x18291BA10")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) JNCEILDEEHI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x291A090", Offset = "0x2918C90", VA = "0x18291A090")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DNPBKHNKNMM(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2919440", Offset = "0x2918040", VA = "0x182919440")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) CGBBCGNBOOI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x291CD80", Offset = "0x291B980", VA = "0x18291CD80")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) MCPDBGPNKBC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x291C630", Offset = "0x291B230", VA = "0x18291C630")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) LKDPGFIMJND(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x291A580", Offset = "0x2919180", VA = "0x18291A580")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>) EHEGDCPPBDA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? POCKALBMPOM)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2918710", Offset = "0x2917310", VA = "0x182918710")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) AOKOJLBLOEL(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x291B360", Offset = "0x2919F60", VA = "0x18291B360")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) HIFPCLALFBI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x291DD30", Offset = "0x291C930", VA = "0x18291DD30")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OPPCIJNLOFH(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x291D930", Offset = "0x291C530", VA = "0x18291D930")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OJBOHFGKHBJ(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x291C210", Offset = "0x291AE10", VA = "0x18291C210")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) KOJLOGAPGOC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x291CB00", Offset = "0x291B700", VA = "0x18291CB00")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) MAMHJMGJHFG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29195A0", Offset = "0x29181A0", VA = "0x1829195A0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) CNJGOPHHPON(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2919880", Offset = "0x2918480", VA = "0x182919880")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) CPEAHOJMBGN(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x291B230", Offset = "0x2919E30", VA = "0x18291B230")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) GOMKDBDODBI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x291CC20", Offset = "0x291B820", VA = "0x18291CC20")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) MCNGBKIJDOK(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x291A310", Offset = "0x2918F10", VA = "0x18291A310")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DPIIIFGIHOA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x291AFF0", Offset = "0x2919BF0", VA = "0x18291AFF0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) GHMEKCGCOBG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2919B60", Offset = "0x2918760", VA = "0x182919B60")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DFFBDEJPAGB(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2918CB0", Offset = "0x29178B0", VA = "0x182918CB0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) BIFDPOEOMIF(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x291A8E0", Offset = "0x29194E0", VA = "0x18291A8E0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) EKLOAICLJOB(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x291D520", Offset = "0x291C120", VA = "0x18291D520")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OBKMDKOBODB(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2918B60", Offset = "0x2917760", VA = "0x182918B60")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) BGBENJFCDBL(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2919E10", Offset = "0x2918A10", VA = "0x182919E10")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DKNKKIFGMHH(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x291BF70", Offset = "0x291AB70", VA = "0x18291BF70")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) KNHLPCONLNN(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x291A1B0", Offset = "0x2918DB0", VA = "0x18291A1B0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DOELGOCOPDE(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2919CE0", Offset = "0x29188E0", VA = "0x182919CE0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) DIDJMJAAKGD(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x291B8B0", Offset = "0x291A4B0", VA = "0x18291B8B0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) JKELNKDGKEO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x291C360", Offset = "0x291AF60", VA = "0x18291C360")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) LBMINMAIPKD(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x291A460", Offset = "0x2919060", VA = "0x18291A460")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) EAPJPKIADMD(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x291AE70", Offset = "0x2919A70", VA = "0x18291AE70")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) GHDIMIBOLKI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x291C9B0", Offset = "0x291B5B0", VA = "0x18291C9B0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) LPONHPOIPAE(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x291B790", Offset = "0x291A390", VA = "0x18291B790")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) JHHOPCBNCIO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29191D0", Offset = "0x2917DD0", VA = "0x1829191D0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) CFDPOLENGBF(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x291CFF0", Offset = "0x291BBF0", VA = "0x18291CFF0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) NEPIBODFEPF(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x291B110", Offset = "0x2919D10", VA = "0x18291B110")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) GMNNAEBENGI(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x291AB20", Offset = "0x2919720", VA = "0x18291AB20")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) FIIONNIFOIO(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] int? FFBFEALHEHP, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x291AA10", Offset = "0x2919610", VA = "0x18291AA10")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) FDOJGBCOAMP(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? FFBFEALHEHP, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x291B4C0", Offset = "0x291A0C0", VA = "0x18291B4C0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> IOANMPHBIJA(this MJLLGLFJCNK<byte> LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x29189E0", Offset = "0x29175E0", VA = "0x1829189E0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) BFDJPGKNEJH(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x291DA90", Offset = "0x291C690", VA = "0x18291DA90")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) OMAICNJILBC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, float HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<NJNBEBOBIJC>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x291AD50", Offset = "0x2919950", VA = "0x18291AD50")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>) FPCBONOJJMG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<NJNBEBOBIJC>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<NJNBEBOBIJC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x291D2A0", Offset = "0x291BEA0", VA = "0x18291D2A0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OADIOFOMCOK(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x291DBE0", Offset = "0x291C7E0", VA = "0x18291DBE0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) ONJKAGDPJCA(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x291CED0", Offset = "0x291BAD0", VA = "0x18291CED0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) NAIODELDDDG(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x291D7D0", Offset = "0x291C3D0", VA = "0x18291D7D0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OENLFLPHFDC(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x291D680", Offset = "0x291C280", VA = "0x18291D680")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) OCMDHJNPHMN(this MJLLGLFJCNK<byte> LAAPKLDJLPE, int HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x291A7C0", Offset = "0x29193C0", VA = "0x18291A7C0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>) EIONKLOMKHB(this MJLLGLFJCNK<byte> LAAPKLDJLPE, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? HJGNALALCBH, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? EHHJAGNGOON, [Optional] IKLALLBKLKC<DGDDJKDGKMF<AHBNIAOBGCP>>? ELLGKFHHCCG)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<AHBNIAOBGCP>>>));
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
