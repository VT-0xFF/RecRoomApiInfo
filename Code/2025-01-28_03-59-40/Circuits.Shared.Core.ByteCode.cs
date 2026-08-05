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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x25136E0", Offset = "0x25128E0", VA = "0x1825136E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LKINNGPKFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3053920", Offset = "0x3052B20", VA = "0x183053920")]
	public static ANHNAJIBLBK<OAPDHILNJPL<M>> CHIIELECIEP<M>(this int MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25135A0", Offset = "0x25127A0", VA = "0x1825135A0")]
	public static ANHNAJIBLBK<BAPNAOEGGLF> DPFGEKBIDPL(this int MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<BAPNAOEGGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3053920", Offset = "0x3052B20", VA = "0x183053920")]
	public static ANHNAJIBLBK<EPNBOEFMACB<M>> IPIONBPLJPF<M>(this int MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<EPNBOEFMACB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OAPDHILNJPL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LKOAFKAIGIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EKLCHICICCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BAPNAOEGGLF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class ABEMNJEHFPP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AEBHCIGIMGK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IEHMCDAPKIH
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
public static class ENLKINEOKOP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HEOFPHFFOHI<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr NLOBHOMPDGD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
		public HEOFPHFFOHI(IntPtr CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x44CF650", Offset = "0x44CE850", VA = "0x1844CF650")]
		public int HJOIGAOEAFJ(TDeps KHICLIFOGCP, TContext LBBKMINILHE, TCompileState HEKBFHLNMDL, [In] LPEAOCPACPN<byte> FOJBBBHMPBG, int COGKOGHIDCL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3118B30", Offset = "0x3117D30", VA = "0x183118B30")]
	public static void IDEGNFOFLIO<TDeps, TContext, TCompileState>(TDeps KHICLIFOGCP, TContext LBBKMINILHE, TCompileState HEKBFHLNMDL, [In] LPEAOCPACPN<byte> EFPLHCGEFPI, LPEAOCPACPN<byte> GHACOJNDPKG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CLBBMEJMCFG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GHEFNPBFECJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AKDOCPINOKE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LJDBKIBFMKC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GGBGNGKDJAG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HBMDGBMIPNJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DDMDPFNJPOP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? EOJCIAADPAL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IBLKFIBMIKO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MEGBHEFHKEP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KPDOFHBHICD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FBJEGEEEMKG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ANGBBGCAKNI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CEMMKGIPBME, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CFMFDBHIEDE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? INBFLMCHGLF, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AOCDCOOLNHL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BGNEHIFFJHC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ADGGCHCGDHB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NOAOFEFFOBC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MDFOOADKIEN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DLNBJJKNDPB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OKNIIFJICLK, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CAFEIMFAAPO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PMKPCAFLDFF, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BNABAAHNCBN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IMKCCHLDBKH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KAEBGIALHIN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LEIHGALPKEN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NBIJLCPAELC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FEAJJJOBAGM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IKLHBEJCCJB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JNNHNCDGFAC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HGHODLOAHJK, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AEODPHCIILD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CIDKLLLOJAP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LACKCIHCOBL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HNDBKDGJMIH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GLKLPOMMMBD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ALFHLILJHJE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OGHPPOEJDEO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CJJEBKPPFAF, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DCCCMHDFCHM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DNOHCIDEPHG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NDODDLIEPAM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OLABGMDIBNP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ABBKMILMGLE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CNCJLBFGEOB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MCCGLOPHJLN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CPCLCPDFNKP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KLNJHIPHMEL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CAJBFFGOLFO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KAKCHHDPJMN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HEDMADPAIGA, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NEGBGPHGBAG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PMGGIEIHICA, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AAGPNJPBCFE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DLNMKCELOEE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CEEMLIPJGBB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PBBCFFKBGIB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MMFPIDLLKLH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BOOAHEHKCDM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CFEJCBJHLCB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LJJPBJGILPD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JELCDNENKDP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IHGLGHDHHAD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BLIFHGFCMBG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? EDNPFKMJGIC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CADMLIGCBIJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BBHIFCCJBIO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HLOOEDFOJDA, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CBICJICDCFL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JKNLOBHDCEN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KHBFFAOLJOE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CBLFIIJALDM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MILMFHBCJDD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MAELDEIOMBI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ACECGCIKPNI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NGOMEDKKBDE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PFNMNOOLLOE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CCGJDGCBMJM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GOIIEDKFGLI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KHMEAANGOHN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KOENKOMAEKP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CNFIEJKPPHF, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IEEKOABMLAL, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FIJDHLJPNKP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? EDFLGMKEADB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IMMFNHMIIPA, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LOLCANHFMCG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FIMOHPAEBNO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? MNNBDCIBNMB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HFMHAOGFOAH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OHEOABIMKCE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BPAPPJDIDIM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HDMBHJCDPDO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KFADPBGEGBP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IBMBOKJDFNO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LDNJBACMEJB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OENIDKBPJFJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CFMBMPEPGNE, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AGEKFJNHECK, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HFPHCMBJKKI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? DDKHHIJLLNB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HMIOCCKLEOC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FMKKOOBFIPA, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IBGAGGHCMDK, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? KCOGILFNODN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CJPBLMJIAKI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? LPDJCAPMLML, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JLGEMKAODLJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JEJNCEDHFMC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NHEHLNCONAH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PEIDGIHNKGN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ANNCNIDILOI, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? EKFNCOOJFCC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ENHCFDEAKDJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? FBLGKIKBKPG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? NBAINKBEAJJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CBLDIAIAKKO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? IOPCDLIACGG, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? HBPHMBJHOGB, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BPBMGIMCOKH, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GHGPMFGMNKC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GFFNAGPMCCP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? OENEAMGOCIJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PHGFDODPCAP, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? ILLJAHFIGOD, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? JKHPFIGLJMJ, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? CDMFLKDFHGC, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? GLKIFHPHJML, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BGIFDCIJLFO, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? PJDNBAADBEN, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? BBLJJPHAGHM, [Optional] HEOFPHFFOHI<TContext, TDeps, TCompileState>? AJGCHPIEGDJ) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x250DB80", Offset = "0x250CD80", VA = "0x18250DB80")]
	private static int BIGHBDCJOBC([In] LPEAOCPACPN<byte> CBAPPNMGAFG, LPEAOCPACPN<byte> CMNHJIAJJEP, int JEMCAHPLMGJ, int EOKNBJLIKEG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DOBDOGBLBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int IFPKHPDDIDI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x30F7CC0", Offset = "0x30F6EC0", VA = "0x1830F7CC0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<T>> MEPDPMBOGOK<T>([In] this LPEAOCPACPN<byte> MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30F7C00", Offset = "0x30F6E00", VA = "0x1830F7C00")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<T>>> JLJOCCHEHLF<T>(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<OAPDHILNJPL<T>>? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x250D6B0", Offset = "0x250C8B0", VA = "0x18250D6B0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<AIBCAJKOANN>> DCDCPAAJDND(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<AIBCAJKOANN>? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<AIBCAJKOANN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x250D5C0", Offset = "0x250C7C0", VA = "0x18250D5C0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>> BNJCJBMIFHJ(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] float? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x250D970", Offset = "0x250CB70", VA = "0x18250D970")]
	public static ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>> KNCELPDINLA(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x250D4E0", Offset = "0x250C6E0", VA = "0x18250D4E0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>> AJFOIDALNBN(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<HNCEKEBEOFB>? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x250D870", Offset = "0x250CA70", VA = "0x18250D870")]
	public static ANHNAJIBLBK<OAPDHILNJPL<AEBHCIGIMGK>> FFIKNGNPBAC(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] byte? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<AEBHCIGIMGK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x250D790", Offset = "0x250C990", VA = "0x18250D790")]
	public static ANHNAJIBLBK<OAPDHILNJPL<BAPNAOEGGLF>> EPCHHJPGCIC(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<BAPNAOEGGLF>? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<BAPNAOEGGLF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x250DA50", Offset = "0x250CC50", VA = "0x18250DA50")]
	public static ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> PELIPKBJNFK(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] IEHMCDAPKIH? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x30F7D20", Offset = "0x30F6F20", VA = "0x1830F7D20")]
	public static ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<T>>> OFEMGNGJEFE<T>(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<T>>? OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x250D3E0", Offset = "0x250C5E0", VA = "0x18250D3E0")]
	public static void ONIBPIFDMJP(this LPEAOCPACPN<byte> MLNFAKCEGNM, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>> OMFFEPIAJMM, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30F7BF0", Offset = "0x30F6DF0", VA = "0x1830F7BF0")]
	public static void LLBICJGNFDC<T>(this LPEAOCPACPN<byte> MLNFAKCEGNM, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<T>>> COGKOGHIDCL, ANHNAJIBLBK<OAPDHILNJPL<T>> OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x30F7BF0", Offset = "0x30F6DF0", VA = "0x1830F7BF0")]
	public static void CMOKFNLCMGK<T>(this LPEAOCPACPN<byte> MLNFAKCEGNM, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<T>>> LEAFPJCLNJN, ANHNAJIBLBK<EPNBOEFMACB<T>> OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NOLPKLEJMPP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25135D0", Offset = "0x25127D0", VA = "0x1825135D0")]
	public static NIJFDNGGKMN NADGDNBBHDB([In] this ReadOnlySpan<byte> JIGDFCPIKCH, int IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2513640", Offset = "0x2512840", VA = "0x182513640")]
	public static NIJFDNGGKMN NADGDNBBHDB([In] this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33F89B0", Offset = "0x33F7BB0", VA = "0x1833F89B0")]
	public static NIJFDNGGKMN NADGDNBBHDB<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33F8B00", Offset = "0x33F7D00", VA = "0x1833F8B00")]
	public static NIJFDNGGKMN NADGDNBBHDB<M>([In] this HAFOAHELBCL<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x33F8920", Offset = "0x33F7B20", VA = "0x1833F8920")]
	public static NIJFDNGGKMN NADGDNBBHDB<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33F87D0", Offset = "0x33F79D0", VA = "0x1833F87D0")]
	public static NIJFDNGGKMN NADGDNBBHDB<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33F8C60", Offset = "0x33F7E60", VA = "0x1833F8C60")]
	public static NIJFDNGGKMN NADGDNBBHDB<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25135D0", Offset = "0x25127D0", VA = "0x1825135D0")]
	public static int BDKMCOOHCMN([In] this ReadOnlySpan<byte> JIGDFCPIKCH, int IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x250D330", Offset = "0x250C530", VA = "0x18250D330")]
	public static int BDKMCOOHCMN([In] this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3053580", Offset = "0x3052780", VA = "0x183053580")]
	public static int BDKMCOOHCMN<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3053580", Offset = "0x3052780", VA = "0x183053580")]
	public static int BDKMCOOHCMN<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3053580", Offset = "0x3052780", VA = "0x183053580")]
	public static int BDKMCOOHCMN<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3053580", Offset = "0x3052780", VA = "0x183053580")]
	public static int BDKMCOOHCMN<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x33F8790", Offset = "0x33F7990", VA = "0x1833F8790")]
	public static float MDGOLNFIPNA<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33F8790", Offset = "0x33F7990", VA = "0x1833F8790")]
	public static float MDGOLNFIPNA<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x33F8790", Offset = "0x33F7990", VA = "0x1833F8790")]
	public static float MDGOLNFIPNA<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x33F8980", Offset = "0x33F7B80", VA = "0x1833F8980")]
	public static byte MFAIBABMIIM<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x33F8840", Offset = "0x33F7A40", VA = "0x1833F8840")]
	public static byte MFAIBABMIIM<M>([In] this HAFOAHELBCL<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x33F8920", Offset = "0x33F7B20", VA = "0x1833F8920")]
	public static byte MFAIBABMIIM<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33F87D0", Offset = "0x33F79D0", VA = "0x1833F87D0")]
	public static byte MFAIBABMIIM<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x33F8860", Offset = "0x33F7A60", VA = "0x1833F8860")]
	public static byte MFAIBABMIIM<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x250D330", Offset = "0x250C530", VA = "0x18250D330")]
	public static IEHMCDAPKIH DJFAIGJBIBF([In] this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG)
	{
		return default(IEHMCDAPKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3053580", Offset = "0x3052780", VA = "0x183053580")]
	public static IEHMCDAPKIH DJFAIGJBIBF<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(IEHMCDAPKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x33F86B0", Offset = "0x33F78B0", VA = "0x1833F86B0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> JAIFIDPHCFF<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x33F85D0", Offset = "0x33F77D0", VA = "0x1833F85D0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> JAIFIDPHCFF<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x33F8640", Offset = "0x33F7840", VA = "0x1833F8640")]
	public static ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> JAIFIDPHCFF<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x33F8720", Offset = "0x33F7920", VA = "0x1833F8720")]
	public static ANHNAJIBLBK<EPNBOEFMACB<NJCGFOAHAGH>> JFFPOLFEJNB<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<EPNBOEFMACB<NJCGFOAHAGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x33F8480", Offset = "0x33F7680", VA = "0x1833F8480")]
	public static ANHNAJIBLBK<BAPNAOEGGLF> GPIHGENIPCG<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<BAPNAOEGGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33F8560", Offset = "0x33F7760", VA = "0x1833F8560")]
	public static ANHNAJIBLBK<BAPNAOEGGLF> GPIHGENIPCG<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<BAPNAOEGGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33F84F0", Offset = "0x33F76F0", VA = "0x1833F84F0")]
	public static ANHNAJIBLBK<BAPNAOEGGLF> GPIHGENIPCG<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<BAPNAOEGGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x33F83A0", Offset = "0x33F75A0", VA = "0x1833F83A0")]
	public static ANHNAJIBLBK<AIBCAJKOANN> BBFKEANPNNH<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<AIBCAJKOANN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33F8410", Offset = "0x33F7610", VA = "0x1833F8410")]
	public static ANHNAJIBLBK<AIBCAJKOANN> BBFKEANPNNH<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<AIBCAJKOANN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33F8330", Offset = "0x33F7530", VA = "0x1833F8330")]
	public static ANHNAJIBLBK<HNCEKEBEOFB> ADNPNMDEOAE<M>(this PIGMDFNHJOI<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG)
	{
		return default(ANHNAJIBLBK<HNCEKEBEOFB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OCGHLLCODMF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2513990", Offset = "0x2512B90", VA = "0x182513990")]
	public static void PPNNCFCBMAB(this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG, NIJFDNGGKMN OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2513A50", Offset = "0x2512C50", VA = "0x182513A50")]
	public static void PPNNCFCBMAB(this byte[] JIGDFCPIKCH, int IEILKJKDKAG, NIJFDNGGKMN OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2513910", Offset = "0x2512B10", VA = "0x182513910")]
	public static void PPNNCFCBMAB([In] this Span<byte> JIGDFCPIKCH, int IEILKJKDKAG, NIJFDNGGKMN OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3433660", Offset = "0x3432860", VA = "0x183433660")]
	public static void PPNNCFCBMAB<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, NIJFDNGGKMN OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3433800", Offset = "0x3432A00", VA = "0x183433800")]
	public static void PPNNCFCBMAB<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, NIJFDNGGKMN OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x250D3E0", Offset = "0x250C5E0", VA = "0x18250D3E0")]
	public static void ONIBPIFDMJP(this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2513810", Offset = "0x2512A10", VA = "0x182513810")]
	public static void ONIBPIFDMJP(this byte[] JIGDFCPIKCH, int IEILKJKDKAG, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2513890", Offset = "0x2512A90", VA = "0x182513890")]
	public static void ONIBPIFDMJP([In] this Span<byte> JIGDFCPIKCH, int IEILKJKDKAG, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3433600", Offset = "0x3432800", VA = "0x183433600")]
	public static void ONIBPIFDMJP<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34335A0", Offset = "0x34327A0", VA = "0x1834335A0")]
	public static void ONIBPIFDMJP<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2513760", Offset = "0x2512960", VA = "0x182513760")]
	public static void ADCPOFKDJGB(this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3433440", Offset = "0x3432640", VA = "0x183433440")]
	public static void ADCPOFKDJGB<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34334A0", Offset = "0x34326A0", VA = "0x1834334A0")]
	public static void ADCPOFKDJGB<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25137A0", Offset = "0x25129A0", VA = "0x1825137A0")]
	public static void JKLEBHFGCEI(this LPEAOCPACPN<byte> JIGDFCPIKCH, int IEILKJKDKAG, byte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3433500", Offset = "0x3432700", VA = "0x183433500")]
	public static void JKLEBHFGCEI<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, byte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3433550", Offset = "0x3432750", VA = "0x183433550")]
	public static void JKLEBHFGCEI<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, byte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3053720", Offset = "0x3052920", VA = "0x183053720")]
	public static void LLBICJGNFDC<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3053720", Offset = "0x3052920", VA = "0x183053720")]
	public static void LLBICJGNFDC<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3053720", Offset = "0x3052920", VA = "0x183053720")]
	public static void AFPHKHNHHJO<M>(this GKMBLDOBBJD<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, ANHNAJIBLBK<BAPNAOEGGLF> OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3053720", Offset = "0x3052920", VA = "0x183053720")]
	public static void AFPHKHNHHJO<M>([In] this KJOFJMGKPCH<M, byte> JIGDFCPIKCH, ANHNAJIBLBK<M> IEILKJKDKAG, ANHNAJIBLBK<BAPNAOEGGLF> OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LFMLCDHAOPN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2511690", Offset = "0x2510890", VA = "0x182511690")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) JGGKJALNMIA(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2511F60", Offset = "0x2511160", VA = "0x182511F60")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) MMMDLAILECE(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x250FE20", Offset = "0x250F020", VA = "0x18250FE20")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) EOBPIPGIBDN(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2510E30", Offset = "0x2510030", VA = "0x182510E30")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) HDPPHHGNEAA(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2512760", Offset = "0x2511960", VA = "0x182512760")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OBCPHMLAAOL(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2513480", Offset = "0x2512680", VA = "0x182513480")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) PCPJEIIIOCC(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25120B0", Offset = "0x25112B0", VA = "0x1825120B0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) NDKLGOJNIBJ(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x250F6F0", Offset = "0x250E8F0", VA = "0x18250F6F0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EDNPDGIEOAL(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2511810", Offset = "0x2510A10", VA = "0x182511810")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) JMBEEBFMEEN(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x250E820", Offset = "0x250DA20", VA = "0x18250E820")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>) CIMLIBCFMOD(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? OMEFCJCOLII, [Optional] ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? KGBGFBBLEAJ)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x250E050", Offset = "0x250D250", VA = "0x18250E050")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>) BLLLNMMNLKE(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OMEFCJCOLII, [Optional] ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? KGBGFBBLEAJ)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x250EA60", Offset = "0x250DC60", VA = "0x18250EA60")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>) CONILAEAAFL(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? OMEFCJCOLII, [Optional] ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? KGBGFBBLEAJ)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x250E700", Offset = "0x250D900", VA = "0x18250E700")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>) CGBNAEACEIA(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OMEFCJCOLII, [Optional] ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? KGBGFBBLEAJ)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2512E20", Offset = "0x2512020", VA = "0x182512E20")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<AIBCAJKOANN>>) OKCGMKGGDBG(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? MCEGGDFEKNF, [Optional] ANHNAJIBLBK<AIBCAJKOANN>? LGBMMKDPNBN)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<AIBCAJKOANN>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x250FA90", Offset = "0x250EC90", VA = "0x18250FA90")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<AIBCAJKOANN>>>) EJMNFINMJGP(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? MCEGGDFEKNF, [Optional] ANHNAJIBLBK<EPNBOEFMACB<AIBCAJKOANN>>? LGBMMKDPNBN)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<AIBCAJKOANN>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2511240", Offset = "0x2510440", VA = "0x182511240")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<BAPNAOEGGLF>>) IDFAMPBBOCP(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? MCEGGDFEKNF, [Optional] ANHNAJIBLBK<BAPNAOEGGLF>? LGBMMKDPNBN)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<BAPNAOEGGLF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25105A0", Offset = "0x250F7A0", VA = "0x1825105A0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<BAPNAOEGGLF>>>) GBHMDHNGFIJ(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? MCEGGDFEKNF, [Optional] ANHNAJIBLBK<EPNBOEFMACB<BAPNAOEGGLF>>? LGBMMKDPNBN)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<BAPNAOEGGLF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x333F980", Offset = "0x333EB80", VA = "0x18333F980")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>) IAPJABCPCBN<TMarker>(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<HNCEKEBEOFB>? LGBMMKDPNBN, [Optional][In] ReadOnlySpan<byte> LFDKFEEPNFP)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25131F0", Offset = "0x25123F0", VA = "0x1825131F0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OOILBKMAHLB(this LPEAOCPACPN<byte> MLNFAKCEGNM, int CBAPPNMGAFG, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CMNHJIAJJEP)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2512FC0", Offset = "0x25121C0", VA = "0x182512FC0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OKKMHKJPMHH(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CBAPPNMGAFG, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CMNHJIAJJEP)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x333F790", Offset = "0x333E990", VA = "0x18333F790")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>) EEBGHCMGIPN<TMarker>(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<TMarker>>? CMNHJIAJJEP, [Optional] int? AFLMMFDMNOE, [Optional][In] ReadOnlySpan<byte> CBAPPNMGAFG)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x333FB80", Offset = "0x333ED80", VA = "0x18333FB80")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>) PPBAEEEFMNM<TMarker>(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<TMarker>>? CBAPPNMGAFG, [Optional] ANHNAJIBLBK<EPNBOEFMACB<TMarker>>? CMNHJIAJJEP, [Optional] int? AFLMMFDMNOE)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<TMarker>>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x250ECF0", Offset = "0x250DEF0", VA = "0x18250ECF0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) DAHHLKPGILE(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25113E0", Offset = "0x25105E0", VA = "0x1825113E0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) JACOJHEPJMM(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x250F0E0", Offset = "0x250E2E0", VA = "0x18250F0E0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) DLNMOJPIBEJ(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25106B0", Offset = "0x250F8B0", VA = "0x1825106B0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) GCEDOAOEOCH(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x250DC20", Offset = "0x250CE20", VA = "0x18250DC20")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) AOABAIKFLLM(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x250F480", Offset = "0x250E680", VA = "0x18250F480")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DOKMDAFFBDK(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2510F90", Offset = "0x2510190", VA = "0x182510F90")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) HHPFBHGPGMB(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2510810", Offset = "0x250FA10", VA = "0x182510810")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) GFMKDHOEGIO(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x250F970", Offset = "0x250EB70", VA = "0x18250F970")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EGGHMIGLECF(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2510D40", Offset = "0x250FF40", VA = "0x182510D40")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>) GPMLDAIMKFO(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? JAGEHPINHCI)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2512210", Offset = "0x2511410", VA = "0x182512210")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) NELKAPNIHPD(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2512A10", Offset = "0x2511C10", VA = "0x182512A10")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OCBBJDAHNLC(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x250F840", Offset = "0x250EA40", VA = "0x18250F840")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EFOPAFNHAJF(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25128B0", Offset = "0x2511AB0", VA = "0x1825128B0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OBKOIMEMCEP(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x250F5A0", Offset = "0x250E7A0", VA = "0x18250F5A0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DPBGPIFIJLD(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x250E4C0", Offset = "0x250D6C0", VA = "0x18250E4C0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) CCKCLAANMJF(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x250DED0", Offset = "0x250D0D0", VA = "0x18250DED0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) BJIIIHOKJFM(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2511E00", Offset = "0x2511000", VA = "0x182511E00")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) MFOGDPNIIOJ(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x250E930", Offset = "0x250DB30", VA = "0x18250E930")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) CKEGDJCFILG(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2511A80", Offset = "0x2510C80", VA = "0x182511A80")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) KKOHKJIKLIM(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2511930", Offset = "0x2510B30", VA = "0x182511930")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) JOPACNDNBIA(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x250EE70", Offset = "0x250E070", VA = "0x18250EE70")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DFIBNBOKDAK(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x250EB70", Offset = "0x250DD70", VA = "0x18250EB70")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DAFDONHEBCP(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2512CC0", Offset = "0x2511EC0", VA = "0x182512CC0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OIMPGCNOPJA(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x250FCF0", Offset = "0x250EEF0", VA = "0x18250FCF0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) ENBMHMFEEED(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2510960", Offset = "0x250FB60", VA = "0x182510960")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) GFNIPFLCEMH(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x250FBA0", Offset = "0x250EDA0", VA = "0x18250FBA0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EMMEFKKJBDK(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25130D0", Offset = "0x25122D0", VA = "0x1825130D0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OLDJCIBHCDG(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25124B0", Offset = "0x25116B0", VA = "0x1825124B0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) NKNJDFPCIIB(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2513320", Offset = "0x2512520", VA = "0x182513320")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) OPAMINOEFNL(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2512630", Offset = "0x2511830", VA = "0x182512630")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) NPKPDJEONFD(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x250F320", Offset = "0x250E520", VA = "0x18250F320")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DNPCEFJOOAI(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2510300", Offset = "0x250F500", VA = "0x182510300")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) FBPFAMEINEG(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x250E5E0", Offset = "0x250D7E0", VA = "0x18250E5E0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) CDJDHAPFHKH(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2510180", Offset = "0x250F380", VA = "0x182510180")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) FANMOCNNNPB(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2512B70", Offset = "0x2511D70", VA = "0x182512B70")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) OHICONMLHDA(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2512390", Offset = "0x2511590", VA = "0x182512390")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) NKCCGIGCGOF(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2510AC0", Offset = "0x250FCC0", VA = "0x182510AC0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) GOEKENLADJI(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2510450", Offset = "0x250F650", VA = "0x182510450")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) FHMDLMNAHGI(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2510060", Offset = "0x250F260", VA = "0x182510060")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EOIJCDBIJCG(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2511CF0", Offset = "0x2510EF0", VA = "0x182511CF0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) MCOKMGPKINL(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] int? NKHJNKHDAGM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2511BE0", Offset = "0x2510DE0", VA = "0x182511BE0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) LPIMPGMKBAE(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? NKHJNKHDAGM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x250E440", Offset = "0x250D640", VA = "0x18250E440")]
	public static ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> BPNEHDDCENN(this LPEAOCPACPN<byte> MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x250E2C0", Offset = "0x250D4C0", VA = "0x18250E2C0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) BPDIJFJHDAP(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25110F0", Offset = "0x25102F0", VA = "0x1825110F0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) HJLEGDEIIIN(this LPEAOCPACPN<byte> MLNFAKCEGNM, float OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<LKOAFKAIGIL>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x250F200", Offset = "0x250E400", VA = "0x18250F200")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>) DNIEEMLIGCG(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<LKOAFKAIGIL>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<LKOAFKAIGIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2511530", Offset = "0x2510730", VA = "0x182511530")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) JBOIKMGONEG(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x250EF90", Offset = "0x250E190", VA = "0x18250EF90")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) DLBOKJHEIID(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2510C20", Offset = "0x250FE20", VA = "0x182510C20")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) GOJKNBHHLPL(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x250DD70", Offset = "0x250CF70", VA = "0x18250DD70")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) BDEBBGHHFNI(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x250E170", Offset = "0x250D370", VA = "0x18250E170")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) BMAGLJLHHHN(this LPEAOCPACPN<byte> MLNFAKCEGNM, int OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x250FF40", Offset = "0x250F140", VA = "0x18250FF40")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>) EOCMLMCEMLC(this LPEAOCPACPN<byte> MLNFAKCEGNM, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? OCIGCGAJDPN, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? CDDLBPNACLO, [Optional] ANHNAJIBLBK<EPNBOEFMACB<EKLCHICICCF>>? MLPBDNHBAMC)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<EKLCHICICCF>>>));
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
