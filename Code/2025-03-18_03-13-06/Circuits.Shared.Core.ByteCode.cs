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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25B4B80", Offset = "0x25B3D80", VA = "0x1825B4B80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MABANKKCGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32C9360", Offset = "0x32C8560", VA = "0x1832C9360")]
	public static LNNKJBCILDK<FDPDAJKJEGG<M>> GNDNGOOPOIA<M>(this int NAELBAPCKEH)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B4AB0", Offset = "0x25B3CB0", VA = "0x1825B4AB0")]
	public static LNNKJBCILDK<EHKOIMJCAAF> JFABMNDDEJL(this int NAELBAPCKEH)
	{
		return default(LNNKJBCILDK<EHKOIMJCAAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32C9360", Offset = "0x32C8560", VA = "0x1832C9360")]
	public static LNNKJBCILDK<BOJBMDGGLJJ<M>> OOLCCKMCNDI<M>(this int NAELBAPCKEH)
	{
		return default(LNNKJBCILDK<BOJBMDGGLJJ<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FDPDAJKJEGG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CKGFOCKGCCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IOJDKHHLODC
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EHKOIMJCAAF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GJCLOCLOPHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NCKLGBGFPFE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OHFIGOKNLJC
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
public static class MFHBPEFKIPE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct AJKNKBHAENI<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr GEBLDODDHJA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
		public AJKNKBHAENI(IntPtr PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4763530", Offset = "0x4762730", VA = "0x184763530")]
		public int LKNMLKMEAKD(TDeps LAJMFENCBAB, TContext BKOBFFIPGEL, TCompileState KDKBMCJKCGA, [In] PKMCDMEOPGC<byte> BLDEHHFGDGN, int BFIFJAEGMPO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3561860", Offset = "0x3560A60", VA = "0x183561860")]
	public static void JCHFFBGOIGF<TDeps, TContext, TCompileState>(TDeps LAJMFENCBAB, TContext BKOBFFIPGEL, TCompileState KDKBMCJKCGA, [In] PKMCDMEOPGC<byte> GKHIPPDBLPG, PKMCDMEOPGC<byte> FBKLIGGFNNO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FHIOOCKLAJK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DGKLKFDJFMN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DHCIOGJKPDG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? PBLDMJNLBFG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? JDFJAHOJHCK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FFHBFDLBMKE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GLBFMLCFDNM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BBJBCKJJMDH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MBEPHONGDJL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? OPDPOKGAOJM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BBOIMIOEHFJ, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? AKFNEPKJLKE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? PPOLJLLMHEL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? OFKEFEBLEDH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KJEHPEAOFBC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LKFFKHAGFMO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IAFGOACILAI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GGOIANKBJLP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NNCPBHOPKKJ, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KKHFDJNIMCM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HDEFEONOFFD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NLOEKNMEHDK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? AMFJHGCHNOM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KLBOCMCPPJO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HLEIPGEACLF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LBNEFGFJOOG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KDACBDFFDIA, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? AGLGHNNJAEI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BPGNHLOKNEC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KNPGLNDICDA, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IHCFOHAJPAA, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MFNLCGPPOKP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? OLOEBCPHDBH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IIMEFDAOPMH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LDHFHAEANGM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ADPDLNOLFLD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? EPBKAABLDHI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IIMFFGIMNNN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HLCPBBFKHCM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MJOEOPHLMLI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FJCJPCPOEDK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DCEKNHDMGEG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DKNCCLLKOOB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KDOGDAGANCE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FFCLHJDEDIE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DFEHFNMKDAB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CMDLGCEPFOD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? EICDCGLDNLO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? PJMBCIFKHNI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IEDNDHHMHME, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GOKPIGFJCKC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CGHKFKCHMLB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CPFGGMEJJOD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DHPCGACAPBC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IBGFILGKJJO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KGHKECGLMIN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? PEJPOBEIOBG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KAKNLAGIKDE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BDLDGGHDOBO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GIIAANPOAAP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? JPJGKLNIBBB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NLNNAABEKNA, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MCEBBJFDPGC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GAMLLFOKEKP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BANPDANIIGG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? COCMJFJJJFJ, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DKHJHLMAJII, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? OKEKIBJIJDH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IICPJKPGLJO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KAOPNFDEHFM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HEFLKAJBALE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MPCPPGBHFPI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IHCHOINJMIE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IIBMGLNCKGN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IEIHBLCPPFP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? EJFIAMDCEDB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? JMIHIEIFCBE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HHCEBMOAFIF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ALAFPMMDLJL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CHIHMMIDNFK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ELBPICPEKMH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CCKACJKDDPJ, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DJJMENBDEEL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NBABLCKMBHB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DMDIIELMNDC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BCHKHGMNFGE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NOLJGLEDGDD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BKHACDEPCPN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LEENHBHJKIK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NAMEPBCNHOP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LNOCCMFAIIC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? OLMPGHKPJAI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GFDEOMHIGKI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? EDBBPFNADOD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? JAFFDAHKMAE, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BLIMBFEPIFF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DBMIEKCEPEN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GGNGDCNFPCF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BJGGJFJKFDF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ENKPHIMCMIH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IMDBMEDEDBB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IMLJHFOPKJM, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? AIPAFMIAEID, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DABKAJKABOD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NEKMMHHNNBH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LCKDCKGFANC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DAJDIEOBAII, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CMOCEFHEFEN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? KNIAENMHCNH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NODKKHFNIHO, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BIJJBIMNHFL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GHBBDPMBOBI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? INNPHPGLCBD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? LFLJNBAMJKI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? HCKFJLDKBLG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IDGOBJCGCNG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ALEEEAPDNFI, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ONEABPAFIKG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? JLDKBJMIDOL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BGPECDHFPGL, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? DCJOOBDFPKC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? BNMONJONKHN, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GOKGFAEMMPH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CNECPDABCBD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IFGOMAHKMKC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FLEAMEFFGAB, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? MFPCGEMHLLK, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GMHNHAIPEFD, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? FMGICPCNBHP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? ELCHOGICCMC, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NFEKENINJPF, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? NCNKHGGNLKP, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? CCNIDOIPNIG, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? IIPPIIDGDBH, [Optional] AJKNKBHAENI<TContext, TDeps, TCompileState>? GBMMHFKDGNL) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25B4AE0", Offset = "0x25B3CE0", VA = "0x1825B4AE0")]
	private static int FHMGANJJNMA([In] PKMCDMEOPGC<byte> BFLKFNFMHDJ, PKMCDMEOPGC<byte> ONKLBOFODCF, int MGKDKECOLOJ, int IPBKHOJKHLJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PHKNCBGLMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int NCOBBMNCJPC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3673220", Offset = "0x3672420", VA = "0x183673220")]
	public static LNNKJBCILDK<FDPDAJKJEGG<T>> HPDIGIEGKFG<T>([In] this PKMCDMEOPGC<byte> NAELBAPCKEH)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36730A0", Offset = "0x36722A0", VA = "0x1836730A0")]
	public static LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<T>>> CEOILBBBDAL<T>(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<FDPDAJKJEGG<T>>? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x25BAAF0", Offset = "0x25B9CF0", VA = "0x1825BAAF0")]
	public static LNNKJBCILDK<FDPDAJKJEGG<MOCBIMOIHLI>> OCOEHPAHFFB(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<MOCBIMOIHLI>? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<MOCBIMOIHLI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25BAA10", Offset = "0x25B9C10", VA = "0x1825BAA10")]
	public static LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>> NPMFFABPNKG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] float? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25BA680", Offset = "0x25B9880", VA = "0x1825BA680")]
	public static LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>> COBDGNGHAAG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x25BA850", Offset = "0x25B9A50", VA = "0x1825BA850")]
	public static LNNKJBCILDK<FDPDAJKJEGG<OPMJHHCBDOA>> HGKLHIHAFFM(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<OPMJHHCBDOA>? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<OPMJHHCBDOA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25BA580", Offset = "0x25B9780", VA = "0x1825BA580")]
	public static LNNKJBCILDK<FDPDAJKJEGG<NCKLGBGFPFE>> ANANACMBNIF(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] byte? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<NCKLGBGFPFE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25BA930", Offset = "0x25B9B30", VA = "0x1825BA930")]
	public static LNNKJBCILDK<FDPDAJKJEGG<EHKOIMJCAAF>> KDDDGJOEHFE(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<EHKOIMJCAAF>? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<EHKOIMJCAAF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x25BA760", Offset = "0x25B9960", VA = "0x1825BA760")]
	public static LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>> GCGECOHKKFM(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] OHFIGOKNLJC? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3673160", Offset = "0x3672360", VA = "0x183673160")]
	public static LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<T>>> HGDLJONPOMD<T>(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<T>>? OMFJNFBDJCA)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x25B4600", Offset = "0x25B3800", VA = "0x1825B4600")]
	public static void NBDOBLCDHAN(this PKMCDMEOPGC<byte> NAELBAPCKEH, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>> ODHDKLJBOBO, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3673280", Offset = "0x3672480", VA = "0x183673280")]
	public static void IFNJOPDJIDL<T>(this PKMCDMEOPGC<byte> NAELBAPCKEH, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<T>>> BFIFJAEGMPO, LNNKJBCILDK<FDPDAJKJEGG<T>> OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3673280", Offset = "0x3672480", VA = "0x183673280")]
	public static void NLBKEDJCOIB<T>(this PKMCDMEOPGC<byte> NAELBAPCKEH, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<T>>> NBKEFDMGLDI, LNNKJBCILDK<BOJBMDGGLJJ<T>> OMFJNFBDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BELPILMMPOB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25B46E0", Offset = "0x25B38E0", VA = "0x1825B46E0")]
	public static KKADPMMIMJJ BCHCEONFPGO([In] this ReadOnlySpan<byte> GJKPEEJCIPN, int PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25B4640", Offset = "0x25B3840", VA = "0x1825B4640")]
	public static KKADPMMIMJJ BCHCEONFPGO([In] this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x31F18C0", Offset = "0x31F0AC0", VA = "0x1831F18C0")]
	public static KKADPMMIMJJ BCHCEONFPGO<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x31F1B20", Offset = "0x31F0D20", VA = "0x1831F1B20")]
	public static KKADPMMIMJJ BCHCEONFPGO<M>([In] this LFPFDLMGFBJ<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x31F1AC0", Offset = "0x31F0CC0", VA = "0x1831F1AC0")]
	public static KKADPMMIMJJ BCHCEONFPGO<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x31F1850", Offset = "0x31F0A50", VA = "0x1831F1850")]
	public static KKADPMMIMJJ BCHCEONFPGO<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x31F1A10", Offset = "0x31F0C10", VA = "0x1831F1A10")]
	public static KKADPMMIMJJ BCHCEONFPGO<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25B46E0", Offset = "0x25B38E0", VA = "0x1825B46E0")]
	public static int HOGHJOLDDBE([In] this ReadOnlySpan<byte> GJKPEEJCIPN, int PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25B4530", Offset = "0x25B3730", VA = "0x1825B4530")]
	public static int HOGHJOLDDBE([In] this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0EE0", VA = "0x1831F1CE0")]
	public static int HOGHJOLDDBE<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0EE0", VA = "0x1831F1CE0")]
	public static int HOGHJOLDDBE<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0EE0", VA = "0x1831F1CE0")]
	public static int HOGHJOLDDBE<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0EE0", VA = "0x1831F1CE0")]
	public static int HOGHJOLDDBE<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x31F1F20", Offset = "0x31F1120", VA = "0x1831F1F20")]
	public static float PHMOGKBCFLK<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31F1F20", Offset = "0x31F1120", VA = "0x1831F1F20")]
	public static float PHMOGKBCFLK<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31F1F20", Offset = "0x31F1120", VA = "0x1831F1F20")]
	public static float PHMOGKBCFLK<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31F1DF0", Offset = "0x31F0FF0", VA = "0x1831F1DF0")]
	public static byte KKNIMPLMFNL<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31F1E20", Offset = "0x31F1020", VA = "0x1831F1E20")]
	public static byte KKNIMPLMFNL<M>([In] this LFPFDLMGFBJ<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x31F1AC0", Offset = "0x31F0CC0", VA = "0x1831F1AC0")]
	public static byte KKNIMPLMFNL<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31F1850", Offset = "0x31F0A50", VA = "0x1831F1850")]
	public static byte KKNIMPLMFNL<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x31F1E40", Offset = "0x31F1040", VA = "0x1831F1E40")]
	public static byte KKNIMPLMFNL<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25B4530", Offset = "0x25B3730", VA = "0x1825B4530")]
	public static OHFIGOKNLJC NFGFHNEHNPI([In] this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC)
	{
		return default(OHFIGOKNLJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31F1EF0", Offset = "0x31F10F0", VA = "0x1831F1EF0")]
	public static OHFIGOKNLJC NFGFHNEHNPI<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(OHFIGOKNLJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x31F2040", Offset = "0x31F1240", VA = "0x1831F2040")]
	public static LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>> POONKJDLFEO<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31F1FD0", Offset = "0x31F11D0", VA = "0x1831F1FD0")]
	public static LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>> POONKJDLFEO<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x31F1F60", Offset = "0x31F1160", VA = "0x1831F1F60")]
	public static LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>> POONKJDLFEO<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31F1C70", Offset = "0x31F0E70", VA = "0x1831F1C70")]
	public static LNNKJBCILDK<BOJBMDGGLJJ<NLNFCNFEIDF>> CJHHJMLJHNJ<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<BOJBMDGGLJJ<NLNFCNFEIDF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31F17E0", Offset = "0x31F09E0", VA = "0x1831F17E0")]
	public static LNNKJBCILDK<EHKOIMJCAAF> AJAPOJPKGIG<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<EHKOIMJCAAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31F1770", Offset = "0x31F0970", VA = "0x1831F1770")]
	public static LNNKJBCILDK<EHKOIMJCAAF> AJAPOJPKGIG<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<EHKOIMJCAAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31F1700", Offset = "0x31F0900", VA = "0x1831F1700")]
	public static LNNKJBCILDK<EHKOIMJCAAF> AJAPOJPKGIG<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<EHKOIMJCAAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31F1D80", Offset = "0x31F0F80", VA = "0x1831F1D80")]
	public static LNNKJBCILDK<MOCBIMOIHLI> JKCEMLCEPDB<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<MOCBIMOIHLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31F1D10", Offset = "0x31F0F10", VA = "0x1831F1D10")]
	public static LNNKJBCILDK<MOCBIMOIHLI> JKCEMLCEPDB<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<MOCBIMOIHLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31F1690", Offset = "0x31F0890", VA = "0x1831F1690")]
	public static LNNKJBCILDK<OPMJHHCBDOA> ACBOLHJOFEE<M>(this GGAILCJBJGL<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC)
	{
		return default(LNNKJBCILDK<OPMJHHCBDOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KENMNMPCLKN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25B4840", Offset = "0x25B3A40", VA = "0x1825B4840")]
	public static void FHMGFOIMDOA(this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC, KKADPMMIMJJ OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25B47D0", Offset = "0x25B39D0", VA = "0x1825B47D0")]
	public static void FHMGFOIMDOA(this byte[] GJKPEEJCIPN, int PPFHNJCIAMC, KKADPMMIMJJ OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25B4750", Offset = "0x25B3950", VA = "0x1825B4750")]
	public static void FHMGFOIMDOA([In] this Span<byte> GJKPEEJCIPN, int PPFHNJCIAMC, KKADPMMIMJJ OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3523B40", Offset = "0x3522D40", VA = "0x183523B40")]
	public static void FHMGFOIMDOA<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, KKADPMMIMJJ OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3523CD0", Offset = "0x3522ED0", VA = "0x183523CD0")]
	public static void FHMGFOIMDOA<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, KKADPMMIMJJ OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25B4600", Offset = "0x25B3800", VA = "0x1825B4600")]
	public static void NBDOBLCDHAN(this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25B49F0", Offset = "0x25B3BF0", VA = "0x1825B49F0")]
	public static void NBDOBLCDHAN(this byte[] GJKPEEJCIPN, int PPFHNJCIAMC, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25B4970", Offset = "0x25B3B70", VA = "0x1825B4970")]
	public static void NBDOBLCDHAN([In] this Span<byte> GJKPEEJCIPN, int PPFHNJCIAMC, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3523F00", Offset = "0x3523100", VA = "0x183523F00")]
	public static void NBDOBLCDHAN<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3523F60", Offset = "0x3523160", VA = "0x183523F60")]
	public static void NBDOBLCDHAN<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25B4A70", Offset = "0x25B3C70", VA = "0x1825B4A70")]
	public static void NFLDDGDBNHP(this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC, float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3524020", Offset = "0x3523220", VA = "0x183524020")]
	public static void NFLDDGDBNHP<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3523FC0", Offset = "0x35231C0", VA = "0x183523FC0")]
	public static void NFLDDGDBNHP<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25B4900", Offset = "0x25B3B00", VA = "0x1825B4900")]
	public static void HPPJGLNBBDA(this PKMCDMEOPGC<byte> GJKPEEJCIPN, int PPFHNJCIAMC, byte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3523E60", Offset = "0x3523060", VA = "0x183523E60")]
	public static void HPPJGLNBBDA<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, byte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3523EB0", Offset = "0x35230B0", VA = "0x183523EB0")]
	public static void HPPJGLNBBDA<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, byte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32C9500", Offset = "0x32C8700", VA = "0x1832C9500")]
	public static void IFNJOPDJIDL<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>> OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32C9500", Offset = "0x32C8700", VA = "0x1832C9500")]
	public static void IFNJOPDJIDL<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, LNNKJBCILDK<FDPDAJKJEGG<NLNFCNFEIDF>> OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32C9500", Offset = "0x32C8700", VA = "0x1832C9500")]
	public static void OHLGJCJNMGI<M>(this EMPGEHDHEDM<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, LNNKJBCILDK<EHKOIMJCAAF> OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32C9500", Offset = "0x32C8700", VA = "0x1832C9500")]
	public static void OHLGJCJNMGI<M>([In] this GIKIKAKEFBK<M, byte> GJKPEEJCIPN, LNNKJBCILDK<M> PPFHNJCIAMC, LNNKJBCILDK<EHKOIMJCAAF> OMFJNFBDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OMDEMNNPHCG
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25B7630", Offset = "0x25B6830", VA = "0x1825B7630")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) JKFHNJKDHGP(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25B6D60", Offset = "0x25B5F60", VA = "0x1825B6D60")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) GKAHADPECCM(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25B4C00", Offset = "0x25B3E00", VA = "0x1825B4C00")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) ADKFLMKMCEC(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25B56C0", Offset = "0x25B48C0", VA = "0x1825B56C0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) CHKIOPBHOAE(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25B6610", Offset = "0x25B5810", VA = "0x1825B6610")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) FKKFMLHCJIO(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25B7F80", Offset = "0x25B7180", VA = "0x1825B7F80")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) KHHPJHAOKIJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25B4D20", Offset = "0x25B3F20", VA = "0x1825B4D20")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) ADLJCBEBHOE(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25B8200", Offset = "0x25B7400", VA = "0x1825B8200")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) KNAODKPLADO(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25B69A0", Offset = "0x25B5BA0", VA = "0x1825B69A0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) GAHLJIGNFAM(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25B5490", Offset = "0x25B4690", VA = "0x1825B5490")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>) BLCIPAOIHOG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? OMFJNFBDJCA, [Optional] LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>? PFOLMEADBEJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25B8990", Offset = "0x25B7B90", VA = "0x1825B8990")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>) LIKBFEOPBAG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? OMFJNFBDJCA, [Optional] LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>? PFOLMEADBEJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25B99D0", Offset = "0x25B8BD0", VA = "0x1825B99D0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>) OELIOAGJADI(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? OMFJNFBDJCA, [Optional] LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>? PFOLMEADBEJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25B5FD0", Offset = "0x25B51D0", VA = "0x1825B5FD0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>) DNLLJHMNICE(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? OMFJNFBDJCA, [Optional] LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>? PFOLMEADBEJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25B97B0", Offset = "0x25B89B0", VA = "0x1825B97B0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<MOCBIMOIHLI>>) OCPCCODOACL(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? JCMDCPAPEGH, [Optional] LNNKJBCILDK<MOCBIMOIHLI>? GGGDPGAGPON)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<MOCBIMOIHLI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25B96A0", Offset = "0x25B88A0", VA = "0x1825B96A0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<MOCBIMOIHLI>>>) OAOOHLJEKBG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? JCMDCPAPEGH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<MOCBIMOIHLI>>? GGGDPGAGPON)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<MOCBIMOIHLI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25B5E30", Offset = "0x25B5030", VA = "0x1825B5E30")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<EHKOIMJCAAF>>) DKAGLGAHDCJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? JCMDCPAPEGH, [Optional] LNNKJBCILDK<EHKOIMJCAAF>? GGGDPGAGPON)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<EHKOIMJCAAF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25BA1E0", Offset = "0x25B93E0", VA = "0x1825BA1E0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<EHKOIMJCAAF>>>) PIDNDIKNOFF(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? JCMDCPAPEGH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<EHKOIMJCAAF>>? GGGDPGAGPON)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<EHKOIMJCAAF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x365D880", Offset = "0x365CA80", VA = "0x18365D880")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<OPMJHHCBDOA>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<TMarker>>) HHLPLHLMMDF<TMarker>(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<OPMJHHCBDOA>? GGGDPGAGPON, [Optional][In] ReadOnlySpan<byte> LJELDKAOCJM)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<OPMJHHCBDOA>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25B7A30", Offset = "0x25B6C30", VA = "0x1825B7A30")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) JOIKHFCDJFJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, int BFLKFNFMHDJ, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? ONKLBOFODCF)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25B63A0", Offset = "0x25B55A0", VA = "0x1825B63A0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) EGFGDEFOEME(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? BFLKFNFMHDJ, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? ONKLBOFODCF)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x365D690", Offset = "0x365C890", VA = "0x18365D690")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<TMarker>>) BGCEELINCDG<TMarker>(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<TMarker>>? ONKLBOFODCF, [Optional] int? IAGJHPFNLHJ, [Optional][In] ReadOnlySpan<byte> BFLKFNFMHDJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x365DA80", Offset = "0x365CC80", VA = "0x18365DA80")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>) IEBFDBELOLB<TMarker>(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<TMarker>>? BFLKFNFMHDJ, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<TMarker>>? ONKLBOFODCF, [Optional] int? IAGJHPFNLHJ)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<TMarker>>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25B7360", Offset = "0x25B6560", VA = "0x1825B7360")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) HJMBOKOHHNB(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25B74E0", Offset = "0x25B66E0", VA = "0x1825B74E0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) IMBHCDLGMCD(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25B7CE0", Offset = "0x25B6EE0", VA = "0x1825B7CE0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) KACFEOMMLHK(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25B93F0", Offset = "0x25B85F0", VA = "0x1825B93F0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) NDNAOJIAFGH(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25B50C0", Offset = "0x25B42C0", VA = "0x1825B50C0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) BBAIFNNOAKG(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25B6880", Offset = "0x25B5A80", VA = "0x1825B6880")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) FNEFELPJEKM(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25B8D60", Offset = "0x25B7F60", VA = "0x1825B8D60")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LMIJGLHBJNH(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25B9550", Offset = "0x25B8750", VA = "0x1825B9550")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) NIHNGGAPBGN(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25B5BE0", Offset = "0x25B4DE0", VA = "0x1825B5BE0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) DIALJNAKLNE(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25B70F0", Offset = "0x25B62F0", VA = "0x1825B70F0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>) HHOCNDFDKEM(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>? NPKOMKFGEMH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<FDPDAJKJEGG<GJCLOCLOPHJ>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25BA400", Offset = "0x25B9600", VA = "0x1825BA400")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PPJFMOMMDHI(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x25B9170", Offset = "0x25B8370", VA = "0x1825B9170")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) MPMEBDLFECB(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25B8C30", Offset = "0x25B7E30", VA = "0x1825B8C30")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LLHIHMKAENH(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25BA080", Offset = "0x25B9280", VA = "0x1825BA080")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PHMLFOGEOPF(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25B5210", Offset = "0x25B4410", VA = "0x1825B5210")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) BGCGDGCBNKF(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25B4FA0", Offset = "0x25B41A0", VA = "0x1825B4FA0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) AFLAPOOHPIC(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25B7E00", Offset = "0x25B7000", VA = "0x1825B7E00")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) KEPGEDCBOAP(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25B8350", Offset = "0x25B7550", VA = "0x1825B8350")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) KPKFMMNILEE(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25B5360", Offset = "0x25B4560", VA = "0x1825B5360")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) BKDIOJGAMDD(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25B9AE0", Offset = "0x25B8CE0", VA = "0x1825B9AE0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) OPLCBAFLJNE(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x25B6AC0", Offset = "0x25B5CC0", VA = "0x1825B6AC0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) GBNDNOFHGAA(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25B5970", Offset = "0x25B4B70", VA = "0x1825B5970")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) DCBAKNGPFNB(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x25B8AB0", Offset = "0x25B7CB0", VA = "0x1825B8AB0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LLCBACICFHO(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25B77B0", Offset = "0x25B69B0", VA = "0x1825B77B0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) JKODEJIPMFP(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25B6FC0", Offset = "0x25B61C0", VA = "0x1825B6FC0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) HGBMLHGIMII(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25B9C40", Offset = "0x25B8E40", VA = "0x1825B9C40")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PDGFHDEALIJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x25B5820", Offset = "0x25B4A20", VA = "0x1825B5820")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) CNOHLENOMPC(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25B4E80", Offset = "0x25B4080", VA = "0x1825B4E80")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) AFHCFOONPKG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B9DA0", Offset = "0x25B8FA0", VA = "0x1825B9DA0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PEHJLBKINIO(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x25B9F20", Offset = "0x25B9120", VA = "0x1825B9F20")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PFLHCLNHDDN(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x25B5D00", Offset = "0x25B4F00", VA = "0x1825B5D00")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) DJFLIDGKIFG(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25B60F0", Offset = "0x25B52F0", VA = "0x1825B60F0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) EAGMPHBGAFL(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25B5A90", Offset = "0x25B4C90", VA = "0x1825B5A90")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) DGJLNGOIDME(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25B8750", Offset = "0x25B7950", VA = "0x1825B8750")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LGJDBMOOFHF(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25B7B60", Offset = "0x25B6D60", VA = "0x1825B7B60")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) JPFODODMAJN(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x25B6250", Offset = "0x25B5450", VA = "0x1825B6250")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) EDPCDBLJKFA(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x25B7910", Offset = "0x25B6B10", VA = "0x1825B7910")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) JOCCNEECFEF(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25B80A0", Offset = "0x25B72A0", VA = "0x1825B80A0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) KJLKBOHGAPE(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25B6C10", Offset = "0x25B5E10", VA = "0x1825B6C10")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) GJIIKHEAHCO(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x25B6760", Offset = "0x25B5960", VA = "0x1825B6760")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) FMMIONJKAMB(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25BA2F0", Offset = "0x25B94F0", VA = "0x1825BA2F0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) PLOKDLPCJII(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] int? DCKDOAFIECO, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25B6EB0", Offset = "0x25B60B0", VA = "0x1825B6EB0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) HEOELFOBCDB(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? DCKDOAFIECO, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x25B9950", Offset = "0x25B8B50", VA = "0x1825B9950")]
	public static LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>> ODNHAMOPHNG(this PKMCDMEOPGC<byte> NAELBAPCKEH)
	{
		return default(LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x25B71E0", Offset = "0x25B63E0", VA = "0x1825B71E0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) HJFPFOPILIE(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, float IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25B8600", Offset = "0x25B7800", VA = "0x1825B8600")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) LGDOJGHIHBJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, float CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<CKGFOCKGCCK>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x25B55A0", Offset = "0x25B47A0", VA = "0x1825B55A0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>) CGCCNKKIEJH(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<CKGFOCKGCCK>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<CKGFOCKGCCK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x25B64B0", Offset = "0x25B56B0", VA = "0x1825B64B0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) EGHONDDDAIO(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x25B9020", Offset = "0x25B8220", VA = "0x1825B9020")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) MGPMGJPFGJJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x25B92D0", Offset = "0x25B84D0", VA = "0x1825B92D0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) NDHBEHOLLDP(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25B8EC0", Offset = "0x25B80C0", VA = "0x1825B8EC0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) MAPJJNEAKDP(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, int IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x25B84B0", Offset = "0x25B76B0", VA = "0x1825B84B0")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LAPFPALIENJ(this PKMCDMEOPGC<byte> NAELBAPCKEH, int CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<IOJDKHHLODC>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25B8870", Offset = "0x25B7A70", VA = "0x1825B8870")]
	public static (LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>) LGMJNNKGCCP(this PKMCDMEOPGC<byte> NAELBAPCKEH, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? CFFPOCBDODN, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? IKOIHHBAIMA, [Optional] LNNKJBCILDK<BOJBMDGGLJJ<IOJDKHHLODC>>? LHFAEBIINIH)
	{
		return default((LNNKJBCILDK<FDPDAJKJEGG<GJCLOCLOPHJ>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>, LNNKJBCILDK<FDPDAJKJEGG<BOJBMDGGLJJ<IOJDKHHLODC>>>));
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
