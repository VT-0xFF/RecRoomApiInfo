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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E3D040", Offset = "0x1E3C040", VA = "0x181E3D040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FBIMNKBBDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<M>> EEHBFMGOFCC<M>(this int HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E36C10", Offset = "0x1E35C10", VA = "0x181E36C10")]
	public static JLADLGKIDDG<AHKIDIJDGNC> ONKACCENBKE(this int HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<AHKIDIJDGNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static JLADLGKIDDG<PHCJBMLJEPM<M>> MIFHLPFDGHB<M>(this int HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<PHCJBMLJEPM<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IDLGMCCAMDG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CIGICPHIEIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PJBEFFCNGMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AHKIDIJDGNC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DBMDCKBHFBA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NFAOIPLNGEP
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BCPHONCEPFD
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
public static class BMEPBJOBAPP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct BMJKIPLKPPH<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr BIHKANIIDAB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
		public BMJKIPLKPPH(IntPtr OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4921E50", Offset = "0x4920E50", VA = "0x184921E50")]
		public int HEGHDPNDHOB(TDeps AKOGIKBAMPF, TContext PNMNIPGGMGH, TCompileState MJKNOPPFGHO, [In] EJCNFOOPALK<byte> AODDEHDGOHN, int LFCMPLFCDIH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26BE5D0", Offset = "0x26BD5D0", VA = "0x1826BE5D0")]
	public static void CHDACFMCPBG<TDeps, TContext, TCompileState>(TDeps AKOGIKBAMPF, TContext PNMNIPGGMGH, TCompileState MJKNOPPFGHO, [In] EJCNFOOPALK<byte> CDJLKGIBGKA, EJCNFOOPALK<byte> JPIMAIEAHEH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? KPBEALNADPL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BMGEIGHHFAF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FGPHNNLKGPM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MEIHFGBJPFA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EMLCFFFJGGP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CLJLAJHIMBN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AGCFFBCNFAF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CMCPHKJJILO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? ILJCAJBFDCJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JHGLFPMGGIM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JNLGFMIFNDA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PKMFJFJENGJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BCFDLKHLGGN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DAOEIACCOJD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MOKJAFLBCGO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EAHHDJMJGLL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AFNLBIDIJNE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PDLPLIHGBPP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NIODKLKCJPI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HAFNNDHEOLJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OIHNNJEJLJL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LOBDAJNCMFP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OPGLEEJHFMP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GOHALLJHPPC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AIJJPLODMNI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DLCGELBHDNJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NNEHEKICJHA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BAKNBDFILGN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HLNOOFCBECM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GPENKLPFHKN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AMONJAEDGID, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NANECJAAAHO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MGHFOINMNEO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DMDNEIDNLAD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IDKGEGLMLMB, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IGNLHMEOLFM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JODEHNPHNFN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LNHPFPGCJIA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OFKEKDJCAPC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CCAGFPGOCID, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JACHBFJGCAF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PPCECPHBGAJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NHIDKEEPJFK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FAFBFJNDFBH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GCCMGCOICCN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HPIGPNMLAEK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EMMPHDAEMDI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IKMOIIBGHCP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FPDKPDMHKMM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OMNFNEBKHJF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NHPKEJJEBOD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LLBPGDNJEJJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HCGNLJKALNM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FHIHMALBJNK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NFPOHFDELNK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AKIFMIMDAGP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PIFLOCKOAAJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JLBBCKAHFEC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IDFHAHILIGH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EJCMJNGAMGL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OOBHLHHEEEJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DDJDJPAEOJK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? ICOECCNBKHN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GMPFIAENMIK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PIDAIBPKBNN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MOEDKDFBBCM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PEHGEMBKFLH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FDCHJPJDMNC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PPLLDMJALAJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MGHGLAJHCAE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FOBDIMEIOHK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HBHMPMJKHHF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BDBDGHHDNIK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MHCDBBCJAMD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DILODCOIPIO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AFADICHMNNE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? ODCKIGCKJGN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GHEMPINAALM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? PKBEIPFKKLE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? KFMEEDCEPMI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EPDFACJPFNC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CDNNKGHEBNO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AKIOCJFODLA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IEDENGHIJFI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BHAJMLHAOJM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GGJCGLPEDJF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DOKLPCOIDBJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IPALLADMMCE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GMDLGLNCODB, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NAOMJDAKCMO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NCDPEFKCEFO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DKNCPJJKLHI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FAJOALJNJIF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DDBEHFEAMMM, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HOCAINNLAKH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AMONCHECCGI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HGKAOMOAALP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CFLOGEDNNEN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EFMJMKKDMAH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BEEMLKCBJDG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NCNKOMBPKPF, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OIDDPDEGPEG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AHOEOIDCGIN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DFMIILFHHKN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? ONCEDAOHAAE, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LOBKJKOILKC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DKJBGHHCNKD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NIIPCCOPKEG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LKCPLIHDHND, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DDFHKPLJNKL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CILMIBOGIGG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DGGNECMGCKC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DALNADHCCJO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NOAPLPNFJHB, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? NPCJNOADAPL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? JBCODKHJKFI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LLODLMKHKOO, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? LEIFIBMOCEG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GFMJGOLPDNL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? IJDGGAOIFNL, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? MEBDIONCIEG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? KFMHGLHPDMP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? DLCDEAJIAEK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FPLMECPFPIC, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OGLMGLAHKKG, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? CLBJOIPALAN, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GBNJLACHCBI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? OMAELJLMPKI, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? GMDNHEMHJPP, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FKMHPGHJJMH, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? FEBFINEHOEJ, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? BPHAPJBNIGK, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? AMPPGDLHGMA, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? EDCLAPOIFOD, [Optional] BMJKIPLKPPH<TContext, TDeps, TCompileState>? HJALOJLEBNN) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E36B70", Offset = "0x1E35B70", VA = "0x181E36B70")]
	private static int BEIONAAFIEC([In] EJCNFOOPALK<byte> PCHMCJDHEHP, EJCNFOOPALK<byte> JBHABPPCPJL, int GGOAAGPAMNC, int MJMIIGGLEFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HJLPPEEIJNH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int HKBMJICMIKD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28EC150", Offset = "0x28EB150", VA = "0x1828EC150")]
	public static JLADLGKIDDG<IDLGMCCAMDG<T>> CNGKBIKFEMB<T>([In] this EJCNFOOPALK<byte> HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28EC090", Offset = "0x28EB090", VA = "0x1828EC090")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<T>>> AMKPLGDGHAB<T>(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<IDLGMCCAMDG<T>>? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E36FA0", Offset = "0x1E35FA0", VA = "0x181E36FA0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<DCNCMOEPGKE>> AECLLFDGHIF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<DCNCMOEPGKE>? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<DCNCMOEPGKE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E37070", Offset = "0x1E36070", VA = "0x181E37070")]
	public static JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>> AEMMPEPNHDF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] float? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E37210", Offset = "0x1E36210", VA = "0x181E37210")]
	public static JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>> GMBKFINKKJI(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E373D0", Offset = "0x1E363D0", VA = "0x181E373D0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>> JLHEOBFLCOP(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<EPAMAENIHNO>? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E372E0", Offset = "0x1E362E0", VA = "0x181E372E0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<NFAOIPLNGEP>> IAFACGJJEJI(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] byte? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<NFAOIPLNGEP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E37140", Offset = "0x1E36140", VA = "0x181E37140")]
	public static JLADLGKIDDG<IDLGMCCAMDG<AHKIDIJDGNC>> FLCIILGMDBG(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<AHKIDIJDGNC>? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<AHKIDIJDGNC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E374A0", Offset = "0x1E364A0", VA = "0x181E374A0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> MFICKLKMMIF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] BCPHONCEPFD? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28EC1A0", Offset = "0x28EB1A0", VA = "0x1828EC1A0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<T>>> EPAMFEFBKAD<T>(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<T>>? LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E369C0", Offset = "0x1E359C0", VA = "0x181E369C0")]
	public static void DDGCDNABGOA(this EJCNFOOPALK<byte> HFLBADIEKAM, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>> HIOPKMEHOGC, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28EC080", Offset = "0x28EB080", VA = "0x1828EC080")]
	public static void FKALKIFDOEE<T>(this EJCNFOOPALK<byte> HFLBADIEKAM, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<T>>> LFCMPLFCDIH, JLADLGKIDDG<IDLGMCCAMDG<T>> LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28EC080", Offset = "0x28EB080", VA = "0x1828EC080")]
	public static void AJAFFIBECJF<T>(this EJCNFOOPALK<byte> HFLBADIEKAM, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<T>>> FJDCIAKKPBG, JLADLGKIDDG<PHCJBMLJEPM<T>> LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MLPLIEOCFNN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E37650", Offset = "0x1E36650", VA = "0x181E37650")]
	public static KHKHDENPCDD DEEMJMBGEBG([In] this ReadOnlySpan<byte> MFPMCBPILCI, int GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E375B0", Offset = "0x1E365B0", VA = "0x181E375B0")]
	public static KHKHDENPCDD DEEMJMBGEBG([In] this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x298EA30", Offset = "0x298DA30", VA = "0x18298EA30")]
	public static KHKHDENPCDD DEEMJMBGEBG<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x298EB40", Offset = "0x298DB40", VA = "0x18298EB40")]
	public static KHKHDENPCDD DEEMJMBGEBG<M>([In] this AIPLBOMEJPM<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x298E9E0", Offset = "0x298D9E0", VA = "0x18298E9E0")]
	public static KHKHDENPCDD DEEMJMBGEBG<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x298ECC0", Offset = "0x298DCC0", VA = "0x18298ECC0")]
	public static KHKHDENPCDD DEEMJMBGEBG<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x298EC50", Offset = "0x298DC50", VA = "0x18298EC50")]
	public static KHKHDENPCDD DEEMJMBGEBG<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E37650", Offset = "0x1E36650", VA = "0x181E37650")]
	public static int JKJHCDKNKMA([In] this ReadOnlySpan<byte> MFPMCBPILCI, int GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E36B60", Offset = "0x1E35B60", VA = "0x181E36B60")]
	public static int JKJHCDKNKMA([In] this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static int JKJHCDKNKMA<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static int JKJHCDKNKMA<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static int JKJHCDKNKMA<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static int JKJHCDKNKMA<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x298E9C0", Offset = "0x298D9C0", VA = "0x18298E9C0")]
	public static float AEBLLACJNEC<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x298E9C0", Offset = "0x298D9C0", VA = "0x18298E9C0")]
	public static float AEBLLACJNEC<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x298E9C0", Offset = "0x298D9C0", VA = "0x18298E9C0")]
	public static float AEBLLACJNEC<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x298EF00", Offset = "0x298DF00", VA = "0x18298EF00")]
	public static byte LBLGNJAADPM<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x298EFA0", Offset = "0x298DFA0", VA = "0x18298EFA0")]
	public static byte LBLGNJAADPM<M>([In] this AIPLBOMEJPM<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x298E9E0", Offset = "0x298D9E0", VA = "0x18298E9E0")]
	public static byte LBLGNJAADPM<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x298ECC0", Offset = "0x298DCC0", VA = "0x18298ECC0")]
	public static byte LBLGNJAADPM<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x298EF30", Offset = "0x298DF30", VA = "0x18298EF30")]
	public static byte LBLGNJAADPM<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E36B60", Offset = "0x1E35B60", VA = "0x181E36B60")]
	public static BCPHONCEPFD FNCPPHECDCO([In] this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH)
	{
		return default(BCPHONCEPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static BCPHONCEPFD FNCPPHECDCO<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(BCPHONCEPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x298EDE0", Offset = "0x298DDE0", VA = "0x18298EDE0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> ICBFCGOECLG<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x298ED80", Offset = "0x298DD80", VA = "0x18298ED80")]
	public static JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> ICBFCGOECLG<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x298ED20", Offset = "0x298DD20", VA = "0x18298ED20")]
	public static JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> ICBFCGOECLG<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x298EFC0", Offset = "0x298DFC0", VA = "0x18298EFC0")]
	public static JLADLGKIDDG<PHCJBMLJEPM<MCDOBOMGEPK>> NCJIFEHHKKG<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<PHCJBMLJEPM<MCDOBOMGEPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x298F080", Offset = "0x298E080", VA = "0x18298F080")]
	public static JLADLGKIDDG<AHKIDIJDGNC> PLHDBMLMPKK<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<AHKIDIJDGNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x298F140", Offset = "0x298E140", VA = "0x18298F140")]
	public static JLADLGKIDDG<AHKIDIJDGNC> PLHDBMLMPKK<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<AHKIDIJDGNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x298F0E0", Offset = "0x298E0E0", VA = "0x18298F0E0")]
	public static JLADLGKIDDG<AHKIDIJDGNC> PLHDBMLMPKK<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<AHKIDIJDGNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x298EEA0", Offset = "0x298DEA0", VA = "0x18298EEA0")]
	public static JLADLGKIDDG<DCNCMOEPGKE> IKPNNKAOPJC<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<DCNCMOEPGKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x298EE40", Offset = "0x298DE40", VA = "0x18298EE40")]
	public static JLADLGKIDDG<DCNCMOEPGKE> IKPNNKAOPJC<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<DCNCMOEPGKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x298F020", Offset = "0x298E020", VA = "0x18298F020")]
	public static JLADLGKIDDG<EPAMAENIHNO> PGIBDAELJNM<M>(this IPKLIOLMJJP<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH)
	{
		return default(JLADLGKIDDG<EPAMAENIHNO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FFKBMMCEGGF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E36DF0", Offset = "0x1E35DF0", VA = "0x181E36DF0")]
	public static void MPHAODOHFJG(this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH, KHKHDENPCDD LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E36F30", Offset = "0x1E35F30", VA = "0x181E36F30")]
	public static void MPHAODOHFJG(this byte[] MFPMCBPILCI, int GLMBIGBGDNH, KHKHDENPCDD LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E36EB0", Offset = "0x1E35EB0", VA = "0x181E36EB0")]
	public static void MPHAODOHFJG([In] this Span<byte> MFPMCBPILCI, int GLMBIGBGDNH, KHKHDENPCDD LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28A5090", Offset = "0x28A4090", VA = "0x1828A5090")]
	public static void MPHAODOHFJG<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, KHKHDENPCDD LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28A5180", Offset = "0x28A4180", VA = "0x1828A5180")]
	public static void MPHAODOHFJG<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, KHKHDENPCDD LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E369C0", Offset = "0x1E359C0", VA = "0x181E369C0")]
	public static void DDGCDNABGOA(this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1E36C80", Offset = "0x1E35C80", VA = "0x181E36C80")]
	public static void DDGCDNABGOA(this byte[] MFPMCBPILCI, int GLMBIGBGDNH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E36D00", Offset = "0x1E35D00", VA = "0x181E36D00")]
	public static void DDGCDNABGOA([In] this Span<byte> MFPMCBPILCI, int GLMBIGBGDNH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28A4F80", Offset = "0x28A3F80", VA = "0x1828A4F80")]
	public static void DDGCDNABGOA<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28A4FD0", Offset = "0x28A3FD0", VA = "0x1828A4FD0")]
	public static void DDGCDNABGOA<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E36C40", Offset = "0x1E35C40", VA = "0x181E36C40")]
	public static void CHLIGMCHMED(this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH, float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28A4F30", Offset = "0x28A3F30", VA = "0x1828A4F30")]
	public static void CHLIGMCHMED<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28A4EE0", Offset = "0x28A3EE0", VA = "0x1828A4EE0")]
	public static void CHLIGMCHMED<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E36D80", Offset = "0x1E35D80", VA = "0x181E36D80")]
	public static void IOMEGNLOLKK(this EJCNFOOPALK<byte> MFPMCBPILCI, int GLMBIGBGDNH, byte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28A5030", Offset = "0x28A4030", VA = "0x1828A5030")]
	public static void IOMEGNLOLKK<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, byte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28A5060", Offset = "0x28A4060", VA = "0x1828A5060")]
	public static void IOMEGNLOLKK<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, byte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28A5020", Offset = "0x28A4020", VA = "0x1828A5020")]
	public static void FKALKIFDOEE<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28A5020", Offset = "0x28A4020", VA = "0x1828A5020")]
	public static void FKALKIFDOEE<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28A5020", Offset = "0x28A4020", VA = "0x1828A5020")]
	public static void EGKONKHCDMJ<M>(this JOFNNHDKNPL<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, JLADLGKIDDG<AHKIDIJDGNC> LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28A5020", Offset = "0x28A4020", VA = "0x1828A5020")]
	public static void EGKONKHCDMJ<M>([In] this FBMJEOAEIFN<M, byte> MFPMCBPILCI, JLADLGKIDDG<M> GLMBIGBGDNH, JLADLGKIDDG<AHKIDIJDGNC> LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NJPJKMAIAHB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BA60", Offset = "0x1E3AA60", VA = "0x181E3BA60")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) MLPHEOLLMAJ(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B910", Offset = "0x1E3A910", VA = "0x181E3B910")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) MLLFCFHKKCP(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E38580", Offset = "0x1E37580", VA = "0x181E38580")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) CFJHEAFHDEE(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A2A0", Offset = "0x1E392A0", VA = "0x181E3A2A0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) IMJHFCDOFDN(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E382B0", Offset = "0x1E372B0", VA = "0x181E382B0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) BHNFHPCAEDG(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C860", Offset = "0x1E3B860", VA = "0x181E3C860")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) OCJCDMEIOLN(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C370", Offset = "0x1E3B370", VA = "0x181E3C370")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) NOGGJCICGGH(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A800", Offset = "0x1E39800", VA = "0x181E3A800")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) KEENEPELHCI(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E398C0", Offset = "0x1E388C0", VA = "0x181E398C0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) GPLAPOALNGF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E39F30", Offset = "0x1E38F30", VA = "0x181E39F30")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>) IJCJHBBJCDL(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? LDGMLLMKHLF, [Optional] JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? MDLKJEDCFBL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E399E0", Offset = "0x1E389E0", VA = "0x181E399E0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>) HIKKAADENIP(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LDGMLLMKHLF, [Optional] JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? MDLKJEDCFBL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E392E0", Offset = "0x1E382E0", VA = "0x181E392E0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>) FIPAEKIANAB(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? LDGMLLMKHLF, [Optional] JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? MDLKJEDCFBL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E391C0", Offset = "0x1E381C0", VA = "0x181E391C0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>) FEMCKEIGMGC(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LDGMLLMKHLF, [Optional] JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? MDLKJEDCFBL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BBE0", Offset = "0x1E3ABE0", VA = "0x181E3BBE0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<DCNCMOEPGKE>>) MMOFLFLKOOO(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? AEKOIIOCDEI, [Optional] JLADLGKIDDG<DCNCMOEPGKE>? DCLBDAHBMFI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<DCNCMOEPGKE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C750", Offset = "0x1E3B750", VA = "0x181E3C750")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<DCNCMOEPGKE>>>) OBGLJNGFKNF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? AEKOIIOCDEI, [Optional] JLADLGKIDDG<PHCJBMLJEPM<DCNCMOEPGKE>>? DCLBDAHBMFI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<DCNCMOEPGKE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CEA0", Offset = "0x1E3BEA0", VA = "0x181E3CEA0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<AHKIDIJDGNC>>) PNNCOGDONPF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? AEKOIIOCDEI, [Optional] JLADLGKIDDG<AHKIDIJDGNC>? DCLBDAHBMFI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<AHKIDIJDGNC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C110", Offset = "0x1E3B110", VA = "0x181E3C110")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<AHKIDIJDGNC>>>) NKIHFDKCPMK(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? AEKOIIOCDEI, [Optional] JLADLGKIDDG<PHCJBMLJEPM<AHKIDIJDGNC>>? DCLBDAHBMFI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<AHKIDIJDGNC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A23370", Offset = "0x2A22370", VA = "0x182A23370")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>) ACNCNKEHPHM<TMarker>(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<EPAMAENIHNO>? DCLBDAHBMFI, [Optional][In] ReadOnlySpan<byte> GPKMLHOONCL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E39520", Offset = "0x1E38520", VA = "0x181E39520")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) FNGGBBOHMLF(this EJCNFOOPALK<byte> HFLBADIEKAM, int PCHMCJDHEHP, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? JBHABPPCPJL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E37900", Offset = "0x1E36900", VA = "0x181E37900")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AFPIAMEGABN(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? PCHMCJDHEHP, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? JBHABPPCPJL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A23560", Offset = "0x2A22560", VA = "0x182A23560")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>) CMEEMEOPLEH<TMarker>(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<TMarker>>? JBHABPPCPJL, [Optional] int? GFFAGBDKDAI, [Optional][In] ReadOnlySpan<byte> PCHMCJDHEHP)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A23740", Offset = "0x2A22740", VA = "0x182A23740")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>) PJPILOFPDLO<TMarker>(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<TMarker>>? PCHMCJDHEHP, [Optional] JLADLGKIDDG<PHCJBMLJEPM<TMarker>>? JBHABPPCPJL, [Optional] int? GFFAGBDKDAI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<TMarker>>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AD30", Offset = "0x1E39D30", VA = "0x181E3AD30")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) KOKOOKCNLEH(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E38000", Offset = "0x1E37000", VA = "0x181E38000")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) BFPIGJPNGIA(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BD80", Offset = "0x1E3AD80", VA = "0x181E3BD80")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) MPKHFKFAMBL(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B3C0", Offset = "0x1E3A3C0", VA = "0x181E3B3C0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) MCMPGNKJIKE(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E39DE0", Offset = "0x1E38DE0", VA = "0x181E39DE0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) IGLALPONDDB(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B520", Offset = "0x1E3A520", VA = "0x181E3B520")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) MEAOMDJJBLG(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C4D0", Offset = "0x1E3B4D0", VA = "0x181E3C4D0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) NPHBICFKOFO(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A400", Offset = "0x1E39400", VA = "0x181E3A400")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) IOFJCPHPOAO(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C630", Offset = "0x1E3B630", VA = "0x181E3C630")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) OACDBCNOGNE(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E37DB0", Offset = "0x1E36DB0", VA = "0x181E37DB0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>) BEBEGEJKIIL(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? FIEACELLIGI)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E38400", Offset = "0x1E37400", VA = "0x181E38400")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) CBEFFPEFAME(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E39060", Offset = "0x1E38060", VA = "0x181E39060")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) FCADDBHFGOC(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CA00", Offset = "0x1E3BA00", VA = "0x181E3CA00")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) OJPNHJALPCM(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E37EA0", Offset = "0x1E36EA0", VA = "0x181E37EA0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) BFHKMILFEEL(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A150", Offset = "0x1E39150", VA = "0x181E3A150")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) IKOLJEPLHKI(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1E39650", Offset = "0x1E38650", VA = "0x181E39650")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) FOPACKHFKCA(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E38C20", Offset = "0x1E37C20", VA = "0x181E38C20")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) EOAKGFIPCLB(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E38DA0", Offset = "0x1E37DA0", VA = "0x181E38DA0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) EPLPLLEAEMK(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A950", Offset = "0x1E39950", VA = "0x181E3A950")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) KIEBHDMMPDE(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E38AC0", Offset = "0x1E37AC0", VA = "0x181E38AC0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) EJKCIIHBDGK(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ABE0", Offset = "0x1E39BE0", VA = "0x181E3ABE0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) KNJMCHOIKEG(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1E389A0", Offset = "0x1E379A0", VA = "0x181E389A0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) DNNJMAMEFIO(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1E39C60", Offset = "0x1E38C60", VA = "0x181E39C60")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) ICFPOKLGJBP(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E37A10", Offset = "0x1E36A10", VA = "0x181E37A10")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AGCKDCDHELP(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1E393F0", Offset = "0x1E383F0", VA = "0x181E393F0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) FKLEDFCDJPJ(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E38150", Offset = "0x1E37150", VA = "0x181E38150")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) BHGJABGHGEK(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B120", Offset = "0x1E3A120", VA = "0x181E3B120")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) LPBMIDJFIMP(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E37C90", Offset = "0x1E36C90", VA = "0x181E37C90")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AMJCMIJKAIM(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B640", Offset = "0x1E3A640", VA = "0x181E3B640")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) MHJJFDHOIJJ(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E39B00", Offset = "0x1E38B00", VA = "0x181E39B00")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) HILOPBFOEDE(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CC50", Offset = "0x1E3BC50", VA = "0x181E3CC50")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) PAAKDFHIIFE(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AA80", Offset = "0x1E39A80", VA = "0x181E3AA80")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) KMNEFNCFNKN(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C220", Offset = "0x1E3B220", VA = "0x181E3C220")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) NLEMNPOLPAA(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CB30", Offset = "0x1E3BB30", VA = "0x181E3CB30")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) OLNHFCDIPLK(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1E386A0", Offset = "0x1E376A0", VA = "0x181E386A0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) DHBOPHKIKKN(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B7C0", Offset = "0x1E3A7C0", VA = "0x181E3B7C0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) MLELPIHAPOK(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CD80", Offset = "0x1E3BD80", VA = "0x181E3CD80")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) PIBEDLPFEOH(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A550", Offset = "0x1E39550", VA = "0x181E3A550")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) JAAOBEGLMNB(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A6B0", Offset = "0x1E396B0", VA = "0x181E3A6B0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) JNIJIMINIHA(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E377E0", Offset = "0x1E367E0", VA = "0x181E377E0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AFEJKDNEIKD(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C000", Offset = "0x1E3B000", VA = "0x181E3C000")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) NFLOINHGAMB(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] int? AIKKBMHBNCK, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A040", Offset = "0x1E39040", VA = "0x181E3A040")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) IJMLELOAJEO(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? AIKKBMHBNCK, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C980", Offset = "0x1E3B980", VA = "0x181E3C980")]
	public static JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> OELKIJBJFHG(this EJCNFOOPALK<byte> HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1E38820", Offset = "0x1E37820", VA = "0x181E38820")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) DMMPHIFJEMK(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B270", Offset = "0x1E3A270", VA = "0x181E3B270")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) MAJDDKCLODC(this EJCNFOOPALK<byte> HFLBADIEKAM, float LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<CIGICPHIEIE>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AEB0", Offset = "0x1E39EB0", VA = "0x181E3AEB0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>) LHDLBFMAGNM(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<CIGICPHIEIE>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<CIGICPHIEIE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BEA0", Offset = "0x1E3AEA0", VA = "0x181E3BEA0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) NBJGPIIAAON(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E39770", Offset = "0x1E38770", VA = "0x181E39770")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) GNDDLOJEKDI(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E376C0", Offset = "0x1E366C0", VA = "0x181E376C0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AEINOKEAMKF(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E38F00", Offset = "0x1E37F00", VA = "0x181E38F00")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) FAPJGBNBGMA(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AFD0", Offset = "0x1E39FD0", VA = "0x181E3AFD0")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) LOGEAGGENAC(this EJCNFOOPALK<byte> HFLBADIEKAM, int LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1E37B70", Offset = "0x1E36B70", VA = "0x181E37B70")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>) AHFPKAJPAJO(this EJCNFOOPALK<byte> HFLBADIEKAM, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? LFLKMMBCCPH, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? MJPOGINCCPF, [Optional] JLADLGKIDDG<PHCJBMLJEPM<PJBEFFCNGMJ>>? NOGFONOHCLB)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<PJBEFFCNGMJ>>>));
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
