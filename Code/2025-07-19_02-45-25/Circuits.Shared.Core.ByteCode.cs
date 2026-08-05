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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A31B30", Offset = "0x2A30B30", VA = "0x182A31B30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGLDLEDGNNM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39D7AF0", Offset = "0x39D6AF0", VA = "0x1839D7AF0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<M>> EIGODPONAIH<M>(this int OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BAD0", Offset = "0x2A2AAD0", VA = "0x182A2BAD0")]
	public static OCIDMCEKJIP<MJCNFBMKBDI> NEPKHJKCIAA(this int OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<MJCNFBMKBDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39D7AF0", Offset = "0x39D6AF0", VA = "0x1839D7AF0")]
	public static OCIDMCEKJIP<FEHKAEFOELM<M>> JFCNIAMJDFI<M>(this int OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<FEHKAEFOELM<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JLOPLFCPODM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JJECECEEMAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BBHJKDCFMMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MJCNFBMKBDI
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LNKLNAJNICB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FFAJAGEECGF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GEJGJDBBAAL
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
public static class NOGPDMBPGAD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LKGEILFBDAD<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr POAHHDEFLKI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
		public LKGEILFBDAD(IntPtr JOEHPNNMIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54B6430", Offset = "0x54B5430", VA = "0x1854B6430")]
		public int BAHFCECOEJD(TDeps APEKGFIAPNC, TContext GNKNFNHHFGL, TCompileState GEAGDPNDIDJ, [In] PBFBDJCALEG<byte> DDCMCELGLMP, int JOAPDCLFNNF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DFCE30", Offset = "0x3DFBE30", VA = "0x183DFCE30")]
	public static void KAJJDNKMCPP<TDeps, TContext, TCompileState>(TDeps APEKGFIAPNC, TContext GNKNFNHHFGL, TCompileState GEAGDPNDIDJ, [In] PBFBDJCALEG<byte> MGIBFKILILE, PBFBDJCALEG<byte> MBDHIPEFHEK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LCJGPHHIEEG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IGOKGMLKGDE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HBHNMCGPGNB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BNGJFFFDAMC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OCMDEIEEKGD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FCNGMGKLFPN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EBDDAIGGJBE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OBCIKNPOAGF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LBOCFEPJGJC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BONOHLEIMIH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MPDMCDFBFGJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FABHAGPEJMN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DOEHCHGAAPK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OEJIJHCBPDC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FCEHOPCEOIH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OOCPNLKJGPD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GDICFAPCOJF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FLAFLPHPICM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MIMCPLEPGIB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DFPEDILCJIF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? PINPLJBDCGD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? ONGIMNPCJLG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IPJELJGNHKE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OEBLLEEDHKP, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JABNGJPKOHH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KELAJCNLNLE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DGBAACMOBAD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NJIKFHBPING, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JMFJHJCHFNN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DFIPKIJLNCI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GMHEOMBOIGA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GGMFCFMMDBB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LLDLDGIELAL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HFHNLMADFAO, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KBJEBNAMGLM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BKOKHLKHGNG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JOJPLFIHFPD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OKOEELOGJBB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FHKGIKAPGFG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OAFLDAJMEDH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JEAKCECBPOI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FCDNFGGKFMA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CAHNBMLAEPF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BIGCMPJJBMG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GJIDDHAIMHO, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BGHPOAAGIKN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HHFPOHBCKOL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GCLLNNPPLGP, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CHBLBAKOCIJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EEGMMPEIIAK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HCEBAMGFNGD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MEEHCDFGCCA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FLHHLJEOODN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MJLIOCKJPBD, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CKHFHNHFOOI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HPPFDLMKKCG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EEINLPMJBJL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KNIEBNHFFIM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? ALEGFHNMJNG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LDHAEPPAPNL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FIEHCBCKGEE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IPEGEKGPDAB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KBCMPDAFLFL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NIMDFLEPDGF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EPNOCKLLALK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? AHMODEHKNAB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BEDJKDIJFOC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? AOIDAOHDLBP, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CHGDPGJDKGH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? PHKKBMFPKAF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FJHOKPPBOMM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KCCKHJKMDIK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KLPKCKEABCF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HNMBANOFJFG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HNGDCNGGIDI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MJGLGNMCAKJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MLGKLIKLHKI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DPIMGFBOELH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HIEGLJPAMLI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LOBNBPNMKEI, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OFPEEOMPPEM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GHNBNFKNOAA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EEECGLJIGED, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FEDNCINEIIH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? GBOBDAAIPNB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OOBMIECLLGF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JMGOPGLOIKE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KNDHJNHHJCN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? ANIEADDOJND, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CIINHMJNOAG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? PEPBPIKALGA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HAJCBCKFLGA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CBFHEAPLILF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IDPCOLNFIBG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DLEEFIKHIEC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LANAODJMBIA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FOLOANEAGHF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? PPAKIFJEOLC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IONANNECFFJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BOIOOPCJAIG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NKLLKDJKBKA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MBGINAMNNFK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CFBDBONKLNF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LFHIPMANHOF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IFGPPCKAGGB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HKDNHPELBOF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? HNFDEJLHPJA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DNIHFPBGJCJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BEJJPFJGEGK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CGDFKDOHBII, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NGBOGKKEJFJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? AMGMEHLAKLB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? CCDLLKKHOCM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? FJKBDKEKPLO, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EKKMGABEBFM, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EJJBAMMEPIF, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NODGBIJPCGG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? DPEHLFOJCAJ, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? AJJMGKNKHFA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? IMEPEAHFLPK, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OLONINOANAE, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? MICDHKIDKKG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? AEFNDOKKJMH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JBGIHMNBMMA, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? EAFCEPLHDGC, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? NHBOFNGKMKB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? PJDPCJAPEHO, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KABLNNFAONG, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LEHJMFFBFEO, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? KDMMLFAPAOH, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? JADGMNOIKKN, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? BDCKFCJHMEL, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? OGJLDMIMGFB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? LLOCFNDBIKB, [Optional] LKGEILFBDAD<TContext, TDeps, TCompileState>? ANCLHFKGDNA) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A31A90", Offset = "0x2A30A90", VA = "0x182A31A90")]
	private static int CKFFOKJPPFA([In] PBFBDJCALEG<byte> HACFJHGGPBG, PBFBDJCALEG<byte> BAEJCLGOEMO, int LMLEMDDGACN, int MFFPIAPMHCN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MAGGJJNLOPD
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int GPJMAELJCND;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D77280", Offset = "0x3D76280", VA = "0x183D77280")]
	public static OCIDMCEKJIP<JLOPLFCPODM<T>> CBDBILGDFGF<T>([In] this PBFBDJCALEG<byte> OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D773A0", Offset = "0x3D763A0", VA = "0x183D773A0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<T>>> JDKNGNLLAMJ<T>(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<JLOPLFCPODM<T>>? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A31620", Offset = "0x2A30620", VA = "0x182A31620")]
	public static OCIDMCEKJIP<JLOPLFCPODM<NIKEPJPNOLD>> FBAEOMKFFAA(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<NIKEPJPNOLD>? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<NIKEPJPNOLD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A316F0", Offset = "0x2A306F0", VA = "0x182A316F0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>> GLEDBBHDPMF(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] float? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A317C0", Offset = "0x2A307C0", VA = "0x182A317C0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>> JGIANOAMHFI(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A31980", Offset = "0x2A30980", VA = "0x182A31980")]
	public static OCIDMCEKJIP<JLOPLFCPODM<BAPKPBLFMNI>> LMJCFFCLHKP(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<BAPKPBLFMNI>? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<BAPKPBLFMNI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A31890", Offset = "0x2A30890", VA = "0x182A31890")]
	public static OCIDMCEKJIP<JLOPLFCPODM<FFAJAGEECGF>> JHAPMMCMNJE(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] byte? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<FFAJAGEECGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A31480", Offset = "0x2A30480", VA = "0x182A31480")]
	public static OCIDMCEKJIP<JLOPLFCPODM<MJCNFBMKBDI>> DGEFLBNNMLI(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<MJCNFBMKBDI>? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<MJCNFBMKBDI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A31550", Offset = "0x2A30550", VA = "0x182A31550")]
	public static OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>> DKKGINBLJAA(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] GEJGJDBBAAL? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D772D0", Offset = "0x3D762D0", VA = "0x183D772D0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<T>>> FFEIDMAGDPI<T>(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<T>>? IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B4B0", Offset = "0x2A2A4B0", VA = "0x182A2B4B0")]
	public static void IBNEDPAPMIL(this PBFBDJCALEG<byte> OLHDOIOOPGE, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>> BJAOFPDOHEM, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D77390", Offset = "0x3D76390", VA = "0x183D77390")]
	public static void GHIFDLPDPPO<T>(this PBFBDJCALEG<byte> OLHDOIOOPGE, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<T>>> JOAPDCLFNNF, OCIDMCEKJIP<JLOPLFCPODM<T>> IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D77390", Offset = "0x3D76390", VA = "0x183D77390")]
	public static void KPKJPJPKPBB<T>(this PBFBDJCALEG<byte> OLHDOIOOPGE, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<T>>> MFIMOIFJINB, OCIDMCEKJIP<FEHKAEFOELM<T>> IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IEPPNGMNIHB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B9C0", Offset = "0x2A2A9C0", VA = "0x182A2B9C0")]
	public static AKECAGNFEBE MINPBFGBLAL([In] this ReadOnlySpan<byte> ODOOLGJOBIG, int CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BA30", Offset = "0x2A2AA30", VA = "0x182A2BA30")]
	public static AKECAGNFEBE MINPBFGBLAL([In] this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA43D0", Offset = "0x3CA33D0", VA = "0x183CA43D0")]
	public static AKECAGNFEBE MINPBFGBLAL<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA44E0", Offset = "0x3CA34E0", VA = "0x183CA44E0")]
	public static AKECAGNFEBE MINPBFGBLAL<M>([In] this GNNFGPJLMIH<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3FE0", Offset = "0x3CA2FE0", VA = "0x183CA3FE0")]
	public static AKECAGNFEBE MINPBFGBLAL<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3EF0", Offset = "0x3CA2EF0", VA = "0x183CA3EF0")]
	public static AKECAGNFEBE MINPBFGBLAL<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4360", Offset = "0x3CA3360", VA = "0x183CA4360")]
	public static AKECAGNFEBE MINPBFGBLAL<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B9C0", Offset = "0x2A2A9C0", VA = "0x182A2B9C0")]
	public static int KBFCCJHPBEA([In] this ReadOnlySpan<byte> ODOOLGJOBIG, int CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B5B0", Offset = "0x2A2A5B0", VA = "0x182A2B5B0")]
	public static int KBFCCJHPBEA([In] this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FD10", Offset = "0x3C2ED10", VA = "0x183C2FD10")]
	public static int KBFCCJHPBEA<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FD10", Offset = "0x3C2ED10", VA = "0x183C2FD10")]
	public static int KBFCCJHPBEA<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FD10", Offset = "0x3C2ED10", VA = "0x183C2FD10")]
	public static int KBFCCJHPBEA<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FD10", Offset = "0x3C2ED10", VA = "0x183C2FD10")]
	public static int KBFCCJHPBEA<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CA45F0", Offset = "0x3CA35F0", VA = "0x183CA45F0")]
	public static float NBLDHIHMBFB<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CA45F0", Offset = "0x3CA35F0", VA = "0x183CA45F0")]
	public static float NBLDHIHMBFB<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CA45F0", Offset = "0x3CA35F0", VA = "0x183CA45F0")]
	public static float NBLDHIHMBFB<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4030", Offset = "0x3CA3030", VA = "0x183CA4030")]
	public static byte GHOLAINODDK<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3FC0", Offset = "0x3CA2FC0", VA = "0x183CA3FC0")]
	public static byte GHOLAINODDK<M>([In] this GNNFGPJLMIH<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3FE0", Offset = "0x3CA2FE0", VA = "0x183CA3FE0")]
	public static byte GHOLAINODDK<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3EF0", Offset = "0x3CA2EF0", VA = "0x183CA3EF0")]
	public static byte GHOLAINODDK<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3F50", Offset = "0x3CA2F50", VA = "0x183CA3F50")]
	public static byte GHOLAINODDK<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B5B0", Offset = "0x2A2A5B0", VA = "0x182A2B5B0")]
	public static GEJGJDBBAAL EEFJICCMBLK([In] this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK)
	{
		return default(GEJGJDBBAAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FD10", Offset = "0x3C2ED10", VA = "0x183C2FD10")]
	public static GEJGJDBBAAL EEFJICCMBLK<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(GEJGJDBBAAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4120", Offset = "0x3CA3120", VA = "0x183CA4120")]
	public static OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>> GKEECOAOGLP<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4060", Offset = "0x3CA3060", VA = "0x183CA4060")]
	public static OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>> GKEECOAOGLP<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3CA40C0", Offset = "0x3CA30C0", VA = "0x183CA40C0")]
	public static OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>> GKEECOAOGLP<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3E90", Offset = "0x3CA2E90", VA = "0x183CA3E90")]
	public static OCIDMCEKJIP<FEHKAEFOELM<IIMIHEOMNMN>> ADDKEHNFEHO<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<FEHKAEFOELM<IIMIHEOMNMN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4240", Offset = "0x3CA3240", VA = "0x183CA4240")]
	public static OCIDMCEKJIP<MJCNFBMKBDI> MALCPMECHKN<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<MJCNFBMKBDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4300", Offset = "0x3CA3300", VA = "0x183CA4300")]
	public static OCIDMCEKJIP<MJCNFBMKBDI> MALCPMECHKN<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<MJCNFBMKBDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CA42A0", Offset = "0x3CA32A0", VA = "0x183CA42A0")]
	public static OCIDMCEKJIP<MJCNFBMKBDI> MALCPMECHKN<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<MJCNFBMKBDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4180", Offset = "0x3CA3180", VA = "0x183CA4180")]
	public static OCIDMCEKJIP<NIKEPJPNOLD> KCICFGFIGBB<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<NIKEPJPNOLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CA41E0", Offset = "0x3CA31E0", VA = "0x183CA41E0")]
	public static OCIDMCEKJIP<NIKEPJPNOLD> KCICFGFIGBB<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<NIKEPJPNOLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4610", Offset = "0x3CA3610", VA = "0x183CA4610")]
	public static OCIDMCEKJIP<BAPKPBLFMNI> NDKJBGPALIF<M>(this AOPCIKCNONB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK)
	{
		return default(OCIDMCEKJIP<BAPKPBLFMNI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FBPNPIDGGEG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B840", Offset = "0x2A2A840", VA = "0x182A2B840")]
	public static void JFOHELAOEID(this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK, AKECAGNFEBE IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B7D0", Offset = "0x2A2A7D0", VA = "0x182A2B7D0")]
	public static void JFOHELAOEID(this byte[] ODOOLGJOBIG, int CCNGABFELGK, AKECAGNFEBE IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B900", Offset = "0x2A2A900", VA = "0x182A2B900")]
	public static void JFOHELAOEID([In] this Span<byte> ODOOLGJOBIG, int CCNGABFELGK, AKECAGNFEBE IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E8F0", Offset = "0x3C2D8F0", VA = "0x183C2E8F0")]
	public static void JFOHELAOEID<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, AKECAGNFEBE IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E9E0", Offset = "0x3C2D9E0", VA = "0x183C2E9E0")]
	public static void JFOHELAOEID<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, AKECAGNFEBE IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B4B0", Offset = "0x2A2A4B0", VA = "0x182A2B4B0")]
	public static void IBNEDPAPMIL(this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B6D0", Offset = "0x2A2A6D0", VA = "0x182A2B6D0")]
	public static void IBNEDPAPMIL(this byte[] ODOOLGJOBIG, int CCNGABFELGK, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B750", Offset = "0x2A2A750", VA = "0x182A2B750")]
	public static void IBNEDPAPMIL([In] this Span<byte> ODOOLGJOBIG, int CCNGABFELGK, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E8A0", Offset = "0x3C2D8A0", VA = "0x183C2E8A0")]
	public static void IBNEDPAPMIL<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E850", Offset = "0x3C2D850", VA = "0x183C2E850")]
	public static void IBNEDPAPMIL<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B980", Offset = "0x2A2A980", VA = "0x182A2B980")]
	public static void JLGNEHOGPED(this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C2EAD0", Offset = "0x3C2DAD0", VA = "0x183C2EAD0")]
	public static void JLGNEHOGPED<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C2EB20", Offset = "0x3C2DB20", VA = "0x183C2EB20")]
	public static void JLGNEHOGPED<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B660", Offset = "0x2A2A660", VA = "0x182A2B660")]
	public static void CAPDAPKEADK(this PBFBDJCALEG<byte> ODOOLGJOBIG, int CCNGABFELGK, byte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E7E0", Offset = "0x3C2D7E0", VA = "0x183C2E7E0")]
	public static void CAPDAPKEADK<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, byte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E810", Offset = "0x3C2D810", VA = "0x183C2E810")]
	public static void CAPDAPKEADK<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, byte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E840", Offset = "0x3C2D840", VA = "0x183C2E840")]
	public static void GHIFDLPDPPO<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>> IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E840", Offset = "0x3C2D840", VA = "0x183C2E840")]
	public static void GHIFDLPDPPO<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, OCIDMCEKJIP<JLOPLFCPODM<IIMIHEOMNMN>> IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E840", Offset = "0x3C2D840", VA = "0x183C2E840")]
	public static void POJLJMAFHKO<M>(this EBPFIABNEBB<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, OCIDMCEKJIP<MJCNFBMKBDI> IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E840", Offset = "0x3C2D840", VA = "0x183C2E840")]
	public static void POJLJMAFHKO<M>([In] this FCHCANALJAF<M, byte> ODOOLGJOBIG, OCIDMCEKJIP<M> CCNGABFELGK, OCIDMCEKJIP<MJCNFBMKBDI> IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KGIDOBAGDBD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DDC0", Offset = "0x2A2CDC0", VA = "0x182A2DDC0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) FLIMDHIBKKH(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FC50", Offset = "0x2A2EC50", VA = "0x182A2FC50")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) KEJJEEGGPOA(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E430", Offset = "0x2A2D430", VA = "0x182A2E430")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) GICPJCELLLA(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CCF0", Offset = "0x2A2BCF0", VA = "0x182A2CCF0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) CICGDLKPKOG(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F340", Offset = "0x2A2E340", VA = "0x182A2F340")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JCDCHDHEKBK(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F0C0", Offset = "0x2A2E0C0", VA = "0x182A2F0C0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) IOFMOGODOOL(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F1E0", Offset = "0x2A2E1E0", VA = "0x182A2F1E0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JBKHBCGBGMG(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DF40", Offset = "0x2A2CF40", VA = "0x182A2DF40")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) FNBBEOCGNBH(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E310", Offset = "0x2A2D310", VA = "0x182A2E310")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) GHANPCDJKPB(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A30310", Offset = "0x2A2F310", VA = "0x182A30310")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>) LJEIPNKNAPC(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? IOALKPFEKEK, [Optional] OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>? MCDCJMGMEJL)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A2ECE0", Offset = "0x2A2DCE0", VA = "0x182A2ECE0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>) IFGHOIFANIP(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? IOALKPFEKEK, [Optional] OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>? MCDCJMGMEJL)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F5E0", Offset = "0x2A2E5E0", VA = "0x182A2F5E0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>) JEOIHPLEGIA(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? IOALKPFEKEK, [Optional] OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>? MCDCJMGMEJL)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CF70", Offset = "0x2A2BF70", VA = "0x182A2CF70")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>) DBFMIOPGDAP(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? IOALKPFEKEK, [Optional] OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>? MCDCJMGMEJL)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A30660", Offset = "0x2A2F660", VA = "0x182A30660")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<NIKEPJPNOLD>>) MPMCPAEBBPC(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? HKMDJOCKOAD, [Optional] OCIDMCEKJIP<NIKEPJPNOLD>? MIHDDGGCGJI)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<NIKEPJPNOLD>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A30550", Offset = "0x2A2F550", VA = "0x182A30550")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<NIKEPJPNOLD>>>) LMHDJEJCOFP(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? HKMDJOCKOAD, [Optional] OCIDMCEKJIP<FEHKAEFOELM<NIKEPJPNOLD>>? MIHDDGGCGJI)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<NIKEPJPNOLD>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DB00", Offset = "0x2A2CB00", VA = "0x182A2DB00")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<MJCNFBMKBDI>>) FAOIAAFCEJO(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? HKMDJOCKOAD, [Optional] OCIDMCEKJIP<MJCNFBMKBDI>? MIHDDGGCGJI)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<MJCNFBMKBDI>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A30EA0", Offset = "0x2A2FEA0", VA = "0x182A30EA0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<MJCNFBMKBDI>>>) OIONLKFLBMH(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? HKMDJOCKOAD, [Optional] OCIDMCEKJIP<FEHKAEFOELM<MJCNFBMKBDI>>? MIHDDGGCGJI)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<MJCNFBMKBDI>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FDC0", Offset = "0x3D1EDC0", VA = "0x183D1FDC0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BAPKPBLFMNI>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<TMarker>>) OECFMKKEIBK<TMarker>(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<BAPKPBLFMNI>? MIHDDGGCGJI, [Optional][In] ReadOnlySpan<byte> INCJDDLACNP)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BAPKPBLFMNI>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A31350", Offset = "0x2A30350", VA = "0x182A31350")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) PJNONDGDPEN(this PBFBDJCALEG<byte> OLHDOIOOPGE, int HACFJHGGPBG, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? BAEJCLGOEMO)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A30800", Offset = "0x2A2F800", VA = "0x182A30800")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) NDOPLNJJFEH(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HACFJHGGPBG, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? BAEJCLGOEMO)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FAC0", Offset = "0x3D1EAC0", VA = "0x183D1FAC0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<TMarker>>) DKKANFLLNOC<TMarker>(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<TMarker>>? BAEJCLGOEMO, [Optional] int? BKLOHAHJLKP, [Optional][In] ReadOnlySpan<byte> HACFJHGGPBG)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FCA0", Offset = "0x3D1ECA0", VA = "0x183D1FCA0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>) MLNEIKPKGLF<TMarker>(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<TMarker>>? HACFJHGGPBG, [Optional] OCIDMCEKJIP<FEHKAEFOELM<TMarker>>? BAEJCLGOEMO, [Optional] int? BKLOHAHJLKP)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<TMarker>>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D440", Offset = "0x2A2C440", VA = "0x182A2D440")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) EDKIBEPKOHC(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D8A0", Offset = "0x2A2C8A0", VA = "0x182A2D8A0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) EMGCGCHPHOD(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A30FB0", Offset = "0x2A2FFB0", VA = "0x182A30FB0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) OOABBFNKKKO(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A30A90", Offset = "0x2A2FA90", VA = "0x182A30A90")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) OANHLGBGGPI(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D090", Offset = "0x2A2C090", VA = "0x182A2D090")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) DKGMFDKAGFG(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CAB0", Offset = "0x2A2BAB0", VA = "0x182A2CAB0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) BNIIIMPKFPD(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D740", Offset = "0x2A2C740", VA = "0x182A2D740")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) EIINBJBFBPL(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E550", Offset = "0x2A2D550", VA = "0x182A2E550")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) GOFIDKNKJLF(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BC60", Offset = "0x2A2AC60", VA = "0x182A2BC60")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) ABHOBELIPGG(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C460", Offset = "0x2A2B460", VA = "0x182A2C460")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>) BEDOJFPHEDB(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>? LDMAIILNDFO)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JLOPLFCPODM<LNKLNAJNICB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D5C0", Offset = "0x2A2C5C0", VA = "0x182A2D5C0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) EDNAFINMBOG(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F850", Offset = "0x2A2E850", VA = "0x182A2F850")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JLNHAEOKHCK(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D310", Offset = "0x2A2C310", VA = "0x182A2D310")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) DNPLBJPEKKB(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EB80", Offset = "0x2A2DB80", VA = "0x182A2EB80")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) ICBOHGLPGMO(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C960", Offset = "0x2A2B960", VA = "0x182A2C960")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) BKILBGIGPEI(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DCA0", Offset = "0x2A2CCA0", VA = "0x182A2DCA0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) FGJFBHICBJG(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FF20", Offset = "0x2A2EF20", VA = "0x182A2FF20")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) KLOOEJJNMEK(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C800", Offset = "0x2A2B800", VA = "0x182A2C800")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) BJONGBFFEAH(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2A30420", Offset = "0x2A2F420", VA = "0x182A30420")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) LLGGJDNBLNL(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C550", Offset = "0x2A2B550", VA = "0x182A2C550")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) BIMMOKHEJFN(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BF20", Offset = "0x2A2AF20", VA = "0x182A2BF20")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) ANFIKKEGBFN(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CBD0", Offset = "0x2A2BBD0", VA = "0x182A2CBD0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) CGJFAKKLGDB(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F9B0", Offset = "0x2A2E9B0", VA = "0x182A2F9B0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JPAAEGBOPDJ(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E8D0", Offset = "0x2A2D8D0", VA = "0x182A2E8D0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) HLKIFEEHCLH(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A31220", Offset = "0x2A30220", VA = "0x182A31220")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) PHFDHAKOMOC(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EF60", Offset = "0x2A2DF60", VA = "0x182A2EF60")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) IKOPCDEIFIC(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F490", Offset = "0x2A2E490", VA = "0x182A2F490")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JDCCBJDOGHE(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BE00", Offset = "0x2A2AE00", VA = "0x182A2BE00")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) AKPFLANECFF(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2A30910", Offset = "0x2A2F910", VA = "0x182A30910")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) NOGBKKCNJFG(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E090", Offset = "0x2A2D090", VA = "0x182A2E090")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) FNGJFIOKPOB(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D1E0", Offset = "0x2A2C1E0", VA = "0x182A2D1E0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) DMNPJOPLDJE(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F6F0", Offset = "0x2A2E6F0", VA = "0x182A2F6F0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) JHBBBJIKDOG(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EA30", Offset = "0x2A2DA30", VA = "0x182A2EA30")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) HNJBDLCBJGN(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FB30", Offset = "0x2A2EB30", VA = "0x182A2FB30")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) KBJHAAAJFEM(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C1C0", Offset = "0x2A2B1C0", VA = "0x182A2C1C0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) BCJAODPILNI(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C6B0", Offset = "0x2A2B6B0", VA = "0x182A2C6B0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) BJLHFALNMHH(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E6A0", Offset = "0x2A2D6A0", VA = "0x182A2E6A0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) HAPKENCJLGI(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EE00", Offset = "0x2A2DE00", VA = "0x182A2EE00")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) IILOJGEJEEC(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C070", Offset = "0x2A2B070", VA = "0x182A2C070")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) AOGJONNIGKK(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E1F0", Offset = "0x2A2D1F0", VA = "0x182A2E1F0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) GBCNJANENNN(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E7C0", Offset = "0x2A2D7C0", VA = "0x182A2E7C0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) HHDJHBAGOCP(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] int? NIMFHEBDIBO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D9F0", Offset = "0x2A2C9F0", VA = "0x182A2D9F0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) ENFINMLBHEL(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? NIMFHEBDIBO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BD80", Offset = "0x2A2AD80", VA = "0x182A2BD80")]
	public static OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>> AJAFBHCCCDA(this PBFBDJCALEG<byte> OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A2FDA0", Offset = "0x2A2EDA0", VA = "0x182A2FDA0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) KKHKGHMAGKL(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, float HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A310D0", Offset = "0x2A300D0", VA = "0x182A310D0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) PFNDJBDBEHF(this PBFBDJCALEG<byte> OLHDOIOOPGE, float PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<JJECECEEMAE>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A301F0", Offset = "0x2A2F1F0", VA = "0x182A301F0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>) LFFNBOFCPHF(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<JJECECEEMAE>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<JJECECEEMAE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A30D40", Offset = "0x2A2FD40", VA = "0x182A30D40")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) OHCIHDFBDGP(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A300A0", Offset = "0x2A2F0A0", VA = "0x182A300A0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) LBBOBIOODLE(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CE50", Offset = "0x2A2BE50", VA = "0x182A2CE50")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) CMMANGFJOCE(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BB00", Offset = "0x2A2AB00", VA = "0x182A2BB00")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) AAAIHIOLIBJ(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, int HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A30BF0", Offset = "0x2A2FBF0", VA = "0x182A30BF0")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) OBMDFDPHONO(this PBFBDJCALEG<byte> OLHDOIOOPGE, int PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<BBHJKDCFMMB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C340", Offset = "0x2A2B340", VA = "0x182A2C340")]
	public static (OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>) BEAAGPFOCOM(this PBFBDJCALEG<byte> OLHDOIOOPGE, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? PPEJEHACJON, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HOBLMFABEEO, [Optional] OCIDMCEKJIP<FEHKAEFOELM<BBHJKDCFMMB>>? HFFGHMALJJF)
	{
		return default((OCIDMCEKJIP<JLOPLFCPODM<LNKLNAJNICB>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>, OCIDMCEKJIP<JLOPLFCPODM<FEHKAEFOELM<BBHJKDCFMMB>>>));
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
